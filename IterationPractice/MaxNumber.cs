using System;
namespace IterationPractice
{
    public class MaxNumber
    {
        public static void MaxNumberInput()
        {
            Console.Write("Enter a series of numbers separated by a coma: ");
            var input = Console.ReadLine();

            string[] numbers = input.Split(separator: ", ");
            List<int> NumbersList = new List<int>();


            foreach (var number in numbers)
            {

                try
                {
                    NumbersList.Add(Convert.ToInt32(number));

                }

                catch (FormatException)
                {
                    Console.WriteLine("Invalid inputs");
                }


            }
            Console.WriteLine(NumbersList.Max());
            Console.Read();
        }

    }
}

