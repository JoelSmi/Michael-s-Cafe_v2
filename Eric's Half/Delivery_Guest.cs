
namespace Software_Engineering
{
    public partial class Delivery_Guest
    {


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

        }

        private void LastNameText_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void PhoneNumberText_TextChanged(object sender, System.EventArgs e)
        {
           
        }

        private void StreetNameText_TextChanged(object sender, System.EventArgs e)
        {
            
        }

        private void AptNumText_TextChanged(object sender, System.EventArgs e)
        {
           
        }

        private void CityText_TextChanged(object sender, System.EventArgs e)
        {
          
        }

        private void StateText_TextChanged(object sender, System.EventArgs e)
        {
            
        }

        private void ZipText_TextChanged(object sender, System.EventArgs e)
        {
           
        }
    }
}