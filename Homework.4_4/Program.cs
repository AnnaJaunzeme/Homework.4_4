using System;

namespace Homework._4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = new int[] { 12, 223, 3343, 45345, 23423, 23, 1112, 456, 33, 1 };

            int[] Array2 = new int[10];

            Array1.CopyTo(Array2, 0);
            Console.WriteLine("Array1: ");

            foreach (var number1 in Array1)
            {
                Console.WriteLine(number1);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Array2: ");

            foreach (var number2 in Array2)
            {
                Console.WriteLine(number2);
            }
                       
            Console.ReadKey();
        }
    }
}
