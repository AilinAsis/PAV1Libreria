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

namespace Innovazione.GUILayer
{
    public partial class frmProveedor : Form
    {
        private ProveedorService oProveedorService;
        public frmProveedor()
        {
            InitializeComponent();
            oProveedorService = new ProveedorService();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMProveedor formulario = new frmABMProveedor();
            formulario.ShowDialog();
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                txtCuil.Enabled = false;
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
            }
            else
            {
                txtCuil.Enabled = true;
                txtNombre.Enabled = true;
                txtApellido.Enabled = true;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<object> filtros = new List<object>();
            bool banderaFiltros = false;

            if (!chkTodos.Checked)
            {
                if (txtCuil.Text != string.Empty)
                {
                    filtros.Add(txtCuil.Text);
                    banderaFiltros = true;
                }
                else
                    filtros.Add(null);
                if (txtNombre.Text != string.Empty)
                {
                    filtros.Add(txtNombre.Text);
                    banderaFiltros = true;
                }
                else
                    filtros.Add(null);
                if (txtApellido.Text != string.Empty)
                {
                    filtros.Add(txtApellido.Text);
                    banderaFiltros = true;
                }
                else
                    filtros.Add(null);

                if (banderaFiltros)
                    llenarGrilla(oProveedorService.consultaConFiltros(filtros));
                else
                    MessageBox.Show("Debe ingresar al menos un criterio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                llenarGrilla(oProveedorService.getAll());
            }

            if (grdConsultarProveedor.Rows.Count == 0)
                MessageBox.Show("No se encontraron resultados", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void llenarGrilla(IList<Proveedor> source)
        {
            grdConsultarProveedor.Rows.Clear();
            foreach (Proveedor oProveedor in source)
                grdConsultarProveedor.Rows.Add(new string[] { oProveedor.idProveedor.ToString(),
                oProveedor.CUIL.ToString(),
                oProveedor.nombre,
                oProveedor.apellido,
                oProveedor.estadoBajaProveedor.ToString()});
        }
        
        private void grdConsultarProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        
        private Proveedor mapProveedorFila()
        {
            Proveedor oProveedor = new Proveedor();
            oProveedor.idProveedor = int.Parse(grdConsultarProveedor.CurrentRow.Cells["colIdProveedor"].Value.ToString());
            oProveedor.CUIL = grdConsultarProveedor.CurrentRow.Cells["colCuil"].Value.ToString();
            oProveedor.nombre = grdConsultarProveedor.CurrentRow.Cells["colNombre"].Value.ToString();
            oProveedor.apellido = grdConsultarProveedor.CurrentRow.Cells["colApellido"].Value.ToString();
            oProveedor.estadoBajaProveedor = Convert.ToChar(grdConsultarProveedor.CurrentRow.Cells["colEstadoBajaProveedor"].Value.ToString());
            return oProveedor;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmABMProveedor formulario = new frmABMProveedor();
            formulario.seleccionarProveedor(frmABMProveedor.Opcion.update, mapProveedorFila());
            formulario.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmABMProveedor formulario = new frmABMProveedor();
            formulario.seleccionarProveedor(frmABMProveedor.Opcion.delete, mapProveedorFila());
            formulario.ShowDialog();
        }
    }
}
