using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVA_AgedMortality
{
    class LVstarterPop : Population
    {
        public static Population lv = new Population();

        static Ind sals = new Ind(296, false, 0, true, 11, 0, 0, 11, true); //male dep inf
        static Ind chut = new Ind(253, false, 0, false, 0, 13, 0, 12, true); //make believe dependent female, for testing purposes 
        static Ind oreg = new Ind(179, false, 0, true, 10, 0, 0, 10, true); // male dep inf 
        static Ind chch = new Ind(190, false, 0, false, 0, 0, 0, 12, true);
        static Ind thym = new Ind(147, false, 0, false, 0, 0, 0, 12,true);
        static Ind vani = new Ind(123, false, 0, false, 0, 0, 0, 12, true);
        static Ind sage = new Ind(121, false, 0, false, 0, 0, 0, 12, true);
        static Ind crys = new Ind(93, false, 0, false, 0, 0, 0, 12, true);
        static Ind roux = new Ind(72, false, 0, false, 0, 0, 0, 12, true);
        static Ind fres = new Ind(72, false, 0, false, 0, 0, 0, 12, true);
        static Ind papr = new Ind(37, false, 0, false, 0, 0, 0, 12, true);
        static Ind hari = new Ind(19, false, 0, false, 0, 0, 0, 12, true);
        static Ind baby = new Ind(0, false, 0, false, 0, 0, 2, 12, true); //make believe inf female for testing purposes

        public static Population DefaultPop()
        {
            
            lv.Add(sals);
            lv.Add(chut);
            lv.Add(oreg);
            lv.Add(chch);
            lv.Add(thym);
            lv.Add(vani);
            lv.Add(sage);
            lv.Add(crys);
            lv.Add(roux);
            lv.Add(fres);
            lv.Add(papr);
            lv.Add(hari);
            lv.Add(baby);

            return lv;
        }

    }
}
