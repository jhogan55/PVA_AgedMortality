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
        public const double DEFAULTAMRRATE = 0.03;
        public static double amrRate;
        public const double INFAMR_A = 21.24997; //These are calculated from Fernando's maximum likelihood bayes method, and represent MORTALITY not SURVIVAL.
        public const double INFAMR_B = 103.83494; //they are A and B values used for sampling from a beta distribution
        public const double INFSTB_MEAN = 0.969926; //mean survival of infants during stable periods
        public const double INFSTB_SD = 0.136259; //standard deviation of survival of infants during stable periods 
        public const double INFSTB_A = (((1 - INFSTB_MEAN) / (INFSTB_SD * INFSTB_SD)) - (1 / INFSTB_MEAN)) * (INFSTB_MEAN * INFSTB_MEAN); //a value for infants, stable period 
        public const double INFSTB_B = INFSTB_A * ((1 / INFSTB_SD) - 1);//b value for infants, stable period        
        
        //Method to determine age-based mortality rates for non-infants 
        public static double ColcheroSiler(int a) 
        {
            //Colchero-dataset's Siler equation for capuchin mortality 
            //https://doi.org/10.21203/rs.3.rs-118237/v1 
            //Preprint available at: https://www.researchsquare.com/article/rs-118237/v1
            double ageInYears = (double)a / (double)12;
            double monthConvert = (double)1 / (double)12; 
            double annualSurv = (1 - (Math.Exp(-0.277 - 2.226 * ageInYears) + 0.044 + Math.Exp(-4.763 + 0.108 * ageInYears)));  //Colchero-derived Siler formula
            double monthlySurv = Math.Pow(annualSurv, monthConvert); //Convert annual mortality to monthly 
            return monthlySurv; //turn it into survival 
        }


        //Method to assign mortality for a monthly trial to an individual 
        public static double MonthlySurvival(int a, bool amr)
        {
            double monthSurvRate;
            if (a < 12) //infants have differentiated survival in AMR periods and outside of them 
            {
                if (amr)
                {
                    monthSurvRate = ( 1 - (MathFunctions.SampleBeta(INFAMR_A, INFAMR_B)));
                    //MessageBox.Show("Sampled from beta during AMR, retrieved value: " + monthSurvRate);
                }
                else //stable period, better survival 
                {
                    //monthSurvRate = (1 - (MathFunctions.SampleBeta(INFSTB_A, INFSTB_B)));
                    monthSurvRate = INFSTB_MEAN;
                    //MessageBox.Show("Sampled from beta during STABLE period, retrieved value: " + monthSurvRate);
                }
            }//beta sample infant mortality and AMR risk }

            else //you're over a year old, so use age-based mortality and AMR is not important 
            { 
                monthSurvRate = ColcheroSiler(a);
                //MessageBox.Show("Ind is " + (a / 12) + " years old. Monthly survival rate = " + monthSurvRate);
            }
            
            return monthSurvRate;

            //DEPRECATED: monthly survival rates per age class derived from Bronikowski data 
            //else if (a < 24) {  monthSurvRate = 0.993; } //1-2 year olds 
            //else if (a < 36) {  monthSurvRate = 0.994; } //2-3
            //else if (a < 48) {  monthSurvRate = 0.995; } //3-4
            //else if (a < 60) {  monthSurvRate = 0.998; } //4-5
            //else if (a < 72) {  monthSurvRate = 0.996; } //5-6, no real figure
            //else if (a < 84) {  monthSurvRate = 0.993; } //6-7
            //else if (a < 96) {  monthSurvRate = 0.998; } //7-8
            //else if (a < 108) { monthSurvRate = 0.994; }//8-9
            //else if (a < 120) { monthSurvRate = 0.993; }//9-10 
            //else if (a < 132) { monthSurvRate = 0.986; }//10-11
            //else if (a < 144) { monthSurvRate = 0.987; }//11-12
            //else if (a < 156) { monthSurvRate = 0.989; }//12-13
            //else if (a < 168) { monthSurvRate = 0.987; }//13-14, no real figure 
            //else if (a < 180) { monthSurvRate = 0.984; }//14-15
            //else if (a < 192) { monthSurvRate = 0.988; }//15-16, no real figure
            //else if (a < 204) { monthSurvRate = 0.988; }//16-17, no real figure
            //else if (a < 216) { monthSurvRate = 0.993; }//17-18
            //else if (a < 228) { monthSurvRate = 0.987; }//18-19, no real figure 
            //else if (a < 240) { monthSurvRate = 0.980; }//19-20
            //else if (a < 252) { monthSurvRate = 0.987; }//20-21
            //else if (a < 264) { monthSurvRate = 0.973; }//21-22, no real figure
            //else if (a < 276) { monthSurvRate = 0.973; }//22-23, no real figure 
            //else if (a < 288) { monthSurvRate = 0.958; }//23-24
            //else if (a < 300) { monthSurvRate = 0.951; }//24-25
            //else if (a < 312) { monthSurvRate = 0.944; }//25-26
            //else { monthSurvRate = 0; }//26 and older 
            //MessageBox.Show("Ind is " + (a / 12) + " years old, mortality rate: " + monthSurvRate);
        }

        //determine an individual's chance of conception, based on time since last infant and status of previous infant 
        public static double ConceptionRate(int age, int mSinceBirthDeath, bool lastInfSurv )
        {
            double repMean;
            if (age < 60) { repMean = 0; } //infants and juvies don't reproduce 
            else
            {
                //check whether IBI is following surviving or lost infant 
                if (lastInfSurv) //"normal" length IBI
                {
                    if (mSinceBirthDeath < 5) repMean = 0; //less than 4 months no chance to reproduce
                    else if (mSinceBirthDeath >= 5 & mSinceBirthDeath < 12 ) repMean = 0.007; //5 to 12 months < 1% per month
                    else if (mSinceBirthDeath == 13) repMean = 0.040; //~10% 
                    else if (mSinceBirthDeath == 14) repMean = 0.042; //~17%
                    else if (mSinceBirthDeath == 15) repMean = 0.080; //
                    else if (mSinceBirthDeath == 16) repMean = 0.055; //
                    else if (mSinceBirthDeath == 17) repMean = 0.067; //
                    else if (mSinceBirthDeath == 18) repMean = 0.054; //
                    else if (mSinceBirthDeath == 19) repMean = 0.132; //
                    else if (mSinceBirthDeath == 20) repMean = 0.130; // now more likely than not to get pregnant if not already
                    else if (mSinceBirthDeath == 21) repMean = 0.125; //
                    else if (mSinceBirthDeath == 22) repMean = 0.129; //
                    else if (mSinceBirthDeath == 23) repMean = 0.180; //
                    else if (mSinceBirthDeath == 24) repMean = 0.240; //
                    else if (mSinceBirthDeath == 25) repMean = 0.132; //
                    else if (mSinceBirthDeath == 26) repMean = 0.182; //
                    else if (mSinceBirthDeath == 27) repMean = 0.185; // real data is 0, split 28 month value into two months (0.370)
                    else if (mSinceBirthDeath == 28) repMean = 0.185; //
                    else if (mSinceBirthDeath == 29) repMean = 0.118; //
                    else if (mSinceBirthDeath == 30) repMean = 0.200; //
                    else if (mSinceBirthDeath == 31) repMean = 0.250; //
                    else if (mSinceBirthDeath == 32) repMean = 0.444; //
                    else if (mSinceBirthDeath == 33) repMean = 0.200; //
                    else if (mSinceBirthDeath == 34) repMean = 0.250; //
                    else if (mSinceBirthDeath == 35) repMean = 0.200; //no females conceived at 35 months, averaged over 34-36 mo
                    else repMean = 0.200; //by 36 months only 3/150 females had not conceived (and these were likely "lost pregnancies")
                }
                else //LastInfSurv = false, the previous infant died so shorter IBI curve
                {
                    if (mSinceBirthDeath == 0) repMean = 0; //just lost your baby, no conception chance 
                    else if (mSinceBirthDeath == 1) repMean = 0.0685; //small chance after 1 month
                    else if (mSinceBirthDeath == 2) repMean = 0.118; //
                    else if (mSinceBirthDeath == 3) repMean = 0.200; //~3 months after losing infant you start to have better odds 
                    else if (mSinceBirthDeath == 4) repMean = 0.271; // 
                    else if (mSinceBirthDeath == 5) repMean = 0.143; //
                    else if (mSinceBirthDeath == 6) repMean = 0.333; //
                    else if (mSinceBirthDeath == 7) repMean = 0.300; // 
                    else if (mSinceBirthDeath == 8) repMean = 0.071; //weird dip in the data, probably just noise 
                    else if (mSinceBirthDeath == 9) repMean = 0.308; //
                    else if (mSinceBirthDeath == 10) repMean = 0.111; //
                    else if (mSinceBirthDeath == 11) repMean = 0.375; // 
                    else repMean = 0.300; //Infant-lost IBI stalls for a while but this is probably high enough 
                };
            }
            return repMean;
        }
    }
}
