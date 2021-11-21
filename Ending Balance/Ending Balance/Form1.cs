using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StartingBalanceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //Constant for the monthly interest rate.
            const decimal INTEREST = 0.005m;

            //Local Variables
            decimal balance;    //The account balance
            int months;         //The number of months
            int count = 1;      //Loop counter, Initialized with 1




            //Get the starting balance.
            if (decimal.TryParse(StartingBalanceTextBox.Text, out balance))
            {
                //Get the number of months.
                if (int.TryParse(NumberOfMonthsTextBox.Text, out months))
                {
                    //The following loop calculates the ending balance
                    while (count < months)
                    {
                        //Add this months interest to the balance
                        balance = balance + (INTEREST * balance);

                        //Display this months ending balance
                        DetailsListBox.Items.Add("The ending balance " +
                            "for month " + count + " is " + balance.ToString("c"));

                        //Add on to the loop counter
                        count++;
                    }

                    //Display the ending balance
                    EndingBalanceResults.Text = balance.ToString("c");
                }

                else
                {
                    //Invalid number of months was entered
                    MessageBox.Show("Invalid value for months.");
                }
            }

            else
            {
                //Invalid starting balance was entered
                MessageBox.Show("Invalid value for starting balance.");
            }            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

            //Clear the TextBoxes and the endingBalanceResult control
            //and the ListBox
            StartingBalanceTextBox.Text = "";
            NumberOfMonthsTextBox.Text = "";
            EndingBalanceResults.Text = "";
            DetailsListBox.Items.Clear();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }
    }
}
