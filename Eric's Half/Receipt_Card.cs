﻿
namespace Software_Engineering
{
    public partial class Reciept_Card
    {
        string CustomerSignature;
        public Reciept_Card()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, System.EventArgs e)
        {
            //If Customer is Guest
            //this.Hide();
            //new Payment_Guest().Show();

            //If Customer is not Guest
            //this.Hide();
            //new Payment().Show();
        }

        private void DeliveryButton_Click(object sender, System.EventArgs e)
        {
            //If Customer is Guest
            //this.Hide();
            //new Delivery_Guest().Show();

            //If Customer is not Guest
            //this.Hide();
            //new Delivery().Show();
        }

        private void PrintButton_Click(object sender, System.EventArgs e)
        {
            //Don't know what to put here. Maybe just remove print button?
        }

        private void CarryoutButton_Click(object sender, System.EventArgs e)
        {
            //End program
        }

        private void OrderNumberText_TextChanged(object sender, System.EventArgs e)
        {
            //Retrieve order number from file or customer object and display
        }

        private void CustomerNameText_TextChanged(object sender, System.EventArgs e)
        {
            //Retrieve customer name from file or customer object and display
        }

        private void SignatureText_TextChanged(object sender, System.EventArgs e)
        {
            CustomerSignature = SignatureText.Text;
        }
    }
}