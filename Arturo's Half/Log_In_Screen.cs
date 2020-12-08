using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Log_In_Screen : Form
    {
        private String Directory = Path.GetDirectoryName(Application.ExecutablePath).Substring(0, Path.GetDirectoryName(Application.ExecutablePath).IndexOf("bin"));
        string username;
        string fileUsername;
        string password;
        string filePassword;

        public Log_In_Screen()
        {
            InitializeComponent();
            
        }

        private void Log_In_Screen_Load(object sender, EventArgs e)
        {

        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }

        private void loginbutton_Click_1(object sender, EventArgs e)
        {
            using (StreamReader ab = new StreamReader(@"" + Directory + "\\Michael_Cafe.txt"))
            {
                username = usernameTextBox1.Text.Trim() ;
                password = textBox1.Text.Trim();

                if (usernameTextBox1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Username is not entered.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (textBox1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Password is not entered.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string CurrLine = ab.ReadLine();
                while (!CurrLine.Equals("#End Of File#")) {
                    if (CurrLine.Contains("LoggedOut") && !CurrLine.Contains("Guest"))
                    {
                        fileUsername = CurrLine.Substring(CurrLine.IndexOf("/") + 1, CurrLine.IndexOf(",")-1); ;
                        filePassword = CurrLine.Substring(CurrLine.IndexOf(",") + 1, (CurrLine.IndexOf("-") - CurrLine.IndexOf(",")-1));
                        usernameTextBox1.Text = fileUsername;
                        textBox1.Text = filePassword;
                       if ((fileUsername.Equals(username)) && (fileUsername.Equals(password)))
                        {
                            ab.Close();
                            string OpenFile = Directory + "\\Michael_Cafe.txt";
                            string FileText = File.ReadAllText(OpenFile);
                            FileText = FileText.Replace("LoggedOut", "LoggedIn");
                            File.WriteAllText(OpenFile, FileText);
                            this.Hide();
                            new Menu_Screen().Show();
                            break;
                        }
                    }
                    CurrLine = ab.ReadLine();
                    if (CurrLine.Equals("#End Of File#"))
                    {
                        MessageBox.Show("Your login credentials don't match an account in our system.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ab.Close();
                    }
                }
                


            }
        }
    }
}
