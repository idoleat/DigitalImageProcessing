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
        public Bitmap OpenedBitmap;
        public Bitmap ProcessedBitmap;
        public List<BitmapData> history = new List<BitmapData>();
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void onClick_OpenImage(object sender, EventArgs e)
        {
            openFileDialog.Filter = "All Files|*.*|Bitmap File|*.bmp|Jpeg Files|*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenedBitmap = new Bitmap(openFileDialog.FileName);
                ProcessedBitmap = new Bitmap(openFileDialog.FileName);
                BitmapData bmpd = ProcessedBitmap.LockBits(
                        new Rectangle(0, 0, ProcessedBitmap.Width,
                        ProcessedBitmap.Height),
                        ImageLockMode.ReadWrite,
                        ProcessedBitmap.PixelFormat
                );
                history.Add(bmpd);
                ProcessedBitmap.UnlockBits(bmpd);
                SourceImageBox.Image = OpenedBitmap;
                ProcessedImageBox.Image = ProcessedBitmap;
            }
        }

        private void onClick_SaveImage(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "All Files|*.*|Bitmap File|*.bmp|Jpeg Files|*.jpg";

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenedBitmap.Save(saveFileDialog.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RGB_r_Click(object sender, EventArgs e)
        {
            
        }

        private void test_Click(object sender, EventArgs e)
        {
            BitmapData bmpData = CopyLastBitmapData();
            //BitmapData bmpData = new BitmapData();
            //bmpData = history.Last();

            // Declare an array to hold the bytes of the bitmap.
            int bytes = Math.Abs(bmpData.Stride) * OpenedBitmap.Height;
            byte[] rgbValues = new byte[bytes];

            // Copy the RGB values into the array.
            Marshal.Copy(bmpData.Scan0, rgbValues, 0, bytes);

            // Set every third value to 255. A 24bpp bitmap will look red.  
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
            else if(count % 3 == 1)
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
            

            // Copy the RGB values back to the bitmap
            Marshal.Copy(rgbValues, 0, bmpData.Scan0, bytes);

            history.Add(bmpData);
            ShowHistoryLast();
        }

        private BitmapData CopyLastBitmapData()
        {
            BitmapData bmpData = new BitmapData();
            bmpData.Scan0 = history.Last().Scan0;
            bmpData.Height = history.Last().Height;
            bmpData.Width = history.Last().Width;
            bmpData.PixelFormat = history.Last().PixelFormat;
            bmpData.Reserved = history.Last().Reserved;
            bmpData.Stride = history.Last().Stride;

            return bmpData;
        }

        private void ShowHistoryLast()
        {
            BitmapData bmpd;
            ProcessedBitmap.LockBits(
                        new Rectangle(0, 0, ProcessedBitmap.Width,
                        ProcessedBitmap.Height),
                        ImageLockMode.ReadWrite,
                        ProcessedBitmap.PixelFormat
            );
            bmpd = CopyLastBitmapData();
            //bmpd = history.Last();
            ProcessedBitmap.UnlockBits(bmpd);

            // Draw the modified image.
            ProcessedImageBox.Image = ProcessedBitmap;
            // Actually before applying filters, image should be freed. But it's C#...let GC do it for you
        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            if (history.Count <= 1) return;
            history.RemoveAt(history.Count - 1);
            Console.WriteLine(history.Count);
            ShowHistoryLast();
        }
    }
}
