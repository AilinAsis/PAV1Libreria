namespace Innovazione
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.grdUsuario = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNomUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnContrasenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultarUsuario = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(28, 32);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(77, 29);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(197, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(77, 81);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(56, 17);
            this.chkTodos.TabIndex = 2;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // grdUsuario
            // 
            this.grdUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnNomUser,
            this.columnContrasenia,
            this.columnActivo});
            this.grdUsuario.Location = new System.Drawing.Point(13, 124);
            this.grdUsuario.Name = "grdUsuario";
            this.grdUsuario.Size = new System.Drawing.Size(262, 150);
            this.grdUsuario.TabIndex = 3;
            this.grdUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUsuario_CellContentClick);
            // 
            // columnId
            // 
            this.columnId.HeaderText = "IDUsuario";
            this.columnId.Name = "columnId";
            // 
            // columnNomUser
            // 
            this.columnNomUser.HeaderText = "Nombre Usuario";
            this.columnNomUser.Name = "columnNomUser";
            this.columnNomUser.Width = 120;
            // 
            // columnContrasenia
            // 
            this.columnContrasenia.HeaderText = "Contraseña";
            this.columnContrasenia.Name = "columnContrasenia";
            this.columnContrasenia.Visible = false;
            // 
            // columnActivo
            // 
            this.columnActivo.HeaderText = "Activo";
            this.columnActivo.Name = "columnActivo";
            this.columnActivo.Visible = false;
            // 
            // btnConsultarUsuario
            // 
            this.btnConsultarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultarUsuario.BackgroundImage")));
            this.btnConsultarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConsultarUsuario.Location = new System.Drawing.Point(238, 70);
            this.btnConsultarUsuario.Name = "btnConsultarUsuario";
            this.btnConsultarUsuario.Size = new System.Drawing.Size(36, 36);
            this.btnConsultarUsuario.TabIndex = 4;
            this.btnConsultarUsuario.UseVisualStyleBackColor = true;
            this.btnConsultarUsuario.Click += new System.EventHandler(this.btnConsultarUsuario_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(239, 290);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(36, 36);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevo.Location = new System.Drawing.Point(13, 290);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(36, 36);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Location = new System.Drawing.Point(55, 290);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(36, 36);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeshabilitar.BackgroundImage")));
            this.btnDeshabilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeshabilitar.Location = new System.Drawing.Point(97, 290);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(36, 36);
            this.btnDeshabilitar.TabIndex = 8;
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(77, 58);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(73, 17);
            this.chkHabilitado.TabIndex = 9;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 338);
            this.Controls.Add(this.chkHabilitado);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultarUsuario);
            this.Controls.Add(this.grdUsuario);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Name = "frmUsuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.DataGridView grdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNomUser;
        private System.Windows.Forms.Button btnConsultarUsuario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnContrasenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnActivo;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.CheckBox chkHabilitado;
    }
}