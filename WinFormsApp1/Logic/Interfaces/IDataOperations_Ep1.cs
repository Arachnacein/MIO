using WinFormsApp1.Logic;
using WinFormsApp1.Models;

namespace MIO.Logic.Interfaces
{
    public interface IDataOperations_Ep1
    {
        int RealToInt(double X_REAL, int a, int b, int l, double D);
        string IntToBin(int X_INT, int l);
        int BinToInt(string X_BIN);
        double IntToReal(int X_INT, int a, int b, int l, double D);
        double MyCustomRandomNumber(int min, int max, double D);
        int Get_l(double d, int a, int b);
        double EvaluationFunction(double x);
        void AddAndConvertData(DataOperations_Ep1 obj, double precision, int a, int b, int l, List<ModelOutput> resultList, decimal N);
        void AddNewMember(List<ModelOutput> resultList, int i, double X_REAL1, int X_INT1, string X_BIN, int X_INT2, double X_REAL2, double function_X);
        double Function_X(double x);

    }
}
