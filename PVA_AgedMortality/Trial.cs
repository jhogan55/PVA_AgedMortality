using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVA_AgedMortality
{
    public class Trial
    {
        private static int timeSinceAmr;
        private static int trialFemBirths;
        private static int trialMaleBirths;
        private static int trialDeaths;
        private static int trialAmrs;
        public static int TimeSinceAmr
        {
            get { return timeSinceAmr; }
            set { timeSinceAmr = value; }
        }
        public static int TrialFemBirths
        {
            get { return trialFemBirths; }
            set { trialFemBirths = value; }
        }

        public static int TrialMaleBirths
        {
            get { return trialMaleBirths; }
            set { trialMaleBirths = value; }
        }
        public static int TrialDeaths
        {
            get { return trialDeaths; }
            set { trialDeaths = value; }
        }
        public static int TrialAmrs
        {
            get { return trialAmrs; }
            set { trialAmrs = value; }
        }

        public static void SingleTrial(int m, Population p)
        {
            TimeSinceAmr = VitalRates.AMRRISKPERIOD; //reset amr counter at start of each trial to NOT be under amr risk 
            TrialFemBirths = 0;
            TrialMaleBirths = 0;
            TrialDeaths = 0;
            TrialAmrs = 0;
            for (int i = 0; i < m; i++)
            {
                //MessageBox.Show("Month " + (i+1) + " of " + m);
                Month.SingleMonth(p);
            }

            MessageBox.Show("End of trial. Ending population: " + p.Count + ". Amrs: " + TrialAmrs + ", infant females born: " + TrialFemBirths + ", infant males born: " + TrialMaleBirths + " Deaths: " + TrialDeaths);
        }
    }
}
