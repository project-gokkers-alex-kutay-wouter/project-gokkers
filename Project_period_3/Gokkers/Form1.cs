using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gokkers
{
    public partial class Form1 : Form
    {
        public int racing = 23;
        public int finish = 838;
        public int winner;
        
        Guy[] guys;
        PictureBox[] zebraArray;

        public Form1()
        {
            InitializeComponent();
            guys = new Guy[]
            {
                new Guy("sietse", 25, rbtn_sietse,bet_status_Sieste),
                new Guy("lidy", 25, rbtn_Lidy, bet_status_Lidy),
                new Guy("fer", 25, rbtn_fer, bet_status_Fer)
            };
            zebraArray = new PictureBox[]
            {
                    Zebra1,
                    Zebra2,
                    Zebra3,
                    Zebra4,
                    Zebra5
            };
        }

        private void Value_bet_ValueChanged(object sender, EventArgs e)
        {
            Value_bet.Maximum = 15;
            Value_bet.Minimum = 5;
        }

        private void Zebra_num_ValueChanged(object sender, EventArgs e)
        {
            Zebra_num.Maximum = 5;
            Zebra_num.Minimum = 1;
        }

        private void zebra1_Click(object sender, EventArgs e)
        {
        }
            
        public void btn_run_Click(object sender, EventArgs e)
        {
            tmr_run_Zebra.Start();
            
        }



        public Random rnd = new Random();
        private int i;
        
        private void tmr_run_Zebra_Tick(object sender, EventArgs e)
        {
            


            for (int i = 0; i < zebraArray.Length; i++)
            {
                if (racing <= finish)
                {
                    int speed = rnd.Next(1, 4);
                    int pos_y = 0 + (i * 65);

                    

                    racing += speed;
                    zebraArray[i].Location = new Point(racing, pos_y);
                }
                else 
                {
                    winner = i;

                    if (!(guys[0].myBet == null))
                    {
                        guys[0].myBet.PayOut(winner);
                    }

                    if (!(guys[1].myBet == null))
                    {
                        guys[1].myBet.PayOut(winner);
                    }

                    if (!(guys[2].myBet == null))
                    {
                        guys[2].myBet.PayOut(winner);
                    }

                    balans_Sieste.Text = guys[0].name + " heeft €" + guys[0].cash;
                    balans_Sieste.Refresh();
                    balans_Lidy.Text = guys[1].name + " heeft €" + guys[1].cash;
                    balans_Lidy.Refresh();
                    balans_Fer.Text = guys[2].name + " heeft €" + guys[2].cash;
                    balans_Fer.Refresh();

                    tmr_run_Zebra.Stop();

                    i = 6;

                }

                if (i == 3)
                {
                    Rain rain = new Rain();
                    rain.rain();
                }
            }
        }

        private void btn_bet_Click(object sender, EventArgs e)
        {
            if (rbtn_sietse.Checked)
            {
                guys[0].PlaceBet((int)Value_bet.Value, (int)Zebra_num.Value);
                guys[0].UpdateLabel();
                
            }

            if (rbtn_Lidy.Checked)
            {
                guys[1].PlaceBet((int)Value_bet.Value, (int)Zebra_num.Value);
                guys[1].UpdateLabel();

            }

            if (rbtn_fer.Checked)
            {
                guys[2].PlaceBet((int)Value_bet.Value, (int)Zebra_num.Value);
                guys[2].UpdateLabel();
            }
        }

        private void balans_Fer_Click(object sender, EventArgs e)
        {
        }

        private void bet_status_Sieste_Click(object sender, EventArgs e)
        {
            //guys[0].UpdateLabel();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < zebraArray.Length; i++)
            {
                int pos_y = 0 + (i * 65);
                zebraArray[i].Location = new Point(23,pos_y);
                racing = 23;
            }
        }
    }
}
