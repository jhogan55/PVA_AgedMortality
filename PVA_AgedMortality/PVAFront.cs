using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            txtAge.Text = Convert.ToString(1);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //get trials and years 
            trials = Convert.ToInt32(txtTrials.Text); //How many trials does user want to run? 
            years = Convert.ToInt32(txtYears.Text);   //How many years should each trial run for? 
            months = MathFunctions.YearsToMonths(years); //Sim is run monthly, so convert years to months 
            RunTrials(trials); //Start trials
            
        }

        //Trial loop: Call "single trial" method to run as many trials as user would like 
        private void RunTrials(int trials)
        {
            for (int t = 0; t < trials; t++) //Start of trial loop
            {
                testPop = Population.ClonePop(startingPop); //keep your starting pop intact and undisturbed, create a clone to use for simulation 
                //MessageBox.Show("Running trial " + (t + 1) + " of " + trials); //test message for debugging 
                Trial.SingleTrial(months, testPop); //Pass your testPop and the # of months to run to the trial method in trial class 
                trialResults.Add(testPop.Count());               
            } //End of trial loop
            var message = string.Join(Environment.NewLine, trialResults);
            MessageBox.Show(message);
            RefreshPopList(lstTrialResults, testPop);
        }

        private void btnAdd_Click(object sender, EventArgs e) //add new individual to population
        {
            //TODO: expand user customization to include other ind variables of your feeder pop 
            Ind newInd = new Ind((Convert.ToInt32(txtAge.Text) * 12), false, 0, false, 0, 0, 0, 0, true);
            startingPop.Add(newInd);
            RefreshPopList(lstStartPop, startingPop);
        }

        private void RefreshPopList(ListBox lb, Population sp) //method to update population list boxes
        {
            lb.Items.Clear(); //reset list box 
            foreach (Ind i in sp)
            {
                lb.Items.Add(i.DisplayIndInPop()); //add individuals in pop one by one to box using the display method 
            }
        }

        private void btnDefault_Click(object sender, EventArgs e) //user wants to start with default population (currently LV 2020) 
        {
            startingPop.Clear(); //empty out starting pop list 
            startingPop = LVstarterPop.DefaultPop(); //starting pop copies LV. TODO: decide if this should be refactored to use Population.ClonePop() instead? 
            RefreshPopList(lstStartPop, startingPop);
        }
    }
}
