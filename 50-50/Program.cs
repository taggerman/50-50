using System;

namespace _50_50
{
    class Program
    {
        static void Main(string[] args)
        {
            int platWins = 0;
            int kroneWins = 0;
            int sideWins = 0;
            
            for (int j = 0; j < 100; j++)
            {
                int platCount = 0;
                int kroneCount = 0;
                int sideCount = 0;

                for (int i = 0; i < 10000; i++)
                {
                    int number = Random();

                    if (number < 50)
                    {
                        platCount++;
                        Console.WriteLine("plat");
                    }
                    else if (number > 50)
                    {
                        kroneCount++;
                        Console.WriteLine("krone");
                    }
                    else
                    {
                        sideCount++;
                        Console.WriteLine("side");
                    }
                }

                Console.WriteLine("antal plat: " + platCount);
                Console.WriteLine("antal krone: " + kroneCount);
                Console.WriteLine("antal side landning: " + sideCount);

                if (platCount > kroneCount)
                {
                    platWins++;
                    Console.WriteLine("plat wins!!!");
                }
                else if (kroneCount > platCount)
                {
                    kroneWins++;
                    Console.WriteLine("korne wins!!!");
                }
                else
                {
                    sideWins++;
                    Console.WriteLine("side wins!!!");
                }

            }
            Console.WriteLine("antal plat wins out of 100 " + platWins);
            Console.WriteLine("antal krone wins out of 100 " + kroneWins);
            Console.WriteLine("antal side wins out of 100 " + sideWins);
            if (platWins > kroneWins)
            {
                Console.WriteLine("out of 100 runs plat WINS!!!");
            }
            else if (kroneWins > platWins)
            {
                Console.WriteLine("out of 100 runs krone WINS!!!");
            }
            else
            {
                Console.WriteLine("out of 100 runs side WINS!!!");
            }
        }

        static int Random()
        {
            Random random = new Random();
            int number = random.Next(0, 101);
            return number;
        }

    }
}
