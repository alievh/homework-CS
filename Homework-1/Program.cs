using System;

namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 254324356;
            int sum = 0;

            while (number != 0)
            {
                number -= number % 10;
                number /= 10;
                sum++;
            }
            Console.WriteLine(sum);
        }
    }
}
