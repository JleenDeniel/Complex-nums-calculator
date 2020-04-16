using System;

namespace lab11
{
    class Program
    {
        static void Main(string[] args) {
            //говнистые случаи: (1,1) / 10.11
            Complex complex = new Complex(2, 1);
            double a = 10.11;
            Complex c = new Complex(1, 0);
            complex.ZeroDivide += ZeroDivide;
            Console.WriteLine(Complex.Pow(complex, 2));
        }
        static void ZeroDivide(object sender, ZeroDivideEventArgs e) {
            Console.WriteLine($"something in {sender} is not ok.  Blame him: {e._divider}");
        }
    }
}
