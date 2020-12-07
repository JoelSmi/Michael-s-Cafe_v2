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
        string PhoneLine;
        public Delivery()
        {
            InitializeComponent();
        }

        private void Delivery_Load_1(object sender, EventArgs e)
        {
            Directory = Path.GetDirectoryName(Application.ExecutablePath);
            string OpenFile = Directory.Substring(0, Directory.IndexOf("Eric's Half")) + "Arturo's Half\\Michael_Cafe.txt";
            StreamReader sr = new StreamReader(OpenFile);
            string CurrLine = sr.ReadLine();

            while (!CurrLine.Contains("#End Of File#"))
            {
                if (CurrLine.Contains("LoggedIn"))
                {
                    CurrLine = sr.ReadLine();
                    NameArray = CurrLine.Split(',');
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

        private void NextButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            new Delivery_Final().Show();
        }

        private void StreetNameText_TextChanged(object sender, System.EventArgs e)
        {
           
        }

        private void AptNumText_TextChanged(object sender, System.EventArgs e)
        {
           
        }

        private void CityText_TextChanged(object sender, System.EventArgs e)
        {
            
        }

        private void StateText_TextChanged(object sender, System.EventArgs e)
        {
            
        }

        private void ZipText_TextChanged(object sender, System.EventArgs e)
        {
            
        }
    }
}