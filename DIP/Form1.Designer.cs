
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.ThresVal = new System.Windows.Forms.NumericUpDown();
            this.btn_Threshold = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_SobelOverlay = new System.Windows.Forms.Button();
            this.SobelComb = new System.Windows.Forms.Button();
            this.VSobel = new System.Windows.Forms.Button();
            this.HSobel = new System.Windows.Forms.Button();
            this.histon1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.histon2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_ConnComp = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_OpenBImage = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SourceImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedImageBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.HistonEqual.SuspendLayout();
            this.Threshold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThresVal)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histon2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.test.Location = new System.Drawing.Point(905, 519);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(34, 19);
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
            this.btn_HistonEqual.Location = new System.Drawing.Point(6, 19);
            this.btn_HistonEqual.Name = "btn_HistonEqual";
            this.btn_HistonEqual.Size = new System.Drawing.Size(203, 29);
            this.btn_HistonEqual.TabIndex = 0;
            this.btn_HistonEqual.Text = "Histongram Equalization";
            this.btn_HistonEqual.UseVisualStyleBackColor = true;
            this.btn_HistonEqual.Click += new System.EventHandler(this.btn_HistonEqual_Click);
            // 
            // Threshold
            // 
            this.Threshold.Controls.Add(this.ThresVal);
            this.Threshold.Controls.Add(this.btn_Threshold);
            this.Threshold.Location = new System.Drawing.Point(12, 256);
            this.Threshold.Name = "Threshold";
            this.Threshold.Size = new System.Drawing.Size(216, 54);
            this.Threshold.TabIndex = 14;
            this.Threshold.TabStop = false;
            this.Threshold.Text = "User Defined Thresholding";
            // 
            // ThresVal
            // 
            this.ThresVal.Location = new System.Drawing.Point(12, 20);
            this.ThresVal.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ThresVal.Name = "ThresVal";
            this.ThresVal.Size = new System.Drawing.Size(93, 22);
            this.ThresVal.TabIndex = 1;
            this.ThresVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ThresVal.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // btn_Threshold
            // 
            this.btn_Threshold.Location = new System.Drawing.Point(110, 18);
            this.btn_Threshold.Name = "btn_Threshold";
            this.btn_Threshold.Size = new System.Drawing.Size(99, 27);
            this.btn_Threshold.TabIndex = 0;
            this.btn_Threshold.Text = "Thresholding";
            this.btn_Threshold.UseVisualStyleBackColor = true;
            this.btn_Threshold.Click += new System.EventHandler(this.btn_Threshold_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_SobelOverlay);
            this.groupBox3.Controls.Add(this.SobelComb);
            this.groupBox3.Controls.Add(this.VSobel);
            this.groupBox3.Controls.Add(this.HSobel);
            this.groupBox3.Location = new System.Drawing.Point(12, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 82);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sobel Edge Detection";
            // 
            // btn_SobelOverlay
            // 
            this.btn_SobelOverlay.Location = new System.Drawing.Point(6, 51);
            this.btn_SobelOverlay.Name = "btn_SobelOverlay";
            this.btn_SobelOverlay.Size = new System.Drawing.Size(204, 21);
            this.btn_SobelOverlay.TabIndex = 3;
            this.btn_SobelOverlay.Text = "Overlay";
            this.btn_SobelOverlay.UseVisualStyleBackColor = true;
            this.btn_SobelOverlay.Click += new System.EventHandler(this.SobelOverlay_Click);
            // 
            // SobelComb
            // 
            this.SobelComb.Location = new System.Drawing.Point(146, 21);
            this.SobelComb.Name = "SobelComb";
            this.SobelComb.Size = new System.Drawing.Size(63, 24);
            this.SobelComb.TabIndex = 2;
            this.SobelComb.Text = "Combine";
            this.SobelComb.UseVisualStyleBackColor = true;
            this.SobelComb.Click += new System.EventHandler(this.SobelComb_Click);
            // 
            // VSobel
            // 
            this.VSobel.Location = new System.Drawing.Point(80, 21);
            this.VSobel.Name = "VSobel";
            this.VSobel.Size = new System.Drawing.Size(60, 24);
            this.VSobel.TabIndex = 1;
            this.VSobel.Text = "V Sobel";
            this.VSobel.UseVisualStyleBackColor = true;
            this.VSobel.Click += new System.EventHandler(this.VSobel_Click);
            // 
            // HSobel
            // 
            this.HSobel.Location = new System.Drawing.Point(6, 21);
            this.HSobel.Name = "HSobel";
            this.HSobel.Size = new System.Drawing.Size(68, 24);
            this.HSobel.TabIndex = 0;
            this.HSobel.Text = "H Sobel";
            this.HSobel.UseVisualStyleBackColor = true;
            this.HSobel.Click += new System.EventHandler(this.HSobel_Click);
            // 
            // histon1
            // 
            chartArea1.Name = "ChartArea1";
            this.histon1.ChartAreas.Add(chartArea1);
            this.histon1.Location = new System.Drawing.Point(591, 12);
            this.histon1.Name = "histon1";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            this.histon1.Series.Add(series1);
            this.histon1.Size = new System.Drawing.Size(338, 239);
            this.histon1.TabIndex = 16;
            this.histon1.Text = "Histongram of grey level";
            title1.Name = "Histongram of grey level";
            this.histon1.Titles.Add(title1);
            // 
            // histon2
            // 
            chartArea2.Name = "ChartArea1";
            this.histon2.ChartAreas.Add(chartArea2);
            this.histon2.Location = new System.Drawing.Point(590, 274);
            this.histon2.Name = "histon2";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Name = "Series1";
            this.histon2.Series.Add(series2);
            this.histon2.Size = new System.Drawing.Size(338, 239);
            this.histon2.TabIndex = 17;
            this.histon2.Text = "Histongram of grey level";
            title2.Name = "Histongram of grey level";
            this.histon2.Titles.Add(title2);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_ConnComp);
            this.groupBox4.Location = new System.Drawing.Point(13, 404);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 52);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Connected Component";
            // 
            // btn_ConnComp
            // 
            this.btn_ConnComp.Location = new System.Drawing.Point(7, 18);
            this.btn_ConnComp.Name = "btn_ConnComp";
            this.btn_ConnComp.Size = new System.Drawing.Size(201, 26);
            this.btn_ConnComp.TabIndex = 0;
            this.btn_ConnComp.Text = "Connect";
            this.btn_ConnComp.UseVisualStyleBackColor = true;
            this.btn_ConnComp.Click += new System.EventHandler(this.btn_ConnComp_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.register);
            this.groupBox5.Controls.Add(this.btn_OpenBImage);
            this.groupBox5.Location = new System.Drawing.Point(13, 469);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(214, 58);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Image Registration";
            // 
            // btn_OpenBImage
            // 
            this.btn_OpenBImage.Location = new System.Drawing.Point(9, 18);
            this.btn_OpenBImage.Name = "btn_OpenBImage";
            this.btn_OpenBImage.Size = new System.Drawing.Size(94, 27);
            this.btn_OpenBImage.TabIndex = 0;
            this.btn_OpenBImage.Text = "Open B Image";
            this.btn_OpenBImage.UseVisualStyleBackColor = true;
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(109, 18);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(95, 27);
            this.register.TabIndex = 1;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 539);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.histon2);
            this.Controls.Add(this.histon1);
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
            ((System.ComponentModel.ISupportInitialize)(this.SourceImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedImageBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.HistonEqual.ResumeLayout(false);
            this.Threshold.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ThresVal)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.histon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histon2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
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
        private System.Windows.Forms.NumericUpDown ThresVal;
        private System.Windows.Forms.Button btn_Threshold;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart histon1;
        private System.Windows.Forms.DataVisualization.Charting.Chart histon2;
        private System.Windows.Forms.Button VSobel;
        private System.Windows.Forms.Button HSobel;
        private System.Windows.Forms.Button SobelComb;
        private System.Windows.Forms.Button btn_SobelOverlay;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_ConnComp;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button btn_OpenBImage;
    }
}

