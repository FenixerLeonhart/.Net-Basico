namespace ConvertidorMonedaExtranjeraALocal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            Contabilidad contabilidad = new Contabilidad();

            contabilidad.DolarGananciaEstimada = txtDolarEstimado.Text;
            contabilidad.DolarBlue = txtValorDBlue.Text;
            contabilidad.ValorLimteChile = txtValorLimiteChile.Text;
            contabilidad.ValorRealChile = txtValorRealCHile.Text;

            contabilidad.MostrarEnPantalla();
        }
    }
}