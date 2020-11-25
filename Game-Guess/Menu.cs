using System;

namespace Game_Guess
{
    class Menu
    {
        Game game = new Game();
        public void StartGame()
        {
            string value = null;
            Console.WriteLine("¡Welcome to the game!");
            do
            {
                Console.WriteLine("¡Choose an option to play!");
                Console.WriteLine("(1) Player vs Computer.\n(2) Computer vs Player.\n(3) Exit game.");
                Console.Write("Option: ");
                value = Console.ReadLine();
                bool testOption = int.TryParse(value, out int option);
                if (testOption)
                {
                    switch (option)
                    {
                        case 1:
                            game.PlayerVsComputer();
                            break;
                        case 2:
                            game.ComputerVsPlayer();
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Clear();
                            Console.WriteLine("Good bye! Come back soon!");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("Please, write the number 1, 2 or 3.");
                            Console.ResetColor();
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Please, write the number 1, 2 or 3.");
                    Console.ResetColor();
                }
                Console.ResetColor();
            } while (value != "3");      
        }
    }
}
