using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
namespace Software_Engineering
{
    public partial class Delivery
    {
        private string Directory = Path.GetDirectoryName(Application.ExecutablePath);

        string[] NameArray = new string[2];
        string[] AddressArray = new string[4];
        string[] NewAddrInfo = { "", "", "", "" };

        string AccountInfo, ChangedAccountInfo;

        string AddrInfo;

        private bool isDiffAddr;
        public Delivery()
        {
            isDiffAddr = false;
            InitializeComponent();
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
                    CustomerNameText.Text = NameArray[0] + " " +  NameArray[1];

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
            //If paying with card
            //this.Hide();
            //new Reciept_Card().Show();

            //If not paying with card
            //this.Hide();
            //new Reciept_Cash().Show();
        }


        private void Delivery_Load(object sender, EventArgs e)
        {
            DisplayCurrentInfo();

            Directory = Path.GetDirectoryName(Application.ExecutablePath);
            string OpenFile = Directory.Substring(0, Directory.IndexOf("Eric's Half")) + "Arturo's Half\\Michael_Cafe.txt";
            StreamReader sr = new StreamReader(OpenFile);
            string CurrLine = sr.ReadLine();
            while (!CurrLine.Contains("#End Of File#"))
            {
                if (CurrLine.Contains("LoggedIn"))
                {
                    AccountInfo = CurrLine;
                    CurrLine = sr.ReadLine();
                    while (!CurrLine.Contains("/") && !CurrLine.Contains("#End Of File#"))
                    {
                        AccountInfo += "\n" + CurrLine;
                        CurrLine = sr.ReadLine();
                    }
                    sr.Close();

                    break;
                }
                else
                {
                    CurrLine = sr.ReadLine();
                }
            }
        }

        private void NextButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            if (isDiffAddr.Equals(true))
            {
                if (!NewAddrInfo[0].Equals("") && !NewAddrInfo[1].Equals("") && !NewAddrInfo[2].Equals("") && !NewAddrInfo[3].Equals(""))
                {
                    AddrInfo = NewAddrInfo[0] + "," + NewAddrInfo[1] + "-" + NewAddrInfo[2] + "." + NewAddrInfo[3];
                    ChangedAccountInfo = AccountInfo;
                    ChangedAccountInfo = ChangedAccountInfo.Replace(ChangedAccountInfo.Substring(ChangedAccountInfo.IndexOf("*")), "*" + AddrInfo);

                    Directory = Path.GetDirectoryName(Application.ExecutablePath);
                    Directory = Directory.Substring(0, Directory.IndexOf("Eric's Half"));
                    string OpenFile = Directory + "\\Arturo's Half\\Michael_Cafe.txt";

                    //File manipulation to update the account information
                    string FileText = File.ReadAllText(OpenFile);
                    FileText = FileText.Replace(AccountInfo, ChangedAccountInfo);
                    File.WriteAllText(OpenFile, FileText);
                    new Delivery_Final().Show();
                }
                else
                {
                    MessageBox.Show("Please fill out all fields when adding a new address", "Address Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                new Delivery_Final().Show();
            }
        }

        private void StreetNameText_TextChanged_1(object sender, EventArgs e)
        {
            NewAddrInfo[0] = StreetNameText.Text;
        }

        private void CityText_TextChanged_1(object sender, EventArgs e)
        {
            NewAddrInfo[1] = CityText.Text;
        }

        private void StateText_TextChanged_1(object sender, EventArgs e)
        {
            NewAddrInfo[2] = StateText.Text;
        }

        private void ZipText_TextChanged_1(object sender, EventArgs e)
        {
            NewAddrInfo[3] = ZipText.Text;
        }

        private void DiffAddButton_CheckedChanged(object sender, EventArgs e)
        {
            isDiffAddr = true;
        }
        private void AptNumText_TextChanged(object sender, System.EventArgs e)
        {
           
        }
    }
}