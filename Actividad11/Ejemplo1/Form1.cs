namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        int contador = 0;
        double acumulador = 0;

        public Form1()
        {
            InitializeComponent();
        }




        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(tbRegistrar.Text);

            acumulador += num;
            contador++;
            tbRegistrar.Text = string.Empty;
        }


        private void tbRegistrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double promedio = acumulador / contador;

            tbResultado.Text = $"El resultado es: {promedio:f2}";
        }
    }
}
