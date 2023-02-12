namespace FacturacionProductos
{
    public partial class Form1 : Form
    {

        public float PrecioTotal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnPantalon_Click(object sender, EventArgs e)
        {
            listaBox.Items.Add("Pantalon 20$");
            PrecioTotal += 20;
            ActualizarTotalTR(PrecioTotal);
        }

        private void btnCamisa_Click(object sender, EventArgs e)
        {
            listaBox.Items.Add("Camisa 25$");
            PrecioTotal += 25;
            ActualizarTotalTR(PrecioTotal);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Boton Zapatos
            listaBox.Items.Add("Zapatos 15$");
            PrecioTotal += 15;
            ActualizarTotalTR(PrecioTotal);
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if(txtDescuento.Text == "NAVIDAD")
            {
                ActualizarTotalTR(PrecioTotal * 0.9f);
            }
            else
            {
                MessageBox.Show("Codigo Invalido");
            }
        }

        private void ActualizarTotalTR(float precioActualizado) => precioTotal.Text = precioActualizado.ToString() + "$";

    }
}