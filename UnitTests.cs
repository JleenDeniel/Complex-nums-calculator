using System;
using System.Collections.Generic;
using System.Text;

namespace lab11 {
    public static class UnitTests {

        public static void ComplexSum() {
            Complex c1 = new Complex(3, 4);
            Complex c2 = new Complex(5, 8);
            Complex c3 = new Complex(0.8, 8.6);
            Complex c4 = new Complex(0.67, 96.67);

            Console.WriteLine($"{c1} + {c2} is {c1+c2}, required (8, 12) ");
            Console.WriteLine($"{c3} + {c4} is {c3 + c4}, required (1.47, 105.27) ");
            Console.WriteLine(Environment.NewLine);
        }
        public static void ComplexSubtraction() {
            Complex c1 = new Complex(3, 4);
            Complex c2 = new Complex(5, 8);
            Complex c3 = new Complex(0.8, 8.6);
            Complex c4 = new Complex(0.67, 96.67);

            Console.WriteLine($"{c1} - {c2} is {c1 - c2}, required (-2, -4) ");
            Console.WriteLine($"{c3} - {c4} is {c3 - c4}, required (0.13, -88.07) ");
            Console.WriteLine(Environment.NewLine);
        }

        public static void ComplexMultiplication() {
            Complex c1 = new Complex(3, 4);
            Complex c2 = new Complex(5, 8);
            Complex c3 = new Complex(0.8, 8.6);
            Complex c4 = new Complex(0.67, 96.67);

            Console.WriteLine($"{c1} * {c2} is {c1 * c2}, required (-17, 44) ");
            Console.WriteLine($"{c3} * {c4} is {c3 * c4}, required (-830.82, 83.09) ");
            Console.WriteLine(Environment.NewLine);
        }

        public static void ComplexDivide() {
            Complex c1 = new Complex(3, 4);
            Complex c2 = new Complex(5, 8);
            Complex c3 = new Complex(56.8, 8.6);
            Complex c4 = new Complex(11.67, 96.67);

            Console.WriteLine($"{c1} / {c2} is {c1 / c2}, required (0.52, -0.44) ");
            Console.WriteLine($"{c3} / {c4} is {c3 / c4}, required (0.15, -0.56) ");
            Console.WriteLine(Environment.NewLine);
        }

        public static void ComplexPow() {
            Complex c1 = new Complex(3, 4);
            Complex c2 = new Complex(5, 8);
            Complex c3 = new Complex(56.8, 8.6);
            Complex c4 = new Complex(11.67, 96.67);

            Console.WriteLine($"{c1} ^ 2 is {Complex.Pow(c1, 2)}, required (-7, 24)");
            Console.WriteLine($"{c3} ^ (1/2) is {Complex.Pow(c3, 0.5)}, required (7.55, 0.6)");
            Console.WriteLine(Environment.NewLine);
        }

        public static void VectorSum() {
            var doubleArr_1 = new double[4] { 3.0, 2.0, 1.0, 1.0 };
            var doubleArr_2 = new double[4] { 3.0, 3.0, 1.0, 2.0 };
            var doubleArr_3 = new double[4] { 1.0, 2.0, 1.0, 2.0 };

            var complexArr1 = new Complex[3] { new Complex(1, 2), new Complex(4, 2), new Complex(1, 8) };
            var complexArr2 = new Complex[3] { new Complex(5, 2), new Complex(0, 5), new Complex(10, 3) };
            
            var doubleVector_1 = new Vector<double>(doubleArr_1);
            var doubleVector_2 = new Vector<double>(doubleArr_2);
            var doubleVector_3 = new Vector<double>(doubleArr_3);

            var complexVector1 = new Vector<Complex>(complexArr1);
            var complexVector2 = new Vector<Complex>(complexArr2);
           

            Console.WriteLine($"{doubleVector_1} + {doubleVector_2} is {doubleVector_1 + doubleVector_2}, required" +
                $"(6,5,2,3)");
            Console.WriteLine($"{complexVector1} + {complexVector2} is {complexVector1 + complexVector2}, required " +
                $"((6, 4), (4,7), (11, 11))");
            Console.WriteLine(Environment.NewLine);
        }

        public static void VectorOrthogonolization() {
            var doubleArr_1 = new double[4] { 3.0, 2.0, 1.0, 1.0 };
            var doubleArr_2 = new double[4] { 3.0, 3.0, 1.0, 2.0 };
            var doubleArr_3 = new double[4] { 1.0, 2.0, 1.0, 2.0 };
            var doubleVector_1 = new Vector<double>(doubleArr_1);
            var doubleVector_2 = new Vector<double>(doubleArr_2);
            var doubleVector_3 = new Vector<double>(doubleArr_3);
            var doubleVectorArr = new Vector<double>[3] { doubleVector_1, doubleVector_2, doubleVector_3 };

            var doubleArr_11 = new double[3] { 1, 0, 0};
            var doubleArr_22 = new double[3] { 0, 1, 0 };
            var doubleArr_33 = new double[3] { 0, 0, 1 };
            var doubleVector_11 = new Vector<double>(doubleArr_11);
            var doubleVector_22 = new Vector<double>(doubleArr_22);
            var doubleVector_33 = new Vector<double>(doubleArr_33);
            var doubleVectorArr2 = new Vector<double>[3] { doubleVector_11, doubleVector_22, doubleVector_33 };
            Vector<double>[] arr1 = Vector<double>.Orthogonolization(doubleVectorArr);

            Console.WriteLine($"Ортогонолизация системы");
            foreach(var vector in doubleVectorArr) {
                Console.WriteLine(vector);
            }
            Console.WriteLine("Результат:");

            for(int i = 0; i < arr1.Length; i++) {
                Console.WriteLine(arr1[i]);
            }

            Console.WriteLine("Ожидается:");
            Console.WriteLine("(3,2,1,1)");
            Console.WriteLine("(-0.6, 0.6, -0.2, 0.8)");
            Console.WriteLine("(-0.14, -0.2, 0.61, 0.19)");

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"Ортогонолизация системы");
            Vector<double>[] arr2 = Vector<double>.Orthogonolization(doubleVectorArr2);
            foreach (var vector in doubleVectorArr2) {
                Console.WriteLine(vector);
            }
            Console.WriteLine("Результат:");

            
            for (int i = 0; i < arr2.Length; i++) {
                Console.WriteLine(arr2[i]);
            }

            Console.WriteLine("Ожидается:");
            Console.WriteLine("(1,0,0)");
            Console.WriteLine("(0,1,0)");
            Console.WriteLine("(0,0,1)");
        }
    }
}
