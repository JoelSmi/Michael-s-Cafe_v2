
namespace Software_Engineering
{
    public partial class Payment
    {
        private bool WithCashCheck;
        private bool WithCard;

        private string CardNum;
        private string CardExp;
        private string CardPin;
        public Payment()
        {
            WithCashCheck = false;
            WithCard = false;
            //Read card number from file if existing customer
            InitializeComponent();
        }

        private void CashButton_CheckedChanged(object sender, System.EventArgs e)
        {
            WithCashCheck = true;
            WithCard = false;
        }

        private void CheckButton_CheckedChanged(object sender, System.EventArgs e)
        {
            WithCashCheck = true;
            WithCard = false;
        }

        private void DefaultCardButton_CheckedChanged(object sender, System.EventArgs e)
        {
            WithCashCheck = false;
            WithCard = true;
        }

        private void BackButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();

            //Doesn't recognize Form1 for some reason
            //new Form1().Show();
        }

        private void NextButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();

            if(WithCard)
            {
                //Would love to change the spelling error but I don't think we'll have time lol - send customer to Receipt_Card
                new Reciept_Card().Show();
            }
            else if(WithCashCheck)
            {
                //Send customer to Receipt_Cash
                new Reciept_Cash().Show();
            }
            else
            {
                return;
            }
        }

        private void DiffCardButton_CheckedChanged(object sender, System.EventArgs e)
        {
            WithCashCheck = false;
            WithCard = true;
        }

        private void CardNumText_TextChanged(object sender, System.EventArgs e)
        {
            CardNum = CardNumText.Text;
        }

        private void CardExpText_TextChanged(object sender, System.EventArgs e)
        {
            CardExp = CardExpText.Text;
        }

        private void CardPinText_TextChanged(object sender, System.EventArgs e)
        {
            CardPin = CardPinText.Text;
        }

    }
}