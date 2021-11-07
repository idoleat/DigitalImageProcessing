using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public partial class Form1
    {
        private void btn_ConnComp_Click(object sender, EventArgs e)
        {
            GeneralFilter(Filter.ConnComp);
        }

        private void ConnComp(ref byte[] rgbValue)
        {
            var colors = new Dictionary<int, byte>();
            Random rnd = new Random();
            int width = OpenedBitmap.Width;
            int[] ExtVal = new int[rgbValue.Length * 2];
            byte[] original = new byte[rgbValue.Length];
            for (int counter = 0; counter < original.Length; counter += 1)
            {
                original[counter] = rgbValue[counter];
                // first value is color, second is parent (in disjoint set).
                ExtVal[counter * 2] = rgbValue[counter];
                // temperarily use 0
                ExtVal[counter * 2 + 1] = 0;
            }

            for (int i = 1; i <= OpenedBitmap.Height - 2; i++)
            {
                for (int j = 1; j < width - 1; j += 1)
                {
                    if (original[i * width + j] != 0) continue;
                    if (ExtVal[(i * width + j) * 2 + 1] == 0)
                    {
                        // generate a color
                        colors.Add((i * width + j), (byte)rnd.Next(50, 200));

                        rgbValue[i * width + j] = (byte)rnd.Next(50, 200);
                        //rgbValue[i * width + j + 1] = (byte)rnd.Next(50, 200);
                        //rgbValue[i * width + j + 2] = (byte)rnd.Next(50, 200);

                        // set itself as parent
                        ExtVal[(i * width + j) * 2 + 1] = i * width + j;
                    }

                    List<int> kernel = (new int[] {
                        (i - 1) * width + j - 1,
                        (i - 1) * width + j,
                        (i - 1) * width + j + 1,
                        i * width + j - 1,
                        i * width + j,
                        i * width + j + 1,
                        (i + 1) * width + j - 1,
                        (i + 1) * width + j,
                        (i + 1) * width + j + 1
                    }).ToList();

                    // in each element in ketnel, if the color is 0, make its parent same as current
                    foreach (var idx in kernel)
                    {
                        if (ExtVal[idx * 2] == 0)
                        {
                            ExtVal[idx * 2 + 1] = ExtVal[(i * width + j) * 2 + 1];
                        }
                    }

                }
            }
            for (int i = 0; i < OpenedBitmap.Height; i++)
            {
                for (int j = 0; j < width; j += 1)
                {
                    if (original[i * width + j] == 0)
                    {
                        rgbValue[i * width + j] = rgbValue[ExtVal[(i * width + j) * 2 + 1]];
                        //rgbValue[i * width + j + 1] = rgbValue[ExtVal[(i * width + j) * 2 + 1] + 1];
                        //rgbValue[i * width + j + 2] = rgbValue[ExtVal[(i * width + j) * 2 + 1] + 2];
                    }
                }
            }
        }
    }
}
