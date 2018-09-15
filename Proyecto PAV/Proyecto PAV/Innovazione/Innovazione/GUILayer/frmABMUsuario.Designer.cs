namespace Innovazione.GUILayer
{
    partial class frmABMUsuario
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
            this.lblIDUsuario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtNuevoUsuario = new System.Windows.Forms.TextBox();
            this.btnAceptarUser = new System.Windows.Forms.Button();
            this.btnSalirUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIDUsuario
            // 
            this.lblIDUsuario.AutoSize = true;
            this.lblIDUsuario.Location = new System.Drawing.Point(85, 42);
            this.lblIDUsuario.Name = "lblIDUsuario";
            this.lblIDUsuario.Size = new System.Drawing.Size(67, 13);
            this.lblIDUsuario.TabIndex = 0;
            this.lblIDUsuario.Text = "IDUsuario (*)";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(95, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre (*)";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(78, 99);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(74, 13);
            this.lblContrasenia.TabIndex = 2;
            this.lblContrasenia.Text = "Contraseña (*)";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(158, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(24, 20);
            this.txtID.TabIndex = 3;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(158, 96);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(174, 20);
            this.txtContrasenia.TabIndex = 4;
            // 
            // txtNuevoUsuario
            // 
            this.txtNuevoUsuario.Location = new System.Drawing.Point(158, 67);
            this.txtNuevoUsuario.Name = "txtNuevoUsuario";
            this.txtNuevoUsuario.Size = new System.Drawing.Size(174, 20);
            this.txtNuevoUsuario.TabIndex = 5;
            // 
            // btnAceptarUser
            // 
            this.btnAceptarUser.Location = new System.Drawing.Point(107, 136);
            this.btnAceptarUser.Name = "btnAceptarUser";
            this.btnAceptarUser.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarUser.TabIndex = 6;
            this.btnAceptarUser.Text = "Aceptar";
            this.btnAceptarUser.UseVisualStyleBackColor = true;
            this.btnAceptarUser.Click += new System.EventHandler(this.btnAceptarUser_Click);
            // 
            // btnSalirUser
            // 
            this.btnSalirUser.Location = new System.Drawing.Point(214, 136);
            this.btnSalirUser.Name = "btnSalirUser";
            this.btnSalirUser.Size = new System.Drawing.Size(75, 23);
            this.btnSalirUser.TabIndex = 7;
            this.btnSalirUser.Text = "Cancelar";
            this.btnSalirUser.UseVisualStyleBackColor = true;
            // 
            // frmABMUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 171);
            this.Controls.Add(this.btnSalirUser);
            this.Controls.Add(this.btnAceptarUser);
            this.Controls.Add(this.txtNuevoUsuario);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIDUsuario);
            this.Name = "frmABMUsuario";
            this.Text = "frmABMUsuario";
            this.Load += new System.EventHandler(this.frmABMUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtNuevoUsuario;
        private System.Windows.Forms.Button btnAceptarUser;
        private System.Windows.Forms.Button btnSalirUser;
    }
}