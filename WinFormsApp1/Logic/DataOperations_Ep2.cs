using MIO.Logic.Interfaces;
using WinFormsApp1.Models;

namespace MIO.Logic
{
    internal class DataOperations_Ep2 : IDataOperations_Ep2
    {
        ////////lab3
        public double Function_G(double functionX, double d, double minimum) => functionX - minimum + d;

        public double GetMinMember(List<ModelOutput> list) => list.Min(x => x.Function_X);

        public double Function_P(double functionG, double sumOfG) => functionG / sumOfG;

        public double SumOfG(List<ModelOutput> list) => list.Sum(x => x.Function_G);

        public double SumOfP(List<ModelOutput> list) => list.Sum(x => x.Function_P);

        public void SetDistance_Q(List<ModelOutput> list, decimal N)
        {
            for (int i = 0; i < N; i++)
            {
                if (list.ElementAt(i).Number == 1) // pierwszy element
                    list.ElementAt(i).Q = list.ElementAt(i).Function_P;
                else
                {
                    list.ElementAt(i).Q = list.ElementAt(i).Function_P + list.ElementAt(i - 1).Q;
                }
            }
        }

        public void SetFunction_G(DataOperations_Ep2 obj, double precision, List<ModelOutput> resultList)
        {
            var minimalMember = GetMinMember(resultList);
            foreach (var item in resultList)
            {
                var function_G = obj.Function_G(item.Function_X, precision, minimalMember);
                item.Function_G = function_G;
            }
        }

        public void SetFunction_P(DataOperations_Ep2 obj, double precision, List<ModelOutput> resultList)
        {
            foreach (var item in resultList)
            {
                var sumOfG = obj.SumOfG(resultList);
                var function_P = obj.Function_P(item.Function_G, sumOfG);
                item.Function_P = function_P;
            }
        }

        public double Draw_R()
        {
            Random random = new Random();
            return random.NextDouble();
        }

        public void Set_R(List<ModelOutput> list)
        {
            foreach (var item in list)
                item.R = Draw_R();
        }

        public void Draw_Selection(List<ModelOutput> list)
        {
            foreach (var item in list)
                GetDrewMember(item, list);
        }

        public void GetDrewMember(ModelOutput drewMember, List<ModelOutput> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (i == 0)//dla 1 osobnika
                {
                    if (drewMember.R <= list.ElementAt(i + 1).Q)
                        drewMember.Selection = list.ElementAt(i).X_REAL1;
                }
                else
                    if (list.ElementAt(i - 1).Q < drewMember.R && drewMember.R <= list.ElementAt(i).Q)
                    drewMember.Selection = list.ElementAt(i).X_REAL1;
            }
        }

        public double SetPrecision(double value)
        {
            int precision = (int)Math.Log10(1.0 / 1E-15);
            return Math.Round(value, precision);
        }

        public bool CheckPropability_P(List<ModelOutput> list)
        {
            if (SumOfP(list) == 1d)
                return true;
            return false;
        }
    }
}