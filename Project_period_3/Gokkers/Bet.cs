using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gokkers
{
    class Bet
    {
        public int amount;
        public int zebra;
        public Guy bettor;

        public Bet(int amount, int zebra, Guy bettor)
        {
            this.amount = amount;
            this.zebra = zebra;

            this.bettor = bettor;
        }

        public string GetDescription()
        {
            return "hello";
        }

        public void PayOut(int winner)
        {
            if (zebra == winner)
            {
                bettor.cash += amount;
            }

            else
            {
                bettor.cash -= amount;
            }
        }
    }
}
