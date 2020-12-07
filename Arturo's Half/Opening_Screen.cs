using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Directory = Path.GetDirectoryName(Application.ExecutablePath);
            Directory = Directory.Substring(0, Directory.IndexOf("bin"));
            string OpenFile = Directory + "\\Michael_Cafe.txt";

            //File manipulation to change the Active order to Placed
            string FileText = File.ReadAllText(OpenFile);
            FileText = FileText.Replace("LoggedIn", "LoggedOut");
            File.WriteAllText(OpenFile, FileText);

            OpenFile = Directory + "\\Order.txt";
            FileText = File.ReadAllText(OpenFile);
            FileText = FileText.Replace("Active", "Cancelled");
            File.WriteAllText(OpenFile, FileText);

            OpenFile = Directory + "\\Order.txt";
            FileText = File.ReadAllText(OpenFile);
            FileText = FileText.Replace("Pending", "Cancelled");
            File.WriteAllText(OpenFile, FileText);
        }
        private void loginbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Log_In_Screen().Show();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Creating_an_Account_Screen().Show();
        }
        private void GuestBtn_Click(object sender, EventArgs e)
        {
            string Directory = Path.GetDirectoryName(Application.ExecutablePath);
            Directory = Directory.Substring(0, Directory.IndexOf("bin"));
            string OpenFile = Directory + "\\Order.txt";

            //Adding a guest to the Order.txt and setting the order status to Pending
            string FileText = File.ReadAllText(OpenFile);
            FileText = FileText.Replace("#End Of File#", "/Guest-Pending\n\\\n" + "#End Of File#");
            File.WriteAllText(OpenFile, FileText);

            //Adding a gues to the Michael_Cafe.txt and setting their logged in status to LoggedIn
            OpenFile = Directory + "\\Michael_Cafe.txt";
            FileText = File.ReadAllText(OpenFile);
            FileText = FileText.Replace("#End Of File#", "/Guest-LoggedIn\n*\n$\n" + "#End Of File#");
            File.WriteAllText(OpenFile, FileText);

            this.Hide();
            new Menu_Screen().Show();
        }
    }
}
