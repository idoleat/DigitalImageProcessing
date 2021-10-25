using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public partial class Form1
    {
        private void test_Click(object sender, EventArgs e)
        {
            if (history.Count == 0) return;

            byte[] LastOne = history.Last();

            // Declare an array to hold bytes of bitmap from the last midification.
            byte[] rgbValues = new byte[LastOne.Length];

            // Copy the RGB values into the array.
            for (int counter = 0; counter < rgbValues.Length; counter += 1)
                rgbValues[counter] = LastOne[counter];


            // Cycling RGB colors
            count += 1;
            if (count % 3 == 0)
            {
                for (int counter = 0; counter < rgbValues.Length; counter += 3)
                    rgbValues[counter] = 255;
                for (int counter = 1; counter < rgbValues.Length; counter += 3)
                    rgbValues[counter] = 0;
                for (int counter = 2; counter < rgbValues.Length; counter += 3)
                    rgbValues[counter] = 0;
            }
            else if (count % 3 == 1)
            {
                for (int counter = 0; counter < rgbValues.Length; counter += 3)
                    rgbValues[counter] = 0;
                for (int counter = 1; counter < rgbValues.Length; counter += 3)
                    rgbValues[counter] = 255;
                for (int counter = 2; counter < rgbValues.Length; counter += 3)
                    rgbValues[counter] = 0;
            }
            else
            {
                for (int counter = 0; counter < rgbValues.Length; counter += 3)
                    rgbValues[counter] = 0;
                for (int counter = 1; counter < rgbValues.Length; counter += 3)
                    rgbValues[counter] = 0;
                for (int counter = 2; counter < rgbValues.Length; counter += 3)
                    rgbValues[counter] = 255;
            }

            history.Add(rgbValues);
            ShowHistoryLast();
        }
    }
}
