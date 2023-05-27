using System;
namespace IterationPractice
{
    public class DivisibleThree
    {
        public static void DivisibleBythree()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}

