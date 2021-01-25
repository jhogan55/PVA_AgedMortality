using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVA_AgedMortality
{
    public static class Month
    {
        //METHODS

        //conduct monthly simulation 
        public static void Simulate(int m, Population p)
        {
            for (int i = 0; i < m; i++)
            {
                MessageBox.Show("Month " + i + 1 + "of " + m);
                SingleMonth(p);
            }
        }

        //One month simulation
        public static void SingleMonth(Population p)
        {

            foreach (Ind i in p)
            {
                //increment all monthly counters for each individual
                i.AgeUp();

                //give birth to any due babies
                i.GiveBirth();

                //check dependencies for matured dependents
                
                //coin flip mortality 
                    
                //kill off any dependent infants of dead mothers 
                
                //

            }
        }
    }
}
