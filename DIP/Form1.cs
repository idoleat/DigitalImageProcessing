using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DIP
{
    public partial class Form1 : Form
    {
        public Bitmap SourceBitmap;
        public Form1()
        {
            InitializeComponent();
        }

        private void onClick_OpenImage(object sender, EventArgs e)
        {
            openFileDialog.Filter = "All Files|*.*|Bitmap File|*.bmp|Jpeg Files|*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SourceBitmap = new Bitmap(openFileDialog.FileName);
                SourceImage.Image = SourceBitmap;
            }
        }

        private void onClick_SaveImage(object sender, EventArgs e)
        {
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RGB_r_Click(object sender, EventArgs e)
        {
            
        }

        private void test_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, SourceBitmap.Width, SourceBitmap.Height);
            BitmapData bmpData = SourceBitmap.LockBits(rect, ImageLockMode.ReadWrite, SourceBitmap.PixelFormat);

            // Get the address of the first line.

            // Declare an array to hold the bytes of the bitmap.
            int bytes = Math.Abs(bmpData.Stride) * SourceBitmap.Height;
            byte[] rgbValues = new byte[bytes];

            // Copy the RGB values into the array.
            Marshal.Copy(bmpData.Scan0, rgbValues, 0, bytes);

            // Set every third value to 255. A 24bpp bitmap will look red.  
            for (int counter = 2; counter < rgbValues.Length; counter += 3)
                rgbValues[counter] = 255;

            // Copy the RGB values back to the bitmap
            Marshal.Copy(rgbValues, 0, bmpData.Scan0, bytes);

            // Unlock the bits.
            SourceBitmap.UnlockBits(bmpData);

            // Draw the modified image.
            ProcessedImage.Image = SourceBitmap;
        }
    }
}
