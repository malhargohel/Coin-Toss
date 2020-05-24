using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //number of tosses
            int limit = 9;
            //customize to u likeing 

            Coin myCoin = new Coin();

            int headsCount = 0;
            for (int i = 0; i < limit; i++)
            {
                // Toss the coin
                myCoin.toss();
                if (myCoin.getSideUp() == 0)
                {
                    headsCount++;
                }
            }
            // print the results
            Console.WriteLine("Heads count: " + headsCount);
            Console.WriteLine("Tails count: " + (limit - headsCount));
        }
    }
}
class Coin
{
    int sideUp;
    Random rnd = new Random();

    public void toss()
    {
        // Get a random value, 0 or 1.
        this.sideUp = rnd.Next(2);
    }
    public int getSideUp()
    {
        return sideUp;
    }
}
