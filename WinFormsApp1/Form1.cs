using MIO.Logic;
using MIO.Validators;
using MIO_1.Validators;
using WinFormsApp1.Logic;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataOperations_Ep1 lab2 = new DataOperations_Ep1();
            DataOperations_Ep2 lab3 = new DataOperations_Ep2();
            ValidateFormInputData validate = new ValidateFormInputData();
            CheckCalculations checkCalculations = new CheckCalculations();
            var resultList = new List<ModelOutput>();

            if (!validate.ValidatePrecision(Precision.SelectedItem) ||
                    !validate.ValidateA_less_B(A.Value, B.Value))
                return;
            do
            {
                //lab2 (ep1)
                var precision = Decimal.ToDouble(decimal.Parse(Precision.SelectedItem.ToString()));
                var a = Convert.ToInt32(A.Value);
                var b = Convert.ToInt32(B.Value);
                var l = lab2.Get_l(precision, a, b);
                resultList.Clear();
                lab2.AddAndConvertData(lab2, precision, a, b, l, resultList, PopulationSize.Value);

                ///lab3 (ep2)
                lab3.SetFunction_G(lab3, precision, resultList);
                lab3.SetFunction_P(lab3, precision, resultList);
            } while (lab3.CheckPropability_P(resultList));
                
            lab3.SetDistance_Q(resultList, PopulationSize.Value);
            lab3.Set_R(resultList);
            lab3.Draw_Selection(resultList);

            //lab4 (ep3)


            dataGridView1.DataSource = resultList;
        }
    }
}