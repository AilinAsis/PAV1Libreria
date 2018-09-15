using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Innovazione.Bussines_Layer.Services;




namespace Innovazione
{
    
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {
            
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            if (txtUsuario.Text == String.Empty || txtContrasenia.Text == String.Empty)
            {
                MessageBox.Show("Error... No debe haber campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
            }
            else
            {
                UsuarioService oUsuarioService = new UsuarioService();
                if (oUsuarioService.validarUsuario(txtUsuario.Text, txtContrasenia.Text) != null)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erorr.. Usuario inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Clear();
                    txtContrasenia.Clear();
                    txtUsuario.Focus();
                }
            }
            
            /*if (txtUsuario.Text == "Keila123")
            {
                if(txtContrasenia.Text == "innovazione456")
                {
                    lblUsuarioIncorrecto.Visible = false;
                    lblContraseniaIncorrecta.Visible = false;
                    MessageBox.Show("Logueo exitoso");
                    this.Close();
                } else
                {
                    lblUsuarioIncorrecto.Visible = false;
                    lblContraseniaIncorrecta.Visible = true;
                }
            }else
            {
                lblContraseniaIncorrecta.Visible = false;
                lblUsuarioIncorrecto.Visible = true;
            }*/
            
        }

        public String getUsuario()
        {
            return txtUsuario.Text;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

       /* private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                
                Application.Exit();
              
            }
            else
            {
                e.Cancel = true;
            }
        }*/
    }
}
