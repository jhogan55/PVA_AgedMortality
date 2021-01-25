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

        //method: add ind to pop
       public List<Ind> AddInd(Ind i)
        {
            pop.Add(i);
            return pop;
        }
        public List<Ind> RemoveInd(Ind i)
        {
            pop.Remove(i);
            return pop;
        }

    }
}
