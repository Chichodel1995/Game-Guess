using System;
namespace Game_Guess
{
    class Computer
    {
        int numberMin = 1;
        int numberMax = 20;
        public int GenerateNumber()
        {
            Random number = new Random();
            int incognitive = number.Next(1, 20);
            return incognitive;
        }
        public int GuessNumber(int incognitive)
        { 
            Random randomNumber = new Random();
            int aNumber = randomNumber.Next(numberMin, numberMax);
            if (aNumber < incognitive)
            {
                numberMin = aNumber;
                numberMin += 1;
            }
            else if (aNumber > incognitive)
            {
                numberMax = aNumber;
                numberMax -= 1; 
            }
            return aNumber;
        }
    }
}
