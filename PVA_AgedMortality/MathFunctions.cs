using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVA_AgedMortality
{
    public class MathFunctions
    {
        static Random rnd = new Random();

        public static bool CoinFlip(double prob) //function for outcome simulation for binary events (AMR/stable, life/death, birth/no birth) 
        {

            if (rnd.NextDouble() < prob) //if random number is less than your probability, event happened 
            {
                return true;
            }
            else return false; //random number > probability, event didnt happen 
        }

        public static double SampleBeta(double a, double b) //function for sampling from beta distribution
        {

            //sampler taken from James McCaffrey, based on 1978 paper from RCH Cheng. 
            //https://jamesmccaffrey.wordpress.com/2017/11/01/more-on-sampling-from-the-beta-distribution-using-c/cheng_ba_csharp/

            double alpha = a + b;
            double beta = 0.0;
            double u1, u2, w, v = 0.0;

            if (Math.Min(a, b) <= 1.0)
                beta = Math.Max(1 / a, 1 / b);
            else
                beta = Math.Sqrt((alpha - 2.0) / (2 * a * b - alpha));
            double gamma = a + 1 / beta;
            while (true)
            {
                u1 = rnd.NextDouble();
                u2 = rnd.NextDouble();
                v = beta * Math.Log(u1 / (1 - u1));
                w = a * Math.Exp(v);
                double tmp = Math.Log(alpha / (b + w));
                if (alpha * tmp + (gamma * v) - 1.3862944 >= Math.Log(u1 * u1 * u2))
                    break;
            }
            double x = w / (b + w);
            return x;
        }

        public static int YearsToMonths(int y)
        {
            int m;
            m = y * 12;
            return m;
        }

        public static int MonthsToYears(int m)
        {
            int y;
            y = m / 12;
            return y;
        }
    }
}
