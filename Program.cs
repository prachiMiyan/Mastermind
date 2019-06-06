using System;

namespace Mastermind
{
    class MasterMind
    {
        private static String guessNum;
        private static String result = ""; // string containing + and -
        private static Boolean win = false;
        public static void Main(string[] args)
        {
            GenerateNum(); //guessNum generated

            Player P = new Player();
            while(P.chance < 10)
            {
                Console.WriteLine("Enter a number for chance " + (P.chance+1) + ": ");
                if (!P.TakeInput())
                    continue;
                result = Compare(P.input);
                if(result.Equals("++++"))
                {
                    win = true;
                    break;
                }
                Console.WriteLine(result);
            }

            if (win == true)
                Console.WriteLine("You have won!");
            else
                Console.WriteLine("You have lost. The number is " + guessNum + "!");
        }

        private static void GenerateNum() //generates a 4 digit random number as required and stores in guessNum
        {
            Random r = new Random();
            int i = 0, num = 0;
            while (i < 4)
            {
                num = r.Next(1, 7);
                guessNum = String.Concat(guessNum, num);
                ++i;
            }
            return;
        }

        private static String Compare(int input) //compares input with guessNum and returns result combination
        {
            String combo = "";
            Char[] guess1 = guessNum.ToCharArray();
            Char[] input1 = (input.ToString()).ToCharArray();
            int x = 4;

            for(int i = 0; i < x; ++ i) // to check corresponding numbers at same position
            {
                if (guess1[i] == input1[i])
                {
                    combo = String.Concat(combo, "+");
                    guess1[i] = '$';
                    input1[i] = '$';
                }
            }


            for (int i = 0; i < x; ++i) // to check if the guessed input number exists anywhere in the guesses number besides the same position
            {
                String guess2 = new String(guess1);

                if (input1[i] != '$' && guess2.IndexOf(input1[i])!= -1)
                {
                    combo = String.Concat(combo, "-");
                    int ind = guess2.IndexOf(input1[i]);
                    guess1[ind] = '$';
                }
            }
            return combo;
        }

    }
}
