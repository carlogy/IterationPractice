using System;
namespace IterationPractice
{
    public class NumberPrompt
    {
        public static void PromptForANumber()
        {

            int SumOfInputs = 0;
            int NumberEntered;



            while (true)
            {

                Console.Write("Enter a number, when done enter ok: ");
                var input = Console.ReadLine();


                if (input != "ok")
                {
                    NumberEntered = Convert.ToInt32(input);
                    SumOfInputs += NumberEntered;
                    continue;
                }
                else if (input == "ok")
                {
                    Console.WriteLine(SumOfInputs);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    break;
                }



            }

        }

    }
}

