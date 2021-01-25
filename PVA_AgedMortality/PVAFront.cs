﻿using System;
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
        Population startingPop = new Population();
        int trials = 0;
        int years = 0;
        int months = 0;
        
        public frmPvaFront()
        {
            InitializeComponent();
            txtTrials.Text = Convert.ToString(100);
            txtYears.Text = Convert.ToString(100);
        }



        private void btnRun_Click(object sender, EventArgs e)
        {
            //get trials and years 
            trials = Convert.ToInt32(txtTrials.Text);
            years = Convert.ToInt32(txtYears.Text);
            months = MathFunctions.YearsToMonths(years);

            
            for (int t = 0; t < trials; t++) //FOR LOOP #1: run t trials 
            {
                MessageBox.Show("Running trial " + t + 1 + " of " + trials);
                Month.Simulate(months, startingPop);
            } //END OF FOR LOOP 1: end of trials 
        }

        private void btnAdd_Click(object sender, EventArgs e) //add new individual to population
        {
            //TODO: expand user customization to include other ind variables 
            Ind newInd = new Ind((Convert.ToInt32(txtAge.Text) * 12), false, 0, 0, 0, 0);
            startingPop.AddInd(newInd);
            RefreshPopList(newInd);
        }

        private void RefreshPopList(Ind i)
        {
            lstStartPop.Items.Add(i.DisplayIndInPop());
        }
    }
}
