using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void btnLottoMax_Click(object sender, EventArgs e)
        {
            // Create a new instance of LottoMaxForm
            LottoMaxForm lottoMaxForm = new LottoMaxForm();

            // Show the LottoMaxForm as a dialog
            lottoMaxForm.ShowDialog();
        }

        private void btnLotto649_Click(object sender, EventArgs e)
        {
            // Create a new instance of Lotto649Form
            Lotto649Form lotto649Form = new Lotto649Form();

            // Show the Lotto649Form as a dialog
            lotto649Form.ShowDialog();
        }

        private void btnMoneyExch_Click(object sender, EventArgs e)
        {
            // Create a new instance of MoneyExForm
            MoneyExForm moneyexForm = new MoneyExForm();

            // Show the MoneyExForm as a dialog
            moneyexForm.ShowDialog();
        }

        private void btnTempConv_Click(object sender, EventArgs e)
        {
            // Create a new instance of TempAppForm
            TempAppForm tempappForm = new TempAppForm();

            // Show the TempAppForm as a dialog
            tempappForm.ShowDialog();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            // Create a new instance of CalculatorForm
            CalculatorForm calculatorForm = new CalculatorForm();

            // Show the CalculatorForm as a dialog
            calculatorForm.ShowDialog();
        }

        private void btnIPValidator_Click(object sender, EventArgs e)
        {
            // Create a new instance of IPForm
            IPForm ipForm = new IPForm();

            // Show the IPForm as a dialog
            ipForm.ShowDialog();
        }

        private void btn_exit_dashboard_Click(object sender, EventArgs e)
        {
            // Display a custom message box asking if the user wants to close the form
            DialogResult result = MessageBox.Show("Do you want to quit this aplication?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Close the form
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                // Do nothing and return to the form
            }
        }
    }
}
