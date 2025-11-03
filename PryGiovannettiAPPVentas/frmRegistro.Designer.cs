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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            lblFecha = new Label();
            lblProducto = new Label();
            lblPrecioUnitario = new Label();
            btnRegistrar = new Button();
            cmbProducto = new ComboBox();
            dtpFecha = new DateTimePicker();
            mtbPrecioUnitario = new MaskedTextBox();
            btnCancelar = new Button();
            nudCantidad = new NumericUpDown();
            lstResultado = new ListBox();
            lblCant = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(22, 21);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(45, 19);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducto.Location = new Point(22, 55);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(66, 19);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioUnitario.Location = new Point(22, 126);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(101, 19);
            lblPrecioUnitario.TabIndex = 3;
            lblPrecioUnitario.Text = "Precio unitario";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(137, 253);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(88, 33);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(119, 49);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(100, 23);
            cmbProducto.TabIndex = 5;
            cmbProducto.TextChanged += cmbProducto_TextChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(119, 21);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(100, 23);
            dtpFecha.TabIndex = 6;
            // 
            // mtbPrecioUnitario
            // 
            mtbPrecioUnitario.Enabled = false;
            mtbPrecioUnitario.Location = new Point(133, 125);
            mtbPrecioUnitario.Mask = "99999999";
            mtbPrecioUnitario.Name = "mtbPrecioUnitario";
            mtbPrecioUnitario.Size = new Size(71, 23);
            mtbPrecioUnitario.TabIndex = 9;
            mtbPrecioUnitario.ValidatingType = typeof(int);
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(23, 253);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 33);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(119, 83);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(100, 23);
            nudCantidad.TabIndex = 11;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 15;
            lstResultado.Location = new Point(23, 168);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(202, 64);
            lstResultado.TabIndex = 14;
            // 
            // lblCant
            // 
            lblCant.AutoSize = true;
            lblCant.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCant.Location = new Point(22, 91);
            lblCant.Name = "lblCant";
            lblCant.Size = new Size(66, 15);
            lblCant.TabIndex = 15;
            lblCant.Text = "Cantidad";
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 298);
            Controls.Add(lblCant);
            Controls.Add(lstResultado);
            Controls.Add(nudCantidad);
            Controls.Add(btnCancelar);
            Controls.Add(mtbPrecioUnitario);
            Controls.Add(dtpFecha);
            Controls.Add(cmbProducto);
            Controls.Add(btnRegistrar);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblProducto);
            Controls.Add(lblFecha);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VENTAS DE HARWARE";
            Load += frmRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private Label lblProducto;     
        private ListBox lstResultado;
        private Label lblPrecioUnitario;
        private Button btnRegistrar;
        private ComboBox cmbProducto;
        private DateTimePicker dtpFecha;
        private MaskedTextBox mtbPrecioUnitario;
        private Button btnCancelar;
        private NumericUpDown nudCantidad;
        private Label lblResultado;
        private Label lblCantidad;
        private Label lblCant;
    }
}
