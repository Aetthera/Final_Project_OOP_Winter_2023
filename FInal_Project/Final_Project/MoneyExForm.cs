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
using System.Text.RegularExpressions;


namespace Final_Project
{
    public partial class MoneyExForm : Form
    {
        private DateTime formLoadTime;
        public MoneyExForm()
        {
            InitializeComponent();
            formLoadTime = DateTime.Now;
        }

        private void btnConvertMoney_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxMoneyIn.Text, out decimal amount))
            {
                string fromCurrency = "";
                if (checkBoxCadFrom.Checked)
                    fromCurrency = "CAD";
                else if (checkBoxUsdFrom.Checked)
                    fromCurrency = "USD";
                else if (checkBoxEurFrom.Checked)
                    fromCurrency = "EUR";
                else if (checkBoxGbpFrom.Checked)
                    fromCurrency = "GBP";
                else if (checkBoxJpyFrom.Checked)
                    fromCurrency = "JPY";

                string toCurrency = "";
                if (checkBoxCadTo.Checked)
                    toCurrency = "CAD";
                else if (checkBoxUsdTo.Checked)
                    toCurrency = "USD";
                else if (checkBoxEurTo.Checked)
                    toCurrency = "EUR";
                else if (checkBoxGbpTo.Checked)
                    toCurrency = "GBP";
                else if (checkBoxJpyTo.Checked)
                    toCurrency = "JPY";

                decimal conversionRate = 0m;
                if (fromCurrency == "CAD" && toCurrency == "USD")
                    conversionRate = 0.8m;
                else if (fromCurrency == "CAD" && toCurrency == "EUR")
                    conversionRate = 0.6m;
                else if (fromCurrency == "CAD" && toCurrency == "GBP")
                    conversionRate = 0.7m;
                else if (fromCurrency == "CAD" && toCurrency == "JPY")
                    conversionRate = 90m;
                else if (fromCurrency == "USD" && toCurrency == "CAD")
                    conversionRate = 1.25m;
                else if (fromCurrency == "USD" && toCurrency == "EUR")
                    conversionRate = 0.85m;
                else if (fromCurrency == "USD" && toCurrency == "GBP")
                    conversionRate = 0.95m;
                else if (fromCurrency == "USD" && toCurrency == "JPY")
                    conversionRate = 100m;
                else if (fromCurrency == "EUR" && toCurrency == "CAD")
                    conversionRate = 1.67m;
                else if (fromCurrency == "EUR" && toCurrency == "USD")
                    conversionRate = 1.18m;
                else if (fromCurrency == "EUR" && toCurrency == "GBP")
                    conversionRate = 1.12m;
                else if (fromCurrency == "EUR" && toCurrency == "JPY")
                    conversionRate = 120m;
                else if (fromCurrency == "GBP" && toCurrency == "CAD")
                    conversionRate = 1.43m;
                else if (fromCurrency == "GBP" && toCurrency == "USD")
                    conversionRate = 1.05m;
                else if (fromCurrency == "GBP" && toCurrency == "EUR")
                    conversionRate = 0.89m;
                else if (fromCurrency == "GBP" && toCurrency == "JPY")
                    conversionRate = 110m;
                else if (fromCurrency == "JPY" && toCurrency == "CAD")
                    conversionRate = 0.011m;
                else if (fromCurrency == "JPY" && toCurrency == "USD")
                    conversionRate = 0.01m;
                else if (fromCurrency == "JPY" && toCurrency == "EUR")
                    conversionRate = 0.0083m;
                else if (fromCurrency == "JPY" && toCurrency == "GBP")
                    conversionRate = 0.0091m;

                decimal convertedAmount = amount * conversionRate;
                string result = $"{convertedAmount} {toCurrency}";


                // Write result to file
                string fileName = "MoneyConv.txt";
                File.WriteAllText(fileName, String.Empty);
                using (StreamWriter writer = new StreamWriter(fileName, false))
                {
                    writer.WriteLine($"{amount} {fromCurrency} = {convertedAmount} {toCurrency}, " + DateTime.Now.ToString());
                }
                textBoxMoneyOut.Text = result;

            }
            else
            {
                MessageBox.Show("Please enter a valid numeric amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReadFileMoney_Click(object sender, EventArgs e)
        {
            // Read the text file content
            string filePath = "MoneyConv.txt"; 
            string fileContent = File.ReadAllText(filePath);

            // Display the text file content in a message box
            MessageBox.Show(fileContent, "Result - Alena Belova", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonExitMoney_Click(object sender, EventArgs e)
        {
            // Calculate the total time in seconds and minutes
            TimeSpan totalTime = DateTime.Now - formLoadTime;
            int totalSeconds = (int)totalTime.TotalSeconds;
            int totalMinutes = (int)totalTime.TotalMinutes;

            // Display a custom message box asking if the user wants to close the form
            DialogResult result = MessageBox.Show($"Do you want to quit this application?{Environment.NewLine}Total time used: {totalSeconds} seconds ({totalMinutes} minutes)", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Close the form
                this.Close();
            }
        }
    }
}
        
  
