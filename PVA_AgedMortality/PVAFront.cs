﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PVA_AgedMortality
{
    public partial class frmPvaFront : Form
    {
        //Form-level variables 
        Population startingPop = new Population(); //keep your starting pop saved to reset after each trial
        Population testPop = new Population(); //this is the pop you feed to your sim 
        int trials = 0; //initialize form-level variables 
        int years = 0;
        int months = 0;
        List<int> trialResults = new List<int>();


        public frmPvaFront()
        {
            InitializeComponent();
            txtTrials.Text = Convert.ToString(3); //form loads, insert default values into text boxes 
            txtYears.Text = Convert.ToString(1);
            txtAmrRate.Text = Convert.ToString(VitalRates.DEFAULTAMRRATE);
            SelectPop();
        }

        //Creates your starting pop from 3 default options (BC, LV, RM) of different sizes 
        private void SelectPop()
        {
            Ind.idCount = 1; //ID counter needs to be reset, this should probably be somewhere else though. 
            startingPop.Clear(); //empty population 
            if (rdoBC.Checked) startingPop = BCstarterPop.DefaultPop(); //BC chosen 
            else if (rdoLV.Checked) startingPop = LVstarterPop.DefaultPop(); //LV chosen
            else startingPop = RMstarterPop.DefaultPop(); //RM chosen
            RefreshPopList(lstStartPop, startingPop); //update list box with the group details 
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //get trials, years, amr rate
            trials = Convert.ToInt32(txtTrials.Text); //How many trials does user want to run? 
            years = Convert.ToInt32(txtYears.Text);   //How many years should each trial run for? 
            VitalRates.amrRate = Convert.ToDouble(txtAmrRate.Text);
            months = MathFunctions.YearsToMonths(years); //Sim is run monthly, so convert years to months 
            RunTrials(trials); //Start trials           
        }

        //Trial loop: Call "single trial" method to run as many trials as user would like 
        private void RunTrials(int trials)
        {
            
            for (int t = 0; t < trials; t++) //Start of trial loop
            {
                testPop = Population.ClonePop(startingPop); //keep your starting pop intact and undisturbed, create a clone to use for simulation 
                Ind.idCount = startingPop.Count + 1; //reset counter after every trial 
                Trial.SingleTrial(months, testPop); //Pass your testPop and the # of months to run to the trial method in trial class 
                trialResults.Add(testPop.Count());  //record the ending population of your trial               
            } //End of trial loop
            SaveResults("EndingPop.txt", trialResults); //Save trial results to a txt document 
            trialResults.Clear(); //after saving the data empty your ending pop list 
        }

        private void RefreshPopList(ListBox lb, Population sp) //method to update population list boxes
        {
            lb.Items.Clear(); //reset list box 
            foreach (Ind i in sp)
            {
                lb.Items.Add(i.DisplayIndInPop()); //add individuals in pop one by one to box using the display method 
            }
        }

        private void SaveResults<T>(string filename, List<T> list) //method that opens streamwriter and saves your ending population count from each trial 
        {
            using (StreamWriter sr = new StreamWriter(filename))
            {
                foreach (var value in list)
                {
                    sr.WriteLine(value);                 
                }
                MessageBox.Show("File " + filename + " saved to bin/debug."); 
            }
        }

        private void btnBeta_Click(object sender, EventArgs e)
        {
            List<double> stbResults = new List<double>();
            List<double> amrResults = new List<double>();
            List<double> colcheroResults = new List<double>();
            int coinCountStb = 0;
            int coinCountAmr = 0;
            int coinCountColch = 0;
            int coinFixedInf = 0;
            for (int i = 0; i < 10000; i++)
            {
                double betaStb = (1 - (MathFunctions.SampleBeta(VitalRates.INFSTB_A, VitalRates.INFSTB_B)));
                if (MathFunctions.CoinFlip(betaStb)) coinCountStb++; 
                stbResults.Add(betaStb);
                double betaAmr = (1 - (MathFunctions.SampleBeta(VitalRates.INFAMR_A, VitalRates.INFAMR_B)));
                amrResults.Add(betaAmr);
                double fixedAmr = VitalRates.MonthlySurvival(0, true);
                if (MathFunctions.CoinFlip(fixedAmr)) coinFixedInf++;
                if (MathFunctions.CoinFlip(betaAmr)) coinCountAmr++;
                double colchero = VitalRates.MonthlySurvival(120, false);
                colcheroResults.Add(colchero);
                if (MathFunctions.CoinFlip(colchero)) coinCountColch++;
            }

            SaveResults("StbResults.txt", stbResults);
            SaveResults("AmrResults.txt", amrResults);
            SaveResults("ColchResults.txt", colcheroResults);
            MessageBox.Show("Files written, sample complete. Coin flip results: STB survived " + coinCountStb + " times, AMR " + coinCountAmr +
                " and 10 year old females survived " + coinCountColch + " times, fixed infant AMR survived " + coinFixedInf);
        }

        private void rdoDefPops_CheckedChanged(object sender, EventArgs e)
        {
            SelectPop();
        }
    }
}
