namespace Final_Project
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGeneratedNumbers = new System.Windows.Forms.TabPage();
            this.groupBoxLotto = new System.Windows.Forms.GroupBox();
            this.lb_Lotto649 = new System.Windows.Forms.Label();
            this.lb_LottoMax = new System.Windows.Forms.Label();
            this.btnLotto649 = new System.Windows.Forms.Button();
            this.btnLottoMax = new System.Windows.Forms.Button();
            this.tabPageConvertions = new System.Windows.Forms.TabPage();
            this.groupBoxConvertions = new System.Windows.Forms.GroupBox();
            this.lb_TempConv = new System.Windows.Forms.Label();
            this.lb_MoneyExch = new System.Windows.Forms.Label();
            this.btnTempConv = new System.Windows.Forms.Button();
            this.btnMoneyExch = new System.Windows.Forms.Button();
            this.tabPageSimpleCalculator = new System.Windows.Forms.TabPage();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.tabPageIPv4Validator = new System.Windows.Forms.TabPage();
            this.btnIPValidator = new System.Windows.Forms.Button();
            this.btn_exit_dashboard = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageGeneratedNumbers.SuspendLayout();
            this.groupBoxLotto.SuspendLayout();
            this.tabPageConvertions.SuspendLayout();
            this.groupBoxConvertions.SuspendLayout();
            this.tabPageSimpleCalculator.SuspendLayout();
            this.tabPageIPv4Validator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGeneratedNumbers);
            this.tabControl1.Controls.Add(this.tabPageConvertions);
            this.tabControl1.Controls.Add(this.tabPageSimpleCalculator);
            this.tabControl1.Controls.Add(this.tabPageIPv4Validator);
            this.tabControl1.Location = new System.Drawing.Point(32, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(906, 548);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageGeneratedNumbers
            // 
            this.tabPageGeneratedNumbers.Controls.Add(this.groupBoxLotto);
            this.tabPageGeneratedNumbers.Location = new System.Drawing.Point(8, 39);
            this.tabPageGeneratedNumbers.Name = "tabPageGeneratedNumbers";
            this.tabPageGeneratedNumbers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneratedNumbers.Size = new System.Drawing.Size(890, 501);
            this.tabPageGeneratedNumbers.TabIndex = 0;
            this.tabPageGeneratedNumbers.Text = "Generated Numbers";
            this.tabPageGeneratedNumbers.UseVisualStyleBackColor = true;
            // 
            // groupBoxLotto
            // 
            this.groupBoxLotto.Controls.Add(this.lb_Lotto649);
            this.groupBoxLotto.Controls.Add(this.lb_LottoMax);
            this.groupBoxLotto.Controls.Add(this.btnLotto649);
            this.groupBoxLotto.Controls.Add(this.btnLottoMax);
            this.groupBoxLotto.Location = new System.Drawing.Point(31, 31);
            this.groupBoxLotto.Name = "groupBoxLotto";
            this.groupBoxLotto.Size = new System.Drawing.Size(835, 451);
            this.groupBoxLotto.TabIndex = 0;
            this.groupBoxLotto.TabStop = false;
            this.groupBoxLotto.Text = "Lotto";
            // 
            // lb_Lotto649
            // 
            this.lb_Lotto649.AutoSize = true;
            this.lb_Lotto649.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Lotto649.Location = new System.Drawing.Point(525, 408);
            this.lb_Lotto649.Name = "lb_Lotto649";
            this.lb_Lotto649.Size = new System.Drawing.Size(136, 31);
            this.lb_Lotto649.TabIndex = 3;
            this.lb_Lotto649.Text = "Lotto 649";
            // 
            // lb_LottoMax
            // 
            this.lb_LottoMax.AutoSize = true;
            this.lb_LottoMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LottoMax.Location = new System.Drawing.Point(143, 408);
            this.lb_LottoMax.Name = "lb_LottoMax";
            this.lb_LottoMax.Size = new System.Drawing.Size(141, 31);
            this.lb_LottoMax.TabIndex = 2;
            this.lb_LottoMax.Text = "Lotto Max";
            // 
            // btnLotto649
            // 
            this.btnLotto649.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLotto649.BackgroundImage")));
            this.btnLotto649.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLotto649.Location = new System.Drawing.Point(432, 49);
            this.btnLotto649.Name = "btnLotto649";
            this.btnLotto649.Size = new System.Drawing.Size(322, 346);
            this.btnLotto649.TabIndex = 2;
            this.btnLotto649.UseVisualStyleBackColor = true;
            this.btnLotto649.Click += new System.EventHandler(this.btnLotto649_Click);
            // 
            // btnLottoMax
            // 
            this.btnLottoMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLottoMax.BackgroundImage")));
            this.btnLottoMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLottoMax.Location = new System.Drawing.Point(60, 49);
            this.btnLottoMax.Name = "btnLottoMax";
            this.btnLottoMax.Size = new System.Drawing.Size(322, 346);
            this.btnLottoMax.TabIndex = 1;
            this.btnLottoMax.UseVisualStyleBackColor = true;
            this.btnLottoMax.Click += new System.EventHandler(this.btnLottoMax_Click);
            // 
            // tabPageConvertions
            // 
            this.tabPageConvertions.Controls.Add(this.groupBoxConvertions);
            this.tabPageConvertions.Location = new System.Drawing.Point(8, 39);
            this.tabPageConvertions.Name = "tabPageConvertions";
            this.tabPageConvertions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConvertions.Size = new System.Drawing.Size(890, 501);
            this.tabPageConvertions.TabIndex = 1;
            this.tabPageConvertions.Text = "Convertions";
            this.tabPageConvertions.UseVisualStyleBackColor = true;
            // 
            // groupBoxConvertions
            // 
            this.groupBoxConvertions.Controls.Add(this.lb_TempConv);
            this.groupBoxConvertions.Controls.Add(this.lb_MoneyExch);
            this.groupBoxConvertions.Controls.Add(this.btnTempConv);
            this.groupBoxConvertions.Controls.Add(this.btnMoneyExch);
            this.groupBoxConvertions.Location = new System.Drawing.Point(28, 32);
            this.groupBoxConvertions.Name = "groupBoxConvertions";
            this.groupBoxConvertions.Size = new System.Drawing.Size(835, 447);
            this.groupBoxConvertions.TabIndex = 0;
            this.groupBoxConvertions.TabStop = false;
            this.groupBoxConvertions.Text = "Convertions";
            // 
            // lb_TempConv
            // 
            this.lb_TempConv.AutoSize = true;
            this.lb_TempConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TempConv.Location = new System.Drawing.Point(436, 407);
            this.lb_TempConv.Name = "lb_TempConv";
            this.lb_TempConv.Size = new System.Drawing.Size(330, 31);
            this.lb_TempConv.TabIndex = 7;
            this.lb_TempConv.Text = "Temperature Convertion";
            // 
            // lb_MoneyExch
            // 
            this.lb_MoneyExch.AutoSize = true;
            this.lb_MoneyExch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MoneyExch.Location = new System.Drawing.Point(116, 407);
            this.lb_MoneyExch.Name = "lb_MoneyExch";
            this.lb_MoneyExch.Size = new System.Drawing.Size(236, 31);
            this.lb_MoneyExch.TabIndex = 5;
            this.lb_MoneyExch.Text = "Money Exchange";
            // 
            // btnTempConv
            // 
            this.btnTempConv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTempConv.BackgroundImage")));
            this.btnTempConv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTempConv.Location = new System.Drawing.Point(442, 48);
            this.btnTempConv.Name = "btnTempConv";
            this.btnTempConv.Size = new System.Drawing.Size(322, 346);
            this.btnTempConv.TabIndex = 6;
            this.btnTempConv.UseVisualStyleBackColor = true;
            this.btnTempConv.Click += new System.EventHandler(this.btnTempConv_Click);
            // 
            // btnMoneyExch
            // 
            this.btnMoneyExch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoneyExch.BackgroundImage")));
            this.btnMoneyExch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMoneyExch.Location = new System.Drawing.Point(70, 48);
            this.btnMoneyExch.Name = "btnMoneyExch";
            this.btnMoneyExch.Size = new System.Drawing.Size(322, 346);
            this.btnMoneyExch.TabIndex = 4;
            this.btnMoneyExch.UseVisualStyleBackColor = true;
            this.btnMoneyExch.Click += new System.EventHandler(this.btnMoneyExch_Click);
            // 
            // tabPageSimpleCalculator
            // 
            this.tabPageSimpleCalculator.Controls.Add(this.btnCalculator);
            this.tabPageSimpleCalculator.Location = new System.Drawing.Point(8, 39);
            this.tabPageSimpleCalculator.Name = "tabPageSimpleCalculator";
            this.tabPageSimpleCalculator.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSimpleCalculator.Size = new System.Drawing.Size(890, 501);
            this.tabPageSimpleCalculator.TabIndex = 2;
            this.tabPageSimpleCalculator.Text = "Simple Calculator";
            this.tabPageSimpleCalculator.UseVisualStyleBackColor = true;
            // 
            // btnCalculator
            // 
            this.btnCalculator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalculator.BackgroundImage")));
            this.btnCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalculator.Location = new System.Drawing.Point(273, 74);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(333, 361);
            this.btnCalculator.TabIndex = 0;
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // tabPageIPv4Validator
            // 
            this.tabPageIPv4Validator.Controls.Add(this.btnIPValidator);
            this.tabPageIPv4Validator.Location = new System.Drawing.Point(8, 39);
            this.tabPageIPv4Validator.Name = "tabPageIPv4Validator";
            this.tabPageIPv4Validator.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIPv4Validator.Size = new System.Drawing.Size(890, 501);
            this.tabPageIPv4Validator.TabIndex = 3;
            this.tabPageIPv4Validator.Text = "IP v4 validator";
            this.tabPageIPv4Validator.UseVisualStyleBackColor = true;
            // 
            // btnIPValidator
            // 
            this.btnIPValidator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIPValidator.BackgroundImage")));
            this.btnIPValidator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIPValidator.Location = new System.Drawing.Point(279, 70);
            this.btnIPValidator.Name = "btnIPValidator";
            this.btnIPValidator.Size = new System.Drawing.Size(333, 361);
            this.btnIPValidator.TabIndex = 1;
            this.btnIPValidator.UseVisualStyleBackColor = true;
            this.btnIPValidator.Click += new System.EventHandler(this.btnIPValidator_Click);
            // 
            // btn_exit_dashboard
            // 
            this.btn_exit_dashboard.Location = new System.Drawing.Point(752, 598);
            this.btn_exit_dashboard.Name = "btn_exit_dashboard";
            this.btn_exit_dashboard.Size = new System.Drawing.Size(178, 57);
            this.btn_exit_dashboard.TabIndex = 3;
            this.btn_exit_dashboard.Text = "E&xit";
            this.btn_exit_dashboard.UseVisualStyleBackColor = true;
            this.btn_exit_dashboard.Click += new System.EventHandler(this.btn_exit_dashboard_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 678);
            this.Controls.Add(this.btn_exit_dashboard);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmDashboard";
            this.Text = "Dashboard - Alena Belova";
            this.tabControl1.ResumeLayout(false);
            this.tabPageGeneratedNumbers.ResumeLayout(false);
            this.groupBoxLotto.ResumeLayout(false);
            this.groupBoxLotto.PerformLayout();
            this.tabPageConvertions.ResumeLayout(false);
            this.groupBoxConvertions.ResumeLayout(false);
            this.groupBoxConvertions.PerformLayout();
            this.tabPageSimpleCalculator.ResumeLayout(false);
            this.tabPageIPv4Validator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGeneratedNumbers;
        private System.Windows.Forms.TabPage tabPageConvertions;
        private System.Windows.Forms.TabPage tabPageSimpleCalculator;
        private System.Windows.Forms.Button btn_exit_dashboard;
        private System.Windows.Forms.TabPage tabPageIPv4Validator;
        private System.Windows.Forms.GroupBox groupBoxLotto;
        private System.Windows.Forms.Label lb_Lotto649;
        private System.Windows.Forms.Label lb_LottoMax;
        private System.Windows.Forms.Button btnLotto649;
        private System.Windows.Forms.Button btnLottoMax;
        private System.Windows.Forms.GroupBox groupBoxConvertions;
        private System.Windows.Forms.Label lb_TempConv;
        private System.Windows.Forms.Label lb_MoneyExch;
        private System.Windows.Forms.Button btnTempConv;
        private System.Windows.Forms.Button btnMoneyExch;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnIPValidator;
    }
}

