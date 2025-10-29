namespace PryGiovannettiAPPVentas
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
        //Declaracion de variables del formulario
        DateTime vFecha;
        string vProducto;
        int vCantidad;
        int vPrecio;

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

        private void frmRegistro_Load(object sender, EventArgs e)

        {
            //Inicializar vairables 
            vFecha = DateTime.Now;
            vProducto = "";
            vCantidad = 0;
            vPrecio = 0;
            //cargar el cmb producto con codigo
            cmbProducto.Items.Add("Gabinete");
            cmbProducto.Items.Add("Ram");
            cmbProducto.Items.Add("CPU");
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (nudCantidad.Value > 0)
            {
                mtbPrecioUnitario.Enabled = true;
            }
            else
            {
                mtbPrecioUnitario.Enabled = false;
            }
        }

        private void mtbPrecioUnitario_TextChanged(object sender, EventArgs e)
        {
            if (mtbPrecioUnitario.Text != "")
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            vFecha = dtpFecha.Value;
            vProducto = cmbProducto.Text;
            //cmbProducto.selectedItem
            vCantidad = Convert.ToInt32(nudCantidad.Value);
            //otra manera es: vCantidad = intParce(nudCantidad.Value.TOstring));
            vPrecio = Convert.ToInt32(mtbPrecioUnitario);

            //mostrar los resultados
            // +/n salto de linea
            lstResultado.Text +=
                vFecha + " " + vProducto
                 + "" + vCantidad + "" + vPrecio + '\n';
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
            cmbProducto.Text = "";
            nudCantidad.Value = 0;
            mtbPrecioUnitario.Text = "";
            cmbProducto.SelectedIndex = -1;
            //Se utiliza para inidicar donde queda el control (Click)
            cmbProducto.Focus();


        }
    }
}
