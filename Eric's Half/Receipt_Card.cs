using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
namespace Software_Engineering
{
    public partial class Reciept_Card
    {
        string CustomerSignature;
        double[] Prices = { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
        private String Directory = Path.GetDirectoryName(Application.ExecutablePath);
        int Lines = 0;
        public Reciept_Card()
        {
            InitializeComponent();
        }
        private void CalculateTotal()
        {
            Double Total = 0.50;
            for (int i = 0; i < Prices.Length; i++)
            {
                Total += Prices[i];
            }

            TotalAmount.Text = "$" + Total.ToString();
        }

        //Checking to see if the Line str is the end of the file and returning the customer to the Opening screen if it is.
        private void LoadError(String str)
        {
            if (str == null)
            {
                MessageBox.Show("The system has encountered an error, we are returning you to the Opening screen", "Loading Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                String Directory = Path.GetDirectoryName(Application.ExecutablePath);
                Directory = Directory.Substring(0, Directory.IndexOf("Eric's Half"));
                Process.Start(@"" + Directory + "\\Arturo's Half\\bin\\Debug\\WindowsFormsApp1.exe");
                Close();
            }
        }

        private void RecieptCash_Load(object sender, EventArgs e)
        {
            Directory = Directory.Substring(0, Directory.IndexOf("Eric's Half"));
            StreamReader sr = new StreamReader(Directory + "\\Arturo's Half\\Order.txt");
            string str = sr.ReadLine();

            //Finding the currently active Order that is on file. If none is found it will return the customer to the Opening Screen
            while (!str.Contains("Placed"))
            {
                str = sr.ReadLine();
                LoadError(str);
            }

            while (!str.Equals("\\"))
            {
                str = sr.ReadLine();
                Lines++;
            }
            Lines--;
            sr.Close();

            //Reopening the file once the order is found
            sr = new StreamReader(Directory + "\\Arturo's Half\\Order.txt");
            str = sr.ReadLine();

            //Finding the currently active Order that is on file. If none is found it will return the customer to the Opening Screen
            while (!str.Contains("Placed"))
            {
                str = sr.ReadLine();
                LoadError(str);
            }

            switch (Lines)
            {
                case 10:
                    Item10.Visible = true;
                    Item10Price.Visible = true;
                    Item10Quantity.Visible = true;

                    //Setting the Text values for the textboxs for Item 10
                    str = sr.ReadLine();
                    Prices[9] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item10.Text = str.Substring(0, str.IndexOf(','));
                    Item10Price.Text = "$" + str.Substring(str.IndexOf('-') + 1);
                    Item10Quantity.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto case 9;
                case 9:
                    Item9.Visible = true;
                    Item9Price.Visible = true;
                    Item9Quantity.Visible = true;

                    //Setting the Text values for the textboxs for Item 9
                    str = sr.ReadLine();
                    Prices[8] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item9.Text = str.Substring(0, str.IndexOf(','));
                    Item9Price.Text = "$" + str.Substring(str.IndexOf('-') + 1);
                    Item9Quantity.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto case 8;
                case 8:
                    Item8.Visible = true;
                    Item8Price.Visible = true;
                    Item8Quantity.Visible = true;

                    //Setting the Text values for the textboxs for Item 8
                    str = sr.ReadLine();
                    Prices[7] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item8.Text = str.Substring(0, str.IndexOf(','));
                    Item8Price.Text = "$" + str.Substring(str.IndexOf('-') + 1);
                    Item8Quantity.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto case 7;
                case 7:
                    Item7.Visible = true;
                    Item7Price.Visible = true;
                    Item7Quantity.Visible = true;

                    //Setting the Text values for the textboxs for Item 7
                    str = sr.ReadLine();
                    Prices[6] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item7.Text = str.Substring(0, str.IndexOf(','));
                    Item7Price.Text = "$" + str.Substring(str.IndexOf('-') + 1);
                    Item7Quantity.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto case 6;
                case 6:
                    Item6.Visible = true;
                    Item6Price.Visible = true;
                    Item6Quantity.Visible = true;

                    //Setting the Text values for the textboxs for Item 6
                    str = sr.ReadLine();
                    Prices[5] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item6.Text = str.Substring(0, str.IndexOf(','));
                    Item6Price.Text = "$" + str.Substring(str.IndexOf('-') + 1);
                    Item6Quantity.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto case 5;
                case 5:
                    Item5.Visible = true;
                    Item5Price.Visible = true;
                    Item5Quantity.Visible = true;

                    //Setting the Text values for the textboxs for Item 5
                    str = sr.ReadLine();
                    Prices[4] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item5.Text = str.Substring(0, str.IndexOf(','));
                    Item5Price.Text = "$" + str.Substring(str.IndexOf('-') + 1);
                    Item5Quantity.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto case 4;
                case 4:
                    Item4.Visible = true;
                    Item4Price.Visible = true;
                    Item4Quantity.Visible = true;

                    //Setting the Text values for the textboxs for Item 4
                    str = sr.ReadLine();
                    Prices[3] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item4.Text = str.Substring(0, str.IndexOf(','));
                    Item4Price.Text = "$" + str.Substring(str.IndexOf('-') + 1);
                    Item4Quantity.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto case 3;
                case 3:
                    Item3.Visible = true;
                    Item3Price.Visible = true;
                    Item3Quantity.Visible = true;

                    //Setting the Text values for the textboxs for Item 3
                    str = sr.ReadLine();
                    Prices[2] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item3.Text = str.Substring(0, str.IndexOf(','));
                    Item3Price.Text = "$" + str.Substring(str.IndexOf('-') + 1);
                    //Currently not working
                    Item3Quantity.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto case 2;
                case 2:
                    Item2.Visible = true;
                    Item2Price.Visible = true;
                    Item2Quantity.Visible = true;

                    //Setting the Text values for the textboxs for Item 2
                    str = sr.ReadLine();
                    Prices[1] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item2.Text = str.Substring(0, str.IndexOf(','));
                    Item2Price.Text = "$" + str.Substring(str.IndexOf('-') + 1);
                    Item2Quantity.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',') - 1));
                    goto case 1;
                case 1:
                    //Setting the Text values for the textboxs for Item 1
                    str = sr.ReadLine();
                    Prices[0] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item1.Text = str.Substring(0, str.IndexOf(','));
                    Item1Price.Text = "$" + str.Substring(str.IndexOf('-') + 1);
                    Item1Quantity.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto default;
                default:
                    sr.Close();
                    CalculateTotal();
                    break;
            }
        }

        private void BackButton_Click(object sender, System.EventArgs e)
        {
            //If Customer is Guest
            //this.Hide();
            //new Payment_Guest().Show();

            //If Customer is not Guest
            //this.Hide();
            //new Payment().Show();
        }

        private void DeliveryButton_Click(object sender, System.EventArgs e)
        {
            //If Customer is Guest
            //this.Hide();
            //new Delivery_Guest().Show();

            //If Customer is not Guest
            //this.Hide();
            //new Delivery().Show();
        }

        private void PrintButton_Click(object sender, System.EventArgs e)
        {
            //Don't know what to put here. Maybe just remove print button?
        }

        private void CarryoutButton_Click(object sender, System.EventArgs e)
        {
            //Return to beginning of program
        }

        private void SignatureText_TextChanged(object sender, System.EventArgs e)
        {
            CustomerSignature = SignatureText.Text;
        }
    }
}