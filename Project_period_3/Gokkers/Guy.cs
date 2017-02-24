using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gokkers
{
    class Guy
    {
        public string name; 
        public Bet myBet;
        public int cash;

        public RadioButton myRadioButton;
        public Label myLabel;

        public Guy(string name, int cash, RadioButton myRadioButton, Label myLabel)
        {
            this.name = name;
            this.cash = cash;
            this.myRadioButton = myRadioButton;
            this.myLabel = myLabel;
        }

        public void UpdateLabel()
        {
            myLabel.Text = name + " heeft €" + myBet.amount + " gebied op zebra nummer " + myBet.zebra;
        }

        public bool PlaceBet(int amount, int zebra)
        {
            myBet = new Bet(amount, zebra, this);
            return true;
        }

        public void ClearBet()
        {

        }

        public void Collect(int winner)
        {

        }
    }
}
