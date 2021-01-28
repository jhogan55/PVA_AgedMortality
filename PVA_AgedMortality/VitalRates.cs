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
            else if (a < 24) {  monthSurvRate = 0.993; } //1-2 year olds 
            else if (a < 36) {  monthSurvRate = 0.994; } //2-3
            else if (a < 48) {  monthSurvRate = 0.995; } //3-4
            else if (a < 60) {  monthSurvRate = 0.998; } //4-5
            else if (a < 72) {  monthSurvRate = 0.996; } //5-6, no real figure
            else if (a < 84) {  monthSurvRate = 0.993; } //6-7
            else if (a < 96) {  monthSurvRate = 0.998; } //7-8
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
            else if (a < 300) { monthSurvRate = 0.951; }//24-25
            else if (a < 312) { monthSurvRate = 0.944; }//25-26
            else { monthSurvRate = 0; }//26 and older 
            //MessageBox.Show("Ind is " + (a / 12) + " years old, mortality rate: " + monthSurvRate);
            return monthSurvRate;
        }

        //determine an individual's chance of conception, based on time since last infant and status of previous infant 
        public static double ConceptionRate(int age, int monthsSinceBirth, bool lastInfSurv )
        {
            double repMean;
            if (age < 60) { repMean = 0; } //infants and juvies don't reproduce 
            else
            {
                //check whether IBI is following surviving or lost infant 
                if (lastInfSurv) //"normal" length IBI
                {
                    if (monthsSinceBirth < 4) repMean = 0; //less than 4 months no chance to reproduce
                    else if (monthsSinceBirth >= 4 & monthsSinceBirth <= 6) repMean = 0.007; //4 to 6 months <1%
                    else if (monthsSinceBirth > 6 & monthsSinceBirth <= 9) repMean = 0.013; //7 to 9 ~1%
                    else if (monthsSinceBirth > 9 & monthsSinceBirth <= 11) repMean = 0.020; //10, 11 months ~2%
                    else if (monthsSinceBirth == 12) repMean = 0.059; //at 12 months curve starts to ramp up, now ~6%
                    else if (monthsSinceBirth == 13) repMean = 0.098; //~10% 
                    else if (monthsSinceBirth == 14) repMean = 0.170; //~17%
                    else if (monthsSinceBirth == 15) repMean = 0.216; //
                    else if (monthsSinceBirth == 16) repMean = 0.268; //
                    else if (monthsSinceBirth == 17) repMean = 0.307; //
                    else if (monthsSinceBirth == 18) repMean = 0.399; //
                    else if (monthsSinceBirth == 19) repMean = 0.477; //
                    else if (monthsSinceBirth == 20) repMean = 0.542; // now more likely than not to get pregnant if not already
                    else if (monthsSinceBirth == 21) repMean = 0.601; //
                    else if (monthsSinceBirth == 22) repMean = 0.673; //
                    else if (monthsSinceBirth == 23) repMean = 0.752; //
                    else if (monthsSinceBirth == 24) repMean = 0.784; //
                    else if (monthsSinceBirth == 25 | monthsSinceBirth == 26) repMean = 0.824; //
                    else repMean = 0.889; //the odds are good enough there's really not a need to ramp up any further 
                }
                else //LastInfSurv = false, the previous infant died so shorter IBI curve
                {
                    if (monthsSinceBirth == 0) repMean = 0.0375; //small chance right off the bat
                    else if (monthsSinceBirth == 1) repMean = 0.01; //
                    else if (monthsSinceBirth == 2) repMean = 0.188; //at 2 months curve jumps big time, ~20% conception chance 
                    else if (monthsSinceBirth == 3) repMean = 0.238; // 
                    else if (monthsSinceBirth == 4) repMean = 0.350; //
                    else if (monthsSinceBirth == 5) repMean = 0.450; //
                    else if (monthsSinceBirth == 6) repMean = 0.550; //most females are pregnant within 6 months of losing an infant 
                    else if (monthsSinceBirth == 7) repMean = 0.588; //
                    else if (monthsSinceBirth == 8) repMean = 0.613; //
                    else if (monthsSinceBirth == 9) repMean = 0.650; //
                    else if (monthsSinceBirth == 10) repMean = 0.675; // 
                    else if (monthsSinceBirth == 11) repMean = 0.750; //
                    else if (monthsSinceBirth == 12) repMean = 0.775; //
                    else if (monthsSinceBirth == 13) repMean = 0.800; //
                    else if (monthsSinceBirth == 14) repMean = 0.838; //
                    else if (monthsSinceBirth == 15) repMean = 0.863; //
                    else repMean = 0.875; //Infant-lost IBI stalls for a while but this is probably high enough 
                };
            }
            return repMean;
        }
    }
}
