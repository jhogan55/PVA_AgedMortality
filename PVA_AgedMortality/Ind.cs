using System;
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
        int indID;
        int age;
        bool isPreg;
        int monthsPreg;
        int monthsSinceBirth;
        int depInfID;
        int motherID;
        private static int idCount = 1;

        //public properties 
        int IndID
        {
            get { return indID; }
            set { indID = value; }
        }
        int Age
        {
            get { return age; }
            set { age = value; }
        }
        bool IsPreg
        {
            get { return isPreg; }
            set { isPreg = value; }
        }
        int MonthsPreg
        {
            get { return monthsPreg; }
            set { monthsPreg = value; } //TODO: data validation, pregnancy can only last 6 months 
        }
        int DepInfID
        {
            get { return depInfID; }
            set { depInfID = value; } //TODO: data validation, dep infant should only last for 12 months 
        }
        int MotherID
        {
            get { return motherID; }
            set { motherID = value; } //TODO: data validation, mother ID should only last for 12 months 
        }
        int MonthsSinceBirth
        {
            get { return monthsSinceBirth; }
            set { monthsSinceBirth = value; } //TODO: data validation, months since birth should never exceed X years  
        }

        //constructor for a new
        public Ind(int mAge, bool preg, int mPreg, int depInf, int mom, int mSinceBirth)
        {
            IndID = idCount;
            idCount++;
            Age = mAge;
            IsPreg = preg;
            MonthsPreg = mPreg;
            DepInfID = depInf;
            MotherID = mom;
            MonthsSinceBirth = mSinceBirth;
        }

        //methods

        //Age Up
        public void AgeUp ()
        {
            Age++;
            if (IsPreg)
            {
                MonthsPreg++;
                if (MonthsPreg == VitalRates.GESTATIONLENGTH) //TODO: Vital Rates class 
                {
                    GiveBirth();
                }
            }
        }

        public void GiveBirth ()
        {
            IsPreg = false;
            MonthsPreg = 0;
            if (MathFunctions.CoinFlip(VitalRates.SEXRATIO)) //If baby is female, create a new individual 
            {
                DepInfID = idCount; //link female to mother 
                Ind baby = new Ind(0, false, 0, 0, IndID, 0); //create new baby             
            }
        }

        //Get pregnant
        public void GetPreg()
        {
            if (MathFunctions.CoinFlip(VitalRates.ConceptionRate(Age))) { IsPreg = true; }
            else IsPreg = false;
            MessageBox.Show("Ind " + indID + " got pregnant this time: " + IsPreg);
        }

        //Remove mother dependency from weaned infants  
        public void LoseMotherDependency()
        {
            if (Age == VitalRates.DEPENDENCYLENGTH) { MotherID = 0; }
        }
        
        //String override for list box
        public string DisplayIndInPop()
        {
            return IndID + ", " + Age + " months old";
        }

    }
}
