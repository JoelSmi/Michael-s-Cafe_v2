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
    public partial class Creating_an_Account_Screen2 : Form
    {

        private String Directory = Path.GetDirectoryName(Application.ExecutablePath).Substring(0, Path.GetDirectoryName(Application.ExecutablePath).IndexOf("bin"));
        string firstName;
        string lastName;
        string DOB;
        string gender;
        string email;
        string password;
        string retypePassword;


        public Creating_an_Account_Screen2(string firstName, string lastName, string DOB, string gender)
        {
            InitializeComponent();

            this.firstName = firstName;
            this.lastName = lastName;
            this.DOB = DOB;
            this.gender = gender;

        }
        


        public Creating_an_Account_Screen2()
        {
            InitializeComponent();
        }

        private void emailtextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            string userText = objTextBox.Text;
            email = userText;
        }

        private void passwordtextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            string userText = objTextBox.Text;
            password = userText;
        }

        private void reTypePasswordtextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            string userText = objTextBox.Text;
            retypePassword = userText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Directory = Path.GetDirectoryName(Application.ExecutablePath);
            Directory = Directory.Substring(0, Directory.IndexOf("bin"));
            string OpenFile = Directory + "\\Michael_Cafe.txt";

            //File manipulation to change the Active order to Placed
            string FileText = File.ReadAllText(OpenFile);
            if (!FileText.Contains(this.email))
            {
                if (email == null)
                {
                    MessageBox.Show("Email address is not entered.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else if (password == null)
                {
                    MessageBox.Show("Password is not entered.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else if (retypePassword == null)
                {
                    MessageBox.Show("Re-type your password to verify your password.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else if (password != retypePassword)
                {
                    MessageBox.Show("The password you typed is not matched with the re-type password.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                this.Close();
                new Creating_an_Account_Screen3(firstName, lastName, DOB, gender, email, password).Show();
            }
            else
            {
                MessageBox.Show("The email you gave is already connected to another account in our system, we are returning you to the main screen.\nYou may want to try logging in instead.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                new Form1().Show() ;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new Creating_an_Account_Screen().Show();
            Close();
        }
    }
}
