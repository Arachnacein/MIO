using WinFormsApp1.Logic.Interfaces;
using WinFormsApp1.Models;

namespace WinFormsApp1.Logic.Classes
{
    public class DataOperations_Ep1 : IDataOperations_Ep1
    {
        public int RealToInt(double X_REAL, int a, int b, int l, double D)
        {
            //wzór
            var X_INT = 1 / (b - (double)a) * (X_REAL - a) * (Math.Pow(2, l) - 1);
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
            var X_REAL = licznik / mianownik + a;
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
            double newValue = double.Parse(number.ToString());
            return SetPrecision(newValue, D);
        }
        public int Get_l(double d, int a, int b)
        {
            //wzór
            var inside = 1 / d * (b - a) + 1;
            var l = Math.Ceiling(Math.Log2(inside));
            return Convert.ToInt32(l);
        }
        public double SetPrecision(double value, double D)
        {
            int precision = (int)Math.Log10(1.0 / D);
            return Math.Round(value, precision);
        }
        public void AddAndConvertData(DataOperations_Ep1 obj, double precision, int a, int b, int l, List<ModelOutput> resultList, decimal N)
        {
            for (int i = 0; i < N; i++)
            {
                var X_REAL1 = obj.MyCustomRandomNumber(a, b, precision);
                var X_INT1 = obj.RealToInt(X_REAL1, a, b, l, precision);
                var X_BIN = obj.IntToBin(X_INT1, l);
                var X_INT2 = obj.BinToInt(X_BIN);
                var X_REAL2 = obj.IntToReal(X_INT2, a, b, l, precision);
                var function_X = obj.Function_X(X_REAL2);

                AddNewMember(resultList, i, X_REAL1, X_INT1, X_BIN, X_INT2, X_REAL2, function_X);
            }
        }
        public void AddNewMember(List<ModelOutput> resultList, int i, double X_REAL1, int X_INT1, string X_BIN, int X_INT2, double X_REAL2, double function_X)
        {
            resultList.Add(new ModelOutput
            {
                Number = i + 1,
                X_REAL1 = X_REAL1,
                X_INT1 = X_INT1,
                X_BIN = X_BIN,
                X_INT2 = X_INT2,
                X_REAL2 = X_REAL2,
                Function_X = function_X
            });
        }
        public double Function_X(double x)
        {
            double mantysa = x - Math.Truncate(x);
            double cos = Math.Cos(20 * Math.PI * x);
            double sin = Math.Sin(x);
            return mantysa * (cos - sin);
        }


    }
}