using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
namespace Software_Engineering
{
    public partial class Delivery_Guest
    {
        private string Directory = Path.GetDirectoryName(Application.ExecutablePath);
        string[] NameArray = { "", "" };
        string[] NewAddrInfo = { "", "", "", "" };
        string AccountInfo;
        string NewInfo;
        string PhonNo;

        public Delivery_Guest()
        {
            InitializeComponent();
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

        private void NextButton_Click(object sender, System.EventArgs e)
        {

            if (!NewAddrInfo[0].Equals("") && !NewAddrInfo[1].Equals("") && !NewAddrInfo[2].Equals("") && !NewAddrInfo[3].Equals(""))
            {
                string Line0 = "/Guest-LoggedIn";
                string Line1 = NameArray[0] + "," + NameArray[1];
                string Line2 = PhonNo;
                string Line3 = NewAddrInfo[0] + "," + NewAddrInfo[1] + "-" + NewAddrInfo[2] + "." + NewAddrInfo[3];



                NewInfo = AccountInfo.Replace(Line0, Line0 + "\n" + Line1 + "\n" + Line2);
                NewInfo = AccountInfo.Replace("*","*"+ Line3);
                Directory = Path.GetDirectoryName(Application.ExecutablePath);
                Directory = Directory.Substring(0, Directory.IndexOf("Eric's Half"));
                string OpenFile = Directory + "\\Arturo's Half\\Michael_Cafe.txt";

                //File manipulation to update the account information
                string FileText = File.ReadAllText(OpenFile);
                FileText = FileText.Replace(AccountInfo, NewInfo);
                File.WriteAllText(OpenFile, FileText);
                new Delivery_Final().Show();
            }
            else
            {
                MessageBox.Show("Please fill out all fields provided above", "Guest Infomration Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();
            new Delivery_Final().Show();
        }

        private void StreetNameText_TextChanged(object sender, System.EventArgs e)
        {
            NewAddrInfo[0] = StreetNameText.Text;
        }

        private void CityText_TextChanged(object sender, System.EventArgs e)
        {
            NewAddrInfo[1] = CityText.Text;
        }

        private void StateText_TextChanged(object sender, System.EventArgs e)
        {
            NewAddrInfo[2] = StateText.Text;
        }

        private void ZipText_TextChanged(object sender, System.EventArgs e)
        {
            NewAddrInfo[3] = ZipText.Text;
        }

        private void FirstNameText_TextChanged_1(object sender, EventArgs e)
        {
            NameArray[0] = FirstNameText.Text;
        }

        private void LastNameText_TextChanged_1(object sender, EventArgs e)
        {
            NameArray[1] = LastNameText.Text;
        }

        private void PhoneNumberText_TextChanged_1(object sender, EventArgs e)
        {
            PhonNo = PhoneNumberText.Text;
        }

        private void Delivery_Guest_Load(object sender, EventArgs e)
        {
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
    }
}