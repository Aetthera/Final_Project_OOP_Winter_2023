using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace Final_Project
{
    public partial class TempAppForm : Form
    {
        public TempAppForm()
        {
            InitializeComponent();
        }

        private void radioButtonCtoF_CheckedChanged(object sender, EventArgs e)
        {
            labelFrom.Text = "C";
            labelTo.Text = "F";
        }

        private void btnConvertMoney_Click(object sender, EventArgs e)
        {
            //c to f
            if (radioButtonCtoF.Checked)
            {
                string content = "";
                DateTime d = DateTime.Now;

                double num1 = 0, num2 = 0;
                num1 = Convert.ToDouble(textBoxFrom.Text);

                num2 = num1 * (9 / 5) + 32;
                textBoxTo.Text = num2.ToString();
                try
                {
                    if (num1 == 100)
                    {
                        textBoxMessage.Text = "Water boils";
                    }
                    else if (num1 == 40)
                    {
                        textBoxMessage.Text = "Hot Bath";
                    }
                    else if (num1 == 37)
                    {
                        textBoxMessage.Text = "Body temperature";
                    }
                    else if (num1 == 30)
                    {
                        textBoxMessage.Text = "Beach weather";
                    }
                    else if (num1 == 21)
                    {
                        textBoxMessage.Text = "Room temperature";
                    }
                    else if (num1 == 10)
                    {
                        textBoxMessage.Text = "Cool Day";
                    }
                    else if (num1 == 0)
                    {
                        textBoxMessage.Text = "Freezing point of water";
                    }
                    else if (num1 == -18)
                    {
                        textBoxMessage.Text = "Very Cold Day";
                    }
                    else if (num1 == -40)
                    {
                        textBoxMessage.Text = "Extremely Cold Day \n(and the same number!)";
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                content = textBoxFrom.Text + "C " + " = " + textBoxTo.Text + "F " + " " + d.ToString();


                FileStream fs = new FileStream(@".\TempConv.txt", FileMode.Append);
                StreamWriter obj = new StreamWriter(fs);
                obj.WriteLine(content);
                obj.Close();
                fs.Close();
            }
            //from f to c
            else if (radioButtonFtoC.Checked)
            {
                string content = "";
                DateTime d = DateTime.Now;

                double num1 = 0, num2 = 0;
                num1 = Convert.ToDouble(textBoxFrom.Text);

                num2 = (num1 - 32) * 5 / 9;

                textBoxTo.Text = num2.ToString();
                try
                {
                    if (num1 == 212)
                    {
                        textBoxMessage.Text = "Water boils";
                    }
                    else if (num1 == 104)
                    {
                        textBoxMessage.Text = "Hot Bath";
                    }
                    else if (num1 == 98.6)
                    {
                        textBoxMessage.Text = "Body temperature";
                    }
                    else if (num1 == 86)
                    {
                        textBoxMessage.Text = "Beach weather";
                    }
                    else if (num1 == 70)
                    {
                        textBoxMessage.Text = "Room temperature";
                    }
                    else if (num1 == 50)
                    {
                        textBoxMessage.Text = "Cool Day";
                    }
                    else if (num1 == 32)
                    {
                        textBoxMessage.Text = "Freezing point of water";
                    }
                    else if (num1 == 0)
                    {
                        textBoxMessage.Text = "Very Cold Day";
                    }
                    else if (num1 == -40)
                    {
                        textBoxMessage.Text = "Extremely Cold Day \n(and the same number!)";
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                content = textBoxFrom.Text + "F " + " = " + textBoxTo.Text + "C " + " " + d.ToString();

                FileStream fs = new FileStream(@".\TempConv.txt", FileMode.Append);
                StreamWriter obj = new StreamWriter(fs);
                obj.WriteLine(content);
                obj.Close();
                fs.Close();
            }
        }

        private void radioButtonFtoC_CheckedChanged(object sender, EventArgs e)
        {
            labelFrom.Text = "F";
            labelTo.Text = "C";
        }

        private void btnReadFileMoney_Click(object sender, EventArgs e)
        {
            string filePath = @".\TempConv.txt";
            FileStream fs = null;

            try
            {
                fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);
                string textToPrint = textBoxFrom.Text + " " + labelFrom.Text + " = " + labelTo.Text + " " + textBoxTo.Text;
                MessageBox.Show(textToPrint);
                textIn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            fs.Close();
        }

        private void buttonExitMoney_Click(object sender, EventArgs e)
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
