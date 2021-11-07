using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public partial class Form1
    {
        private void btn_HistonEqual_Click(object sender, EventArgs e)
        {
            GeneralFilter(Filter.HistonEqual);
        }

        private void HistongramEqualization(ref byte[] rgbValue)
        {
            float[] hist = new float[256];
            //hist[0] = 
            for (int i = 0; i < rgbValue.Length; i += 3)
            {

            }
        }
    }
}
