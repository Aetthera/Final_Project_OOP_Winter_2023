namespace Final_Project
{
    partial class TempAppForm
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
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.labelInter = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonExitMoney = new System.Windows.Forms.Button();
            this.btnReadFileMoney = new System.Windows.Forms.Button();
            this.btnConvertMoney = new System.Windows.Forms.Button();
            this.radioButtonCtoF = new System.Windows.Forms.RadioButton();
            this.radioButtonFtoC = new System.Windows.Forms.RadioButton();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(29, 165);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(207, 31);
            this.textBoxFrom.TabIndex = 2;
            // 
            // textBoxTo
            // 
            this.textBoxTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTo.Location = new System.Drawing.Point(377, 165);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.ReadOnly = true;
            this.textBoxTo.Size = new System.Drawing.Size(207, 31);
            this.textBoxTo.TabIndex = 3;
            // 
            // labelInter
            // 
            this.labelInter.AutoSize = true;
            this.labelInter.Location = new System.Drawing.Point(296, 168);
            this.labelInter.Name = "labelInter";
            this.labelInter.Size = new System.Drawing.Size(30, 25);
            this.labelInter.TabIndex = 4;
            this.labelInter.Text = "to";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(24, 265);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(106, 25);
            this.labelMessage.TabIndex = 5;
            this.labelMessage.Text = "Message:";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMessage.Location = new System.Drawing.Point(29, 317);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ReadOnly = true;
            this.textBoxMessage.Size = new System.Drawing.Size(555, 71);
            this.textBoxMessage.TabIndex = 6;
            // 
            // buttonExitMoney
            // 
            this.buttonExitMoney.Location = new System.Drawing.Point(435, 415);
            this.buttonExitMoney.Name = "buttonExitMoney";
            this.buttonExitMoney.Size = new System.Drawing.Size(167, 53);
            this.buttonExitMoney.TabIndex = 17;
            this.buttonExitMoney.Text = "E&xit";
            this.buttonExitMoney.UseVisualStyleBackColor = true;
            this.buttonExitMoney.Click += new System.EventHandler(this.buttonExitMoney_Click);
            // 
            // btnReadFileMoney
            // 
            this.btnReadFileMoney.Location = new System.Drawing.Point(233, 415);
            this.btnReadFileMoney.Name = "btnReadFileMoney";
            this.btnReadFileMoney.Size = new System.Drawing.Size(167, 53);
            this.btnReadFileMoney.TabIndex = 16;
            this.btnReadFileMoney.Text = "&Read File";
            this.btnReadFileMoney.UseVisualStyleBackColor = true;
            this.btnReadFileMoney.Click += new System.EventHandler(this.btnReadFileMoney_Click);
            // 
            // btnConvertMoney
            // 
            this.btnConvertMoney.Location = new System.Drawing.Point(29, 415);
            this.btnConvertMoney.Name = "btnConvertMoney";
            this.btnConvertMoney.Size = new System.Drawing.Size(167, 53);
            this.btnConvertMoney.TabIndex = 15;
            this.btnConvertMoney.Text = "&Convert";
            this.btnConvertMoney.UseVisualStyleBackColor = true;
            this.btnConvertMoney.Click += new System.EventHandler(this.btnConvertMoney_Click);
            // 
            // radioButtonCtoF
            // 
            this.radioButtonCtoF.AutoSize = true;
            this.radioButtonCtoF.Location = new System.Drawing.Point(218, 42);
            this.radioButtonCtoF.Name = "radioButtonCtoF";
            this.radioButtonCtoF.Size = new System.Drawing.Size(156, 29);
            this.radioButtonCtoF.TabIndex = 18;
            this.radioButtonCtoF.TabStop = true;
            this.radioButtonCtoF.Text = "From C to F";
            this.radioButtonCtoF.UseVisualStyleBackColor = true;
            this.radioButtonCtoF.CheckedChanged += new System.EventHandler(this.radioButtonCtoF_CheckedChanged);
            // 
            // radioButtonFtoC
            // 
            this.radioButtonFtoC.AutoSize = true;
            this.radioButtonFtoC.Location = new System.Drawing.Point(218, 104);
            this.radioButtonFtoC.Name = "radioButtonFtoC";
            this.radioButtonFtoC.Size = new System.Drawing.Size(156, 29);
            this.radioButtonFtoC.TabIndex = 19;
            this.radioButtonFtoC.TabStop = true;
            this.radioButtonFtoC.Text = "From F to C";
            this.radioButtonFtoC.UseVisualStyleBackColor = true;
            this.radioButtonFtoC.CheckedChanged += new System.EventHandler(this.radioButtonFtoC_CheckedChanged);
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(98, 214);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(0, 25);
            this.labelFrom.TabIndex = 20;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(430, 214);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(0, 25);
            this.labelTo.TabIndex = 21;
            // 
            // TempAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 509);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.radioButtonFtoC);
            this.Controls.Add(this.radioButtonCtoF);
            this.Controls.Add(this.buttonExitMoney);
            this.Controls.Add(this.btnReadFileMoney);
            this.Controls.Add(this.btnConvertMoney);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelInter);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFrom);
            this.Name = "TempAppForm";
            this.Text = "Temp App - Alena Belova";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Label labelInter;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonExitMoney;
        private System.Windows.Forms.Button btnReadFileMoney;
        private System.Windows.Forms.Button btnConvertMoney;
        private System.Windows.Forms.RadioButton radioButtonCtoF;
        private System.Windows.Forms.RadioButton radioButtonFtoC;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
    }
}