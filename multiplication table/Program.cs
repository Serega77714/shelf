using System;

namespace multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insert the number");
            int num = Convert.ToInt32(Console.ReadLine());
            Mult(num);
            Console.ReadKey();
        }

        static void Mult(int num)
        {
            for (int i = 1; i < 10; i++)
            {
                int a = num * i;
                Console.WriteLine($"{num}*{i}={a}");
                
            }
        }
            }
}
