using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace
{
    public partial class Form1 : Form
    {
        Guy[] guys = new Guy[3];
        Greyhound[] dogs = new Greyhound[4];
        Boolean win = false;
        int winner = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Dog2_Click(object sender, EventArgs e)
        {

        }
        private bool haveTheyBet()
        {
            for (int i = 0; i < 3; i++)
            {
                if (guys[i].MyBet == null)
                {
                    return false;
                }
            }
            return true;
        }


        private void Race_Click(object sender, EventArgs e)
        {
            if (haveTheyBet())
            {
                timer1.Enabled = true;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("" +
                    "Please place the bet first!");
            }
        }

        private void timer1_tick(object sender, EventArgs e)
        {

            for (int i = 0; i < 4 && win == false; i++)
            {
                win = dogs[i].Run();
                if (win)
                {
                    timer1.Stop();
                    timer1.Enabled = false;
                    winner = i;
                    int dnumber = winner + 1;
                    for (int j = 0; j < 3; j++)
                    {
                        guys[j].Collect(winner);
                        guys[j].ClearBet();
                        guys[j].UpdateLabels();

                    }
                    MessageBox.Show("Dog " + dnumber + " Win the Race!!");
                    break;
                }
            }



        }

        private void reset_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 4; i++)
            {
                dogs[i].TakeStartingPosition();
            }
            win = false;
        }

        private void betsButton_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 3; i++)
            {
                if (guys[i].MyRadioButton.Checked)
                {
                    guys[i].MyLabel.Text = guys[i].Name + " has bet " + betNumeric.Value;
                    int val1, val2;
                    val1 = Convert.ToInt16(betNumeric.Value);
                    val2 = Convert.ToInt16(dogNumberNumeric.Value) - 1;
                    guys[i].PlaceBet(val1, val2);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            guys[0] = new Guy("Joe", 50, JoeLabel, JoeRadio);
            guys[1] = new Guy("Al", 50, AlLabel, AlRadio);
            guys[2] = new Guy("Bob", 50, BobLabel, BobRadio);

            guys[0].UpdateLabels();
            guys[1].UpdateLabels();
            guys[2].UpdateLabels();
            Random ran = new Random();
            dogs[0] = new Greyhound(Dog1, ran);
            dogs[1] = new Greyhound(Dog2, ran);
            dogs[2] = new Greyhound(Dog3, ran);
            dogs[3] = new Greyhound(Dog4, ran);
           
        }

        private void radioclicked(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (guys[i].MyRadioButton.Checked)
                {
                    betNumeric.Value = 5;
                    betNumeric.Maximum = guys[i].Cash;
                  
                    NameOfBettorLabel.Text = guys[i].Name;
                }
            }

            MinimumBetLabel.Text = "Min Bet: $ " + betNumeric.Maximum + " ";
        }

        private void JoeLabel_Click(object sender, EventArgs e)
        {

        }

        private void MinimumBetLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NameOfBettorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
