using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DogRace
{
    class Greyhound   // greyhound class 
    {
        public int StartingPosition = 20; // starting position for dogs
        public int RacetrackLength = 750; // finish line 
        public PictureBox MyPictureBox = null; // dog pictures
        public int Location = 0;
        public Random ran; // random speed

        public Greyhound(PictureBox picture, Random r)
        {
            MyPictureBox = picture;
            this.ran = r;
        }

        public bool Run() // run function where dogs run randomly
        {
            int step = ran.Next(2,5) + 4;
            Point p = MyPictureBox.Location;
            p.X += step;
            MyPictureBox.Location = p;
            if (p.X >= RacetrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void TakeStartingPosition()
        {
            Point p = MyPictureBox.Location;
            p.X = StartingPosition;
            MyPictureBox.Location = p;
        }
    }
}
