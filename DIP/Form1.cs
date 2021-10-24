using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onClick_OpenImage(object sender, EventArgs e)
        {
            openFileDialog.Filter = "All Files|*.*|Bitmap File|*.bmp|Jpeg Files|*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK) pictureBox1.Image = new Bitmap(openFileDialog.FileName);
        }

        private void onClick_SaveImage(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
