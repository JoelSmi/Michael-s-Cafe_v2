
namespace Software_Engineering
{
    public partial class Delivery_Guest
    {
        private string FirstName, LastName, PhoneNumber, StreetName, AptNum, City, State, Zip;

        public Delivery_Guest()
        {
            InitializeComponent();
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

        private void FirstNameText_TextChanged(object sender, System.EventArgs e)
        {
            FirstName = FirstNameText.Text;
        }

        private void LastNameText_TextChanged(object sender, System.EventArgs e)
        {
            LastName = LastNameText.Text;
        }

        private void PhoneNumberText_TextChanged(object sender, System.EventArgs e)
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