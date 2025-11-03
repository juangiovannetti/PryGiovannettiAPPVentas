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
        int indice = 0;

        //Declaración struct
        public struct datoVentas
        {
            public DateTime Fecha;
            public string Producto;
            public int Cantidad;
            public int Precio;
        }

        //Declaración de array principal
        public datoVentas[] vecProductos = new datoVentas[100];

        private void cmbProducto_TextChanged(object sender, EventArgs e)
        {
            if (cmbProducto.Text != "")
            {
                //Habilita nudCantidad
                nudCantidad.Enabled = true;
            }
            else
            {
                // Deshabilita nudCantidad cuando no hay producto seleccionado
                nudCantidad.Enabled = false;
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


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
            cmbProducto.Text = "";
            nudCantidad.Value = 0;
            mtbPrecioUnitario.Text = "";
            cmbProducto.SelectedIndex = -1;
            lstResultado.Items.Clear();
            //Se utiliza para inidicar donde queda el control (Click)
            cmbProducto.Focus();

        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            //Validamos que el array no este lleno
            if (indice >= vecProductos.Length)
            {
                MessageBox.Show("El array se encuentra lleno, no se puede grabar más datos.", "Array lleno",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRegistrar.Enabled = false;

            }

            //Otorgo valor a variables             
            vFecha = dtpFecha.Value;
            vProducto = cmbProducto.Text;
            //cmbProducto.SelectedItem
            vCantidad = Convert.ToInt32(nudCantidad.Value);
            //otra manera es: vCantidad = intParce(nudCantidad.Value.ToString));
            vPrecio = Convert.ToInt32(mtbPrecioUnitario.Text);

            //Gabro datos en array
            vecProductos[indice].Fecha = dtpFecha.Value;
            vecProductos[indice].Producto = vProducto;
            vecProductos[indice].Cantidad = vCantidad;
            vecProductos[indice].Precio = vPrecio;
            indice++;

            //Mostrar resultado
            lstResultado.Items.Add("Producto:" + vProducto);
            lstResultado.Items.Add("Fecha:" + vFecha);
            lstResultado.Items.Add("Cantidad:" + vCantidad);
            lstResultado.Items.Add("Precio:$ " + vPrecio);
        }
    }
}
