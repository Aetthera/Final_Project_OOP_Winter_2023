using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final_Project
{
    public partial class LottoMaxForm : Form
    {
        public LottoMaxForm()
        {
            InitializeComponent();
        }

        private void btn_Generate_Max_Click(object sender, EventArgs e)
        {
            // Create a new instance of Random
            Random random = new Random();

            // Create a list to store unique numbers
            List<int> uniqueNumbers = new List<int>();

            // Generate 7 unique random numbers between 1 and 50
            while (uniqueNumbers.Count < 7)
            {
                int randomNumber = random.Next(1, 51);
                if (!uniqueNumbers.Contains(randomNumber))
                {
                    uniqueNumbers.Add(randomNumber);
                }
            }

            // Generate a unique bonus number between 1 and 50
            int bonusNumber;
            do
            {
                bonusNumber = random.Next(1, 51);
            } while (uniqueNumbers.Contains(bonusNumber));

            // Create a string to store the formatted content
            string content = "Max, " + DateTime.Now.ToString() + ", " + string.Join(", ", uniqueNumbers) + " Bonus: " + bonusNumber;

            // Write the content to the text file and overwrite existing content
            File.WriteAllText("LottoNbrs.txt", content);

            // Clear the existing text in the textBox_Max
            textBox_Max.Clear();

            // Display the 7 unique random numbers and the bonus number in the textBox_Max
            foreach (int number in uniqueNumbers)
            {
                textBox_Max.AppendText(number.ToString() + Environment.NewLine);
            }
            textBox_Max.AppendText(bonusNumber.ToString());

             

            // Create a list to store unique digits
            List<int> digits = new List<int>();

            // Create a random number generator
            Random randomDigits = new Random();

            // Generate and store 7 unique digits
            while (digits.Count < 7)
            {
                int digit = randomDigits.Next(10); // Generate a random digit from 0 to 9

                // Add the digit to the list if it is not already present
                if (!digits.Contains(digit))
                {
                    digits.Add(digit);
                }
            }

            // Update the text in the textBox_Max_digits with the generated digits
            textBox_Max_digits.Text = string.Join(" ", digits);
        }

        private void btn_Readfile_Max_Click(object sender, EventArgs e)
        {
            try
            {
                // Set the file path
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LottoNbrs.txt");

                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Create FileStream and StreamReader objects to read the file
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            // Read the content of the file
                            string fileContent = reader.ReadToEnd();

                            // Show the content in a MessageBox
                            MessageBox.Show(fileContent, "Winning Numbers - Alena Belova", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Exit_Max_Click(object sender, EventArgs e)
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
