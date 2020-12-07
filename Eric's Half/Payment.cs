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
        private string Directory = Path.GetDirectoryName(Application.ExecutablePath);
        string AccountInfo = "",ChangedAccounInfo;
        string CardInfo;
        string[] NewCardInfo = {"","",""};

        public Payment()
        {
            WithCashCheck = false;
            WithCard = false;
            InitializeComponent();
        }
        private void Payment_Load_1(object sender, EventArgs e)
        {
            Directory = Path.GetDirectoryName(Application.ExecutablePath);
            string OpenFile = Directory.Substring(0, Directory.IndexOf("Eric's Half")) + "Arturo's Half\\Michael_Cafe.txt";
            StreamReader sr = new StreamReader(OpenFile);
            string CurrLine = sr.ReadLine(), PaymentLine = CurrLine;
            while (!CurrLine.Contains("#End Of File#"))
            {
                if (CurrLine.Contains("LoggedIn"))
                {
                    AccountInfo += CurrLine;
                    CurrLine = sr.ReadLine();
                    break;
                }
                else
                {
                    CurrLine = sr.ReadLine();
                }
            }
            while (!CurrLine.Contains("/"))
            {
                PaymentLine = CurrLine;
                AccountInfo += "\n" + CurrLine;
                CurrLine = sr.ReadLine();
            }
            if (PaymentLine.Length < 5)
            {
                MaskedCardNo.Text = "No card in our system";
            }
            else
            {
                CardInfo = AccountInfo.Substring(AccountInfo.IndexOf("$") + 1);
                MaskedCardNo.Text = CardInfo.Substring(0, CardInfo.IndexOf(","));
            }
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
                    FileText = FileText.Replace(AccountInfo,ChangedAccounInfo);
                    File.WriteAllText(OpenFile, FileText);
                }
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
        private void CardNumText_TextChanged(object sender, System.EventArgs e)
        {
            NewCardInfo[0] = CardNumText.Text;
        }

        private void CardExpText_TextChanged(object sender, System.EventArgs e)
        {
            NewCardInfo[1] = CardExpText.Text;
        }

        private void CardPinText_TextChanged(object sender, System.EventArgs e)
        {
            NewCardInfo[2] = CardPinText.Text;
        }

    }
}