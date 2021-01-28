using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVA_AgedMortality
{
    public class MathFunctions
    {
        static Random rnd = new Random();

        public static bool CoinFlip(double prob) //function for outcome simulation for binary events (AMR/stable, life/death, birth/no birth) 
        {

            if (rnd.NextDouble() < prob) //if random number is less than your probability, event happened 
            {
                return true;
            }
            else return false; //random number > probability, event didnt happen 
        }

        public static int YearsToMonths(int y)
        {
            int m;
            m = y * 12;
            return m;
        }

        public static int MonthsToYears(int m)
        {
            int y;
            y = m / 12;
            return y;
        }
    }
}
