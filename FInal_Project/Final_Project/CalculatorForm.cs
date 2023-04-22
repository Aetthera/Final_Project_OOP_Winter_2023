using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Final_Project
{
    public partial class CalculatorForm : Form
    {
        static string dir = @".\";
        String filePath = dir + "Calculator.txt";
        double FirNum, Secnum, result;
        string Operation;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(dir) == false)
            {
                Directory.CreateDirectory(dir);
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            int c = textBoxOutput.TextLength;
            int flag = 0;
            string text = textBoxOutput.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1;
                    break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                textBoxOutput.Text = textBoxOutput.Text + ".";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Operation = "+";
            FirNum = double.Parse(textBoxOutput.Text);
            textBoxOutput.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Operation = "-";
            FirNum = double.Parse(textBoxOutput.Text);
            textBoxOutput.Clear();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            Operation = "*";
            FirNum = double.Parse(textBoxOutput.Text);
            textBoxOutput.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Operation = "/";
            FirNum = double.Parse(textBoxOutput.Text);
            textBoxOutput.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Secnum = double.Parse(textBoxOutput.Text);
            if (Operation == "+") { result = FirNum + Secnum; }
            if (Operation == "-") { result = FirNum - Secnum; }
            if (Operation == "*") { result = FirNum * Secnum; }
            if (Operation == "/")
            {
                if (Secnum == 0)
                {
                    MessageBox.Show("Cannot divide by zero!");

                }
                else
                {
                    result = FirNum / Secnum;
                }
            }

            textBoxOutput.Text = result + "";
            FileStream fs = null;
            try
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);

                StreamWriter textOut = new StreamWriter(fs);

                if (Operation == "/" && Secnum == 0)
                {

                    textOut.WriteLine(FirNum.ToString() + " " + Operation + " " + Secnum.ToString() + " = undefined");
                }
                else
                {
                    textOut.WriteLine(FirNum.ToString() + " " + Operation + " " + Secnum.ToString() + " = " +
                        result.ToString() + " ");
                }

                textOut.Close();
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) fs.Close(); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxOutput.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
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
