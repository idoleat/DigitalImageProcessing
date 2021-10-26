
namespace DIP
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_OpenImage = new System.Windows.Forms.Button();
            this.btn_SaveImage = new System.Windows.Forms.Button();
            this.SourceImageBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ProcessedImageBox = new System.Windows.Forms.PictureBox();
            this.RGB_r = new System.Windows.Forms.Button();
            this.RGB_g = new System.Windows.Forms.Button();
            this.RGB_b = new System.Windows.Forms.Button();
            this.RGB_grey = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.btn_undo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_MedianFilter = new System.Windows.Forms.Button();
            this.btn_MeanFilter = new System.Windows.Forms.Button();
            this.HistonEqual = new System.Windows.Forms.GroupBox();
            this.btn_HistonEqual = new System.Windows.Forms.Button();
            this.Threshold = new System.Windows.Forms.GroupBox();
            this.btn_Threshold = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.SourceImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedImageBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.HistonEqual.SuspendLayout();
            this.Threshold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OpenImage
            // 
            this.btn_OpenImage.Location = new System.Drawing.Point(12, 12);
            this.btn_OpenImage.Name = "btn_OpenImage";
            this.btn_OpenImage.Size = new System.Drawing.Size(74, 35);
            this.btn_OpenImage.TabIndex = 0;
            this.btn_OpenImage.Text = "Open Image";
            this.btn_OpenImage.UseVisualStyleBackColor = true;
            this.btn_OpenImage.Click += new System.EventHandler(this.onClick_OpenImage);
            // 
            // btn_SaveImage
            // 
            this.btn_SaveImage.Location = new System.Drawing.Point(92, 12);
            this.btn_SaveImage.Name = "btn_SaveImage";
            this.btn_SaveImage.Size = new System.Drawing.Size(72, 35);
            this.btn_SaveImage.TabIndex = 1;
            this.btn_SaveImage.Text = "Save Image";
            this.btn_SaveImage.UseVisualStyleBackColor = true;
            this.btn_SaveImage.Click += new System.EventHandler(this.onClick_SaveImage);
            // 
            // SourceImageBox
            // 
            this.SourceImageBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SourceImageBox.Enabled = false;
            this.SourceImageBox.Location = new System.Drawing.Point(253, 12);
            this.SourceImageBox.Name = "SourceImageBox";
            this.SourceImageBox.Size = new System.Drawing.Size(320, 240);
            this.SourceImageBox.TabIndex = 2;
            this.SourceImageBox.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // ProcessedImageBox
            // 
            this.ProcessedImageBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ProcessedImageBox.Location = new System.Drawing.Point(253, 274);
            this.ProcessedImageBox.Name = "ProcessedImageBox";
            this.ProcessedImageBox.Size = new System.Drawing.Size(320, 240);
            this.ProcessedImageBox.TabIndex = 3;
            this.ProcessedImageBox.TabStop = false;
            // 
            // RGB_r
            // 
            this.RGB_r.Location = new System.Drawing.Point(6, 21);
            this.RGB_r.Name = "RGB_r";
            this.RGB_r.Size = new System.Drawing.Size(35, 33);
            this.RGB_r.TabIndex = 5;
            this.RGB_r.Text = "R";
            this.RGB_r.UseVisualStyleBackColor = true;
            this.RGB_r.Click += new System.EventHandler(this.RGB_r_Click);
            // 
            // RGB_g
            // 
            this.RGB_g.Location = new System.Drawing.Point(47, 21);
            this.RGB_g.Name = "RGB_g";
            this.RGB_g.Size = new System.Drawing.Size(35, 33);
            this.RGB_g.TabIndex = 6;
            this.RGB_g.Text = "G";
            this.RGB_g.UseVisualStyleBackColor = true;
            this.RGB_g.Click += new System.EventHandler(this.RGB_g_Click);
            // 
            // RGB_b
            // 
            this.RGB_b.Location = new System.Drawing.Point(88, 21);
            this.RGB_b.Name = "RGB_b";
            this.RGB_b.Size = new System.Drawing.Size(35, 33);
            this.RGB_b.TabIndex = 7;
            this.RGB_b.Text = "B";
            this.RGB_b.UseVisualStyleBackColor = true;
            this.RGB_b.Click += new System.EventHandler(this.RGB_b_Click);
            // 
            // RGB_grey
            // 
            this.RGB_grey.Location = new System.Drawing.Point(129, 21);
            this.RGB_grey.Name = "RGB_grey";
            this.RGB_grey.Size = new System.Drawing.Size(81, 33);
            this.RGB_grey.TabIndex = 8;
            this.RGB_grey.Text = "Grey";
            this.RGB_grey.UseVisualStyleBackColor = true;
            this.RGB_grey.Click += new System.EventHandler(this.RGB_grey_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(696, 20);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(76, 26);
            this.test.TabIndex = 9;
            this.test.Text = "test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // btn_undo
            // 
            this.btn_undo.Location = new System.Drawing.Point(198, 12);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.Size = new System.Drawing.Size(30, 35);
            this.btn_undo.TabIndex = 10;
            this.btn_undo.Text = "undo";
            this.btn_undo.UseVisualStyleBackColor = true;
            this.btn_undo.Click += new System.EventHandler(this.btn_undo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RGB_r);
            this.groupBox1.Controls.Add(this.RGB_g);
            this.groupBox1.Controls.Add(this.RGB_b);
            this.groupBox1.Controls.Add(this.RGB_grey);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 64);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RGB Seperation and Grayscale";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_MedianFilter);
            this.groupBox2.Controls.Add(this.btn_MeanFilter);
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 63);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mean/Median Filter";
            // 
            // btn_MedianFilter
            // 
            this.btn_MedianFilter.Location = new System.Drawing.Point(110, 21);
            this.btn_MedianFilter.Name = "btn_MedianFilter";
            this.btn_MedianFilter.Size = new System.Drawing.Size(100, 31);
            this.btn_MedianFilter.TabIndex = 1;
            this.btn_MedianFilter.Text = "Median";
            this.btn_MedianFilter.UseVisualStyleBackColor = true;
            this.btn_MedianFilter.Click += new System.EventHandler(this.btn_MedianFilter_Click);
            // 
            // btn_MeanFilter
            // 
            this.btn_MeanFilter.Location = new System.Drawing.Point(6, 21);
            this.btn_MeanFilter.Name = "btn_MeanFilter";
            this.btn_MeanFilter.Size = new System.Drawing.Size(100, 31);
            this.btn_MeanFilter.TabIndex = 0;
            this.btn_MeanFilter.Text = "Mean";
            this.btn_MeanFilter.UseVisualStyleBackColor = true;
            this.btn_MeanFilter.Click += new System.EventHandler(this.btn_MeanFilter_Click);
            // 
            // HistonEqual
            // 
            this.HistonEqual.Controls.Add(this.btn_HistonEqual);
            this.HistonEqual.Location = new System.Drawing.Point(12, 191);
            this.HistonEqual.Name = "HistonEqual";
            this.HistonEqual.Size = new System.Drawing.Size(215, 58);
            this.HistonEqual.TabIndex = 13;
            this.HistonEqual.TabStop = false;
            this.HistonEqual.Text = "Histongram Equalization";
            // 
            // btn_HistonEqual
            // 
            this.btn_HistonEqual.Location = new System.Drawing.Point(10, 19);
            this.btn_HistonEqual.Name = "btn_HistonEqual";
            this.btn_HistonEqual.Size = new System.Drawing.Size(199, 29);
            this.btn_HistonEqual.TabIndex = 0;
            this.btn_HistonEqual.Text = "Histongram Equalization";
            this.btn_HistonEqual.UseVisualStyleBackColor = true;
            this.btn_HistonEqual.Click += new System.EventHandler(this.btn_HistonEqual_Click);
            // 
            // Threshold
            // 
            this.Threshold.Controls.Add(this.numericUpDown1);
            this.Threshold.Controls.Add(this.btn_Threshold);
            this.Threshold.Location = new System.Drawing.Point(12, 256);
            this.Threshold.Name = "Threshold";
            this.Threshold.Size = new System.Drawing.Size(216, 54);
            this.Threshold.TabIndex = 14;
            this.Threshold.TabStop = false;
            this.Threshold.Text = "User Defined Thresholding";
            // 
            // btn_Threshold
            // 
            this.btn_Threshold.Location = new System.Drawing.Point(110, 18);
            this.btn_Threshold.Name = "btn_Threshold";
            this.btn_Threshold.Size = new System.Drawing.Size(98, 27);
            this.btn_Threshold.TabIndex = 0;
            this.btn_Threshold.Text = "Thresholding";
            this.btn_Threshold.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 20);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(93, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 51);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sobel Edge Detection";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 539);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Threshold);
            this.Controls.Add(this.HistonEqual);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_undo);
            this.Controls.Add(this.test);
            this.Controls.Add(this.ProcessedImageBox);
            this.Controls.Add(this.SourceImageBox);
            this.Controls.Add(this.btn_SaveImage);
            this.Controls.Add(this.btn_OpenImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SourceImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedImageBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.HistonEqual.ResumeLayout(false);
            this.Threshold.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OpenImage;
        private System.Windows.Forms.Button btn_SaveImage;
        private System.Windows.Forms.PictureBox SourceImageBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PictureBox ProcessedImageBox;
        private System.Windows.Forms.Button RGB_r;
        private System.Windows.Forms.Button RGB_g;
        private System.Windows.Forms.Button RGB_b;
        private System.Windows.Forms.Button RGB_grey;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.Button btn_undo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_MedianFilter;
        private System.Windows.Forms.Button btn_MeanFilter;
        private System.Windows.Forms.GroupBox HistonEqual;
        private System.Windows.Forms.Button btn_HistonEqual;
        private System.Windows.Forms.GroupBox Threshold;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_Threshold;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

