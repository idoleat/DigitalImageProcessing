using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace DIP
{
    public partial class Form1
    {
        private void RGB_r_Click(object sender, EventArgs e)
        {
            if (history.Count == 0) return;

            history.Add(GetBitmapDataBytes(OpenedBitmap));
            byte[] LastOne = history.Last();
            history.RemoveAt(history.Count - 1);
            byte[] rgbValues = new byte[LastOne.Length];
            for (int counter = 0; counter < rgbValues.Length; counter += 1)
                rgbValues[counter] = LastOne[counter];

            for (int counter = 2; counter < rgbValues.Length; counter += 3)
            {
                rgbValues[counter - 1] = rgbValues[counter];
                rgbValues[counter - 2] = rgbValues[counter];
            }

            history.Add(rgbValues);
            UpdateHiston2(history.Last());
            ShowHistoryLast();
        }

        private void RGB_g_Click(object sender, EventArgs e)
        {
            if (history.Count == 0) return;

            history.Add(GetBitmapDataBytes(OpenedBitmap));
            byte[] LastOne = history.Last();
            history.RemoveAt(history.Count - 1);
            byte[] rgbValues = new byte[LastOne.Length];
            for (int counter = 0; counter < rgbValues.Length; counter += 1)
                rgbValues[counter] = LastOne[counter];

            for (int counter = 1; counter < rgbValues.Length; counter += 3)
            {
                rgbValues[counter - 1] = rgbValues[counter];
                rgbValues[counter + 1] = rgbValues[counter];
            }

            history.Add(rgbValues);
            UpdateHiston2(history.Last());
            ShowHistoryLast();
        }

        private void RGB_b_Click(object sender, EventArgs e)
        {
            if (history.Count == 0) return;

            history.Add(GetBitmapDataBytes(OpenedBitmap));
            byte[] LastOne = history.Last();
            history.RemoveAt(history.Count - 1);
            byte[] rgbValues = new byte[LastOne.Length];
            for (int counter = 0; counter < rgbValues.Length; counter += 1)
                rgbValues[counter] = LastOne[counter];

            for (int counter = 0; counter < rgbValues.Length; counter += 3)
            {
                rgbValues[counter + 1] = rgbValues[counter];
                rgbValues[counter + 2] = rgbValues[counter];
            }

            history.Add(rgbValues);
            UpdateHiston2(history.Last());
            ShowHistoryLast();
        }

        private void RGB_grey_Click(object sender, EventArgs e)
        {
            if (history.Count == 0) return;

            history.Add(GetBitmapDataBytes(OpenedBitmap));
            byte[] LastOne = history.Last();
            history.RemoveAt(history.Count - 1);
            byte[] rgbValues = new byte[LastOne.Length];
            for (int counter = 0; counter < rgbValues.Length; counter += 1)
                rgbValues[counter] = LastOne[counter];

            for (int counter = 0; counter < rgbValues.Length; counter += 3)
            {
                byte grey = (byte)(rgbValues[counter] * 0.114 + rgbValues[counter + 1] * 0.587 + rgbValues[counter + 2] * 0.299);
                rgbValues[counter] = grey;
                rgbValues[counter + 1] = grey;
                rgbValues[counter + 2] = grey;
            }


            history.Add(rgbValues);
            UpdateHiston2(history.Last());
            ShowHistoryLast();
        }
    }
}
