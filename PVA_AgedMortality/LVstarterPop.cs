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

        static Ind sals = new Ind(299, false, 0, false, 0, 0, 0, 12, true); 
        static Ind chut = new Ind(258, false, 0, false, 0, 0, 0, 12, true);
        static Ind oreg = new Ind(190, true, 2, false, 0, 0, 0, 12, true);  //pregnant 
        static Ind chch = new Ind(195, false, 0, true, 7, 0, 0, 7, true); //male dep inf
        static Ind thym = new Ind(152, true, 2, false, 0, 0, 0, 12, true); //pregnant 
        static Ind vani = new Ind(129, false, 0, false, 0, 0, 0, 12, true);
        static Ind sage = new Ind(126, false, 0, false, 0, 0, 0, 12, true);
        static Ind crys = new Ind(99, false, 0, false, 0, 13, 0, 7, true); //cuaj is her baby
        static Ind roux = new Ind(78, false, 0, false, 0, 0, 0, 12, true);
        static Ind fres = new Ind(77, false, 0, false, 0, 0, 0, 12, true);
        static Ind papr = new Ind(42, false, 0, false, 0, 0, 0, 12, true);
        static Ind hari = new Ind(24, false, 0, false, 0, 0, 0, 12, true);
        static Ind cuaj = new Ind(7, false, 0, false, 0, 0, 8, 12, true);

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
            lv.Add(cuaj);
            return lv;
        }

    }
}
