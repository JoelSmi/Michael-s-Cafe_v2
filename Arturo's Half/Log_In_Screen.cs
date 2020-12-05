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
        string password;

        public Log_In_Screen()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            string userText = objTextBox.Text;
            username = userText;
        }
        
        

        private void Log_In_Screen_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            string passText = objTextBox.Text;
            password = passText;

        }



        private void loginbutton_Click(object sender, EventArgs e)
        {
            using (StreamReader ab = new StreamReader(@"" + Directory + "\\Michael_Cafe.txt"))
            {
                string line1 = ab.ReadLine();
                string line2 = ab.ReadLine();
                



                while ((line1 != null) && (line2 != null))
                {
                    if ((line1 == username) && (line2 == password))
                    {
                        Console.WriteLine("Welcome");
                        this.Hide();
                        new Menu_Screen().Show();
                        break;
                        
                    }
                    else
                    {
                        MessageBox.Show("Your login credentials don't match an account in our system.", "Login Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        username = null;
                        password = null;
                        break;
                    }

                }
                ab.Close();
                

            }



        }

        private void passwordLbl_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }
    }
}
