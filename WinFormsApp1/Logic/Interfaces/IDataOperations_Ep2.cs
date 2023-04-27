using WinFormsApp1.Logic;
using WinFormsApp1.Models;

namespace MIO.Logic.Interfaces
{
    internal interface IDataOperations_Ep2
    {
        double Function_G(double functionX, double d, double minimum);
        double GetMinMember(List<ModelOutput> list);
        double Function_P(double functionG, double sumOfG);
        double SumOfG(List<ModelOutput> list);
        double SumOfP(List<ModelOutput> list);
        void SetFunction_G(DataOperations_Ep2 obj, double precision, List<ModelOutput> resultList);
        void SetFunction_P(DataOperations_Ep2 obj, double precision, List<ModelOutput> resultList);
        void SetDistance_Q(List<ModelOutput> list, decimal N);
        double Draw_R();
        void Set_R(List<ModelOutput> list);
        void Draw_Selection(List<ModelOutput> list);
        void GetDrewMember(ModelOutput drewMember, List<ModelOutput> list);
        bool CheckPropability_P(List<ModelOutput> list);
    }
}
