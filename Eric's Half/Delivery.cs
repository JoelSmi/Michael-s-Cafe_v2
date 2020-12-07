
namespace Software_Engineering
{
    public partial class Delivery
    {
        private string PhoneNumber, StreetName, AptNum, City, State, Zip;


        public Delivery()
        {
            InitializeComponent();
        }

        private void DefaultAddButton_CheckedChanged(object sender, System.EventArgs e)
        {
            //Keep address info the same
        }
        private void DiffAddButton_CheckedChanged(object sender, System.EventArgs e)
        {
            //Set address info to info provided by user
        }

        private void BackButton_Click(object sender, System.EventArgs e)
        {
            //If paying with card
            //this.Hide();
            //new Reciept_Card().Show();

            //If not paying with card
            //this.Hide();
            //new Reciept_Cash().Show();
        }

        private void NextButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            new Delivery_Final().Show();
        }

        private void PhoneNumberText_TextChanged(object sender, System.EventArgs e)
        {
           //Retrieve customer phone number from file or object
        }

        private void CustomerNameText_TextChanged(object sender, System.EventArgs e)
        {
            //Retrieve customer name from file or object
        }

        private void CustomerAddressText_Click(object sender, System.EventArgs e)
        {
            //Display customer address from file or obejct
        }

        private void PhoneNumberText_TextChanged_1(object sender, System.EventArgs e)
        {
            PhoneNumber = PhoneNumberText.Text;
        }

        private void StreetNameText_TextChanged(object sender, System.EventArgs e)
        {
            StreetName = StreetNameText.Text;
        }

        private void AptNumText_TextChanged(object sender, System.EventArgs e)
        {
            AptNum = AptNumText.Text;
        }

        private void CityText_TextChanged(object sender, System.EventArgs e)
        {
            City = CityText.Text;
        }

        private void StateText_TextChanged(object sender, System.EventArgs e)
        {
            State = StateText.Text;
        }

        private void ZipText_TextChanged(object sender, System.EventArgs e)
        {
            Zip = ZipText.Text;
        }
    }
}