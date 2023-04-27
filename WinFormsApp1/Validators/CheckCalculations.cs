using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIO.Validators
{
    internal class CheckCalculations
    {
        public bool CheckSumOf_P(double sum)
        {
            if (sum != 1d)
            {
                MessageBox.Show("Suma prawdopodobieństw P nie jest równa 1!", "Error");
                return false;
            }
            return true;
        }
    }
}
