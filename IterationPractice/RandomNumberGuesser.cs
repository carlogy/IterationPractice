using System;
namespace IterationPractice
{
    public class RandomNumberGuesser
    {
        public static void GuessRandomInt()
        {
            Random random = new Random();
            int compRandom = random.Next(1, 10);
            int Number = 0;

            var i = 0;

            Console.WriteLine("Let's guess the number the computer has saved!");
            for (i = 0; i < 4; i++)
            {
                Console.Write("Enter a number between 1 and 10: ");

                var input = Console.ReadLine();


                try
                {
                    Number = Convert.ToInt32(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input enterd. Please enter a number.");
                }


                if (i != 4 && compRandom == Number)
                {
                    Console.WriteLine($"You guessed {Number}, You won!");
                    break;
                }
                else if (i != 4 && compRandom != Number)
                {
                    continue;
                }


            }
            if (i == 4 && compRandom != Number)
            {
                Console.WriteLine("You lost! Better luck next time.");
            }

        }
    }
}

