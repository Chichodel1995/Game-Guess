using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.StartGame();
            Console.ReadKey();
        }
    }
}
