using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public partial class Form1
    {
        private void btn_Threshold_Click(object sender, EventArgs e)
        {
            GeneralFilter(Filter.Thres);
        }

        private void ThresholdFilter(ref byte[] rgbValue)
        {
            for(int i=0; i<rgbValue.Length; i++)
            {
                if(rgbValue[i] >= ThresVal.Value)
                {
                    rgbValue[i] = 255;
                }
                else
                {
                    rgbValue[i] = 0;
                }
            }
        }
    }
}
