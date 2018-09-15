using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Innovazione

{
    public partial class frmPrincipal : Form
    {
        frmLogin ventanaLogin = new frmLogin();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ventanaLogin.ShowDialog();
            String usuario = ventanaLogin.getUsuario();
            lblUsuario.Text += usuarioActual();
            
        }

        public string usuarioActual()
        {
            String usuario = ventanaLogin.getUsuario();
            return usuario;
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmCerrarSesion cerrarSesion = new frmCerrarSesion();
            //cerrarSesion.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario userfrm = new frmUsuario();
            userfrm.Show();
        }
    }
}
