using System;

namespace lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex = new Complex(1, 1, 0);
            Console.WriteLine(complex);
            int a = 5;
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a/b);
            
        }

        static void ZeroDivideHandler() {

        }
    }
}
