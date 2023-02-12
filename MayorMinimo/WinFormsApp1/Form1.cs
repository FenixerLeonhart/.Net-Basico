namespace WinFormsApp1
{
    public partial class PrimerosPasos : Form
    {
        public PrimerosPasos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] valores = { Valor1.Text, Valor2.Text, Valor3.Text };

            int[] valoresN = { 0, 1, 2 };

            if (int.TryParse(valores[0], out valoresN[0]))
            {
                for (int i = 0; i < valoresN.Length; i++)
                {
                    valoresN[i] = int.Parse(valores[i]);
                }
                //Continuar
                txtResultado.Text = "EL MAXIMO ES " + valoresN.Max() + " Y EL MINIMO ES " + valoresN.Min();
            }
            else
            {
                txtResultado.Text = "COLOCAR SOLO VALORES NUMERICOS";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PrimerosPasos_Load(object sender, EventArgs e)
        {

        }

    }
}