using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu_Screen : Form
    {
        private String Directory = Path.GetDirectoryName(Application.ExecutablePath);
        decimal OrderCount = 0;
        public Menu_Screen()
        {
            InitializeComponent();
        }

        private void Menu_Screen_Load(object sender, EventArgs e)
        {
            //Add the showing of the update account if they have an account already
            //Add the reading of the file to know how to store the Order ID
            string str = "";
            Directory = Directory.Substring(0,Directory.IndexOf("bin"));
            StreamReader sr = new StreamReader(@"" + Directory + "\\MenuItems.txt");
            str = sr.ReadLine();
            while (str != null)
            {
                if (str.Equals("/Sides\\"))
                {
                    str = sr.ReadLine();
                    SideItem1.Text = str.Substring(0, str.IndexOf(','));
                    SidePrice1.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    SideItem2.Text = str.Substring(0, str.IndexOf(','));
                    SidePrice2.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    SideItem3.Text = str.Substring(0, str.IndexOf(','));
                    SidePrice3.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    SideItem4.Text = str.Substring(0, str.IndexOf(','));
                    SidePrice4.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    SideItem5.Text = str.Substring(0, str.IndexOf(','));
                    SidePrice5.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    SideItem6.Text = str.Substring(0, str.IndexOf(','));
                    SidePrice6.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                }
                else if (str.Equals("/Beverages\\"))
                {
                    str = sr.ReadLine();
                    Bev1.Text = str.Substring(0, str.IndexOf(','));
                    BevPrice1.Text = '$' + str.Substring(str.IndexOf(',') + 2);

                    str = sr.ReadLine();
                    Bev2.Text = str.Substring(0, str.IndexOf(','));
                    BevPrice2.Text = '$' + str.Substring(str.IndexOf(',') + 2);

                    str = sr.ReadLine();
                    Bev3.Text = str.Substring(0, str.IndexOf(','));
                    BevPrice3.Text = '$' + str.Substring(str.IndexOf(',') + 2);

                    str = sr.ReadLine();
                    Bev4.Text = str.Substring(0, str.IndexOf(','));
                    BevPrice4.Text = '$' + str.Substring(str.IndexOf(',') + 2);

                    str = sr.ReadLine();
                    Bev5.Text = str.Substring(0, str.IndexOf(','));
                    BevPrice5.Text = '$' + str.Substring(str.IndexOf(',') + 2);

                    str = sr.ReadLine();
                    Bev6.Text = str.Substring(0, str.IndexOf(','));
                    BevPrice6.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                }
                else if (str.Equals("/Breakfast Sandwich\\"))
                {
                    str = sr.ReadLine();
                    BSandwich1.Text = str.Substring(0, str.IndexOf(','));
                    BSandPrice1.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    BSandwich2.Text = str.Substring(0, str.IndexOf(','));
                    BSandPrice2.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    BSandwich3.Text = str.Substring(0, str.IndexOf(','));
                    BSandPrice3.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    BSandwich4.Text = str.Substring(0, str.IndexOf(','));
                    BSandPrice4.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    BSandwich5.Text = str.Substring(0, str.IndexOf('-'));
                    BSandPrice5.Text = '$' + str.Substring(str.IndexOf('-') + 2);
                }
                else if (str.Equals("/Breakfast Platters\\"))
                {
                    str = sr.ReadLine();
                    BPlatters1.Text = str.Substring(0, str.IndexOf(','));
                    BPlattersPrice1.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    BPlatters2.Text = str.Substring(0, str.IndexOf(','));
                    BPlattersPrice2.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    BPlatters3.Text = str.Substring(0, str.IndexOf(','));
                    BPlattersPrice3.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    BPlatters4.Text = str.Substring(0, str.IndexOf(','));
                    BPlattersPrice4.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    BPlatters5.Text = str.Substring(0, str.IndexOf(','));
                    BPlattersPrice5.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                }
                else if (str.Equals("/Lunch Sandwiches\\"))
                {
                    str = sr.ReadLine();
                    LSandwich1.Text = str.Substring(0, str.IndexOf(','));
                    LSandPrice1.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    LSandwich2.Text = str.Substring(0, str.IndexOf(','));
                    LSandPrice2.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    LSandwich3.Text = str.Substring(0, str.IndexOf(','));
                    LSandPrice3.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    LSandwich4.Text = str.Substring(0, str.IndexOf(','));
                    LSandPrice4.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    LSandwich5.Text = str.Substring(0, str.IndexOf(','));
                    LSandPrice5.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    LSandwich6.Text = str.Substring(0, str.IndexOf(','));
                    LSandPrice6.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    LSandwich7.Text = str.Substring(0, str.IndexOf(','));
                    LSandPrice7.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                }
                else if (str.Equals("/Specialty Items\\"))
                {
                    str = sr.ReadLine();
                    LSpecial1.Text = str.Substring(0, str.IndexOf(','));
                    LSpecialPrice1.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    LSpecial2.Text = str.Substring(0, str.IndexOf(','));
                    LSpecialPrice2.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    LSpecial3.Text = str.Substring(0, str.IndexOf(','));
                    LSpecialPrice3.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    LSpecial4.Text = str.Substring(0, str.IndexOf(','));
                    LSpecialPrice4.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    LSpecial5.Text = str.Substring(0, str.IndexOf(','));
                    LSpecialPrice5.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    LSpecial6.Text = str.Substring(0, str.IndexOf(','));
                    LSpecialPrice6.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                    str = sr.ReadLine();
                    LSpecial7.Text = str.Substring(0, str.IndexOf(','));
                    LSpecialPrice7.Text = '$' + str.Substring(str.IndexOf(',') + 2);
                }
                str = sr.ReadLine();
            }
            sr.Close();
            
        }

        private void OrderQuantity(Decimal Items)
        {
            this.OrderCount += Items;
            return;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Close();
        }

        private void CheckOut_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"" + Directory + "\\Order.txt");
            string order = sr.ReadLine();
            while (!order.Contains("Pending"))
            {
                order = sr.ReadLine();
                if(order.Contains("#End Of File#"))
                {
                    sr.Close();
                    MessageBox.Show("The system has encountered an error, we are returning you to the Opening screen", "Checkout Loading Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    String Directory = Path.GetDirectoryName(Application.ExecutablePath);
                    Process.Start(@"" + Directory + "\\WindowsFormsApp1.exe");
                    this.Close();
                    break;
                }
            }
            sr.Close();
            order = "";
            //Beginning of the Side Quantity Calculation
            if (SideQ1.Value != 0){
                order = order + "\n" +  SideItem1.Text + "," +  SideQ1.Value.ToString() + "-" + (decimal.Parse(SidePrice1.Text.Substring(SidePrice1.Text.IndexOf('$')+1)) * SideQ1.Value).ToString();
                OrderQuantity(SideQ1.Value);
            }
            if (SideQ2.Value != 0)
            {
                order = order + "\n" + SideItem2.Text + "," + SideQ2.Value.ToString() + "-" + (decimal.Parse(SidePrice2.Text.Substring(SidePrice2.Text.IndexOf('$') + 1)) * SideQ2.Value).ToString();
                OrderQuantity(SideQ2.Value);
            }
            if (SideQ3.Value != 0)
            {
                order = order + "\n" + SideItem3.Text + "," + SideQ3.Value.ToString() + "-" + (decimal.Parse(SidePrice3.Text.Substring(SidePrice3.Text.IndexOf('$') + 1)) * SideQ3.Value).ToString();
                OrderQuantity(SideQ3.Value);
            }
            if (SideQ4.Value != 0)
            {
                order = order + "\n" + SideItem4.Text + "," + SideQ4.Value.ToString() + "-" + (decimal.Parse(SidePrice4.Text.Substring(SidePrice4.Text.IndexOf('$') + 1)) * SideQ4.Value).ToString();
                OrderQuantity(SideQ4.Value);
            }
            if (SideQ5.Value != 0)
            {
                order = order + "\n" + SideItem5.Text + "," + SideQ5.Value.ToString() + "-" + (decimal.Parse(SidePrice5.Text.Substring(SidePrice5.Text.IndexOf('$') + 1)) * SideQ5.Value).ToString();
                OrderQuantity(SideQ5.Value);
            }
            if (SideQ6.Value != 0)
            {
                order = order + "\n" + SideItem6.Text + "," + SideQ6.Value.ToString() + "-" + (decimal.Parse(SidePrice6.Text.Substring(SidePrice6.Text.IndexOf('$') + 1)) * SideQ6.Value).ToString();
                OrderQuantity(SideQ6.Value);
            }

            //Beginning of the Beverage Calculation
            if (BevQ1.Value != 0)
            {
                order = order + "\n" + Bev1.Text + "," + BevQ1.Value.ToString() + "-" + (decimal.Parse(BevPrice1.Text.Substring(BevPrice1.Text.IndexOf('$') + 1)) * BevQ1.Value).ToString();
                OrderQuantity(BevQ1.Value);
            }
            if (BevQ2.Value != 0)
            {
                order = order + "\n" + Bev2.Text + "," + BevQ2.Value.ToString() + "-" + (decimal.Parse(BevPrice2.Text.Substring(BevPrice2.Text.IndexOf('$') + 1)) * BevQ2.Value).ToString();
                OrderQuantity(BevQ2.Value);
            }
            if (BevQ3.Value != 0)
            {
                order = order + "\n" + Bev3.Text + "," + BevQ3.Value.ToString() + "-" + (decimal.Parse(BevPrice3.Text.Substring(BevPrice3.Text.IndexOf('$') + 1)) * BevQ3.Value).ToString();
                OrderQuantity(BevQ3.Value);
            }
            if (BevQ4.Value != 0)
            {
                order = order + "\n" + Bev4.Text + "," + BevQ4.Value.ToString() + "-" + (decimal.Parse(BevPrice4.Text.Substring(BevPrice4.Text.IndexOf('$') + 1)) * BevQ4.Value).ToString();
                OrderQuantity(BevQ4.Value);
            }
            if (BevQ5.Value != 0)
            {
                order = order + "\n" + Bev5.Text + "," + BevQ5.Value.ToString() + "-" + (decimal.Parse(BevPrice5.Text.Substring(BevPrice5.Text.IndexOf('$') + 1)) * BevQ5.Value).ToString();
                OrderQuantity(BevQ5.Value);
            }
            if (BevQ6.Value != 0)
            {
                order = order + "\n" + Bev6.Text + "," + BevQ6.Value.ToString() + "-" + (decimal.Parse(BevPrice6.Text.Substring(BevPrice6.Text.IndexOf('$') + 1)) * BevQ6.Value).ToString();
                OrderQuantity(BevQ6.Value);
            }

            //Beginning of Breakfast Sandwiches calculation
            if (BSandwichQ1.Value != 0)
            {
                order = order + "\n" + BSandwich1.Text + "," + BSandwichQ1.Value.ToString() + "-" + (decimal.Parse(BSandPrice1.Text.Substring(BSandPrice1.Text.IndexOf('$') + 1)) * BSandwichQ1.Value).ToString();
                OrderQuantity(BSandwichQ1.Value);
            }
            if (BSandwichQ2.Value != 0)
            {
                order = order + "\n" + BSandwich2.Text + "," + BSandwichQ2.Value.ToString() + "-" + (decimal.Parse(BSandPrice2.Text.Substring(BSandPrice2.Text.IndexOf('$') + 1)) * BSandwichQ2.Value).ToString();
                OrderQuantity(BSandwichQ2.Value);
            }
            if (BSandwichQ3.Value != 0)
            {
                order = order + "\n" + BSandwich3.Text + "," + BSandwichQ3.Value.ToString() + "-" + (decimal.Parse(BSandPrice3.Text.Substring(BSandPrice3.Text.IndexOf('$') + 1)) * BSandwichQ3.Value).ToString();
                OrderQuantity(BSandwichQ3.Value);
            }
            if (BSandwichQ4.Value != 0)
            {
                order = order + "\n" + BSandwich4.Text + "," + BSandwichQ4.Value.ToString() + "-" + (decimal.Parse(BSandPrice4.Text.Substring(BSandPrice4.Text.IndexOf('$') + 1)) * BSandwichQ4.Value).ToString();
                OrderQuantity(BSandwichQ4.Value);
            }
            if (BSandwichQ5.Value != 0)
            {
                order = order + "\n" + BSandwich5.Text + "," + BSandwichQ5.Value.ToString() + "-" + (decimal.Parse(BSandPrice5.Text.Substring(BSandPrice5.Text.IndexOf('$') + 1)) * BSandwichQ5.Value).ToString();
                OrderQuantity(BSandwichQ5.Value);
            }

            //Beginning of Breakfast Platters calculation
            if (BPlattersQ1.Value != 0)
            {
                order = order + "\n" + BPlatters1.Text + "," + BPlattersQ1.Value.ToString() + "-" + (decimal.Parse(BPlattersPrice1.Text.Substring(BPlattersPrice1.Text.IndexOf('$') + 1)) * BPlattersQ1.Value).ToString();
                OrderQuantity(BPlattersQ1.Value);
            }
            if (BPlattersQ2.Value != 0)
            {
                order = order + "\n" + BSandwich2.Text + "," + BPlattersQ2.Value.ToString() + "-" + (decimal.Parse(BPlattersPrice2.Text.Substring(BPlattersPrice2.Text.IndexOf('$') + 1)) * BPlattersQ2.Value).ToString();
                OrderQuantity(BPlattersQ2.Value);
            }
            if (BPlattersQ3.Value != 0)
            {
                order = order + "\n" + BPlatters3.Text + "," + BPlattersQ3.Value.ToString() + "-" + (decimal.Parse(BPlattersPrice3.Text.Substring(BPlattersPrice3.Text.IndexOf('$') + 1)) * BPlattersQ3.Value).ToString();
                OrderQuantity(BPlattersQ3.Value);
            }
            if (BPlattersQ4.Value != 0)
            {
                order = order + "\n" + BPlatters4.Text + "," + BPlattersQ4.Value.ToString() + "-" + (decimal.Parse(BPlattersPrice4.Text.Substring(BPlattersPrice4.Text.IndexOf('$') + 1)) * BPlattersQ4.Value).ToString();
                OrderQuantity(BPlattersQ4.Value);
            }
            if (BSandwichQ5.Value != 0)
            {
                order = order + "\n" + BPlatters5.Text + "," + BPlattersQ5.Value.ToString() + "-" + (decimal.Parse(BPlattersPrice5.Text.Substring(BPlattersPrice5.Text.IndexOf('$') + 1)) * BPlattersQ5.Value).ToString();
                OrderQuantity(BPlattersQ5.Value);
            }

            //Beginning of Lunch Sandwichs calculation
            if (LSandwichQ1.Value != 0)
            {
                order = order + "\n" + LSandwich1.Text + "," + LSandwichQ1.Value.ToString() + "-" + (decimal.Parse(LSandPrice1.Text.Substring(LSandPrice1.Text.IndexOf('$') + 1)) * LSandwichQ1.Value).ToString();
                OrderQuantity(LSandwichQ1.Value);
            }
            if (LSandwichQ2.Value != 0)
            {
                order = order + "\n" + LSandwich2.Text + "," + LSandwichQ2.Value.ToString() + "-" + (decimal.Parse(LSandPrice2.Text.Substring(LSandPrice2.Text.IndexOf('$') + 1)) * LSandwichQ2.Value).ToString();
                OrderQuantity(LSandwichQ2.Value);
            }
            if (LSandwichQ3.Value != 0)
            {
                order = order + "\n" + LSandwich3.Text + "," + LSandwichQ3.Value.ToString() + "-" + (decimal.Parse(LSandPrice3.Text.Substring(LSandPrice3.Text.IndexOf('$') + 1)) * LSandwichQ3.Value).ToString();
                OrderQuantity(LSandwichQ3.Value);
            }
            if (LSandwichQ4.Value != 0)
            {
                order = order + "\n" + LSandwich4.Text + "," + LSandwichQ4.Value.ToString() + "-" + (decimal.Parse(LSandPrice4.Text.Substring(LSandPrice4.Text.IndexOf('$') + 1)) * LSandwichQ4.Value).ToString();
                OrderQuantity(LSandwichQ4.Value);
            }
            if (LSandwichQ5.Value != 0)
            {
                order = order + "\n" + LSandwich5.Text + "," + LSandwichQ5.Value.ToString() + "-" + (decimal.Parse(LSandPrice5.Text.Substring(LSandPrice5.Text.IndexOf('$') + 1)) * LSandwichQ5.Value).ToString();
                OrderQuantity(LSandwichQ5.Value);
            }
            if (LSandwichQ6.Value != 0)
            {
                order = order + "\n" + LSandwich6.Text + "," + LSandwichQ6.Value.ToString() + "-" + (decimal.Parse(LSandPrice6.Text.Substring(LSandPrice6.Text.IndexOf('$') + 1)) * LSandwichQ6.Value).ToString();
                OrderQuantity(LSandwichQ6.Value);
            }
            if (LSandwichQ7.Value != 0)
            {
                order = order + "\n" + LSandwich7.Text + "," + LSandwichQ7.Value.ToString() + "-" + (decimal.Parse(LSandPrice7.Text.Substring(LSandPrice7.Text.IndexOf('$') + 1)) * LSandwichQ7.Value).ToString();
                OrderQuantity(LSandwichQ7.Value);
            }

            //Beginning of Lunch Specials calculation
            if (LSpecialQ1.Value != 0)
            {
                order = order + "\n" + LSpecial1.Text + "," + LSpecialQ1.Value.ToString() + "-" + (decimal.Parse(LSpecialPrice1.Text.Substring(LSpecialPrice1.Text.IndexOf('$') + 1)) * LSpecialQ1.Value).ToString();
                OrderQuantity(LSpecialQ1.Value);
            }
            if (LSpecialQ2.Value != 0)
            {
                order = order + "\n" + LSpecial2.Text + "," + LSpecialQ2.Value.ToString() + "-" + (decimal.Parse(LSpecialPrice2.Text.Substring(LSpecialPrice2.Text.IndexOf('$') + 1)) * LSpecialQ2.Value).ToString();
                OrderQuantity(LSpecialQ2.Value);
            }
            if (LSpecialQ3.Value != 0)
            {
                order = order + "\n" + LSpecial3.Text + "," + LSpecialQ3.Value.ToString() + "-" + (decimal.Parse(LSpecialPrice3.Text.Substring(LSpecialPrice3.Text.IndexOf('$') + 1)) * LSpecialQ3.Value).ToString();
                OrderQuantity(LSpecialQ3.Value);
            }
            if (LSpecialQ4.Value != 0)
            {
                order = order + "\n" + LSpecial4.Text + "," + LSpecialQ4.Value.ToString() + "-" + (decimal.Parse(LSpecialPrice4.Text.Substring(LSpecialPrice4.Text.IndexOf('$') + 1)) * LSpecialQ4.Value).ToString();
                OrderQuantity(LSpecialQ4.Value);
            }
            if (LSpecialQ5.Value != 0)
            {
                order = order + "\n" + LSpecial5.Text + "," + LSpecialQ5.Value.ToString() + "-" + (decimal.Parse(LSpecialPrice5.Text.Substring(LSpecialPrice5.Text.IndexOf('$') + 1)) * LSpecialQ5.Value).ToString();
                OrderQuantity(LSpecialQ5.Value);
            }
            if (LSpecialQ6.Value != 0)
            {
                order = order + "\n" + LSpecial6.Text + "," + LSpecialQ6.Value.ToString() + "-" + (decimal.Parse(LSpecialPrice6.Text.Substring(LSpecialPrice6.Text.IndexOf('$') + 1)) * LSpecialQ6.Value).ToString();
                OrderQuantity(LSpecialQ6.Value);
            }
            if (LSpecialQ7.Value != 0)
            {
                order = order + "\n" + LSpecial7.Text + "," + LSpecialQ7.Value.ToString() + "-" + (decimal.Parse(LSpecialPrice7.Text.Substring(LSpecialPrice7.Text.IndexOf('$') + 1)) * LSpecialQ7.Value).ToString();
                OrderQuantity(LSpecialQ7.Value);
            }

            //Restricking orders to have no more than 10 items, if the statement is false then the screens will progress.
            if (this.OrderCount > 10)
            {
                MessageBox.Show("In order to ensure we can complete all orders in a timely manner we will not accept orders over 10 Items.", "Transaction Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                new Menu_Screen().Show();
                this.Close();
            }
            else
            {
                //Writing the Order to the File and closing the form to open up the Order Summary screen
                string Directory = Path.GetDirectoryName(Application.ExecutablePath);
                Directory = Directory.Substring(0, Directory.IndexOf("bin"));
                string OpenFile = Directory + "\\Order.txt";

                //File manipulation to change the Active order to Placed
                string FileText = File.ReadAllText(Directory + "\\Order.txt");
                FileText = FileText.Replace("Pending", "Active" + order);
                File.WriteAllText(OpenFile, FileText);

                Directory = Directory.Substring(0, Directory.IndexOf("Arturo's Half"));
                Process.Start(Directory + "\\Eric's Half\\bin\\Debug\\Software_Engineering.exe");
                Application.Exit();
            }
        }
    }
}
