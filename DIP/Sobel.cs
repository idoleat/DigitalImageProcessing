using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public partial class Form1
    {
        private void VSobel_Click(object sender, EventArgs e)
        {
            GeneralFilter(Filter.VSobel);
        }

        private void HSobel_Click(object sender, EventArgs e)
        {
            GeneralFilter(Filter.HSobel);
        }

        private void SobelComb_Click(object sender, EventArgs e)
        {
            GeneralFilter(Filter.CombSobel);
        }

        private void SobelOverlay_Click(object sender, EventArgs e)
        {
            GeneralFilter(Filter.SobelOverlay);
        }

        // 3 functions below have too much dupicated code. Need refactor.

        private void V_Sobel(ref byte[] rgbValue)
        {
            int width = OpenedBitmap.Width * 3;
            byte[] original = new byte[rgbValue.Length];
            for (int counter = 0; counter < original.Length; counter += 1)
                original[counter] = rgbValue[counter];
            for (int i = 1; i <= OpenedBitmap.Height - 2; i++)
            {
                for (int j = 3; j < width - 3; j += 3)
                {
                    int x =
                        original[(i - 1) * width + j - 3] * (-1) +
                        original[(i - 1) * width + j] * (-2) +
                        original[(i - 1) * width + j + 3] * (-1) +
                        original[i * width + j - 3] * 0 +
                        original[i * width + j] * 0 +
                        original[i * width + j + 3] * 0 +
                        original[(i + 1) * width + j - 3] * 1 +
                        original[(i + 1) * width + j] * 2 +
                        original[(i + 1) * width + j + 3] * 1;

                    if (x < 0) x = -x;
                    if (x > 255) x = 255;

                    rgbValue[i * width + j] = (byte)x;
                    rgbValue[i * width + j + 1] = (byte)x;
                    rgbValue[i * width + j + 2] = (byte)x;
                }
            }
        }

        private void H_Sobel(ref byte[] rgbValue)
        {
            int width = OpenedBitmap.Width * 3;
            byte[] original = new byte[rgbValue.Length];
            for (int counter = 0; counter < original.Length; counter += 1)
                original[counter] = rgbValue[counter];
            for (int i = 1; i <= OpenedBitmap.Height - 2; i++)
            {
                for (int j = 3; j < width - 3; j += 3)
                {
                    int y =
                        original[(i - 1) * width + j - 3] * (-1) +
                        original[(i - 1) * width + j] * 0 +
                        original[(i - 1) * width + j + 3] +
                        original[i * width + j - 3] * 2 +
                        original[i * width + j] * 0 +
                        original[i * width + j + 3] * (-2) +
                        original[(i + 1) * width + j - 3] * (-1) +
                        original[(i + 1) * width + j] * 0 +
                        original[(i + 1) * width + j + 3];

                    if (y < 0) y = -y;
                    if (y > 255) y = 255;

                    rgbValue[i * width + j] = (byte)y;
                    rgbValue[i * width + j + 1] = (byte)y;
                    rgbValue[i * width + j + 2] = (byte)y;
                }
            }
        }

        private void Comb_Sobel(ref byte[] rgbValue)
        {
            int width = OpenedBitmap.Width * 3;
            byte[] original = new byte[rgbValue.Length];
            for (int counter = 0; counter < original.Length; counter += 1)
                original[counter] = rgbValue[counter];
            for (int i = 1; i <= OpenedBitmap.Height - 2; i++)
            {
                for (int j = 3; j < width - 3; j += 3)
                {
                    int x =
                        original[(i - 1) * width + j - 3] * (-1) +
                        original[(i - 1) * width + j] * (-2) +
                        original[(i - 1) * width + j + 3] * (-1) +
                        original[i * width + j - 3] * 0 +
                        original[i * width + j] * 0 +
                        original[i * width + j + 3] * 0 +
                        original[(i + 1) * width + j - 3] * 1 +
                        original[(i + 1) * width + j] * 2 +
                        original[(i + 1) * width + j + 3] * 1;

                    int y =
                        original[(i - 1) * width + j - 3] * (-1) +
                        original[(i - 1) * width + j] * 0 +
                        original[(i - 1) * width + j + 3] +
                        original[i * width + j - 3] * 2 +
                        original[i * width + j] * 0 +
                        original[i * width + j + 3] * (-2) +
                        original[(i + 1) * width + j - 3] * (-1) +
                        original[(i + 1) * width + j] * 0 +
                        original[(i + 1) * width + j + 3];

                    double result = Math.Sqrt(x * x + y * y);

                    rgbValue[i * width + j] = (byte)result;
                    rgbValue[i * width + j + 1] = (byte)result;
                    rgbValue[i * width + j + 2] = (byte)result;
                }
            }
        }

        private void SobelOverlay(ref byte[] rgbValue)
        {
            GeneralFilter(Filter.CombSobel);
            GeneralFilter(Filter.Thres);

            byte[] original = new byte[rgbValue.Length];
            for (int counter = 0; counter < original.Length; counter += 1)
                original[counter] = history.Last()[counter];
            history.RemoveAt(history.Count - 1);
            history.RemoveAt(history.Count - 1);

            for (int i=1; i<original.Length; i += 3)
            {
                if(original[i] == 255)
                {
                    rgbValue[i] = 255;
                }
            }
        }
    }
}
