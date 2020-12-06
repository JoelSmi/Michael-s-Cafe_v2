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

        private void Log_In_Screen_Load(object sender, EventArgs e)
        {

        }

        //Back Button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
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
                string line1 = null;
                string line2 = null;
                username = usernameTextBox1.Text;
                password = textBox1.Text;

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

                while ((line1 = ab.ReadLine()) != null)
                {
                    if (line1.Contains(username))
                    {
                        line2 = ab.ReadLine();
                        break;
                    }
                }





                if ((line1.Equals(username)) && (line2.Equals(password)))
                {
                    Console.WriteLine("Welcome");
                    this.Hide();
                    new Menu_Screen().Show();
                }

                else
                {
                    MessageBox.Show("Your login credentials don't match an account in our system.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                ab.Close();


            }
        }
    }
}
