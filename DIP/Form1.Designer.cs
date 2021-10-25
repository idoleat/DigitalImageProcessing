
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
            this.RGB = new System.Windows.Forms.Label();
            this.RGB_r = new System.Windows.Forms.Button();
            this.RGB_g = new System.Windows.Forms.Button();
            this.RGB_b = new System.Windows.Forms.Button();
            this.RGB_grey = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.btn_undo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SourceImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedImageBox)).BeginInit();
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
            // RGB
            // 
            this.RGB.AutoSize = true;
            this.RGB.Location = new System.Drawing.Point(12, 56);
            this.RGB.Name = "RGB";
            this.RGB.Size = new System.Drawing.Size(152, 12);
            this.RGB.TabIndex = 4;
            this.RGB.Text = "RGB Seperation and Grey scale";
            // 
            // RGB_r
            // 
            this.RGB_r.Location = new System.Drawing.Point(10, 83);
            this.RGB_r.Name = "RGB_r";
            this.RGB_r.Size = new System.Drawing.Size(35, 33);
            this.RGB_r.TabIndex = 5;
            this.RGB_r.Text = "R";
            this.RGB_r.UseVisualStyleBackColor = true;
            this.RGB_r.Click += new System.EventHandler(this.RGB_r_Click);
            // 
            // RGB_g
            // 
            this.RGB_g.Location = new System.Drawing.Point(51, 83);
            this.RGB_g.Name = "RGB_g";
            this.RGB_g.Size = new System.Drawing.Size(35, 33);
            this.RGB_g.TabIndex = 6;
            this.RGB_g.Text = "G";
            this.RGB_g.UseVisualStyleBackColor = true;
            this.RGB_g.Click += new System.EventHandler(this.RGB_g_Click);
            // 
            // RGB_b
            // 
            this.RGB_b.Location = new System.Drawing.Point(92, 83);
            this.RGB_b.Name = "RGB_b";
            this.RGB_b.Size = new System.Drawing.Size(35, 33);
            this.RGB_b.TabIndex = 7;
            this.RGB_b.Text = "B";
            this.RGB_b.UseVisualStyleBackColor = true;
            this.RGB_b.Click += new System.EventHandler(this.RGB_b_Click);
            // 
            // RGB_grey
            // 
            this.RGB_grey.Location = new System.Drawing.Point(133, 83);
            this.RGB_grey.Name = "RGB_grey";
            this.RGB_grey.Size = new System.Drawing.Size(96, 33);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 539);
            this.Controls.Add(this.btn_undo);
            this.Controls.Add(this.test);
            this.Controls.Add(this.RGB_grey);
            this.Controls.Add(this.RGB_b);
            this.Controls.Add(this.RGB_g);
            this.Controls.Add(this.RGB_r);
            this.Controls.Add(this.RGB);
            this.Controls.Add(this.ProcessedImageBox);
            this.Controls.Add(this.SourceImageBox);
            this.Controls.Add(this.btn_SaveImage);
            this.Controls.Add(this.btn_OpenImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SourceImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OpenImage;
        private System.Windows.Forms.Button btn_SaveImage;
        private System.Windows.Forms.PictureBox SourceImageBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PictureBox ProcessedImageBox;
        private System.Windows.Forms.Label RGB;
        private System.Windows.Forms.Button RGB_r;
        private System.Windows.Forms.Button RGB_g;
        private System.Windows.Forms.Button RGB_b;
        private System.Windows.Forms.Button RGB_grey;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.Button btn_undo;
    }
}

