using System;
namespace Game_Guess
{
    class Player
    {
        public int GuessNumber(int incognitive)
        {
            string value;
            bool testNumber;
            int number;
            do
            {
                Console.Write("Number: ");
                value = Console.ReadLine();
                testNumber = int.TryParse(value, out number);
                if (testNumber)
                {
                    if (number < incognitive)
                        Console.WriteLine("It isn't number. \nThe number's greater.");
                    else if (number > incognitive)
                        Console.WriteLine("It isn't number. \nThe number's less.");
                    else
                    {
                        Console.WriteLine("\n-------.-------.-------");                        
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Congratulation! The number is {0}", number);
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Please, digit a number");
                    Console.ResetColor();
                }
                    
            } while (testNumber != true);
            return number;
        }
    }
}
