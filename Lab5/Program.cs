using System;

namespace Lab5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus Casino!");

            bool run = true;
            while (run == true)
            {
                run = Roll();

                Console.WriteLine("How many sides should each die have?");
                int Sides = Int32.Parse(Console.ReadLine());

                Random rng = new Random();
                int min = 1;
                int max = Sides;

                Console.WriteLine("Roll 1:");
                int i = 0;
                while (i < 1)
                {
                    Console.WriteLine(rng.Next(min, max));
                    i++;
                    Console.WriteLine(rng.Next(min, max));
                    i++;
                }

                run = Continue();
            }

        }
        
        public static bool Roll()
        {
            Console.WriteLine("Roll the dice? (y/n)");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
            }
            else if (input == "n")
            {
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Roll();
            }
            return goOn;
        }

        public static bool Continue()
        {
            Console.WriteLine("Want to play again? (y/n)");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
            }
            else if (input == "n")
            {
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }
            return goOn;
        }

    }
}
