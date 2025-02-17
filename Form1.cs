namespace DIVIDE_BY_ZERO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNdividir_Click(object sender, EventArgs e)
        {

            try
            {
                // Convers�o dos valores inseridos
                double n1 = Convert.ToDouble(textBoxNumero1.Text);
                double  n2 = Convert.ToDouble(textBoxNumero2.Text);
                if (n2 == 0)
                {
                    throw new DivideByZeroException("N�o � poss�vel dividir por zero.");

                }
                // Realizar a divis�o
                double resultado = n1 / n2;
                textBoxResultado.Text = "Resultado: "+ resultado;
            }
         
            catch (DivideByZeroException)
            {
                MessageBox.Show("Erro: N�o � poss�vel dividir por zero.");
            }
           



        }
    }
}
