using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVA_AgedMortality
{
    public class Trial
    {
        public static void SingleTrial(int m, Population p)
        {
            for (int i = 0; i < m; i++)
            {
                MessageBox.Show("Month " + (i+1) + " of " + m);
                Month.SingleMonth(p);                
            }
        }
    }
}
