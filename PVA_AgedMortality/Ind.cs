﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVA_AgedMortality
{
    public class Ind
    {
        //private variables
        int indID; //each ind has a unique key, mainly for tracking mother/infant dependency
        int age; //age in months
        bool isPreg; //whether ind is pregnant or not 
        int monthsPreg; //how many months has ind been pregnant
        int monthsSinceBirthOrInfDeath; //how many months since ind last gave birth
        bool depMaleInf; //keep track of dependent male infants (used to establish fertility pathway, if baby dies early)
        int depMaleAge; //keep track of age of male infant, drop once weaned 
        int depInfID; //while a mother w/dependent infant, keep track of infant ID (used to establish fertility pathway, based on if infant dies or not) 
        int motherID; //while infant, keep track of mother's ID (if mother dies, infant dies too) 
        bool prevInfSurv; //keep track of whether the last infant survived to wean or not. Changes fertility down the road 
        public static int idCount = 1; //counter used to provide ID number 

        //public properties 
        public int IndID
        {
            get { return indID; }
            set { indID = value; } //TODO: Data validation. And should the idCount++ be moved here? 
        }
        public int Age
        {
            get { return age; }
            set { age = value; } //TODO: data validation 
        }
        public bool IsPreg
        {
            get { return isPreg; }
            set { isPreg = value; } //TODO: data validation 
        }
        public int MonthsPreg
        {
            get { return monthsPreg; }
            set { monthsPreg = value; } //TODO: data validation, pregnancy can only last 6 months 
        }
        public bool DepMaleInf
        {
            get { return depMaleInf; }
            set { depMaleInf = value; } //TODO: data validation 
        }
        public int DepMaleAge
        {
            get { return depMaleAge; }
            set { depMaleAge = value; } //TODO: data validation, should never exceed DEPENDENCY constant  
        }
        public int DepInfID
        {
            get { return depInfID; }
            set { depInfID = value; } //TODO: data validation, dep infant should only last for 12 months 
        }
        public int MotherID
        {
            get { return motherID; }
            set { motherID = value; } //TODO: data validation, mother ID should only last for 12 months 
        }

        public int MonthsSinceBirthOrInfDeath
        {
            get { return monthsSinceBirthOrInfDeath; }
            set { monthsSinceBirthOrInfDeath = value; } //TODO: data validation, months since birth should never exceed X years  
        }

        public bool PrevInfSurv
        {
            get { return prevInfSurv; }
            set { prevInfSurv = value; } //TODO: data validation 
        }

        //default constructor
        public Ind()
        {

        }

        //constructor for a new ind
        public Ind(int mAge, bool preg, int mPreg, bool maleBaby, int maleAge, int depInf, int mom, int mSinceBirth, bool infSurv)
        {
            IndID = idCount;
            idCount++;
            Age = mAge;
            IsPreg = preg;
            MonthsPreg = mPreg;
            DepMaleInf = maleBaby;
            DepMaleAge = maleAge;
            DepInfID = depInf;
            MotherID = mom;
            MonthsSinceBirthOrInfDeath = mSinceBirth;
            PrevInfSurv = infSurv;
        }

        //methods

        //Age Up: each month of simulation increases individuals age. If ind reaches weaning, motherID is dropped from record
        //Also increases months pregnant if ind is pregnant, and calls give birth
        public void AddMonthToIndCounters ()
        {
            Age++; //ind is one month older 
            if (DepMaleInf) DepMaleAge++;
            MonthsSinceBirthOrInfDeath++;
            CheckPreg();
            InfantDependencyTest(); //check if ind is an infant who has reached weaning. If so, drop motherID 
        }

        //Test individuals for monthly survival using age-based survival rate and (if an infant), whether there is AMR risk 
        public static bool IndSurvTest(int i, bool amr)
        {
            bool survived = MathFunctions.CoinFlip(VitalRates.MonthlySurvival(i, amr)); //if true, individual passed the survival test 
            return survived; 
        }

        //Remove dependency between mother and infant. Store female infant ID to remove from mother at population-level 
        public void InfantDependencyTest()
        {
            if (Age == VitalRates.DEPENDENCYLENGTH) //is ind of weaning age? 
            {
                MotherID = 0; //if so, mother's ID no longer used in sim, reset to 0 
                Population.weanedInf.Add(IndID); //add infant's ID to the list of weaned infants to remove from population  
            }
            if (DepMaleAge == VitalRates.DEPENDENCYLENGTH) //mothers lose their male infant dependency, but there is no male in pop to clean up 
            {
                ResetDepMale();
                //MessageBox.Show("Male infant weaned, no longer dependent. " + DepMaleInf + PrevInfSurv);
            }
        }
        public void ChanceToConceive()
        {
            if (!isPreg) //Only non-pregnant individuals can get pregnant 
            {
                isPreg = MathFunctions.CoinFlip(VitalRates.ConceptionRate(Age, MonthsSinceBirthOrInfDeath, PrevInfSurv));
                //if (isPreg) MessageBox.Show("Pregnant female! Ind " + IndID);
                //TODO: build in MonthsSincePreg and LastInfKilled for differentiated fertility rates 
            }
        }
        //CheckPreg: increment the pregnancy counter for any individuals that are pregnant. If pregnancy has been long enough, give birth 
        private void CheckPreg()
        {
            if (IsPreg) //check if ind is pregnant 
            {
                MonthsPreg++; //if so, increase the months pregnant counter
                if (MonthsPreg == VitalRates.GESTATIONLENGTH) //check if mom should be giving birth (if pregnancy has reached gestation length constant) 
                {
                    GiveBirth(); //if so, give birth
                }
            }
        }
        //Female has been pregnant for GESTATION LENGTH, so reset pregnancy variables, give birth. If baby female, create new ind. 
        public void GiveBirth()
        {
            IsPreg = false; //ind gives birth and is no longer pregnant, reset flag 
            MonthsPreg = 0; //reset MonthsPreg counter to 0 
            MonthsSinceBirthOrInfDeath = 0; //reset "months since birth" counter to 0
            PrevInfSurv = true; //this baby is born and alive 
            if (MathFunctions.CoinFlip(VitalRates.SEXRATIO)) //determine sex of infant. TRUE is female, so create a new ind in population  
            {
                DepInfID = idCount; //link female to mother 
                Ind baby = new Ind(0, false, 0, false, 0, 0, IndID, 0, true); //create new baby 
                Population.newFemInf.Add(baby); //add to the new baby collection for the month 
                //MessageBox.Show("New female infant born, ID# " + baby.IndID + " , mother is #" + baby.MotherID);
                Trial.TrialFemBirths++;
            }
            else //male baby
            {
                DepMaleInf = true;
                //MessageBox.Show("Male baby born to mother " + IndID);
                Trial.TrialMaleBirths++;
            }
        }
        //Clone ind, used to keep starter population separate from tested pop 
        public static Ind CloneInd(Ind i)
        {
            Ind clonedInd = new Ind();
            clonedInd.IndID = i.IndID;
            clonedInd.Age = i.Age;
            clonedInd.IsPreg = i.IsPreg;
            clonedInd.MonthsPreg = i.MonthsPreg;
            clonedInd.MonthsSinceBirthOrInfDeath = i.MonthsSinceBirthOrInfDeath;
            clonedInd.DepMaleInf = i.DepMaleInf;
            clonedInd.DepMaleAge = i.DepMaleAge;
            clonedInd.DepInfID = i.DepInfID;
            clonedInd.MotherID = i.MotherID;
            clonedInd.PrevInfSurv = i.PrevInfSurv;
            return clonedInd;
        }        
        //String override for list box
        public string DisplayIndInPop()
        {
            if (DepMaleInf)
            {
                return IndID + ", " + Age + " months old, dep inf male";
            }
            else if (DepInfID == 0)
            {
                return IndID + ", " + Age + " months old";
            }
            else return IndID + ", " + Age + " months old, dep inf #" + DepInfID ;
        }

        public void ResetDepFem()
        {
            DepInfID = 0;
            //MessageBox.Show("Infant is of age, no dep inf now. DepInfID = " + DepInfID);
        }
        public void ResetDepMale()
        {
            DepMaleInf = false;
            DepMaleAge = 0;
            //MessageBox.Show("Male infant is weaned, no longer dependent");
        }
    }
}
