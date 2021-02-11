using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVA_AgedMortality
{
    class BCstarterPop : Population
    {
        public static Population bc = new Population();

        static Ind weas = new Ind(313, false, 0, false, 0, 0, 0, 12, true);
        static Ind rita = new Ind(240, false, 0, false, 0, 0, 0, 12, true); 
        static Ind wink = new Ind(152, false, 0, false, 0, 0, 0, 12, false); //infant male died this month
        static Ind nymp = new Ind(110, false, 0, true, 7, 0, 0, 7, true); // 7 mo male infant 
        static Ind hung = new Ind(104, false, 0, false, 0, 7, 0, 7, true); //thal is baby
        static Ind levi = new Ind(47, false, 0, false, 0, 0, 0, 12, true);
        static Ind thal = new Ind(3, false, 0, false, 0, 0, 5, 12, true); //hung is mom 


        public static Population DefaultPop()
        {
            bc.Add(weas);
            bc.Add(rita);
            bc.Add(wink);
            bc.Add(nymp);
            bc.Add(hung);
            bc.Add(levi);
            bc.Add(thal);
            return bc;
        }
    }
}
