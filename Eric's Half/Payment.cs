using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Software_Engineering
{
    public partial class Payment
    {
        private bool WithCashCheck;
        private bool WithCard;
        private String Directory = Path.GetDirectoryName(Application.ExecutablePath);

        public Payment()
        {
            WithCashCheck = false;
            WithCard = false;
            InitializeComponent();
        }

        private void CashButton_CheckedChanged(object sender, System.EventArgs e)
        {
            WithCashCheck = true;
            WithCard = false;
        }

        private void CheckButton_CheckedChanged(object sender, System.EventArgs e)
        {
            WithCashCheck = true;
            WithCard = false;
        }

        private void DefaultCardButton_CheckedChanged(object sender, System.EventArgs e)
        {
            WithCashCheck = false;
            WithCard = true;
        }

        private void BackButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            new OrderSummary().Show();
        }

        private void NextButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();

            if(WithCard)
            {
                //Would love to change the spelling error but I don't think we'll have time lol
                new Reciept_Card().Show();
            }
            else if(WithCashCheck)
            {
                new Reciept_Cash().Show();
            }
            else
            {
                return;
            }
        }

        private void DiffCardButton_CheckedChanged(object sender, System.EventArgs e)
        {
            WithCashCheck = false;
            WithCard = true;
        }

        /*
        * Appends card info to file
        */
        private void CardNumText_TextChanged(object sender, System.EventArgs e)
        {
            //ERROR - Can't seem to access the proper path to get to CustomerInfo file
            //Potential Issue - Customer doesn't put card info in correct order
            //Can probably remove \n when actual customer info is added through Console.WriteLine
            StreamWriter sw = new StreamWriter(Directory + "\\Arturo's Half\\CustomerInfo.txt", true);
            sw.WriteLine("\n" + CardNumText.Text + ",");
            sw.Close();
        }

        private void CardExpText_TextChanged(object sender, System.EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Directory + "\\Arturo's Half\\CustomerInfo.txt", true);
            sw.WriteLine("\n" + CardExpText.Text + ",");
            sw.Close();
        }

        private void CardPinText_TextChanged(object sender, System.EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Directory + "\\Arturo's Half\\CustomerInfo.txt", true);
            sw.WriteLine("\n" + CardExpText.Text + ",");
            sw.Close();
        }

    }
}