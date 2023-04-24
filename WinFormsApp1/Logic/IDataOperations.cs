namespace WinFormsApp1.Logic
{
    public interface IDataOperations
    {
        int RealToInt(double X_REAL, int a, int b, int l, double D);
        string IntToBin(int X_INT, int l);
        int BinToInt(string X_BIN);
        double IntToReal(int X_INT, int a, int b, int l, double D);
        double MyCustomRandomNumber(int min, int max, double D);
        int Get_l(double d, int a, int b);
        double EvaluationFunction(double x);
    }
}
