using WinFormsApp1.Logic;
using WinFormsApp1.Logic.Classes;
using WinFormsApp1.Models;
using WinFormsApp1.Validators;

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
            Main();
        }

        public void Main()
        {
            DataOperations_Ep1 lab2 = new DataOperations_Ep1();
            DataOperations_Ep2 lab3 = new DataOperations_Ep2();
            DataOperations_Ep3 lab4 = new DataOperations_Ep3();


            ValidateFormInputData validate = new ValidateFormInputData();
            CheckCalculations checkCalculations = new CheckCalculations();
            var resultList = new List<ModelOutput>();

            var precision = Decimal.ToDouble(decimal.Parse(Precision.SelectedItem.ToString()));
            var a = Convert.ToInt32(A.Value);
            var b = Convert.ToInt32(B.Value);
            var l = lab2.Get_l(precision, a, b);
            var crossingPropability = Convert.ToDouble(crossPropability.SelectedItem.ToString());
            var mutatingPropability = Convert.ToDouble(mutationPropability.SelectedItem.ToString());

            if (!validate.ValidatePrecision(Precision.SelectedItem) ||
                    !validate.ValidateA_less_B(A.Value, B.Value) ||
                    !validate.ValidatePropability(crossingPropability) ||
                    !validate.ValidatePropability(mutatingPropability))
                return;
            do
            {
                //lab2 (ep1)
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
            var generation = lab4.InitiaiteModel(resultList);
            lab4.DrawAndMarkParents(generation, crossingPropability);
            //lab4.SetCutPosition(generation);
            lab4.Crossing(generation);
            lab4.Mutation(generation, mutatingPropability);
            lab4.FillMutatedX_Real(generation, a, b, l, precision);
            lab4.Function_F(generation);

            dataGridView1.DataSource = generation;
        }
    }
}