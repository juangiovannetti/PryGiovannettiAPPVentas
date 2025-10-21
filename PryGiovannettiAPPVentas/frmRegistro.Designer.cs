namespace PryGiovannettiAPPVentas
{
    partial class frmRegistro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFecha = new Label();
            lblProducto = new Label();
            lblCantidad = new Label();
            lblPrecioUnitario = new Label();
            btnRegistrar = new Button();
            cmbProducto = new ComboBox();
            dtpFecha = new DateTimePicker();
            nudCantidad = new NumericUpDown();
            mtbPrecio = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(38, 66);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(55, 23);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducto.Location = new Point(38, 143);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(83, 23);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(38, 220);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(83, 23);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioUnitario.Location = new Point(14, 302);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(127, 23);
            lblPrecioUnitario.TabIndex = 3;
            lblPrecioUnitario.Text = "Precio unitario";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Black;
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(207, 368);
            btnRegistrar.Margin = new Padding(3, 5, 3, 5);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(107, 43);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(159, 143);
            cmbProducto.Margin = new Padding(3, 5, 3, 5);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(155, 31);
            cmbProducto.TabIndex = 5;
            cmbProducto.TextChanged += cmbProducto_TextChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(159, 66);
            dtpFecha.Margin = new Padding(3, 5, 3, 5);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(155, 30);
            dtpFecha.TabIndex = 6;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(159, 220);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(107, 30);
            nudCantidad.TabIndex = 9;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // mtbPrecio
            // 
            mtbPrecio.Location = new Point(173, 302);
            mtbPrecio.Mask = "9999999999";
            mtbPrecio.Name = "mtbPrecio";
            mtbPrecio.Size = new Size(92, 30);
            mtbPrecio.TabIndex = 10;
            mtbPrecio.ValidatingType = typeof(int);
            mtbPrecio.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            mtbPrecio.TextChanged += mtbPrecio_TextChanged;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 454);
            Controls.Add(mtbPrecio);
            Controls.Add(nudCantidad);
            Controls.Add(dtpFecha);
            Controls.Add(cmbProducto);
            Controls.Add(btnRegistrar);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblFecha);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "frmRegistro";
            Text = "APP VENTAS DE HARWARE";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblPrecioUnitario;
        private Button btnRegistrar;
        private ComboBox cmbProducto;
        private DateTimePicker dtpFecha;
        private NumericUpDown nudCantidad;
        private MaskedTextBox mtbPrecio;
    }
}
