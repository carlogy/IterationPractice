using System;
namespace IterationPractice
{
    public class Factorials
    {
        public static void GetFactorial()
        {
            Console.Write("Enter a number: ");
            var input = Console.ReadLine();

            int number = 0;


            try
            {
                number = Int32.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number. Please enter a number.");
            }

            int factorial = number;
            number -= 1;

            for (int i = number; i > 0; i--)
            {
                factorial *= i;

            }
            Console.WriteLine($"{input}! =  {factorial}");
            Console.ReadLine();
        }
    }
}

