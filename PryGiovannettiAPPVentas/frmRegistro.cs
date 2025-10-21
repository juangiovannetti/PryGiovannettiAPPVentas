namespace PryGiovannettiAPPVentas
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cmbProducto_TextChanged(object sender, EventArgs e)
        {
            if (cmbProducto.Text != "")
            {
                cmbProducto.Enabled = true;
            }
            else
            {
                cmbProducto.Enabled = false;
            }
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (nudCantidad.Value > 0)
            {
                nudCantidad.Enabled = true;
            }
            else
            {
                nudCantidad.Enabled = false;
            }
        }

        private void mtbPrecio_TextChanged(object sender, EventArgs e)
        {
            if (mtbPrecio.Text != "")
            {
                mtbPrecio.Enabled = true;
                btnRegistrar.Enabled = true;
            }
            else
            {
                mtbPrecio.Enabled = false;
                btnRegistrar.Enabled = false;
            }
        }
    }
}
