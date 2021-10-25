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
        public List<byte[]> history = new List<byte[]>();

        // for TestEffect
        private int count = 0;

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
                SourceImageBox.Image = OpenedBitmap;
                ProcessedImageBox.Image = ProcessedBitmap;

                // Add the original image as first history
                history.Add( GetBitmapDataBytes(ProcessedBitmap) );
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

        private void ShowHistoryLast()
        {
            SetBitmapDataBytes(ProcessedBitmap, history.Last());

            // Draw the modified image.
            ProcessedImageBox.Image = ProcessedBitmap;
            // Actually before applying filters, image should be freed. But it's C#...let GC do it for you
        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            if (history.Count <= 1) return;
            //Marshal.FreeHGlobal(history.Last().Scan0);
            history.RemoveAt(history.Count - 1);
            ShowHistoryLast();
        }

        public byte[] GetBitmapDataBytes(Bitmap bmp)
        {
            BitmapData bmpData = bmp.LockBits(
                new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadOnly, ProcessedBitmap.PixelFormat
            );

            int bytes = bmpData.Stride * bmpData.Height;
            byte[] buffer = new byte[bytes];
            Marshal.Copy(bmpData.Scan0, buffer, 0, bytes);

            bmp.UnlockBits(bmpData);

            return buffer;
        }

        public void SetBitmapDataBytes(Bitmap bmp, byte[] bytes)
        {
            BitmapData bmpData = bmp.LockBits(
                new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.WriteOnly, ProcessedBitmap.PixelFormat
                );

            Marshal.Copy(bytes, 0, bmpData.Scan0, bytes.Length);

            bmp.UnlockBits(bmpData);
        }
    }
}
