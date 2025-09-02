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
            dtmFecha = new DateTimePicker();
            mtbPrecioUnitario = new MaskedTextBox();
            btnCancelar = new Button();
            nudCantidad = new NumericUpDown();
            lblResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(228, 128);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(228, 168);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(56, 15);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(228, 224);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Location = new Point(228, 278);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(84, 15);
            lblPrecioUnitario.TabIndex = 3;
            lblPrecioUnitario.Text = "Precio unitario";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(547, 323);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(88, 33);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(338, 168);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(200, 23);
            cmbProducto.TabIndex = 5;
            cmbProducto.TextChanged += cmbProducto_TextChanged;
            // 
            // dtmFecha
            // 
            dtmFecha.Format = DateTimePickerFormat.Short;
            dtmFecha.Location = new Point(338, 128);
            dtmFecha.Name = "dtmFecha";
            dtmFecha.Size = new Size(100, 23);
            dtmFecha.TabIndex = 6;
            // 
            // mtbPrecioUnitario
            // 
            mtbPrecioUnitario.Location = new Point(338, 270);
            mtbPrecioUnitario.Mask = "99999999";
            mtbPrecioUnitario.Name = "mtbPrecioUnitario";
            mtbPrecioUnitario.Size = new Size(100, 23);
            mtbPrecioUnitario.TabIndex = 9;
            mtbPrecioUnitario.ValidatingType = typeof(int);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(414, 323);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 33);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(338, 224);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(100, 23);
            nudCantidad.TabIndex = 11;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // lblResultado
            // 
            lblResultado.BorderStyle = BorderStyle.Fixed3D;
            lblResultado.Location = new Point(228, 366);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(210, 75);
            lblResultado.TabIndex = 12;
            lblResultado.Text = "---";
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(nudCantidad);
            Controls.Add(btnCancelar);
            Controls.Add(mtbPrecioUnitario);
            Controls.Add(dtmFecha);
            Controls.Add(cmbProducto);
            Controls.Add(btnRegistrar);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblFecha);
            Name = "frmRegistro";
            Text = "APP VENTAS DE HARWARE";
            Load += frmRegistro_Load;
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
        private DateTimePicker dtmFecha;
        private MaskedTextBox mtbPrecioUnitario;
        private Button btnCancelar;
        private NumericUpDown nudCantidad;
        private Label lblResultado;
    }
}
