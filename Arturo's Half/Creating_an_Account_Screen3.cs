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
    public partial class Creating_an_Account_Screen3 : Form
    {
        private String Directory = Path.GetDirectoryName(Application.ExecutablePath).Substring(0, Path.GetDirectoryName(Application.ExecutablePath).IndexOf("bin"));

        
        string address;
        string infoAddress;
        string city;
        string state;
        string zipCode;
        string phoneNumber;
        public Creating_an_Account_Screen3()
        {
            InitializeComponent();
        }

        private void AddresstextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            string userText = objTextBox.Text;
            address = userText;
        }

        private void CitytextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            string userText = objTextBox.Text;
            infoAddress = userText;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            string userText = objTextBox.Text;
            city = userText;
        }

        private void statetextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            string userText = objTextBox.Text;
            state = userText;
        }

        private void zipCodetextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            string userText = objTextBox.Text;
            zipCode = userText;
        }

        private void phoneNumbertextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            string userText = objTextBox.Text;
            phoneNumber = userText;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Creating_an_Account_Screen2().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (address == null)
            {
                MessageBox.Show("Address is not entered.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if (city == null)
            {
                MessageBox.Show("City is not entered.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if (state == null)
            {
                MessageBox.Show("State is not entered.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if (zipCode == null)
            {
                MessageBox.Show("Zip code is not entered.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if (phoneNumber == null)
            {
                MessageBox.Show("Phone Number is not entered.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            using (StreamWriter ab = new StreamWriter(@"" + Directory + "\\Michael_Cafe.txt", true))
            {
                ab.WriteLine("\nCustomer Name: ");
                ab.Close();
            }


            this.Hide();
            new Form1().Show();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new Creating_an_Account_Screen2().Show();
            Close();
        }
    }
}
