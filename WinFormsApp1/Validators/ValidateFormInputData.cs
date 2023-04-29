namespace WinFormsApp1.Validators
{
    internal class ValidateFormInputData
    {
        public bool ValidateA_less_B(decimal a, decimal b)
        {
            if (a > b)
            {
                MessageBox.Show("B nie może być mniejsze niż A!", "Error");
                return false;
            }
            return true;
        }

        public bool ValidatePrecision(object precision)
        {
            if (precision == null)
            {
                MessageBox.Show("Uzupełnij precyzję!", "Error");
                return false;
            }
            return true;
        }

        public bool ValidatePropability(double propability)
        {
            if (propability < 0d)
            {
                MessageBox.Show("Prawdomopobieństwo nie może być mniejsze niż 0!", "Error");
                return false;
            }           
            if (propability > 1d)
            {
                MessageBox.Show("Prawdomopobieństwo nie może być większe niż 1!", "Error");
                return false;
            }
            return true;
        }
        

    }
}