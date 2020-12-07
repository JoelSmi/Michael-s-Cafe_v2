using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Software_Engineering
{
    public partial class OrderSummary
    {
        //Array storing the prices for the order that is being placed
        double[] Prices = { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
        private String Directory = Path.GetDirectoryName(Application.ExecutablePath);
        int Lines = 0;

        private void CalculateTotal()
        {
            Double Total = 0.50;
            for (int i = 0; i < Prices.Length; i++)
            {
                Total += Prices[i];
            }

            TotalCost.Text = "$" + Total.ToString();
        }

        public OrderSummary()
        {
            InitializeComponent();
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
        private void Form1_Load(object sender, EventArgs e)
        {
            Directory = Directory.Substring(0, Directory.IndexOf("Eric's Half"));
            StreamReader sr = new StreamReader(Directory + "\\Arturo's Half\\Order.txt");
            string str = sr.ReadLine();

            //Finding the currently active Order that is on file. If none is found it will return the customer to the Opening Screen
            while (!str.Contains("Active"))
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
            while (!str.Contains("Active"))
            {
                str = sr.ReadLine();
                LoadError(str);
            }

            switch (Lines)
            {
                case 10:
                    Item10.Visible = true;
                    ItemCost10.Visible = true;
                    ItemQ10.Visible = true;
                    ItemRemove10.Visible = true;

                    //Setting the Text values for the textboxs for Item 10
                    str = sr.ReadLine();
                    Prices[9] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item10.Text = str.Substring(0, str.IndexOf(','));
                    ItemCost10.Text = "$" + str.Substring(str.IndexOf('-') + 1);
                    ItemQ10.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto case 9;
                case 9:
                    Item9.Visible = true;
                    ItemCost9.Visible = true;
                    ItemQ9.Visible = true;
                    ItemRemove9.Visible = true;

                    //Setting the Text values for the textboxs for Item 9
                    str = sr.ReadLine();
                    Prices[8] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item9.Text = str.Substring(0, str.IndexOf(','));
                    ItemCost9.Text = "$" + str.Substring(str.IndexOf('-') + 1);
                    ItemQ9.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto case 8;
                case 8:
                    Item8.Visible = true;
                    ItemCost8.Visible = true;
                    ItemQ8.Visible = true;
                    ItemRemove8.Visible = true;

                    //Setting the Text values for the textboxs for Item 8
                    str = sr.ReadLine();
                    Prices[7] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item8.Text = str.Substring(0, str.IndexOf(','));
                    ItemCost8.Text = "$" + str.Substring(str.IndexOf('-') + 1);
                    ItemQ8.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto case 7;
                case 7:
                    Item7.Visible = true;
                    ItemCost7.Visible = true;
                    ItemQ7.Visible = true;
                    ItemRemove7.Visible = true;

                    //Setting the Text values for the textboxs for Item 7
                    str = sr.ReadLine();
                    Prices[6] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item7.Text = str.Substring(0, str.IndexOf(','));
                    ItemCost7.Text = "$" + str.Substring(str.IndexOf('-') + 1);
                    ItemQ7.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto case 6;
                case 6:
                    Item6.Visible = true;
                    ItemCost6.Visible = true;
                    ItemQ6.Visible = true;
                    ItemRemove6.Visible = true;

                    //Setting the Text values for the textboxs for Item 6
                    str = sr.ReadLine();
                    Prices[5] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item6.Text = str.Substring(0, str.IndexOf(','));
                    ItemCost6.Text = "$" + str.Substring(str.IndexOf('-') + 1);
                    ItemQ6.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto case 5;
                case 5:
                    Item5.Visible = true;
                    ItemCost5.Visible = true;
                    ItemQ5.Visible = true;
                    ItemRemove5.Visible = true;

                    //Setting the Text values for the textboxs for Item 5
                    str = sr.ReadLine();
                    Prices[4] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item5.Text = str.Substring(0, str.IndexOf(','));
                    ItemCost5.Text = "$" + str.Substring(str.IndexOf('-') + 1);
                    ItemQ5.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto case 4;
                case 4:
                    Item4.Visible = true;
                    ItemCost4.Visible = true;
                    ItemQ4.Visible = true;
                    ItemRemove4.Visible = true;

                    //Setting the Text values for the textboxs for Item 4
                    str = sr.ReadLine();
                    Prices[3] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item4.Text = str.Substring(0, str.IndexOf(','));
                    ItemCost4.Text = "$" + str.Substring(str.IndexOf('-') + 1);
                    ItemQ4.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto case 3;
                case 3:
                    Item3.Visible = true;
                    ItemCost3.Visible = true;
                    ItemQ3.Visible = true;
                    ItemRemove3.Visible = true;

                    //Setting the Text values for the textboxs for Item 3
                    str = sr.ReadLine();
                    Prices[2] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item3.Text = str.Substring(0, str.IndexOf(','));
                    ItemCost3.Text = "$" + str.Substring(str.IndexOf('-') + 1);
                    //Currently not working
                    ItemQ3.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto case 2;
                case 2:
                    Item2.Visible = true;
                    ItemCost2.Visible = true;
                    ItemQ2.Visible = true;
                    ItemRemove2.Visible = true;

                    //Setting the Text values for the textboxs for Item 2
                    str = sr.ReadLine();
                    Prices[1] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item2.Text = str.Substring(0, str.IndexOf(','));
                    ItemCost2.Text = "$" + str.Substring(str.IndexOf('-') + 1);
                    ItemQ2.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',') - 1));
                    goto case 1;
                case 1:
                    //Setting the Text values for the textboxs for Item 1
                    str = sr.ReadLine();
                    Prices[0] = double.Parse(str.Substring(str.IndexOf('-') + 1));
                    Item1.Text = str.Substring(0, str.IndexOf(','));
                    ItemCost1.Text = "$" + str.Substring(str.IndexOf('-') + 1);
                    ItemQ1.Text = str.Substring(str.IndexOf(',') + 1, (str.IndexOf('-') - str.IndexOf(',')) - 1);
                    goto default;
                default:
                    sr.Close();
                    CalculateTotal();
                    break;
            }

        }

        //All of the following Item_Remove#_click functions are meant to return the 
        //Textboxs to their original state and set the Price for that item to 0.0 in 
        //the Prices Array
        private void ItemRemove1_Click(object sender, EventArgs e)
        {
            Item1.Text = "";
            ItemCost1.Text = "$0.00";
            Prices[0] = 0.0;
            ItemQ1.Text = "";
            CalculateTotal();
        }
        private void ItemRemove2_Click(object sender, EventArgs e)
        {
            Item2.Text = "";
            ItemCost2.Text = "$0.00";
            Prices[1] = 0.0;
            ItemQ2.Text = "";
            CalculateTotal();
        }
        private void ItemRemove3_Click(object sender, EventArgs e)
        {
            Item3.Text = "";
            ItemCost3.Text = "$0.00";
            Prices[2] = 0.0;
            ItemQ3.Text = "";
            CalculateTotal();
        }
        private void ItemRemove4_Click(object sender, EventArgs e)
        {
            Item4.Text = "";
            ItemCost4.Text = "$0.00";
            Prices[3] = 0.0;
            ItemQ4.Text = "";
            CalculateTotal();
        }
        private void ItemRemove5_Click(object sender, EventArgs e)
        {
            Item5.Text = "";
            ItemCost5.Text = "$0.00";
            Prices[4] = 0.0;
            ItemQ5.Text = "";
            CalculateTotal();
        }
        private void ItemRemove6_Click(object sender, EventArgs e)
        {
            Item6.Text = "";
            ItemCost6.Text = "$0.00";
            Prices[5] = 0.0;
            ItemQ6.Text = "";
            CalculateTotal();
        }
        private void ItemRemove7_Click(object sender, EventArgs e)
        {
            Item7.Text = "";
            ItemCost7.Text = "$0.00";
            Prices[6] = 0.0;
            ItemQ7.Text = "";
            CalculateTotal();
        }
        private void ItemRemove8_Click(object sender, EventArgs e)
        {
            Item8.Text = "";
            ItemCost8.Text = "$0.00";
            Prices[7] = 0.0;
            ItemQ8.Text = "";
            CalculateTotal();
        }
        private void ItemRemove9_Click(object sender, EventArgs e)
        {
            Item9.Text = "";
            ItemCost9.Text = "$0.00";
            Prices[8] = 0.0;
            ItemQ9.Text = "";
            CalculateTotal();
        }
        private void ItemRemove10_Click(object sender, EventArgs e)
        {
            Item10.Text = "";
            ItemCost10.Text = "$0.00";
            Prices[9] = 0.0;
            ItemQ10.Text = "";
            CalculateTotal();
        }

        //To move on to the next screen for the ordering process, 
        //the next once will be the Payment -- or the Payment_Guest if 
        //they chose to continue as guest
        private void PlaceOrder_Click(object sender, EventArgs e)
        {
            Directory = Path.GetDirectoryName(Application.ExecutablePath);
            Directory = Directory.Substring(0, Directory.IndexOf("Eric's Half"));
            string OpenFile = Directory + "\\Arturo's Half\\Order.txt";

            //File manipulation to change the Active order to Placed
            string FileText = File.ReadAllText(Directory + "\\Arturo's Half\\Order.txt");
            FileText = FileText.Replace("Active", "Placed");
            File.WriteAllText(OpenFile, FileText);
            Hide();
            new Payment_Guest().Show();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Directory = Path.GetDirectoryName(Application.ExecutablePath);
            Directory = Directory.Substring(0, Directory.IndexOf("Eric's Half"));
            string OpenFile = Directory + "\\Arturo's Half\\Order.txt";

            //File manipulation to change the Active order to Placed
            string FileText = File.ReadAllText(Directory + "\\Arturo's Half\\Order.txt");
            FileText = FileText.Replace("Active", "Placed");
            File.WriteAllText(OpenFile, FileText);

            Directory = Path.GetDirectoryName(Application.ExecutablePath);
            Directory = Directory.Substring(0, Directory.IndexOf("Eric's Half"));
            Process.Start(@"" + Directory + "\\Arturo's Half\\bin\\Debug\\WindowsFormsApp1.exe");
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            //Clean up code
            String Directory = Path.GetDirectoryName(Application.ExecutablePath);
            Directory = Directory.Substring(0, Directory.IndexOf("Eric's Half"));
            String OpenFile = Directory + "\\Arturo's Half\\Order.txt";
            string text = File.ReadAllText(Directory + "\\Arturo's Half\\Order.txt");
            text = text.Replace("Active", "Pending");
            File.WriteAllText(OpenFile, text);
            Process.Start(@"" + Directory + "\\Arturo's Half\\bin\\Debug\\WindowsFormsApp1.exe");
            Close();
        }
    }
}