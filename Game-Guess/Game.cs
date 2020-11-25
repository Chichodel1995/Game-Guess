using System;
namespace Game_Guess
{
    class Game
    {
        Player player;
        Computer computer;
        Life life;
        public void PlayerVsComputer()
        {
            player = new Player();
            computer = new Computer();
            life = new Life();
            int incognitive = computer.GenerateNumber();
            int number;
            Console.Clear();
            Console.WriteLine("Welcome to Player vs Computer");
            Console.WriteLine("------------.------------.------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Life: {0}", life.Count);
            Console.ResetColor();
            Console.WriteLine("What do you think the hidden number is?");
            do
            {
                number = player.GuessNumber(incognitive);
                if (number != incognitive)
                {
                    life.Count -= 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Life: {0}", life.Count);
                    Console.ResetColor();
                }
                    
                if (life.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Game Over");
                } 
            } while (number != incognitive && life.Count != 0);
            Console.ReadKey();
            Console.Clear();
        }
        public void ComputerVsPlayer()
        {
            player = new Player();
            computer = new Computer();
            life = new Life();
            int number;
            Console.Clear();
            Console.WriteLine("Welcome to Computer vs Player.");
            Console.WriteLine("------------.------------.------------");
            Console.Write("Please, digit the number incognitive.\nIncognitive: ");
            int incognitive = int.Parse(Console.ReadLine());
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Life: {0}", life.Count);
                Console.ResetColor();
                Console.WriteLine("What do you think is the computer number?");
                number = computer.GuessNumber(incognitive);
                Console.Write("Number: {0}", number);
           
                if (number != incognitive)
                {
                    life.Count -= 1;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("\n-------.-------.-------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congratulation! The number is {0}", number);
                }
                if (life.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Life: {0}", life.Count);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Game Over");
                }
            } while (number != incognitive && life.Count != 0);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
