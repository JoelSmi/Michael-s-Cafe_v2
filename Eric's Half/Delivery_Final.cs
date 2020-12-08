using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
namespace Software_Engineering
{
    public partial class Delivery_Final
    {
        private string Directory = Path.GetDirectoryName(Application.ExecutablePath);

        string[] NameArray = new string[2];
        string[] AddressArray = new string[4];
        string[] NewAddrInfo = { "", "", "", "" };

        int Lines = 0;
        double Total = 0.0, Tax = 0.0;
        const double SalesTaxCnst = .06;

        bool isError = false;

        double[] Prices = { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
        public Delivery_Final()
        {
            InitializeComponent();
        }
        private void CalculateTotal()
        {
            for (int i = 0; i < this.Prices.Length; i++)
            {
                this.Total += this.Prices[i];
            }
            this.Tax = Math.Round(this.Total * SalesTaxCnst, 2);
            this.Total = Math.Round(this.Total + this.Tax, 2);
            TotalCost.Text = "$" + this.Total.ToString();
        }

        private void DisplayCurrentInfo()
        {
            Directory = Path.GetDirectoryName(Application.ExecutablePath);
            string OpenFile = Directory.Substring(0, Directory.IndexOf("Eric's Half")) + "Arturo's Half\\Michael_Cafe.txt";
            StreamReader sr = new StreamReader(OpenFile);
            string CurrLine = sr.ReadLine();

            while (!CurrLine.Contains("#End Of File#"))
            {
                if (CurrLine.Contains("LoggedIn"))
                {
                    //Sets customer name box
                    CurrLine = sr.ReadLine();
                    NameArray = CurrLine.Split(',');
                    CustomerNameText.Text = NameArray[0] + " " + NameArray[1];

                    //Sets phone number box
                    CurrLine = sr.ReadLine();
                    PhoneNumberText.Text = CurrLine;

                    //Sets default address label
                    CurrLine = sr.ReadLine();
                    AddressArray = CurrLine.Split(',', '-', '.');
                    AddressArray[0] = AddressArray[0].Substring(1);
                    CustomerAddressText.Text = AddressArray[0] + ", " + AddressArray[1] + ", " + AddressArray[2] + " " + AddressArray[3];

                    sr.Close();
                    break;
                }
                else
                {
                    CurrLine = sr.ReadLine();
                }
            }
        }
        private void BackButton_Click(object sender, System.EventArgs e)
        {
            //If customer is guest
            //this.Hide();
            //new Delivery_Guest().Show();

            //If customer not is guest
            //this.Hide();
            //new Delivery().Show();
        }

        private void DoneButton_Click(object sender, System.EventArgs e)
        {
            Directory = Path.GetDirectoryName(Application.ExecutablePath);
            Directory = Directory.Substring(0, Directory.IndexOf("Eric's Half"));
            string OpenFile = Directory + "\\Arturo's Half\\Order.txt";

            //File manipulation to change the Active order to Cancelled and returning the customer to the opening screen
            string FileText = File.ReadAllText(Directory + "\\Arturo's Half\\Order.txt");
            FileText = FileText.Replace("Active", "Closed");
            File.WriteAllText(OpenFile, FileText);
            Process.Start(@"" + Directory + "\\Arturo's Half\\bin\\Debug\\WindowsFormsApp1.exe");
            Application.Exit();
        }

        private void LoadError(String str)
        {
            if (str == null)
            {
                MessageBox.Show("The system has encountered an error, we are returning you to the Opening screen", "Loading Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                String Directory = Path.GetDirectoryName(Application.ExecutablePath);
                Directory = Directory.Substring(0, Directory.IndexOf("Eric's Half"));
                Process.Start(@"" + Directory + "\\Arturo's Half\\bin\\Debug\\WindowsFormsApp1.exe");
                Application.Exit();
                isError = true;
            }
        }
        private void Delivery_Final_Load(object sender, EventArgs e)
        {
            DisplayCurrentInfo();
            DeliverNameText.Text = "Jim E Johns";

            Directory = Directory.Substring(0, Directory.IndexOf("Eric's Half"));
            StreamReader sr = new StreamReader(Directory + "\\Arturo's Half\\Order.txt");
            string str = sr.ReadLine();
            //Finding the currently placed Order that is on file. If none is found it will return the customer to the Opening Screen
            while (!str.Contains("Placed"))
            {
                str = sr.ReadLine();
                LoadError(str);
                if (isError == true)
                {
                    Close();
                }
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
                if (isError == true)
                {
                    break;
                }
            }
            switch (Lines)
            {
                case 10:
                    Item10.Visible = true;
                    ItemQ10.Visible = true;

                    //Setting the Text values for the textboxs for Item 10
                    str = sr.ReadLine();
                    Prices[9] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item10.Text = str.Substring(0, str.IndexOf(','));
                    ItemQ10.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto case 9;
                case 9:
                    Item9.Visible = true;
                    ItemQ9.Visible = true;

                    //Setting the Text values for the textboxs for Item 9
                    str = sr.ReadLine();
                    Prices[8] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item9.Text = str.Substring(0, str.IndexOf(','));
                    ItemQ9.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto case 8;
                case 8:
                    Item8.Visible = true;
                    ItemQ8.Visible = true;

                    //Setting the Text values for the textboxs for Item 8
                    str = sr.ReadLine();
                    Prices[7] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item8.Text = str.Substring(0, str.IndexOf(','));
                    ItemQ8.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto case 7;
                case 7:
                    Item7.Visible = true;
                    ItemQ7.Visible = true;

                    //Setting the Text values for the textboxs for Item 7
                    str = sr.ReadLine();
                    Prices[6] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item7.Text = str.Substring(0, str.IndexOf(','));
                    ItemQ7.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto case 6;
                case 6:
                    Item6.Visible = true;
                    ItemQ6.Visible = true;

                    //Setting the Text values for the textboxs for Item 6
                    str = sr.ReadLine();
                    Prices[5] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item6.Text = str.Substring(0, str.IndexOf(','));
                    ItemQ6.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto case 5;
                case 5:
                    Item5.Visible = true;
                    ItemQ5.Visible = true;

                    //Setting the Text values for the textboxs for Item 5
                    str = sr.ReadLine();
                    Prices[4] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item5.Text = str.Substring(0, str.IndexOf(','));
                    ItemQ5.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto case 4;
                case 4:
                    Item4.Visible = true;
                    ItemQ4.Visible = true;

                    //Setting the Text values for the textboxs for Item 4
                    str = sr.ReadLine();
                    Prices[3] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item4.Text = str.Substring(0, str.IndexOf(','));
                    ItemQ4.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto case 3;
                case 3:
                    Item3.Visible = true;
                    ItemQ3.Visible = true;

                    //Setting the Text values for the textboxs for Item 3
                    str = sr.ReadLine();
                    Prices[2] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item3.Text = str.Substring(0, str.IndexOf(','));
                    //Currently not working
                    ItemQ3.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto case 2;
                case 2:
                    Item2.Visible = true;
                    ItemQ2.Visible = true;

                    //Setting the Text values for the textboxs for Item 2
                    str = sr.ReadLine();
                    Prices[1] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item2.Text = str.Substring(0, str.IndexOf(','));
                    ItemQ2.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',') - 1));
                    goto case 1;
                case 1:
                    //Setting the Text values for the textboxs for Item 1
                    str = sr.ReadLine();
                    Prices[0] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item1.Text = str.Substring(0, str.IndexOf(','));
                    ItemQ1.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto default;
                default:
                    sr.Close();
                    CalculateTotal();
                    break;
            }
        }

    }
}