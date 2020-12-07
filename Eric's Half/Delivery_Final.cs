
namespace Software_Engineering
{
    public partial class Delivery_Final
    {
        public Delivery_Final()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, System.EventArgs e)
        {
            //If customer is guest
            //this.Hide();
            //new Delivery_Guest().Show();

            //If customer not is guest
            //this.Hide();
            //new Delivery().Show();
        }

        private void DoneButton_Click(object sender, System.EventArgs e)
        {
            //End program
        }

        private void CustomerNameText_TextChanged(object sender, System.EventArgs e)
        {
            //Retrieve customer name from file or object
        }

        private void PhoneNumberText_TextChanged(object sender, System.EventArgs e)
        {
            //Retrieve customer phone number from file or object
        }

        private void OrderNumberText_TextChanged(object sender, System.EventArgs e)
        {
            //Retrieve customer order number from file or object
        }

        private void DeliverNameText_TextChanged(object sender, System.EventArgs e)
        {
            //Retrieve deliverer name from file or object
        }

        private void DeliverAddrText_TextChanged(object sender, System.EventArgs e)
        {
            //NEEDS TO BE COMBINED WITH CUSTOMERADDRESSTEXT
            //Retrieve customer address from file or object
        }

        private void CustomerAddressText_Click(object sender, System.EventArgs e)
        {
            //Retrieve customer address from file or object
        }

        private void OrderedItemsText_Click(object sender, System.EventArgs e)
        {
            //Retrieve ordered items from file or object
        }

        private void TotalAmountText_Click(object sender, System.EventArgs e)
        {
            //Retrieve total amount for order from file or object
        }
    }
}