namespace Innovazione
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itmArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itmCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.itmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.itmVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.itmCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.itmNuevoCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.itmConsultarCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.itmReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.itmNuevoReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.itmConsultarReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.itmInformes = new System.Windows.Forms.ToolStripMenuItem();
            this.itmReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.itmFacturasImpagas = new System.Windows.Forms.ToolStripMenuItem();
            this.itmReservasPendientes = new System.Windows.Forms.ToolStripMenuItem();
            this.itmComprasNoRecibidas = new System.Windows.Forms.ToolStripMenuItem();
            this.itmProductoSinStock = new System.Windows.Forms.ToolStripMenuItem();
            this.itmBalances = new System.Windows.Forms.ToolStripMenuItem();
            this.itmBalanceAnual = new System.Windows.Forms.ToolStripMenuItem();
            this.itmBalanceMensual = new System.Windows.Forms.ToolStripMenuItem();
            this.itmBalanceSemanal = new System.Windows.Forms.ToolStripMenuItem();
            this.itmBalancePorDia = new System.Windows.Forms.ToolStripMenuItem();
            this.itmEstadistica = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesConMásComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grdUsuario = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmArchivo,
            this.itmVentas,
            this.itmCompras,
            this.itmReserva,
            this.itmInformes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itmArchivo
            // 
            this.itmArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.proveedorToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.itmCerrarSesion,
            this.itmSalir});
            this.itmArchivo.Name = "itmArchivo";
            this.itmArchivo.Size = new System.Drawing.Size(60, 20);
            this.itmArchivo.Text = "Archivo";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            this.proveedorToolStripMenuItem.Click += new System.EventHandler(this.proveedorToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // itmCerrarSesion
            // 
            this.itmCerrarSesion.Name = "itmCerrarSesion";
            this.itmCerrarSesion.Size = new System.Drawing.Size(143, 22);
            this.itmCerrarSesion.Text = "Cerrar Sesión";
            this.itmCerrarSesion.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // itmSalir
            // 
            this.itmSalir.Name = "itmSalir";
            this.itmSalir.Size = new System.Drawing.Size(143, 22);
            this.itmSalir.Text = "Salir";
            this.itmSalir.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // itmVentas
            // 
            this.itmVentas.Name = "itmVentas";
            this.itmVentas.Size = new System.Drawing.Size(53, 20);
            this.itmVentas.Text = "Ventas";
            this.itmVentas.Click += new System.EventHandler(this.itmVentas_Click);
            // 
            // itmCompras
            // 
            this.itmCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmNuevoCompras,
            this.itmConsultarCompras});
            this.itmCompras.Name = "itmCompras";
            this.itmCompras.Size = new System.Drawing.Size(67, 20);
            this.itmCompras.Text = "Compras";
            // 
            // itmNuevoCompras
            // 
            this.itmNuevoCompras.Name = "itmNuevoCompras";
            this.itmNuevoCompras.Size = new System.Drawing.Size(125, 22);
            this.itmNuevoCompras.Text = "Nuevo";
            // 
            // itmConsultarCompras
            // 
            this.itmConsultarCompras.Name = "itmConsultarCompras";
            this.itmConsultarCompras.Size = new System.Drawing.Size(125, 22);
            this.itmConsultarCompras.Text = "Consultar";
            // 
            // itmReserva
            // 
            this.itmReserva.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmNuevoReserva,
            this.itmConsultarReserva});
            this.itmReserva.Name = "itmReserva";
            this.itmReserva.Size = new System.Drawing.Size(59, 20);
            this.itmReserva.Text = "Reserva";
            // 
            // itmNuevoReserva
            // 
            this.itmNuevoReserva.Name = "itmNuevoReserva";
            this.itmNuevoReserva.Size = new System.Drawing.Size(125, 22);
            this.itmNuevoReserva.Text = "Nuevo";
            // 
            // itmConsultarReserva
            // 
            this.itmConsultarReserva.Name = "itmConsultarReserva";
            this.itmConsultarReserva.Size = new System.Drawing.Size(125, 22);
            this.itmConsultarReserva.Text = "Consultar";
            // 
            // itmInformes
            // 
            this.itmInformes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmReportes,
            this.itmEstadistica});
            this.itmInformes.Name = "itmInformes";
            this.itmInformes.Size = new System.Drawing.Size(66, 20);
            this.itmInformes.Text = "Informes";
            // 
            // itmReportes
            // 
            this.itmReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmFacturasImpagas,
            this.itmReservasPendientes,
            this.itmComprasNoRecibidas,
            this.itmProductoSinStock,
            this.itmBalances});
            this.itmReportes.Name = "itmReportes";
            this.itmReportes.Size = new System.Drawing.Size(134, 22);
            this.itmReportes.Text = "Reportes";
            // 
            // itmFacturasImpagas
            // 
            this.itmFacturasImpagas.Name = "itmFacturasImpagas";
            this.itmFacturasImpagas.Size = new System.Drawing.Size(189, 22);
            this.itmFacturasImpagas.Text = "Facturas impagas";
            // 
            // itmReservasPendientes
            // 
            this.itmReservasPendientes.Name = "itmReservasPendientes";
            this.itmReservasPendientes.Size = new System.Drawing.Size(189, 22);
            this.itmReservasPendientes.Text = "Reservas pendientes";
            // 
            // itmComprasNoRecibidas
            // 
            this.itmComprasNoRecibidas.Name = "itmComprasNoRecibidas";
            this.itmComprasNoRecibidas.Size = new System.Drawing.Size(189, 22);
            this.itmComprasNoRecibidas.Text = "Compras no recibidas";
            // 
            // itmProductoSinStock
            // 
            this.itmProductoSinStock.Name = "itmProductoSinStock";
            this.itmProductoSinStock.Size = new System.Drawing.Size(189, 22);
            this.itmProductoSinStock.Text = "Productos sin stock";
            // 
            // itmBalances
            // 
            this.itmBalances.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmBalanceAnual,
            this.itmBalanceMensual,
            this.itmBalanceSemanal,
            this.itmBalancePorDia});
            this.itmBalances.Name = "itmBalances";
            this.itmBalances.Size = new System.Drawing.Size(189, 22);
            this.itmBalances.Text = "Balances";
            // 
            // itmBalanceAnual
            // 
            this.itmBalanceAnual.Name = "itmBalanceAnual";
            this.itmBalanceAnual.Size = new System.Drawing.Size(119, 22);
            this.itmBalanceAnual.Text = "Anual";
            // 
            // itmBalanceMensual
            // 
            this.itmBalanceMensual.Name = "itmBalanceMensual";
            this.itmBalanceMensual.Size = new System.Drawing.Size(119, 22);
            this.itmBalanceMensual.Text = "Mensual";
            // 
            // itmBalanceSemanal
            // 
            this.itmBalanceSemanal.Name = "itmBalanceSemanal";
            this.itmBalanceSemanal.Size = new System.Drawing.Size(119, 22);
            this.itmBalanceSemanal.Text = "Semanal";
            // 
            // itmBalancePorDia
            // 
            this.itmBalancePorDia.Name = "itmBalancePorDia";
            this.itmBalancePorDia.Size = new System.Drawing.Size(119, 22);
            this.itmBalancePorDia.Text = "Por día";
            // 
            // itmEstadistica
            // 
            this.itmEstadistica.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesConMásComprasToolStripMenuItem,
            this.estadísticaDeProductosToolStripMenuItem});
            this.itmEstadistica.Name = "itmEstadistica";
            this.itmEstadistica.Size = new System.Drawing.Size(134, 22);
            this.itmEstadistica.Text = "Estadísticas";
            // 
            // clientesConMásComprasToolStripMenuItem
            // 
            this.clientesConMásComprasToolStripMenuItem.Name = "clientesConMásComprasToolStripMenuItem";
            this.clientesConMásComprasToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.clientesConMásComprasToolStripMenuItem.Text = "Estadísticas de clientes";
            // 
            // estadísticaDeProductosToolStripMenuItem
            // 
            this.estadísticaDeProductosToolStripMenuItem.Name = "estadísticaDeProductosToolStripMenuItem";
            this.estadísticaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.estadísticaDeProductosToolStripMenuItem.Text = "Estadística de productos";
            // 
            // grdUsuario
            // 
            this.grdUsuario.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.grdUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsuario.Location = new System.Drawing.Point(0, 24);
            this.grdUsuario.Name = "grdUsuario";
            this.grdUsuario.Size = new System.Drawing.Size(1179, 43);
            this.grdUsuario.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 33);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.LimeGreen;
            this.lblUsuario.Location = new System.Drawing.Point(51, 40);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(98, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario ingresado: ";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(914, 378);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grdUsuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Principal - Innovazione";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itmArchivo;
        private System.Windows.Forms.ToolStripMenuItem itmCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem itmSalir;
        private System.Windows.Forms.ToolStripMenuItem itmVentas;
        private System.Windows.Forms.ToolStripMenuItem itmCompras;
        private System.Windows.Forms.ToolStripMenuItem itmNuevoCompras;
        private System.Windows.Forms.ToolStripMenuItem itmConsultarCompras;
        private System.Windows.Forms.ToolStripMenuItem itmReserva;
        private System.Windows.Forms.ToolStripMenuItem itmNuevoReserva;
        private System.Windows.Forms.ToolStripMenuItem itmConsultarReserva;
        private System.Windows.Forms.ToolStripMenuItem itmInformes;
        private System.Windows.Forms.ToolStripMenuItem itmReportes;
        private System.Windows.Forms.ToolStripMenuItem itmFacturasImpagas;
        private System.Windows.Forms.ToolStripMenuItem itmReservasPendientes;
        private System.Windows.Forms.ToolStripMenuItem itmComprasNoRecibidas;
        private System.Windows.Forms.ToolStripMenuItem itmEstadistica;
        private System.Windows.Forms.ToolStripMenuItem itmProductoSinStock;
        private System.Windows.Forms.ToolStripMenuItem itmBalances;
        private System.Windows.Forms.ToolStripMenuItem clientesConMásComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itmBalanceAnual;
        private System.Windows.Forms.ToolStripMenuItem itmBalanceMensual;
        private System.Windows.Forms.ToolStripMenuItem itmBalanceSemanal;
        private System.Windows.Forms.ToolStripMenuItem itmBalancePorDia;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
    }
}

