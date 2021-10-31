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

            int width = OpenedBitmap.Width * 3;
            byte[] original = new byte[rgbValue.Length];
            for (int counter = 0; counter < original.Length; counter += 1)
                original[counter] = rgbValue[counter];

            for (int i = 1; i <= OpenedBitmap.Height - 2; i++)
            {
                for (int j = 3; j < width - 3; j += 3)
                {
                    /*byte[] colors = new byte[256];
                    for (int k = 0; k < colors.Length; k++) colors[k] = 0;

                    colors[original[(i - 1) * width + j - 3]] = original[(i - 1) * width + j - 3];
                    colors[original[(i - 1) * width + j]] = original[(i - 1) * width + j - 3];
                    colors[original[(i - 1) * width + j + 3]] = original[(i - 1) * width + j - 3];
                    colors[original[i * width + j - 3]] = original[(i - 1) * width + j - 3];
                    colors[original[i * width + j]] = original[(i - 1) * width + j - 3];
                    colors[original[i * width + j + 3]] = original[(i - 1) * width + j - 3];
                    colors[original[(i + 1) * width + j - 3]] = original[(i - 1) * width + j - 3];
                    colors[original[(i + 1) * width + j]] = original[(i - 1) * width + j - 3];
                    colors[original[(i + 1) * width + j + 3]] = original[(i - 1) * width + j - 3];

                    int count = 0;
                    for(int k=0; k<255; k++)
                    {
                        if (colors[k] != 0) count += 1;
                        if(count == 5)
                        {
                            rgbValue[i * width + j] = (byte)k;
                            rgbValue[i * width + j + 1] = (byte)k;
                            rgbValue[i * width + j + 2] = (byte)k;
                        }
                    }*/
                    List<byte> NxN = new List<byte>();
                    NxN.Add(original[(i - 1) * width + j - 3]);
                    NxN.Add(original[(i - 1) * width + j]);
                    NxN.Add(original[(i - 1) * width + j + 3]);
                    NxN.Add(original[i * width + j - 3]);
                    NxN.Add(original[i * width + j]);
                    NxN.Add(original[i * width + j + 3]);
                    NxN.Add(original[(i + 1) * width + j - 3]);
                    NxN.Add(original[(i + 1) * width + j]);
                    NxN.Add(original[(i + 1) * width + j + 3]);
                    NxN.Sort();

                    byte median = NxN.ElementAt(4);
                    rgbValue[i * width + j] = median;
                    rgbValue[i * width + j + 1] = median;
                    rgbValue[i * width + j + 2] = median;
                }
            }
        }

        private void btn_MeanFilter_Click(object sender, EventArgs e)
        {
            GeneralFilter(Filter.Mean);
        }

        private void MeanFilter(ref byte[] rgbValue)
        {
            int width = OpenedBitmap.Width *3;
            byte[] original = new byte[rgbValue.Length];
            for (int counter = 0; counter < original.Length; counter += 1)
                original[counter] = rgbValue[counter];
            for (int i=1 ; i <= OpenedBitmap.Height-2; i++)
            {
                for(int j=3; j < width - 3; j += 3)
                {
                    int mean =
                        original[(i - 1) * width + j-3] +
                        original[(i - 1) * width + j] +
                        original[(i - 1) * width + j+3] +
                        original[i * width + j-3] +
                        original[i * width + j] +
                        original[i * width + j+3] +
                        original[(i + 1) * width + j-3] +
                        original[(i + 1) * width + j] +
                        original[(i + 1) * width + j+3];

                    mean /= 9;
                    rgbValue[i * width + j] = (byte)mean;
                    rgbValue[i * width + j+1] = (byte)mean;
                    rgbValue[i * width + j+2] = (byte)mean;
                }
            }
        }
    }
}
