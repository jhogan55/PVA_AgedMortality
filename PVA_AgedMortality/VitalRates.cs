using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVA_AgedMortality
{
    public class VitalRates
    {
        public const double SEXRATIO = 0.5;
        public const int GESTATIONLENGTH = 6;
        public const int DEPENDENCYLENGTH = 12;
        public const int AMRRISKPERIOD = 6; 

        public static double ConceptionRate(int a)
        {
            double ageRate; 
            if (a/12 >= 6) { ageRate = 0.25; } //TODO: THESE ARE DUMMY VALUES, NEED TO CREATE AGE-SPECIFIC FERTILITY RATES 
            else { ageRate = 0; }
            return ageRate; 
        }
    }
}
