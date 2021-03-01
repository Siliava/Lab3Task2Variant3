using System;

namespace Lab3Task2Variant3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter eps");
            double eps = double.Parse(Console.ReadLine());
            double term = 1;
            double sum = 0;
            int n = 0;
            while (true)
            {
                term = 1 / (Math.Pow(4, n) + Math.Pow(5, n + 2));
                n++;
                if (n > eps)
                    sum += term;
                Console.WriteLine(sum);
                Console.ReadKey();
            }
        }
             
        
    }
}
