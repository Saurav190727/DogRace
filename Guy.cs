using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace
{
    class Guy // players class , declare parameters for players and betting amount
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;
        public Guy(string name, int Cash, Label MyLabel, RadioButton guyButton)
        {
            Name = name;
            this.Cash = Cash;
            this.MyLabel = MyLabel;
            MyRadioButton = guyButton;
            MyBet = null;

        }
        public void UpdateLabels() // update details 
        {
            MyRadioButton.Text = Name + " has $ " + Cash + " ";
            if (MyBet == null) // if condition mybet is equal to null or 0 when message show for place the bet 
            {
                MyLabel.Text = "Please Place a Bet";
                
            }
            else
            {
                MyBet.Dog++;
                MyLabel.Text = Name + " place  $ " + MyBet.Amount + "  bet  on dog number " + MyBet.Dog;
            }


        }

        public void ClearBet() // clearbet function
        {
            MyBet = null;
        }

        public bool PlaceBet(int Amount, int Dog) // place bet on dog
        {
            MyBet = new Bet(Amount, Dog, this);
            UpdateLabels();
            return false;
        }

        public void Collect(int Winner) // winner 
        {
            Cash += MyBet.PayOut(Winner);
        }


    }
}
