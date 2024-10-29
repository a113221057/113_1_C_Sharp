using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal hoursWorked, hourlyPayRate, grossPay;
            const decimal BASE_HOURS = 40m;
            const decimal OVERTIME = 1.5m;

            try
            {
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate  = decimal.Parse(hourlyPayRateTextBox.Text);

                if (hoursWorked > BASE_HOURS)
                {
                    grossPay = BASE_HOURS * hourlyPayRate +
                                 ((hoursWorked - BASE_HOURS) * hourlyPayRate * OVERTIME);
                }
                else
                {
                    grossPay = hoursWorked * hourlyPayRate;
                }
                grossPayLabel.Text = grossPay.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and gross pay label.
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            // Reset the focus.
            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void hoursWorkedTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
