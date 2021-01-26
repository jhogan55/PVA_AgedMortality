﻿using System;
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
            bool amrOccur = MathFunctions.CoinFlip(VitalRates.AMRRATE);
            if (amrOccur)
            {
                MessageBox.Show("AMR occurred this month");
            }
            Population.MonthlySurvivalTest(p, amrOccur);
            foreach (Ind i in p)
            {
                //increment all monthly counters for each individual                
                i.AgeUp();

                //MessageBox.Show(i.DisplayIndInPop());

                //give birth to any due babies
                //i.GiveBirth();

                //check dependencies for matured dependents
                
                //coin flip mortality 
                    
                //kill off any dependent infants of dead mothers 
                
                //

            }
        }
    }
}
