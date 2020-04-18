using System;

namespace lab11
{
    class Program
    {
        static void Main(string[] args) {
            Complex complex = new Complex(2, 1);
            complex.ZeroDivide += ZeroDivide;
            Console.WriteLine(complex / new Complex(0,0));
            Console.WriteLine(Environment.NewLine);

            

            UnitTests.ComplexSum();
            UnitTests.ComplexSubtraction();
            UnitTests.ComplexMultiplication();
            UnitTests.ComplexDivide();
            UnitTests.ComplexPow();
            UnitTests.VectorSum();
            UnitTests.VectorOrthogonolization();
          
        }
        static void ZeroDivide(object sender, ZeroDivideEventArgs e) {
            Console.WriteLine($"something in division is not ok.  Blame them: {e._dividend} and {e._divider}");
        }
    }
}
