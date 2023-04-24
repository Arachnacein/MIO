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
            DataOperations obj = new DataOperations();
            ValidateFormInputData validate = new ValidateFormInputData();

            if (!validate.ValidatePrecision(Precision.SelectedItem) ||
                !validate.ValidateA_less_B(A.Value, B.Value))
                return;

            var precision = Decimal.ToDouble(decimal.Parse(Precision.SelectedItem.ToString()));
            var a = Convert.ToInt32(A.Value);
            var b = Convert.ToInt32(B.Value);
            var l = obj.Get_l(precision, a, b);

            Bytes.Text = l.ToString();

            var resultList = new List<ModelOutput>();

            for (int i = 0; i < PopulationSize.Value; i++)
            {
                var X_REAL1 = obj.MyCustomRandomNumber(a, b, precision);
                var X_INT1 = obj.RealToInt(X_REAL1, a, b, l, precision);
                var X_BIN = obj.IntToBin(X_INT1, l);
                var X_INT2 = obj.BinToInt(X_BIN);
                var X_REAL2 = obj.IntToReal(X_INT2, a, b, l, precision);

                resultList.Add(new ModelOutput
                {
                    Number = i + 1,
                    X_REAL1 = X_REAL1,
                    X_INT1 = X_INT1,
                    X_BIN = X_BIN,
                    X_INT2 = X_INT2,
                    X_REAL2 = X_REAL2
                }); ;
            }
            dataGridView1.DataSource = resultList;
        }
    }
}