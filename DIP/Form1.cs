using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DIP
{
    public partial class Form1 : Form
    {
        public Bitmap OpenedBitmap;
        public Bitmap ProcessedBitmap;
        public List<byte[]> history = new List<byte[]>();

        public enum Filter
        {
            Median,
            Mean,
            HistonEqual,
            Thres,
            HSobel,
            VSobel,
            CombSobel,
            SobelOverlay,
            ConnComp,
            Regist
        }

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
                history.Add(GetBitmapDataBytes(ProcessedBitmap));
                InitHistons();
                btn_OpenImage.Enabled = false;
            }
        }

        private void onClick_SaveImage(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "All Files|*.*|Bitmap File|*.bmp|Jpeg Files|*.jpg";

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ProcessedBitmap.Save(saveFileDialog.FileName);
            }
        }

        private void ShowHistoryLast()
        {
            SetBitmapDataBytes(ProcessedBitmap, history.Last());

            // Draw the modified image immediately.
            // Otherwise the image will be updated in a indefinated period of time, eventhough thr image reference is updated already.
            ProcessedImageBox.Image = ProcessedBitmap;
            // Actually before applying filters, image should be freed. But it's C#...let GC do it for you
        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            if (history.Count <= 1) return;
            history.RemoveAt(history.Count - 1);
            UpdateHiston2(history.Last());
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

        public void GeneralFilter(Filter fileterType)
        {
            // prevent applying filters when there's no image
            if (history.Count == 0) return;

            byte[] LastOne = history.Last();
            byte[] rgbValues = new byte[LastOne.Length];
            for (int counter = 0; counter < rgbValues.Length; counter += 1)
                rgbValues[counter] = LastOne[counter];

            switch (fileterType)
            {
                case Filter.Median:
                    MedianFilter(ref rgbValues);
                    break;

                case Filter.Mean:
                    MeanFilter(ref rgbValues);
                    break;

                case Filter.HistonEqual:
                    HistongramEqualization(ref rgbValues);
                    break;

                case Filter.Thres:
                    ThresholdFilter(ref rgbValues);
                    break;

                case Filter.HSobel:
                    H_Sobel(ref rgbValues);
                    break;

                case Filter.VSobel:
                    V_Sobel(ref rgbValues);
                    break;

                case Filter.CombSobel:
                    Comb_Sobel(ref rgbValues);
                    break;

                case Filter.SobelOverlay:
                    SobelOverlay(ref rgbValues);
                    break;

                case Filter.Regist:
                    break;

                case Filter.ConnComp:
                    ConnComp(ref rgbValues);
                    break;

                default:
                    Console.WriteLine("Invalid Filter choice");
                    break;
            }

            history.Add(rgbValues);
            ShowHistoryLast();
            UpdateHiston2(history.Last());
        }

        private void InitHistons() {
            byte[] data = new byte[256];
            foreach(byte px in history.First())
            {
                data[px] += 1;
            }
            histon1.DataBindTable(data);
            histon2.DataBindTable(new byte[256]);
            UpdateHiston2(history.First());
        }

        private void UpdateHiston2(byte[] HistonData)
        {
            byte[] newData = new byte[256];
            foreach (var px in HistonData)
            {
                newData[px] += 1;
            }

            int count = 0;
            foreach(var val in histon2.Series.Last().Points)
            {
                double[] v = new double[1];
                v[0] = newData[count];
                val.YValues = v;
                count += 1;
            }
        }
    }
}
