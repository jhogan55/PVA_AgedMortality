using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVA_AgedMortality
{
    public class Month
    {

        //METHODS    
        //One month simulation
        public static void SingleMonth(Population p)
        {
            bool amr = AmrStatus();
            Population.MonthlySurvivalTest(p, amr); //Test survival of each individual 
            Population.MonthlyIndChanges(p); //Make all individual-level changes for the month: age, pregnancy duration,  
            Population.RemoveInfantID(Population.weanedInf, p); //Remove infant dependencies from mothers 
        }

        //Method: determine if 1) an amr occurs, 2) if you are in a post-amr risk period 
        private static bool AmrStatus()
        {
            bool amrOccur = MathFunctions.CoinFlip(VitalRates.AMRRATE); //determine if AMR occured this month. 
            if (amrOccur) //amrOccured: reset amrRisk counter to 0
            {
                Trial.TimeSinceAmr = 0; //it has been 0 months since the last takeover 
                Trial.TrialAmrs++;
                //MessageBox.Show("AMR RISK: occurred this month, time since AMR = " + Trial.TimeSinceAmr + " months.");
                return true;
            }
            else
            {
                Trial.TimeSinceAmr++; //increment AMR counter by a month 
                if (Trial.TimeSinceAmr <= VitalRates.AMRRISKPERIOD)
                {
                    //MessageBox.Show("AMR RISK: No amr, but one " + Trial.TimeSinceAmr + " months ago, so you are under AMR risk");
                    return true;
                } //you are still in the post-amr risk period 
                else 
                {
                    return false; //it has been long enough since an amr group is no longer at risk 
                }
               
            }
        }
    }
}
