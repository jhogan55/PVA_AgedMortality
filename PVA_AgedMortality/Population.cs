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
        List<Ind> pop = new List<Ind>();
        
        //public property 
        public List<Ind> Pop
        {
            get { return pop; }
            set { pop = value; }
        }
        
        //Constructor (default for now) 
        public Population ()
        {

        }

        //method: mother with dependent infant died, remove her infant from pop
        public void RemoveDependentInfant(int m)  
        {
           //use mother's ID (m) to find infant with motherID m 
           //message box saying "Mother #XXX died, removing dependent infant ID #YYY"
           //remove that infant from pop
        }

        public static Population ClonePop(Population p)
        {
            Population n = new Population();
            foreach (Ind i in p)
            {
                n.Add(Ind.CloneInd(i));
            }
            return n;
        }

        public static Population MonthlySurvivalTest(Population p, bool amr)
        {
            List<int> deadInd = new List<int>();
            foreach (Ind i in p)
            {
                
                bool survivedMonth = Ind.IndSurvTest(i, amr);
                if (survivedMonth == false)
                {
                    deadInd.Add(i.ReturnID());
                    MessageBox.Show("Ind " + i.DisplayIndInPop() + " months old, died. Removing from population");
                }
            } //end of foreach loop of population
            foreach (int j in deadInd)
            {
                p.RemoveAll(Ind => Ind.ReturnID() == j);
                p.RemoveAll(Ind => Ind.ReturnMotherID() == j);
            }
            return p;
        }

    }
}
