using System;
using System.Collections.Generic;
using System.Text;


namespace lab11{
    class Complex : ICloneable{
        double _real;
        double _imaginary;

        public event EventHandler<ZeroDivideEventArgs> ZeroDivideEventHandler; 


        public Complex() {
            _real = 0;
            _imaginary = 0;
        }


        public Complex(double real, double imaginary) {
            _real = real;
            _imaginary = imaginary;
        }


        public Complex(double module, double cosValue, double sinValue) {
            getAlgebraicForm(module, cosValue, sinValue);
        }


        public void getAlgebraicForm(double module, double cosValue, double sinValue) {
            //Complex result = new Complex();
            _real = module * cosValue;
            _imaginary = module * sinValue;
            //return result;
        }

        public static Complex ComplexConjugate(Complex complex) {
            return Multiply(complex, new Complex(-1, 0));
        }


        public static Complex Add(Complex left, Complex right) {
            Complex result = new Complex();
            result._real = left._real + right._real;
            result._imaginary = left._imaginary + right._imaginary;
            return result;
        }


        public static Complex Substract(Complex left, Complex right) {
            Complex result = new Complex();
            result._real = left._real - right._real;
            result._imaginary = left._imaginary - right._imaginary;
            return result;
        }

        public static Complex Multiply(Complex left, Complex right) {
            Complex result = new Complex();
            result._real = left._real * right._real - left._imaginary * right._imaginary;
            result._imaginary = left._imaginary * right._real + left._real * right._imaginary;
            return result;
        }

        public static Complex Divide(Complex comlexNum, double realNum) {
            
            
            if(Math.Abs(realNum) < Math.Pow(10, -14)) {
                ZeroDivideEventArgs args = new ZeroDivideEventArgs(comlexNum, realNum);
                
            }
            //todo реализовать событие генерируемое при делении на 0
            Complex result = comlexNum;
            result._real /= realNum;
            result._imaginary /= realNum;
            return result;
        }

        public static Complex Divide(Complex dividend, Complex divider) {
            dividend = Multiply(dividend, ComplexConjugate(divider));
            divider = Multiply(divider, ComplexConjugate(divider));
            dividend = Divide(dividend, divider._real);
            return dividend;

        }

        protected virtual void OnZeroDivide(ZeroDivideEventArgs e) {
            ZeroDivideEventHandler?.Invoke(this, e);
        }


        public static Complex operator +(Complex left, Complex right) {
            return Add(left, right);
        }


        public static Complex operator -(Complex left, Complex right) {
            return Substract(left, right);
        }


        public static Complex operator *(Complex left, Complex right) {
            return Multiply(left, right);
        }

        public static Complex operator /(Complex left, Complex right) {
            return Divide(left, right);
        }


        public override string ToString() {
            StringBuilder res = new StringBuilder();
            res.Append(_real);
            if(_imaginary > 0 ) {
                res.Append(" - ");
                res.Append(_imaginary).Append("i");
            }
            else if(_imaginary < 0) {
                res.Append(_imaginary).Append("i");
            }
            return res.ToString();
        }

        public object Clone() {
            return new Complex(this._real, this._imaginary);
        }
    }
}
