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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpConsultarCliente = new System.Windows.Forms.TabPage();
            this.tbpNuevoCliente = new System.Windows.Forms.TabPage();
            this.tbpModificarCliente = new System.Windows.Forms.TabPage();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.cmbTipoDni = new System.Windows.Forms.ComboBox();
            this.lblTipoDni = new System.Windows.Forms.Label();
            this.grdConsultaClientes = new System.Windows.Forms.DataGridView();
            this.columnNroDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTipoDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbpConsultarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpConsultarCliente);
            this.tabControl1.Controls.Add(this.tbpNuevoCliente);
            this.tabControl1.Controls.Add(this.tbpModificarCliente);
            this.tabControl1.Location = new System.Drawing.Point(1, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(692, 336);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpConsultarCliente
            // 
            this.tbpConsultarCliente.Controls.Add(this.btnConsultar);
            this.tbpConsultarCliente.Controls.Add(this.grdConsultaClientes);
            this.tbpConsultarCliente.Controls.Add(this.lblTipoDni);
            this.tbpConsultarCliente.Controls.Add(this.cmbTipoDni);
            this.tbpConsultarCliente.Controls.Add(this.lblDni);
            this.tbpConsultarCliente.Controls.Add(this.txtDNICliente);
            this.tbpConsultarCliente.Location = new System.Drawing.Point(4, 22);
            this.tbpConsultarCliente.Name = "tbpConsultarCliente";
            this.tbpConsultarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsultarCliente.Size = new System.Drawing.Size(684, 310);
            this.tbpConsultarCliente.TabIndex = 0;
            this.tbpConsultarCliente.Text = "Consultar";
            this.tbpConsultarCliente.UseVisualStyleBackColor = true;
            //this.tbpConsultarCliente.Click += new System.EventHandler(this.tbpConsultarCliente_Click);
            // 
            // tbpNuevoCliente
            // 
            this.tbpNuevoCliente.Location = new System.Drawing.Point(4, 22);
            this.tbpNuevoCliente.Name = "tbpNuevoCliente";
            this.tbpNuevoCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tbpNuevoCliente.Size = new System.Drawing.Size(192, 74);
            this.tbpNuevoCliente.TabIndex = 1;
            this.tbpNuevoCliente.Text = "Nuevo";
            this.tbpNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // tbpModificarCliente
            // 
            this.tbpModificarCliente.Location = new System.Drawing.Point(4, 22);
            this.tbpModificarCliente.Name = "tbpModificarCliente";
            this.tbpModificarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tbpModificarCliente.Size = new System.Drawing.Size(594, 316);
            this.tbpModificarCliente.TabIndex = 2;
            this.tbpModificarCliente.Text = "Modificar/Eliminar";
            this.tbpModificarCliente.UseVisualStyleBackColor = true;
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Location = new System.Drawing.Point(83, 57);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.Size = new System.Drawing.Size(150, 20);
            this.txtDNICliente.TabIndex = 0;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(51, 60);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "DNI";
            // 
            // cmbTipoDni
            // 
            this.cmbTipoDni.FormattingEnabled = true;
            this.cmbTipoDni.Location = new System.Drawing.Point(83, 30);
            this.cmbTipoDni.Name = "cmbTipoDni";
            this.cmbTipoDni.Size = new System.Drawing.Size(150, 21);
            this.cmbTipoDni.TabIndex = 2;
            // 
            // lblTipoDni
            // 
            this.lblTipoDni.AutoSize = true;
            this.lblTipoDni.Location = new System.Drawing.Point(30, 33);
            this.lblTipoDni.Name = "lblTipoDni";
            this.lblTipoDni.Size = new System.Drawing.Size(47, 13);
            this.lblTipoDni.TabIndex = 3;
            this.lblTipoDni.Text = "Tipo Dni";
            // 
            // grdConsultaClientes
            // 
            this.grdConsultaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsultaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNroDni,
            this.columnTipoDni,
            this.columnApellido,
            this.columnNombre,
            this.columnMail,
            this.columnTelefono});
            this.grdConsultaClientes.Location = new System.Drawing.Point(6, 122);
            this.grdConsultaClientes.Name = "grdConsultaClientes";
            this.grdConsultaClientes.Size = new System.Drawing.Size(642, 150);
            this.grdConsultaClientes.TabIndex = 4;
            // 
            // columnNroDni
            // 
            this.columnNroDni.HeaderText = "Número Dni";
            this.columnNroDni.Name = "columnNroDni";
            // 
            // columnTipoDni
            // 
            this.columnTipoDni.HeaderText = "Tipo Dni";
            this.columnTipoDni.Name = "columnTipoDni";
            // 
            // columnApellido
            // 
            this.columnApellido.HeaderText = "Apellido";
            this.columnApellido.Name = "columnApellido";
            // 
            // columnNombre
            // 
            this.columnNombre.HeaderText = "Nombre";
            this.columnNombre.Name = "columnNombre";
            // 
            // columnMail
            // 
            this.columnMail.HeaderText = "Email";
            this.columnMail.Name = "columnMail";
            // 
            // columnTelefono
            // 
            this.columnTelefono.HeaderText = "Telefono";
            this.columnTelefono.Name = "columnTelefono";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(118, 83);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            //this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 336);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpConsultarCliente.ResumeLayout(false);
            this.tbpConsultarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpConsultarCliente;
        private System.Windows.Forms.TabPage tbpNuevoCliente;
        private System.Windows.Forms.TabPage tbpModificarCliente;
        private System.Windows.Forms.DataGridView grdConsultaClientes;
        private System.Windows.Forms.Label lblTipoDni;
        private System.Windows.Forms.ComboBox cmbTipoDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNroDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTipoDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTelefono;
        private System.Windows.Forms.Button btnConsultar;
    }
}