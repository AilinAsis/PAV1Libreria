namespace Innovazione
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.tbpConsultarCliente = new System.Windows.Forms.TabPage();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.grdConsultaClientes = new System.Windows.Forms.DataGridView();
            this.columnNroDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTipoDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdTipoDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoBajaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTipoDni = new System.Windows.Forms.Label();
            this.cmbTipoDni = new System.Windows.Forms.ComboBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpConsultarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaClientes)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpConsultarCliente
            // 
            this.tbpConsultarCliente.Controls.Add(this.btnNuevo);
            this.tbpConsultarCliente.Controls.Add(this.btnEliminar);
            this.tbpConsultarCliente.Controls.Add(this.btnModificar);
            this.tbpConsultarCliente.Controls.Add(this.chkTodos);
            this.tbpConsultarCliente.Controls.Add(this.lblApellido);
            this.tbpConsultarCliente.Controls.Add(this.txtApellido);
            this.tbpConsultarCliente.Controls.Add(this.lblNombre);
            this.tbpConsultarCliente.Controls.Add(this.txtNombre);
            this.tbpConsultarCliente.Controls.Add(this.btnConsultar);
            this.tbpConsultarCliente.Controls.Add(this.grdConsultaClientes);
            this.tbpConsultarCliente.Controls.Add(this.lblTipoDni);
            this.tbpConsultarCliente.Controls.Add(this.cmbTipoDni);
            this.tbpConsultarCliente.Controls.Add(this.lblDni);
            this.tbpConsultarCliente.Controls.Add(this.txtDNICliente);
            this.tbpConsultarCliente.Location = new System.Drawing.Point(4, 22);
            this.tbpConsultarCliente.Name = "tbpConsultarCliente";
            this.tbpConsultarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsultarCliente.Size = new System.Drawing.Size(684, 393);
            this.tbpConsultarCliente.TabIndex = 0;
            this.tbpConsultarCliente.Text = "Consultar";
            this.tbpConsultarCliente.UseVisualStyleBackColor = true;
            this.tbpConsultarCliente.Click += new System.EventHandler(this.tbpConsultarCliente_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevo.Location = new System.Drawing.Point(506, 351);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(36, 36);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.Location = new System.Drawing.Point(613, 351);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(36, 36);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificar.Location = new System.Drawing.Point(560, 351);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(36, 36);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(83, 133);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(56, 17);
            this.chkTodos.TabIndex = 10;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(33, 110);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(83, 107);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(150, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 84);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultar.BackgroundImage")));
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConsultar.Location = new System.Drawing.Point(197, 133);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(36, 36);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // grdConsultaClientes
            // 
            this.grdConsultaClientes.AllowUserToAddRows = false;
            this.grdConsultaClientes.AllowUserToDeleteRows = false;
            this.grdConsultaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsultaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNroDni,
            this.columnTipoDni,
            this.columnApellido,
            this.columnNombre,
            this.columnMail,
            this.columnTelefono,
            this.columnIdTipoDni,
            this.colEstadoBajaCliente,
            this.colIdCliente});
            this.grdConsultaClientes.Location = new System.Drawing.Point(7, 189);
            this.grdConsultaClientes.Name = "grdConsultaClientes";
            this.grdConsultaClientes.ReadOnly = true;
            this.grdConsultaClientes.Size = new System.Drawing.Size(642, 150);
            this.grdConsultaClientes.TabIndex = 4;
            this.grdConsultaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsultaClientes_CellContentClick);
            // 
            // columnNroDni
            // 
            this.columnNroDni.HeaderText = "Número Dni";
            this.columnNroDni.Name = "columnNroDni";
            this.columnNroDni.ReadOnly = true;
            // 
            // columnTipoDni
            // 
            this.columnTipoDni.HeaderText = "Tipo Dni";
            this.columnTipoDni.Name = "columnTipoDni";
            this.columnTipoDni.ReadOnly = true;
            // 
            // columnApellido
            // 
            this.columnApellido.HeaderText = "Apellido";
            this.columnApellido.Name = "columnApellido";
            this.columnApellido.ReadOnly = true;
            // 
            // columnNombre
            // 
            this.columnNombre.HeaderText = "Nombre";
            this.columnNombre.Name = "columnNombre";
            this.columnNombre.ReadOnly = true;
            // 
            // columnMail
            // 
            this.columnMail.HeaderText = "Email";
            this.columnMail.Name = "columnMail";
            this.columnMail.ReadOnly = true;
            // 
            // columnTelefono
            // 
            this.columnTelefono.HeaderText = "Teléfono";
            this.columnTelefono.Name = "columnTelefono";
            this.columnTelefono.ReadOnly = true;
            // 
            // columnIdTipoDni
            // 
            this.columnIdTipoDni.HeaderText = "IdTipoDni";
            this.columnIdTipoDni.Name = "columnIdTipoDni";
            this.columnIdTipoDni.ReadOnly = true;
            this.columnIdTipoDni.Visible = false;
            // 
            // colEstadoBajaCliente
            // 
            this.colEstadoBajaCliente.HeaderText = "EstadoCliente";
            this.colEstadoBajaCliente.Name = "colEstadoBajaCliente";
            this.colEstadoBajaCliente.ReadOnly = true;
            this.colEstadoBajaCliente.Visible = false;
            // 
            // colIdCliente
            // 
            this.colIdCliente.HeaderText = "Id";
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.ReadOnly = true;
            this.colIdCliente.Visible = false;
            // 
            // lblTipoDni
            // 
            this.lblTipoDni.AutoSize = true;
            this.lblTipoDni.Location = new System.Drawing.Point(30, 31);
            this.lblTipoDni.Name = "lblTipoDni";
            this.lblTipoDni.Size = new System.Drawing.Size(47, 13);
            this.lblTipoDni.TabIndex = 3;
            this.lblTipoDni.Text = "Tipo Dni";
            // 
            // cmbTipoDni
            // 
            this.cmbTipoDni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDni.FormattingEnabled = true;
            this.cmbTipoDni.Location = new System.Drawing.Point(83, 28);
            this.cmbTipoDni.Name = "cmbTipoDni";
            this.cmbTipoDni.Size = new System.Drawing.Size(150, 21);
            this.cmbTipoDni.TabIndex = 2;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(51, 58);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "DNI";
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Location = new System.Drawing.Point(83, 55);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.Size = new System.Drawing.Size(150, 20);
            this.txtDNICliente.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpConsultarCliente);
            this.tabControl1.Location = new System.Drawing.Point(1, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(692, 419);
            this.tabControl1.TabIndex = 0;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 418);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmCliente";
            this.Text = "Innovazione - Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.tbpConsultarCliente.ResumeLayout(false);
            this.tbpConsultarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaClientes)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tbpConsultarCliente;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView grdConsultaClientes;
        private System.Windows.Forms.Label lblTipoDni;
        private System.Windows.Forms.ComboBox cmbTipoDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNroDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTipoDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdTipoDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoBajaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCliente;
    }
}