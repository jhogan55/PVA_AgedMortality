using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVA_AgedMortality
{
    public class VitalRates
    {
        public const double SEXRATIO = 0.5;
        public const int GESTATIONLENGTH = 6;
        public const int DEPENDENCYLENGTH = 12;
        public const int AMRRISKPERIOD = 6;
        public const double AMRRATE = 0.03; 

        //determine an individual's chance of conception, based on time since last infant and status of previous infant 
        public static double ConceptionRate(int a)
        {
            double ageRate; 
            if (a/12 >= 6) { ageRate = 0.25; } //TODO: THESE ARE DUMMY VALUES, NEED TO CREATE AGE-SPECIFIC FERTILITY RATES 
            else { ageRate = 0; }
            return ageRate; 
        }

        public static double MonthlySurvival(int a, bool amr)
        {
            double monthSurvRate;
            if (a < 12) //infants have differentiated survival in AMR periods and outside of them 
            {
                if (amr)
                {
                    monthSurvRate = 0.807388; //TODO: replace this with beta sampler + a/b for infants 
                    //MessageBox.Show("Ind is infant, amr occured. Survival rate: " + monthSurvRate);
                }
                else //stable period, better survival 
                {
                    monthSurvRate = 0.969926;
                    //MessageBox.Show("Ind is infant, no AMR period. Survival rate: " + monthSurvRate);
                }
            }//beta sample infant mortality and AMR risk }
            else if (a < 24) { monthSurvRate = 0.993; } //1-2 year olds 
            else if (a < 36) { monthSurvRate = 0.994; } //2-3
            else if (a < 48) { monthSurvRate = 0.995; } //3-4
            else if (a < 60) { monthSurvRate = 0.998; } //4-5
            else if (a < 72) { monthSurvRate = 0.996; } //5-6, no real figure
            else if (a < 84) { monthSurvRate = 0.993; } //6-7
            else if (a < 96) { monthSurvRate = 0.998; } //7-8
            else if (a < 108) { monthSurvRate = 0.994; }//8-9
            else if (a < 120) { monthSurvRate = 0.993; }//9-10 
            else if (a < 132) { monthSurvRate = 0.986; }//10-11
            else if (a < 144) { monthSurvRate = 0.987; }//11-12
            else if (a < 156) { monthSurvRate = 0.989; }//12-13
            else if (a < 168) { monthSurvRate = 0.987; }//13-14, no real figure 
            else if (a < 180) { monthSurvRate = 0.984; }//14-15
            else if (a < 192) { monthSurvRate = 0.988; }//15-16, no real figure
            else if (a < 204) { monthSurvRate = 0.988; }//16-17, no real figure
            else if (a < 216) { monthSurvRate = 0.993; }//17-18
            else if (a < 228) { monthSurvRate = 0.987; }//18-19, no real figure 
            else if (a < 240) { monthSurvRate = 0.980; }//19-20
            else if (a < 252) { monthSurvRate = 0.987; }//20-21
            else if (a < 264) { monthSurvRate = 0.973; }//21-22, no real figure
            else if (a < 276) { monthSurvRate = 0.973; }//22-23, no real figure 
            else if (a < 288) { monthSurvRate = 0.958; }//23-24
            else if (a < 300) { monthSurvRate = 0.951; }//25-26
            else if (a < 312) { monthSurvRate = 0.944; }//26-27
            else { monthSurvRate = 0.9; }//27 and older 
            //MessageBox.Show("Ind is " + (a / 12) + " years old, mortality rate: " + monthSurvRate);
            return monthSurvRate;
        }        
        
    }
}
