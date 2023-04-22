namespace Final_Project
{
    partial class Lotto649Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lotto649Form));
            this.btn_Exit_649 = new System.Windows.Forms.Button();
            this.btn_Readfile_649 = new System.Windows.Forms.Button();
            this.btn_Generate_649 = new System.Windows.Forms.Button();
            this.textBox_649 = new System.Windows.Forms.TextBox();
            this.img_649Extra = new System.Windows.Forms.PictureBox();
            this.lb_WinNum649 = new System.Windows.Forms.Label();
            this.textBox_649_digits = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_649Extra)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit_649
            // 
            this.btn_Exit_649.Location = new System.Drawing.Point(422, 529);
            this.btn_Exit_649.Name = "btn_Exit_649";
            this.btn_Exit_649.Size = new System.Drawing.Size(178, 57);
            this.btn_Exit_649.TabIndex = 4;
            this.btn_Exit_649.Text = "E&xit";
            this.btn_Exit_649.UseVisualStyleBackColor = true;
            this.btn_Exit_649.Click += new System.EventHandler(this.btn_Exit_649_Click);
            // 
            // btn_Readfile_649
            // 
            this.btn_Readfile_649.Location = new System.Drawing.Point(219, 529);
            this.btn_Readfile_649.Name = "btn_Readfile_649";
            this.btn_Readfile_649.Size = new System.Drawing.Size(178, 57);
            this.btn_Readfile_649.TabIndex = 3;
            this.btn_Readfile_649.Text = "&Read File";
            this.btn_Readfile_649.UseVisualStyleBackColor = true;
            this.btn_Readfile_649.Click += new System.EventHandler(this.btn_Readfile_649_Click);
            // 
            // btn_Generate_649
            // 
            this.btn_Generate_649.Location = new System.Drawing.Point(17, 529);
            this.btn_Generate_649.Name = "btn_Generate_649";
            this.btn_Generate_649.Size = new System.Drawing.Size(178, 57);
            this.btn_Generate_649.TabIndex = 2;
            this.btn_Generate_649.Text = "&Generate";
            this.btn_Generate_649.UseVisualStyleBackColor = true;
            this.btn_Generate_649.Click += new System.EventHandler(this.btn_Generate_649_Click);
            // 
            // textBox_649
            // 
            this.textBox_649.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_649.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_649.Location = new System.Drawing.Point(431, 33);
            this.textBox_649.Multiline = true;
            this.textBox_649.Name = "textBox_649";
            this.textBox_649.ReadOnly = true;
            this.textBox_649.Size = new System.Drawing.Size(127, 401);
            this.textBox_649.TabIndex = 1;
            // 
            // img_649Extra
            // 
            this.img_649Extra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img_649Extra.BackgroundImage")));
            this.img_649Extra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img_649Extra.Location = new System.Drawing.Point(42, 100);
            this.img_649Extra.Name = "img_649Extra";
            this.img_649Extra.Size = new System.Drawing.Size(342, 334);
            this.img_649Extra.TabIndex = 8;
            this.img_649Extra.TabStop = false;
            // 
            // lb_WinNum649
            // 
            this.lb_WinNum649.AutoSize = true;
            this.lb_WinNum649.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_WinNum649.Location = new System.Drawing.Point(19, 23);
            this.lb_WinNum649.Name = "lb_WinNum649";
            this.lb_WinNum649.Size = new System.Drawing.Size(388, 37);
            this.lb_WinNum649.TabIndex = 0;
            this.lb_WinNum649.Text = "The winning numbers are:";
            // 
            // textBox_649_digits
            // 
            this.textBox_649_digits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_649_digits.Location = new System.Drawing.Point(114, 456);
            this.textBox_649_digits.Name = "textBox_649_digits";
            this.textBox_649_digits.Size = new System.Drawing.Size(170, 38);
            this.textBox_649_digits.TabIndex = 9;
            // 
            // Lotto649Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 622);
            this.Controls.Add(this.textBox_649_digits);
            this.Controls.Add(this.btn_Exit_649);
            this.Controls.Add(this.btn_Readfile_649);
            this.Controls.Add(this.btn_Generate_649);
            this.Controls.Add(this.textBox_649);
            this.Controls.Add(this.img_649Extra);
            this.Controls.Add(this.lb_WinNum649);
            this.Name = "Lotto649Form";
            this.Text = "Lotto 649 - Alena Belova";
            ((System.ComponentModel.ISupportInitialize)(this.img_649Extra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit_649;
        private System.Windows.Forms.Button btn_Readfile_649;
        private System.Windows.Forms.Button btn_Generate_649;
        private System.Windows.Forms.TextBox textBox_649;
        private System.Windows.Forms.PictureBox img_649Extra;
        private System.Windows.Forms.Label lb_WinNum649;
        private System.Windows.Forms.TextBox textBox_649_digits;
    }
}