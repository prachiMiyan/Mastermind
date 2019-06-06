using System;

namespace Mastermind
{
    class Player
    {
        public int chance;
        public int input;

        public Player()
        {
            chance = 0;
            input = 0;
        }

        public Boolean TakeInput()
        {
            String inputStr = Console.ReadLine();
            if(inputStr.Length != 4) // to check if the input has 4 characters
            {
                Console.WriteLine("Input must be 4 digits long. Try again!");
                return false;
            }

            if (int.TryParse(inputStr, out input)) // to check if the input is all numbers 
            {
                int rangeInt = input;
                for(int i = 0; i< 4; ++i) // to check that all digits in the input lie between 1 and 6
                {
                    int num = rangeInt / ((Int32)Math.Pow(10, 4 - i - 1));
                    rangeInt = rangeInt % ((Int32)Math.Pow(10, 4 - i - 1));
                    if (num < 1 || num > 6)
                    {
                        Console.WriteLine("Digits must be within the range of 1 and 6. Try again!");
                        return false;
                    }
                }
                ++chance;
            }
            else // if the input is not an int convertible
            {
                Console.WriteLine("Input must be a number. Try again!");
                return false;
            }
            return true;
        }
    }
}
