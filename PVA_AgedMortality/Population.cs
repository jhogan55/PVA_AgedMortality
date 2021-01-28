using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVA_AgedMortality
{
    public class Population: List<Ind>
    {
        //private list 
        public static List<int> weanedInf = new List<int>();
        public static Population newFemInf = new Population();
        //Constructor (default for now) 
        public Population ()
        {

        }

        //include all the individual-level changes to survivors here: eg 1 month older, 1 month further pregnant if preg etc 
        public static void MonthlyIndChanges(Population p)
        {
            foreach (Ind i in p)
            {
                //increment all monthly counters for each individual                
                i.AddMonthToIndCounters();
                i.ChanceToConceive();
            }
        }


        //Infant female has weaned, no longer associated with mother. Population-level method because it involves 2 different individuals  
        public static void RemoveWeanedFem(List<int> weaned, Population p)  
        {
            foreach (int infID in weaned) //for every ID stored in weaned list 
            {
                foreach (Ind i in p) //find every matching individual 
                {
                    if (i.DepInfID == infID) 
                    {
                        //MessageBox.Show("Dep inf ID = " + i.DepInfID + " weaned, removing dependency");
                        i.ResetDepFem();//reset depInf to 0;  
                    }                    
                }              
            }
            weaned.Clear(); //empty list after every run 
        }

        //create a deep copy of any population (changes to new population will not affect "original" population) 
        public static Population ClonePop(Population p)
        {
            Population n = new Population();
            foreach (Ind i in p)
            {
                n.Add(Ind.CloneInd(i));
            }
            return n;
        }

        //Use age-based survival curves to determine monthly survivorship for each individual. Also test male dependent infants 
        public static Population MonthlySurvivalTest(Population p, bool amr)
        {
            List<int> deadInd = new List<int>();
            
            foreach (Ind i in p) //check survival for each individual in pop 
            {
                
                bool survivedMonth = Ind.IndSurvTest(i.Age, amr); 
                if (survivedMonth == false) //individual died 
                {
                    deadInd.Add(i.IndID); //add individual's ID to the death list 
                    Trial.TrialDeaths++;  //increment death counter 
                    //MessageBox.Show("Ind " + i.DisplayIndInPop() + " months old, died. Removing from population"); 
                }
                bool maleInfSurv = Ind.IndSurvTest(i.DepMaleAge, amr);
                if (maleInfSurv == false)
                {
                    i.ResetDepMale();
                    i.PrevInfSurv = false; //mom lost baby, so goes on shortened IBI path 
                    Trial.TrialDeaths++;
                    //MessageBox.Show("Infant male of female " + i.IndID + " died, now on short IBI path " + i.PrevInfSurv);
                }
            } //end of foreach loop of population
            foreach (int j in deadInd) //for all dead inds, remove them from population. Also remove dependent infants 
            {
                p.RemoveAll(Ind => Ind.IndID == j); //remove individuals who died 
                foreach (Ind i in p) //foreach loop to find any dependent infants who are going to be removed, used to increment trial death counter only  
                {
                    if(i.DepInfID == j) //dependent female infant was killed
                    {
                        i.PrevInfSurv = false; //mom goes on the shortenend IBI path 
                        i.ResetDepFem(); //no infant association for mom anymore 
                        //MessageBox.Show("Infant fenale lost, ID# " + j + ", mom ID# " + i.IndID + " now on short IBI path " + i.PrevInfSurv);
                    }
                    if(i.MotherID == j) //if your mom is on the death list you are dead 
                    {
                        Trial.TrialDeaths++; //count as a death statistic 
                       // MessageBox.Show("Dependent infant " + i.DisplayIndInPop() + " months old, lost mother (ID " + i.MotherID + "), removed from population");
                    }
                }
                p.RemoveAll(Ind => Ind.MotherID == j); //remove dependent infants of individuals who died 
            }
            return p;
        }

    }
}
