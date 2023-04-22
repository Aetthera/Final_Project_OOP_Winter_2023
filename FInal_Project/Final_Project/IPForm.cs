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
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_Project
{
    public partial class IPForm : Form
    {
        static string dir = @".\";
        String pathBinary = dir + "IP4-Validator.dat";
        public IPForm()
        {
            InitializeComponent();
        }

        private void IPForm_Load(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            labelDate.Text = d.ToString();

            if (Directory.Exists(dir) == false)
            {
                Directory.CreateDirectory(dir);
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            //validation
            string ip = textBoxIP.Text;
            Regex regex = new Regex(@"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$");
            string[] byteNbrs = new string[4];

            byteNbrs = ip.Split('.');

            if (byteNbrs.Length != 4 || !regex.IsMatch(ip))
            {
                MessageBox.Show($"{ip}\nThe IP must have 4 bytes\ninteger must be between 0 to 255\n" +
                    $" Separated by a dot (255.255.255.255)\nReset to try again");
                textBoxIP.ReadOnly = true;
                return;
            }
            foreach (string bytes in byteNbrs)
            {
                string bytes1 = bytes.Trim();
                int value = int.Parse(bytes1);

                if (value < 0 || value > 255)
                {
                    MessageBox.Show($"{ip}\nThe IP must have 4 bytes\ninteger must be between 0 to 255" +
                                    $" Separated by a dot (255.255.255.255) Reset to try again");
                    textBoxIP.ReadOnly = true;
                    return;
                }
            }
            textBoxIP.ReadOnly = true;
            MessageBox.Show($"{ip} The IP address is correct");
            //write in binary file
            FileStream fs = null;

            try
            {
                fs = new FileStream(pathBinary, FileMode.Append, FileAccess.Write);
                BinaryWriter binaryOut = new BinaryWriter(fs);
                // write the fields into text file
                binaryOut.Write(textBoxIP.Text.Trim());


                // close the output stream for the text file
                binaryOut.Close();
                //fs.Close();
                string textToPrint = "ip\n";
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) fs.Close(); }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxIP.Text = string.Empty;
            textBoxIP.ReadOnly = false;
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
