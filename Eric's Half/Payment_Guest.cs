using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
namespace Software_Engineering
{
    public partial class Payment_Guest
    {
        private bool isCashCheck;
        private bool isCard;
        private string Directory = Path.GetDirectoryName(Application.ExecutablePath);
        string AccountInfo = "", ChangedAccounInfo;
        string CardInfo;
        string CurrLine = "";
        string[] NewCardInfo = { "", "", "" };

        public Payment_Guest()
        {
            InitializeComponent();
        }
        private void Payment_Guest_Load_1(object sender, EventArgs e)
        {
            Directory = Path.GetDirectoryName(Application.ExecutablePath);
            string OpenFile = Directory.Substring(0, Directory.IndexOf("Eric's Half")) + "Arturo's Half\\Michael_Cafe.txt";
            StreamReader sr = new StreamReader(OpenFile);
            CurrLine = sr.ReadLine();
            while (!CurrLine.Contains("#End Of File#"))
            {
                if (CurrLine.Contains("LoggedIn"))
                {
                    AccountInfo += CurrLine;
                    CurrLine = sr.ReadLine();

                    //NullException that needs to be fixed
                    while (!CurrLine.Contains("/"))
                    {
                        AccountInfo += "\n" + CurrLine;
                        CurrLine = sr.ReadLine();
                    }
                    break;
                }
                else
                {
                    CurrLine = sr.ReadLine();
                }
            }
            
        }

        private void CashButton_CheckedChanged(object sender, EventArgs e)
        {
            isCashCheck = true;
            isCard = false;
        }
        private void CheckButton_CheckedChanged(object sender, EventArgs e)
        {
            isCashCheck = true;
            isCard = false;
        }

        private void CardButton_CheckedChanged(object sender, EventArgs e)
        {
            isCashCheck = false;
            isCard = true;
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (isCard.Equals(true))
            {
                if (!NewCardInfo[0].Equals("") && !NewCardInfo[1].Equals("") && !NewCardInfo[2].Equals(""))
                {
                    CardInfo = NewCardInfo[0] + "," + NewCardInfo[1] + "-" + NewCardInfo[2];
                    ChangedAccounInfo = AccountInfo;
                    ChangedAccounInfo = ChangedAccounInfo.Replace(ChangedAccounInfo.Substring(ChangedAccounInfo.IndexOf("$")), "$" + CardInfo);

                    Directory = Path.GetDirectoryName(Application.ExecutablePath);
                    Directory = Directory.Substring(0, Directory.IndexOf("Eric's Half"));
                    string OpenFile = Directory + "\\Arturo's Half\\Michael_Cafe.txt";

                    //File manipulation to change the Active order to Placed
                    string FileText = File.ReadAllText(OpenFile);
                    FileText = FileText.Replace(AccountInfo, ChangedAccounInfo);
                    File.WriteAllText(OpenFile, FileText);
                }
                new Reciept_Card().Show();
            }
            else if (isCashCheck.Equals(true))
            {
                new Reciept_Cash().Show();
            }
            else
            {
                return;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OrderSummary().Show();
        }
        private void CardNumText_TextChanged(object sender, EventArgs e)
        {
            NewCardInfo[0] = CardNumText.Text;
        }


        private void CardExpText_TextChanged(object sender, EventArgs e)
        {
            NewCardInfo[1] = CardExpText.Text;
        }


        private void CardPinText_TextChanged(object sender, System.EventArgs e)
        {
            NewCardInfo[2] = CardPinText.Text;
        }

    }
}