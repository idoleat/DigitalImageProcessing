using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public partial class Form1
    {
        private void btn_MedianFilter_Click(object sender, EventArgs e)
        {
            GeneralFilter(Filter.Median);
        }

        private void MedianFilter(ref byte[] rgbValue)
        {
            
            for(int i=0; i<rgbValue.Length; i += 3)
            {

            }
        }

        private void btn_MeanFilter_Click(object sender, EventArgs e)
        {
            GeneralFilter(Filter.Mean);
        }

        private void MeanFilter(ref byte[] rgbValue)
        {
            for (int i = 0; i < rgbValue.Length; i += 3)
            {

            }
        }
    }
}
