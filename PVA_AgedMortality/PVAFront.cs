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
        int trials = 0;
        int years = 0;
        int months = 0;
        
        public frmPvaFront()
        {
            InitializeComponent();
            txtTrials.Text = Convert.ToString(3);
            txtYears.Text = Convert.ToString(1);            
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //get trials and years 
            trials = Convert.ToInt32(txtTrials.Text);
            years = Convert.ToInt32(txtYears.Text);
            months = MathFunctions.YearsToMonths(years);            
           
            for (int t = 0; t < trials; t++) //FOR LOOP #1: run t trials 
            {
               testPop = Population.ClonePop(startingPop);
               MessageBox.Show("Running trial " + (t + 1) + " of " + trials);
               Trial.SingleTrial(months, testPop);
            } //END OF FOR LOOP 1: end of trials 
        }

        private void btnAdd_Click(object sender, EventArgs e) //add new individual to population
        {
            //TODO: expand user customization to include other ind variables 
            Ind newInd = new Ind((Convert.ToInt32(txtAge.Text) * 12), false, 0, 0, 0, 0);
            startingPop.Add(newInd);
            RefreshPopList(startingPop);
        }

        private void RefreshPopList(Population sp)
        {
            lstStartPop.Items.Clear();
            foreach (Ind i in startingPop)
            {
                lstStartPop.Items.Add(i.DisplayIndInPop());
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            startingPop.Clear();
            startingPop = LVstarterPop.DefaultPop();
            RefreshPopList(startingPop);
        }
    }
}
