namespace SacarPromedioDeNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            string[] valoresT = {valor1.Text,valor2.Text,valor3.Text};

            int[] valoresN = { 0, 1, 2 };

            if (int.TryParse(valoresT[0], out valoresN[0]))
            {
                for(int i = 0; i < valoresN.Length; i++)
                {
                    valoresN[i] = int.Parse(valoresT[i]);
                }

                double Promedio = valoresN.Average();

                MessageBox.Show("EL VALOR PROMEDIO DE LOS TRES NUMEROS ES " + Promedio);
            }
        }
    }
}