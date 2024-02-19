using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceLibC_
{
    public class DiceLib
    {
        //coin fip, 50/50, 0 = heads, 1 = tails
        public int CoinFlip()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 2);
            return randInt;
        }

        public int DiceFour()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 4);
            return randInt;
        }

        public int DiceSix()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 6);
            return randInt;
        }

        public int DiceEight()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 8);
            return randInt;
        }

        public int DiceTwelve()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 12);
            return randInt;
        }

        public int DiceTwenty()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 20);
            return randInt;
        }

        public int Dice100()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 100);
            return randInt;
        }
    }
}
