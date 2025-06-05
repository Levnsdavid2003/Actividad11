namespace Ejemplo2
{
    public partial class FormPrincipal : Form
    {
        int contador = 0;
        double[] valores = new double[100];
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void tbRegistrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(tbRegistrar.Text);

            valores[contador] = num;
            contador++;
            tbRegistrar.Text = string.Empty;
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double acumulador = 0;
            for (int i = 0; i < contador; i++)
            {
                acumulador += valores[i];
            }

            if (contador > 0)
            {
                double promedio = acumulador / contador;
                tbResultado.Text = $"El resultado es: {promedio:f2}";
            }
            else
            {
                tbResultado.Text = "No se han cargado numeros";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            contador = 0;
            valores = new double[100];
            tbResultado.Text = string.Empty;
        }
    }
}
