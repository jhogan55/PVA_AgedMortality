using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVA_AgedMortality
{
    class RMstarterPop : Population
    {
        public static Population rm = new Population();

        static Ind simb = new Ind(270, false, 0, false, 0, 0, 0, 12, true);
        static Ind eddd = new Ind(249, false, 0, false, 0, 16, 0, 11, true); //baby is duchess
        static Ind kiar = new Ind(225, false, 0, true, 11, 0, 0, 11, true);  //dep male inf
        static Ind shan = new Ind(215, true, 1, false, 0, 0, 0, 12, true); //1 mo preg
        static Ind fant = new Ind(150, false, 0, false, 0, 17, 0, 10, true); //baby is tiana 
        static Ind lady = new Ind(141, false, 0, true, 7, 0, 0, 7, true); // 7 month old male inf 
        static Ind perd = new Ind(125, false, 0, true, 11, 0, 0, 11, true); //dep male inf
        static Ind meri = new Ind(104, false, 0, false, 0, 0, 0, 7, true); 
        static Ind duck = new Ind(99, false, 0, false, 0, 18, 0, 6, true); //baby narissa 
        static Ind ursu = new Ind(77, false, 0, false, 0, 0, 0, 12, true);
        static Ind dott = new Ind(57, false, 0, false, 0, 0, 0, 12, true);
        static Ind henw = new Ind(53, false, 0, false, 0, 0, 0, 12, true);
        static Ind fali = new Ind(47, false, 0, false, 0, 0, 0, 12, true);
        static Ind yzma = new Ind(43, false, 0, false, 0, 0, 0, 12, true);
        static Ind kopa = new Ind(23, false, 0, false, 0, 0, 0, 12, true);
        static Ind duch = new Ind(11, false, 0, false, 0, 0, 2, 12, true); //mom is ed
        static Ind tian = new Ind(10, false, 0, false, 0, 0, 5, 12, true); //mom is fanta
        static Ind nari = new Ind(6, false, 0, false, 0, 0, 9, 12, true); //mom is ducky


        public static Population DefaultPop()
        {

            rm.Add(simb);
            rm.Add(eddd);
            rm.Add(kiar);
            rm.Add(shan);
            rm.Add(fant);
            rm.Add(lady);
            rm.Add(perd);
            rm.Add(meri);
            rm.Add(duck);
            rm.Add(ursu);
            rm.Add(dott);
            rm.Add(henw);
            rm.Add(fali);
            rm.Add(yzma);
            rm.Add(kopa);
            rm.Add(duch);
            rm.Add(tian);
            rm.Add(nari);
            return rm; 
        }
    }
}
