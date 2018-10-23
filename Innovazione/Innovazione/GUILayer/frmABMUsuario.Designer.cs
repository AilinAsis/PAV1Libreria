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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMUsuario));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtNuevoUsuario = new System.Windows.Forms.TextBox();
            this.btnAceptarUser = new System.Windows.Forms.Button();
            this.btnSalirUser = new System.Windows.Forms.Button();
            this.txtRepetirContrasenia = new System.Windows.Forms.TextBox();
            this.lblRepetirContrasenia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(95, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre (*)";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(78, 58);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(74, 13);
            this.lblContrasenia.TabIndex = 2;
            this.lblContrasenia.Text = "Contraseña (*)";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(158, 55);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(174, 20);
            this.txtContrasenia.TabIndex = 4;
            // 
            // txtNuevoUsuario
            // 
            this.txtNuevoUsuario.Location = new System.Drawing.Point(158, 26);
            this.txtNuevoUsuario.Name = "txtNuevoUsuario";
            this.txtNuevoUsuario.Size = new System.Drawing.Size(174, 20);
            this.txtNuevoUsuario.TabIndex = 5;
            // 
            // btnAceptarUser
            // 
            this.btnAceptarUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceptarUser.BackgroundImage")));
            this.btnAceptarUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAceptarUser.Location = new System.Drawing.Point(254, 136);
            this.btnAceptarUser.Name = "btnAceptarUser";
            this.btnAceptarUser.Size = new System.Drawing.Size(36, 36);
            this.btnAceptarUser.TabIndex = 6;
            this.btnAceptarUser.UseVisualStyleBackColor = true;
            this.btnAceptarUser.Click += new System.EventHandler(this.btnAceptarUser_Click);
            // 
            // btnSalirUser
            // 
            this.btnSalirUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalirUser.BackgroundImage")));
            this.btnSalirUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalirUser.Location = new System.Drawing.Point(296, 136);
            this.btnSalirUser.Name = "btnSalirUser";
            this.btnSalirUser.Size = new System.Drawing.Size(36, 36);
            this.btnSalirUser.TabIndex = 7;
            this.btnSalirUser.UseVisualStyleBackColor = true;
            this.btnSalirUser.Click += new System.EventHandler(this.btnSalirUser_Click);
            // 
            // txtRepetirContrasenia
            // 
            this.txtRepetirContrasenia.Location = new System.Drawing.Point(158, 81);
            this.txtRepetirContrasenia.Name = "txtRepetirContrasenia";
            this.txtRepetirContrasenia.PasswordChar = '*';
            this.txtRepetirContrasenia.Size = new System.Drawing.Size(174, 20);
            this.txtRepetirContrasenia.TabIndex = 9;
            // 
            // lblRepetirContrasenia
            // 
            this.lblRepetirContrasenia.AutoSize = true;
            this.lblRepetirContrasenia.Location = new System.Drawing.Point(42, 84);
            this.lblRepetirContrasenia.Name = "lblRepetirContrasenia";
            this.lblRepetirContrasenia.Size = new System.Drawing.Size(110, 13);
            this.lblRepetirContrasenia.TabIndex = 8;
            this.lblRepetirContrasenia.Text = "Repetir contraseña (*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Campos Obligatorios (*)";
            // 
            // frmABMUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 188);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRepetirContrasenia);
            this.Controls.Add(this.lblRepetirContrasenia);
            this.Controls.Add(this.btnSalirUser);
            this.Controls.Add(this.btnAceptarUser);
            this.Controls.Add(this.txtNuevoUsuario);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmABMUsuario";
            this.Text = "frmABMUsuario";
            this.Load += new System.EventHandler(this.frmABMUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtNuevoUsuario;
        private System.Windows.Forms.Button btnAceptarUser;
        private System.Windows.Forms.Button btnSalirUser;
        private System.Windows.Forms.TextBox txtRepetirContrasenia;
        private System.Windows.Forms.Label lblRepetirContrasenia;
        private System.Windows.Forms.Label label1;
    }
}