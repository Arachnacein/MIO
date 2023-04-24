using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Logic
{
    public class DataOperations : IDataOperations
    {
        public int RealToInt(double X_REAL, int a, int b, int l, double D)
        {
            //wzór
            var X_INT = (1 / ((double)b - (double)a)) * (X_REAL - a) * (Math.Pow(2, l) - 1);
            return Convert.ToInt32(Math.Round(X_INT / D) * D);
        }
        public string IntToBin(int X_INT, int l)
        {
            string X_BIN = Convert.ToString(X_INT, 2);
            X_BIN = X_BIN.PadLeft(l, '0');
            return X_BIN;
        }
        public int BinToInt(string X_BIN)
        {
            int X_INT = Convert.ToInt32(X_BIN, 2);
            return X_INT;
        }
        public double IntToReal(int X_INT, int a, int b, int l, double D)
        {
            //wzór
            var licznik = X_INT * (b - a);
            var mianownik = Math.Pow(2, l) - 1;
            var X_REAL = (licznik / mianownik) + a;
            return SetPrecision(X_REAL, D);
        }
        public double EvaluationFunction(double x)
        {
            double mantysa = x - Math.Floor(x);
            return mantysa * (Math.Cos(20 * Math.PI * x) - Math.Sin(x));

        }
        public double MyCustomRandomNumber(int min, int max, double D)
        {
            Random rng = new Random();
            var number = rng.NextDouble() * (max - min) + min;
            double newValue = Double.Parse(number.ToString());
            return SetPrecision(newValue, D);
        }
        public int Get_l(double d, int a, int b)
        {
            //wzór
            var inside = (1 / d * (b - a) + 1);
            var l = Math.Ceiling(Math.Log2(inside));
            return Convert.ToInt32(l);
        }
        public double SetPrecision(double value, double D)
        {
            int precision = (int)Math.Log10(1.0 / D);
            return Math.Round(value, precision);
        }
    }
}
