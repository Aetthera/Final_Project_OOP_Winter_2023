namespace Final_Project
{
    partial class IPForm
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
            this.labelTd = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTd
            // 
            this.labelTd.AutoSize = true;
            this.labelTd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTd.Location = new System.Drawing.Point(154, 50);
            this.labelTd.Name = "labelTd";
            this.labelTd.Size = new System.Drawing.Size(98, 31);
            this.labelTd.TabIndex = 0;
            this.labelTd.Text = "Today:";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIP.Location = new System.Drawing.Point(10, 160);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(234, 31);
            this.labelIP.TabIndex = 1;
            this.labelIP.Text = "Enter IP Address: ";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(299, 163);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.ShortcutsEnabled = false;
            this.textBoxIP.Size = new System.Drawing.Size(370, 31);
            this.textBoxIP.TabIndex = 2;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(16, 237);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(184, 62);
            this.btnValidate.TabIndex = 3;
            this.btnValidate.Text = "Validate IP";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(256, 237);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(184, 62);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(485, 237);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(184, 62);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(268, 56);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(19, 25);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "-";
            // 
            // IPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 348);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.labelTd);
            this.Name = "IPForm";
            this.Text = "IP4-Validator";
            this.Load += new System.EventHandler(this.IPForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTd;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelDate;
    }
}