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
        string email;
        string password;
        string retypePassword;
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
            this.Hide();
            new Creating_an_Account_Screen3().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            new Creating_an_Account_Screen().Show();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new Creating_an_Account_Screen().Show();
            Close();
        }
    }
}
