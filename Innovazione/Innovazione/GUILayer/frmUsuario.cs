using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Innovazione.Bussines_Layer;
using Innovazione.Bussines_Layer.Services;
using Innovazione.GUILayer;

namespace Innovazione
{
    public partial class frmUsuario : Form
    {
        private UsuarioService oUsuarioService;

        public frmUsuario()
        {
            InitializeComponent();
            oUsuarioService = new UsuarioService();
        }

        

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                txtUsuario.Enabled = false;
                chkHabilitado.Enabled = false;
            }
            else
            {
                txtUsuario.Enabled = true;
                chkHabilitado.Enabled = true;
            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnConsultarUsuario_Click(object sender, EventArgs e)
        {
            List<object> filters = new List<object>();
            bool flagFiltros = false;

            if (!chkTodos.Checked)
            {
                if(txtUsuario.Text != string.Empty)
                {
                    filters.Add(txtUsuario.Text);
                    flagFiltros = true;
                }
                else
                {
                    filters.Add(null);   
                }
                if (chkHabilitado.Checked)
                {
                    filters.Add("S");
                    flagFiltros = true;
                }
                else
                {
                    filters.Add(null);
                }

                if (flagFiltros)
                {
                    llenarGrilla(oUsuarioService.consultarUsuariosConFiltros(filters));
                }
                else
                {
                    MessageBox.Show("Debe cargar al menos un criterio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                llenarGrilla(oUsuarioService.consultarUsuarios());
            }
        }

        private void grdUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
        }

        private void llenarGrilla(IList<Usuario> source)
        {
            grdUsuario.Rows.Clear();
            foreach (Usuario oUsuario in source)
                grdUsuario.Rows.Add(new string[] { oUsuario.idUsuario.ToString(), oUsuario.nomUser, oUsuario.contraseña, oUsuario.activo });
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMUsuario oABMUsuario = new frmABMUsuario();
            oABMUsuario.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmABMUsuario form = new frmABMUsuario();
            form.SeleccionarUsuario(frmABMUsuario.Opcion.update, mapUsuarioFila());
            form.ShowDialog();
            btnConsultarUsuario_Click(sender, e);
        }

        private Usuario mapUsuarioFila()
        {
            Usuario oUsuario = new Usuario();
            oUsuario.idUsuario = int.Parse(grdUsuario.CurrentRow.Cells["columnID"].Value.ToString());
            oUsuario.nomUser = grdUsuario.CurrentRow.Cells["columnNomUser"].Value.ToString();
            oUsuario.contraseña = grdUsuario.CurrentRow.Cells["columnContrasenia"].Value.ToString();
            oUsuario.activo = grdUsuario.CurrentRow.Cells["columnActivo"].Value.ToString();

            return oUsuario;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            frmABMUsuario form = new frmABMUsuario();
            form.SeleccionarUsuario(frmABMUsuario.Opcion.delete, mapUsuarioFila());
            form.ShowDialog();
            btnConsultarUsuario_Click(sender, e);
        }

        private void grdUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
