using System;

namespace DevBuildLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Requirements:
             * 1.0 Prompt the user to provide integer (good spot for a user input method!)
             *      1.1 Challenge #1 Reject any submissions of 0 or negative numbers in the input.  Keep prompting the user until a valid response is given
             *      1.2 Challenge #3 Limit the user to only provide an int whose cubed value can still fit in the int variable.  See below for the math.
             * 2.0 Calculate the square and cube of numbers 1 to {input}
             * 3.0 Display the integer values of 1 to {input}, their square and their cube in a table.
             *      3.1 Challenge #2 format the strings to be right-aligned in the columns displayed.
             * 4.0 Ask the user if they want to start this again ('continue' loop method!)
            
            //Challenge#3 int32 can store up to 2,147,483,647 - extra step is asking if you can limit the user's # to what can be contained in an int.
            //Actually calculated this in the program, instead of using 1290!
            */

            bool goOn = true;
            int maxInt = Convert.ToInt32(Math.Cbrt(int.MaxValue));

            Console.WriteLine("Learn your squares and cubes!\n");
            
            while (goOn == true)
            {
                string userNum = GetInput("Enter an integer: ");
                int userInt = int.Parse(userNum);

                if (userInt > 0 && userInt <= maxInt)
                {
                    Console.WriteLine(String.Format("{0,10} {1,20} {2,20}", "Number", "Squared", "Cubed"));
                    Console.WriteLine(String.Format("{0,10} {1,20} {2,20}","======", "=======", "====="));

                    for (int i = 1; i <= userInt; i++)
                    {
                        Console.WriteLine($"{i,10} {GetSquare(i),20}{GetCube(i),20}");
                    }
                }
                else if (userInt <= 0)
                {
                    Console.WriteLine("I'm sorry, but we need a number greater than zero.");
                }
                else if (userInt > maxInt)
                {
                    Console.WriteLine("I'm sorry, but that number is too large.  Try a 'long' variable program instead.");
                }
                goOn = ContinueLoop();
            }
        }
        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();

            return output;
        }
        public static bool ContinueLoop()
        {
            string answer = GetInput("Would you like to continue?  Y/N");
            if (answer.ToLower() == "y")
            {
                return true;
            }
            else if (answer == "n" || answer == "N")
            {
                Console.WriteLine("OK, goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("I'm sorry, I didn't catch that.\nLet's try that again.");
                return ContinueLoop();
            }
        }
        public static int GetSquare(int userInt)
        {
            int userSquared = (userInt * userInt);
            
            return userSquared;
        }
        public static int GetCube(int userInt)
        {
            int userCubed = (userInt * userInt * userInt);

            return userCubed;
        }
        
    }
}
