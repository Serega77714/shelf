using System;

namespace Delegate
{
    class Program
    {
        delegate int _Sum(int x, int y);
        static void Main(string[] args)
        {


            int Summ(int x, int y) => x + y;
            int Mult(int x, int y) => x * y;

            _Sum sum;
            Console.WriteLine("enter operation");
            var s = Console.ReadLine();
            if (s == "*")
                sum = Mult;
            else
            if (s == "+")
                sum = Summ;
            else
                Console.WriteLine("incorrect value");

            int result = sum(5, 6);
            Console.WriteLine(result);
        }
}
