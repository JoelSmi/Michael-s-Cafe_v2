using System;
using System.Windows.Forms;

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu_Screen().Show();
        }
    }
}
