namespace Innovazione.GUILayer
{
    partial class frmFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            this.txtNroCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNumeroPedido = new System.Windows.Forms.Label();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.btnArticulo = new System.Windows.Forms.Button();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.txtNroArticulo = new System.Windows.Forms.TextBox();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTotalParcial = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblTotalParcial = new System.Windows.Forms.Label();
            this.grdGrilla = new System.Windows.Forms.DataGridView();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.chkPagado = new System.Windows.Forms.CheckBox();
            this.btnBuscarFactura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(71, 20);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(82, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 23);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(117, 70);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(41, 23);
            this.btnCliente.TabIndex = 11;
            this.btnCliente.Text = "...";
            this.btnCliente.UseVisualStyleBackColor = true;
            // 
            // txtNroCliente
            // 
            this.txtNroCliente.Location = new System.Drawing.Point(62, 72);
            this.txtNroCliente.Name = "txtNroCliente";
            this.txtNroCliente.Size = new System.Drawing.Size(49, 20);
            this.txtNroCliente.TabIndex = 10;
            this.txtNroCliente.TextChanged += new System.EventHandler(this.txtNroCliente_TextChanged);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(164, 72);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(289, 20);
            this.txtNombreCliente.TabIndex = 12;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(17, 75);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 13;
            this.lblCliente.Text = "Cliente";
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.AutoSize = true;
            this.lblNumeroPedido.Location = new System.Drawing.Point(165, 23);
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(90, 13);
            this.lblNumeroPedido.TabIndex = 14;
            this.lblNumeroPedido.Text = "Número de Venta";
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.Enabled = false;
            this.txtNumeroPedido.Location = new System.Drawing.Point(261, 20);
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.Size = new System.Drawing.Size(49, 20);
            this.txtNumeroPedido.TabIndex = 15;
            // 
            // btnArticulo
            // 
            this.btnArticulo.Location = new System.Drawing.Point(117, 99);
            this.btnArticulo.Name = "btnArticulo";
            this.btnArticulo.Size = new System.Drawing.Size(41, 23);
            this.btnArticulo.TabIndex = 17;
            this.btnArticulo.Text = "...";
            this.btnArticulo.UseVisualStyleBackColor = true;
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Enabled = false;
            this.txtNombreArticulo.Location = new System.Drawing.Point(164, 101);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(289, 20);
            this.txtNombreArticulo.TabIndex = 19;
            // 
            // txtNroArticulo
            // 
            this.txtNroArticulo.Location = new System.Drawing.Point(62, 101);
            this.txtNroArticulo.Name = "txtNroArticulo";
            this.txtNroArticulo.Size = new System.Drawing.Size(49, 20);
            this.txtNroArticulo.TabIndex = 16;
            this.txtNroArticulo.TextChanged += new System.EventHandler(this.txtNroArticulo_TextChanged);
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(12, 104);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(44, 13);
            this.lblArticulo.TabIndex = 18;
            this.lblArticulo.Text = "Artículo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(373, 132);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(78, 23);
            this.btnAgregar.TabIndex = 26;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTotalParcial
            // 
            this.txtTotalParcial.Enabled = false;
            this.txtTotalParcial.Location = new System.Drawing.Point(287, 134);
            this.txtTotalParcial.Name = "txtTotalParcial";
            this.txtTotalParcial.Size = new System.Drawing.Size(49, 20);
            this.txtTotalParcial.TabIndex = 25;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(176, 134);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(49, 20);
            this.txtPrecio.TabIndex = 24;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(62, 134);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(49, 20);
            this.txtCantidad.TabIndex = 23;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(7, 137);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 22;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(133, 137);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 21;
            this.lblPrecio.Text = "Precio";
            // 
            // lblTotalParcial
            // 
            this.lblTotalParcial.AutoSize = true;
            this.lblTotalParcial.Location = new System.Drawing.Point(250, 137);
            this.lblTotalParcial.Name = "lblTotalParcial";
            this.lblTotalParcial.Size = new System.Drawing.Size(31, 13);
            this.lblTotalParcial.TabIndex = 20;
            this.lblTotalParcial.Text = "Total";
            // 
            // grdGrilla
            // 
            this.grdGrilla.AllowUserToAddRows = false;
            this.grdGrilla.AllowUserToDeleteRows = false;
            this.grdGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCantidad,
            this.colId,
            this.colArticulo,
            this.colPrecio,
            this.colSubtotal});
            this.grdGrilla.Location = new System.Drawing.Point(10, 174);
            this.grdGrilla.Name = "grdGrilla";
            this.grdGrilla.ReadOnly = true;
            this.grdGrilla.Size = new System.Drawing.Size(467, 150);
            this.grdGrilla.TabIndex = 43;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colArticulo
            // 
            this.colArticulo.HeaderText = "Artículo";
            this.colArticulo.Name = "colArticulo";
            this.colArticulo.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(296, 382);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.TabIndex = 54;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.Location = new System.Drawing.Point(62, 382);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(40, 40);
            this.btnEliminar.TabIndex = 52;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGrabar.BackgroundImage")));
            this.btnGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGrabar.Location = new System.Drawing.Point(10, 382);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(40, 40);
            this.btnGrabar.TabIndex = 51;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(433, 369);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(49, 20);
            this.txtSubtotal.TabIndex = 47;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(433, 393);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(49, 20);
            this.txtDescuento.TabIndex = 48;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(433, 417);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(49, 20);
            this.txtTotal.TabIndex = 49;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(385, 420);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 46;
            this.lblTotal.Text = "Total";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(357, 396);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(59, 13);
            this.lblDescuento.TabIndex = 45;
            this.lblDescuento.Text = "Descuento";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(370, 372);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lblSubtotal.TabIndex = 44;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // chkPagado
            // 
            this.chkPagado.AutoSize = true;
            this.chkPagado.Location = new System.Drawing.Point(414, 340);
            this.chkPagado.Name = "chkPagado";
            this.chkPagado.Size = new System.Drawing.Size(63, 17);
            this.chkPagado.TabIndex = 55;
            this.chkPagado.Text = "Pagado";
            this.chkPagado.UseVisualStyleBackColor = true;
            // 
            // btnBuscarFactura
            // 
            this.btnBuscarFactura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarFactura.BackgroundImage")));
            this.btnBuscarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarFactura.Location = new System.Drawing.Point(113, 382);
            this.btnBuscarFactura.Name = "btnBuscarFactura";
            this.btnBuscarFactura.Size = new System.Drawing.Size(40, 40);
            this.btnBuscarFactura.TabIndex = 56;
            this.btnBuscarFactura.UseVisualStyleBackColor = true;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 458);
            this.Controls.Add(this.btnBuscarFactura);
            this.Controls.Add(this.chkPagado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.grdGrilla);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtTotalParcial);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblTotalParcial);
            this.Controls.Add(this.btnArticulo);
            this.Controls.Add(this.txtNombreArticulo);
            this.Controls.Add(this.txtNroArticulo);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.txtNumeroPedido);
            this.Controls.Add(this.lblNumeroPedido);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.txtNroCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Name = "frmFactura";
            this.Text = "frmFactura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.TextBox txtNroCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNumeroPedido;
        private System.Windows.Forms.TextBox txtNumeroPedido;
        private System.Windows.Forms.Button btnArticulo;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.TextBox txtNroArticulo;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTotalParcial;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTotalParcial;
        private System.Windows.Forms.DataGridView grdGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.CheckBox chkPagado;
        private System.Windows.Forms.Button btnBuscarFactura;
    }
}