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

        string firstName = "";
        string lastName = "";
        string DOB = "";
        string gender = "";
        string email = "";
        string password = "";
        string address = "";
        string infoAddress = "";
        string city = "";
        string state = "";
        string zipCode = "";
        string phoneNumber = "";

        public Creating_an_Account_Screen3(string firstName, string lastName, string DOB, string gender, string email, string password)
        {
            InitializeComponent();

            this.firstName = firstName;
            this.lastName =lastName;
            this.DOB =DOB;
            this.gender =gender;
            this.email =email;
            this.password = password;

        }



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

            string line1 = email + "," + password;
            string line2 = firstName + "," + lastName;
            string line3 = phoneNumber;
            string line4 = address + " " + infoAddress + "," + city + " - " + state + "." + zipCode;


            using (StreamWriter ab = new StreamWriter(@"" + Directory + "\\Michael_Cafe.txt", true))
            {
                ab.WriteLine("\n/" + line1 + "-LoggedIn" + "\n" + line2 + "\n" + line3 + "\n" + line4);
                ab.Close();
            }
            Directory = Path.GetDirectoryName(Application.ExecutablePath);
            Directory = Directory.Substring(0, Directory.IndexOf("bin"));
            string OpenFile = Directory + "\\Order.txt";

            //File manipulation to change the Active order to Placed
            string FileText = File.ReadAllText(Directory + "\\Order.txt");
            FileText = FileText.Replace("#End Of File#", "/"+ this.email + "-Pending\n\\\n" + "#End Of File#");
            File.WriteAllText(OpenFile, FileText);
            this.Hide();
            new Menu_Screen().Show();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new Creating_an_Account_Screen2(this.firstName,this.lastName,this.DOB,this.gender).Show();
            Close();
        }
    }
}
