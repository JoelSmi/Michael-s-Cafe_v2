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
        public Menu_Screen()
        {
            InitializeComponent();
        }

        private void Menu_Screen_Load(object sender, EventArgs e)
        {
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

        private void Back_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Close();
        }

        private void CheckOut_Click(object sender, EventArgs e)
        {
            string order = "23030 \n";
            //Beginning of the Side Quantity Calculation
            if (SideQ1.Value != 0){
                order = order +  SideItem1.Text + "," +  SideQ1.Value.ToString() + "-" + (decimal.Parse(SidePrice1.Text.Substring(SidePrice1.Text.IndexOf('$')+1)) * SideQ1.Value).ToString() +"\n";
            }
            if (SideQ2.Value != 0)
            {
                order = order + SideItem2.Text + "," + SideQ2.Value.ToString() + "-" + (decimal.Parse(SidePrice2.Text.Substring(SidePrice2.Text.IndexOf('$') + 1)) * SideQ2.Value).ToString() + "\n";
            }
            if (SideQ3.Value != 0)
            {
                order = order + SideItem3.Text + "," + SideQ3.Value.ToString() + "-" + (decimal.Parse(SidePrice3.Text.Substring(SidePrice3.Text.IndexOf('$') + 1)) * SideQ3.Value).ToString() + "\n";
            }
            if (SideQ4.Value != 0)
            {
                order = order + SideItem4.Text + "," + SideQ4.Value.ToString() + "-" + (decimal.Parse(SidePrice4.Text.Substring(SidePrice4.Text.IndexOf('$') + 1)) * SideQ4.Value).ToString() + "\n";
            }
            if (SideQ5.Value != 0)
            {
                order = order + SideItem5.Text + "," + SideQ5.Value.ToString() + "-" + (decimal.Parse(SidePrice5.Text.Substring(SidePrice5.Text.IndexOf('$') + 1)) * SideQ5.Value).ToString() + "\n";
            }
            if (SideQ6.Value != 0)
            {
                order = order + SideItem6.Text + "," + SideQ6.Value.ToString() + "-" + (decimal.Parse(SidePrice6.Text.Substring(SidePrice6.Text.IndexOf('$') + 1)) * SideQ6.Value).ToString() + "\n";
            }

            //Beginning of the Beverage Calculation
            if (BevQ1.Value != 0)
            {
                order = order + Bev1.Text + "," + BevQ1.Value.ToString() + "-" + (decimal.Parse(BevPrice1.Text.Substring(BevPrice1.Text.IndexOf('$') + 1)) * BevQ1.Value).ToString() + "\n";
            }
            if (BevQ2.Value != 0)
            {
                order = order + Bev2.Text + "," + BevQ2.Value.ToString() + "-" + (decimal.Parse(BevPrice2.Text.Substring(BevPrice2.Text.IndexOf('$') + 1)) * BevQ2.Value).ToString() + "\n";
            }
            if (BevQ3.Value != 0)
            {
                order = order + Bev3.Text + "," + BevQ3.Value.ToString() + "-" + (decimal.Parse(BevPrice3.Text.Substring(BevPrice3.Text.IndexOf('$') + 1)) * BevQ3.Value).ToString() + "\n";
            }
            if (BevQ4.Value != 0)
            {
                order = order + Bev4.Text + "," + BevQ4.Value.ToString() + "-" + (decimal.Parse(BevPrice4.Text.Substring(BevPrice4.Text.IndexOf('$') + 1)) * BevQ4.Value).ToString() + "\n";
            }
            if (BevQ5.Value != 0)
            {
                order = order + Bev5.Text + "," + BevQ5.Value.ToString() + "-" + (decimal.Parse(BevPrice5.Text.Substring(BevPrice5.Text.IndexOf('$') + 1)) * BevQ5.Value).ToString() + "\n";
            }
            if (BevQ6.Value != 0)
            {
                order = order + Bev6.Text + "," + BevQ6.Value.ToString() + "-" + (decimal.Parse(BevPrice6.Text.Substring(BevPrice6.Text.IndexOf('$') + 1)) * BevQ6.Value).ToString() + "\n";
            }

            //Beginning of Breakfast Sandwiches calculation
            if (BSandwichQ1.Value != 0)
            {
                order = order + BSandwich1.Text + "," + BSandwichQ1.Value.ToString() + "-" + (decimal.Parse(BSandPrice1.Text.Substring(BSandPrice1.Text.IndexOf('$') + 1)) * BSandwichQ1.Value).ToString() + "\n";
            }
            if (BSandwichQ2.Value != 0)
            {
                order = order + BSandwich2.Text + "," + BSandwichQ2.Value.ToString() + "-" + (decimal.Parse(BSandPrice2.Text.Substring(BSandPrice2.Text.IndexOf('$') + 1)) * BSandwichQ2.Value).ToString() + "\n";
            }
            if (BSandwichQ3.Value != 0)
            {
                order = order + BSandwich3.Text + "," + BSandwichQ3.Value.ToString() + "-" + (decimal.Parse(BSandPrice3.Text.Substring(BSandPrice3.Text.IndexOf('$') + 1)) * BSandwichQ3.Value).ToString() + "\n";
            }
            if (BSandwichQ4.Value != 0)
            {
                order = order + BSandwich4.Text + "," + BSandwichQ4.Value.ToString() + "-" + (decimal.Parse(BSandPrice4.Text.Substring(BSandPrice4.Text.IndexOf('$') + 1)) * BSandwichQ4.Value).ToString() + "\n";
            }
            if (BSandwichQ5.Value != 0)
            {
                order = order + BSandwich5.Text + "," + BSandwichQ5.Value.ToString() + "-" + (decimal.Parse(BSandPrice5.Text.Substring(BSandPrice5.Text.IndexOf('$') + 1)) * BSandwichQ5.Value).ToString() + "\n";
            }

            //Beginning of Breakfast Platters calculation
            if (BPlattersQ1.Value != 0)
            {
                order = order + BPlatters1.Text + "," + BPlattersQ1.Value.ToString() + "-" + (decimal.Parse(BPlattersPrice1.Text.Substring(BPlattersPrice1.Text.IndexOf('$') + 1)) * BPlattersQ1.Value).ToString() + "\n";
            }
            if (BPlattersQ2.Value != 0)
            {
                order = order + BSandwich2.Text + "," + BPlattersQ2.Value.ToString() + "-" + (decimal.Parse(BPlattersPrice2.Text.Substring(BPlattersPrice2.Text.IndexOf('$') + 1)) * BPlattersQ2.Value).ToString() + "\n";
            }
            if (BPlattersQ3.Value != 0)
            {
                order = order + BPlatters3.Text + "," + BPlattersQ3.Value.ToString() + "-" + (decimal.Parse(BPlattersPrice3.Text.Substring(BPlattersPrice3.Text.IndexOf('$') + 1)) * BPlattersQ3.Value).ToString() + "\n";
            }
            if (BPlattersQ4.Value != 0)
            {
                order = order + BPlatters4.Text + "," + BPlattersQ4.Value.ToString() + "-" + (decimal.Parse(BPlattersPrice4.Text.Substring(BPlattersPrice4.Text.IndexOf('$') + 1)) * BPlattersQ4.Value).ToString() + "\n";
            }
            if (BSandwichQ5.Value != 0)
            {
                order = order + BPlatters5.Text + "," + BPlattersQ5.Value.ToString() + "-" + (decimal.Parse(BPlattersPrice5.Text.Substring(BPlattersPrice5.Text.IndexOf('$') + 1)) * BPlattersQ5.Value).ToString() + "\n";
            }

            //Beginning of Lunch Sandwichs calculation
            if (LSandwichQ1.Value != 0)
            {
                order = order + LSandwich1.Text + "," + LSandwichQ1.Value.ToString() + "-" + (decimal.Parse(LSandPrice1.Text.Substring(LSandPrice1.Text.IndexOf('$') + 1)) * LSandwichQ1.Value).ToString() + "\n";
            }
            if (LSandwichQ2.Value != 0)
            {
                order = order + LSandwich2.Text + "," + LSandwichQ2.Value.ToString() + "-" + (decimal.Parse(LSandPrice2.Text.Substring(LSandPrice2.Text.IndexOf('$') + 1)) * LSandwichQ2.Value).ToString() + "\n";
            }
            if (LSandwichQ3.Value != 0)
            {
                order = order + LSandwich3.Text + "," + LSandwichQ3.Value.ToString() + "-" + (decimal.Parse(LSandPrice3.Text.Substring(LSandPrice3.Text.IndexOf('$') + 1)) * LSandwichQ3.Value).ToString() + "\n";
            }
            if (LSandwichQ4.Value != 0)
            {
                order = order + LSandwich4.Text + "," + LSandwichQ4.Value.ToString() + "-" + (decimal.Parse(LSandPrice4.Text.Substring(LSandPrice4.Text.IndexOf('$') + 1)) * LSandwichQ4.Value).ToString() + "\n";
            }
            if (LSandwichQ5.Value != 0)
            {
                order = order + LSandwich5.Text + "," + LSandwichQ5.Value.ToString() + "-" + (decimal.Parse(LSandPrice5.Text.Substring(LSandPrice5.Text.IndexOf('$') + 1)) * LSandwichQ5.Value).ToString() + "\n";
            }
            if (LSandwichQ6.Value != 0)
            {
                order = order + LSandwich6.Text + "," + LSandwichQ6.Value.ToString() + "-" + (decimal.Parse(LSandPrice6.Text.Substring(LSandPrice6.Text.IndexOf('$') + 1)) * LSandwichQ6.Value).ToString() + "\n";
            }
            if (LSandwichQ7.Value != 0)
            {
                order = order + LSandwich7.Text + "," + LSandwichQ7.Value.ToString() + "-" + (decimal.Parse(LSandPrice7.Text.Substring(LSandPrice7.Text.IndexOf('$') + 1)) * LSandwichQ7.Value).ToString() + "\n";
            }

            //Beginning of Lunch Specials calculation
            if (LSpecialQ1.Value != 0)
            {
                order = order + LSpecial1.Text + "," + LSpecialQ1.Value.ToString() + "-" + (decimal.Parse(LSpecialPrice1.Text.Substring(LSpecialPrice1.Text.IndexOf('$') + 1)) * LSpecialQ1.Value).ToString() + "\n";
            }
            if (LSpecialQ2.Value != 0)
            {
                order = order + LSpecial2.Text + "," + LSpecialQ2.Value.ToString() + "-" + (decimal.Parse(LSpecialPrice2.Text.Substring(LSpecialPrice2.Text.IndexOf('$') + 1)) * LSpecialQ2.Value).ToString() + "\n";
            }
            if (LSpecialQ3.Value != 0)
            {
                order = order + LSpecial3.Text + "," + LSpecialQ3.Value.ToString() + "-" + (decimal.Parse(LSpecialPrice3.Text.Substring(LSpecialPrice3.Text.IndexOf('$') + 1)) * LSpecialQ3.Value).ToString() + "\n";
            }
            if (LSpecialQ4.Value != 0)
            {
                order = order + LSpecial4.Text + "," + LSpecialQ4.Value.ToString() + "-" + (decimal.Parse(LSpecialPrice4.Text.Substring(LSpecialPrice4.Text.IndexOf('$') + 1)) * LSpecialQ4.Value).ToString() + "\n";
            }
            if (LSpecialQ5.Value != 0)
            {
                order = order + LSpecial5.Text + "," + LSpecialQ5.Value.ToString() + "-" + (decimal.Parse(LSpecialPrice5.Text.Substring(LSpecialPrice5.Text.IndexOf('$') + 1)) * LSpecialQ5.Value).ToString() + "\n";
            }
            if (LSpecialQ6.Value != 0)
            {
                order = order + LSpecial6.Text + "," + LSpecialQ6.Value.ToString() + "-" + (decimal.Parse(LSpecialPrice6.Text.Substring(LSpecialPrice6.Text.IndexOf('$') + 1)) * LSpecialQ6.Value).ToString() + "\n";
            }
            if (LSpecialQ7.Value != 0)
            {
                order = order + LSpecial7.Text + "," + LSpecialQ7.Value.ToString() + "-" + (decimal.Parse(LSpecialPrice7.Text.Substring(LSpecialPrice7.Text.IndexOf('$') + 1)) * LSpecialQ7.Value).ToString() + "\n";
            }

            //Writing the Order to the File and closing the form to open up the Order Summary screen
            StreamWriter sw = new StreamWriter(@"" + Directory + "\\Order.txt");
            sw.WriteLine(order);
            sw.Close();

            String CheckDirectory = Directory.Substring(0, Directory.IndexOf("Arturo's Half"));
            Process.Start(@"" + CheckDirectory + "\\Eric's Half\\bin\\Debug\\Software_Engineering.exe");
            Close();
        }
    }
}
