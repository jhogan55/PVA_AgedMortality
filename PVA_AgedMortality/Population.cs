using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
