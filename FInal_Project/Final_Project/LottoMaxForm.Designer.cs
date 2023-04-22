namespace Final_Project
{
    partial class LottoMaxForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LottoMaxForm));
            this.lb_WinNumMax = new System.Windows.Forms.Label();
            this.img_MaxExtra = new System.Windows.Forms.PictureBox();
            this.textBox_Max = new System.Windows.Forms.TextBox();
            this.btn_Generate_Max = new System.Windows.Forms.Button();
            this.btn_Readfile_Max = new System.Windows.Forms.Button();
            this.btn_Exit_Max = new System.Windows.Forms.Button();
            this.textBox_Max_digits = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_MaxExtra)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_WinNumMax
            // 
            this.lb_WinNumMax.AutoSize = true;
            this.lb_WinNumMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_WinNumMax.Location = new System.Drawing.Point(28, 36);
            this.lb_WinNumMax.Name = "lb_WinNumMax";
            this.lb_WinNumMax.Size = new System.Drawing.Size(388, 37);
            this.lb_WinNumMax.TabIndex = 0;
            this.lb_WinNumMax.Text = "The winning numbers are:";
            // 
            // img_MaxExtra
            // 
            this.img_MaxExtra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img_MaxExtra.BackgroundImage")));
            this.img_MaxExtra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img_MaxExtra.Location = new System.Drawing.Point(51, 113);
            this.img_MaxExtra.Name = "img_MaxExtra";
            this.img_MaxExtra.Size = new System.Drawing.Size(342, 334);
            this.img_MaxExtra.TabIndex = 1;
            this.img_MaxExtra.TabStop = false;
            // 
            // textBox_Max
            // 
            this.textBox_Max.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_Max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Max.Location = new System.Drawing.Point(440, 46);
            this.textBox_Max.Multiline = true;
            this.textBox_Max.Name = "textBox_Max";
            this.textBox_Max.ReadOnly = true;
            this.textBox_Max.Size = new System.Drawing.Size(127, 401);
            this.textBox_Max.TabIndex = 1;
            // 
            // btn_Generate_Max
            // 
            this.btn_Generate_Max.Location = new System.Drawing.Point(26, 542);
            this.btn_Generate_Max.Name = "btn_Generate_Max";
            this.btn_Generate_Max.Size = new System.Drawing.Size(178, 57);
            this.btn_Generate_Max.TabIndex = 2;
            this.btn_Generate_Max.Text = "&Generate";
            this.btn_Generate_Max.UseVisualStyleBackColor = true;
            this.btn_Generate_Max.Click += new System.EventHandler(this.btn_Generate_Max_Click);
            // 
            // btn_Readfile_Max
            // 
            this.btn_Readfile_Max.Location = new System.Drawing.Point(228, 542);
            this.btn_Readfile_Max.Name = "btn_Readfile_Max";
            this.btn_Readfile_Max.Size = new System.Drawing.Size(178, 57);
            this.btn_Readfile_Max.TabIndex = 3;
            this.btn_Readfile_Max.Text = "&Read File";
            this.btn_Readfile_Max.UseVisualStyleBackColor = true;
            this.btn_Readfile_Max.Click += new System.EventHandler(this.btn_Readfile_Max_Click);
            // 
            // btn_Exit_Max
            // 
            this.btn_Exit_Max.Location = new System.Drawing.Point(431, 542);
            this.btn_Exit_Max.Name = "btn_Exit_Max";
            this.btn_Exit_Max.Size = new System.Drawing.Size(178, 57);
            this.btn_Exit_Max.TabIndex = 4;
            this.btn_Exit_Max.Text = "E&xit";
            this.btn_Exit_Max.UseVisualStyleBackColor = true;
            this.btn_Exit_Max.Click += new System.EventHandler(this.btn_Exit_Max_Click);
            // 
            // textBox_Max_digits
            // 
            this.textBox_Max_digits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Max_digits.Location = new System.Drawing.Point(131, 460);
            this.textBox_Max_digits.Name = "textBox_Max_digits";
            this.textBox_Max_digits.ReadOnly = true;
            this.textBox_Max_digits.Size = new System.Drawing.Size(178, 38);
            this.textBox_Max_digits.TabIndex = 5;
            // 
            // LottoMaxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 633);
            this.Controls.Add(this.textBox_Max_digits);
            this.Controls.Add(this.btn_Exit_Max);
            this.Controls.Add(this.btn_Readfile_Max);
            this.Controls.Add(this.btn_Generate_Max);
            this.Controls.Add(this.textBox_Max);
            this.Controls.Add(this.img_MaxExtra);
            this.Controls.Add(this.lb_WinNumMax);
            this.Name = "LottoMaxForm";
            this.Text = "Lotto Max - Alena Belova";
            ((System.ComponentModel.ISupportInitialize)(this.img_MaxExtra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_WinNumMax;
        private System.Windows.Forms.PictureBox img_MaxExtra;
        private System.Windows.Forms.TextBox textBox_Max;
        private System.Windows.Forms.Button btn_Generate_Max;
        private System.Windows.Forms.Button btn_Readfile_Max;
        private System.Windows.Forms.Button btn_Exit_Max;
        private System.Windows.Forms.TextBox textBox_Max_digits;
    }
}