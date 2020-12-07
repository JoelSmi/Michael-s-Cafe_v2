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
    public partial class Creating_an_Account_Screen : Form
    {

        private String Directory = Path.GetDirectoryName(Application.ExecutablePath).Substring(0, Path.GetDirectoryName(Application.ExecutablePath).IndexOf("bin"));

        string firstName{ get; set; }
        string lastName { get; set; }
        string DOB { get; set; }
        string gender { get; set; }




        public Creating_an_Account_Screen()
        {
            InitializeComponent();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Creating_an_Account_Screen_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void firstNametextBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            string userText = objTextBox.Text;
            firstName = userText;
            
        }

        private void LastNametextBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            string userText = objTextBox.Text;
            lastName = userText;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            string userText = objTextBox.Text;
            DOB = userText;
        }

        private void gendertextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            string userText = objTextBox.Text;
            gender = userText;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (firstName == null)
            {

                MessageBox.Show("First name is not entered.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                


                return;

            }
            else if (lastName == null)
            {

                MessageBox.Show("Last Name is not entered.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if (DOB == null)
            {

                MessageBox.Show("Date of Birth is not entered.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }
            else if (gender == null)
            {

                MessageBox.Show("Gender is not entered.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;

            }



            if ((firstName != null) && (lastName != null) && (DOB != null) && (gender != null))
            {


                this.Hide();
                new Creating_an_Account_Screen2(firstName, lastName, DOB, gender).Show();
            }


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Close();
        }
    }


}
