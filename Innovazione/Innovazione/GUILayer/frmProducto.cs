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
    public partial class frmProducto : Form
    {
        private ProductoService oProductoService;
        public frmProducto()
        {
            InitializeComponent();
            oProductoService = new ProductoService();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMProducto formulario = new frmABMProducto();
            formulario.ShowDialog();
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                txtNombreProducto.Enabled = false;
            }
            else
            {
                txtNombreProducto.Enabled = true;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<object> filtros = new List<object>();
            bool banderaFiltros = false;

            if (!chkTodos.Checked)
            {
                if (txtNombreProducto.Text != string.Empty)
                {
                    filtros.Add(txtNombreProducto.Text);
                    banderaFiltros = true;
                }
                else
                {
                    filtros.Add(null);
                }

                if (banderaFiltros)
                {
                    llenarGrilla(oProductoService.getByFilters(filtros));
                }
                else
                {
                    MessageBox.Show("Debe ingresar al menos un criterio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                llenarGrilla(oProductoService.getAll());
            }
            if (grdConsultarProductos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void llenarGrilla(IList<Producto> source)
        {
            grdConsultarProductos.Rows.Clear();
            foreach (Producto oProducto in source)
                grdConsultarProductos.Rows.Add(new string[] { oProducto.nombre, oProducto.descripcion, oProducto.precio.ToString(),
                oProducto.cantDisponible.ToString(), oProducto.estadoBajaProducto.ToString(), oProducto.idProducto.ToString()});
        }

        private Producto mapProductoFila()
        {
            Producto oProducto = new Producto();
            oProducto.nombre = grdConsultarProductos.CurrentRow.Cells["colNombre"].Value.ToString();
            oProducto.descripcion = grdConsultarProductos.CurrentRow.Cells["colDescripcion"].Value.ToString();
            oProducto.precio = double.Parse(grdConsultarProductos.CurrentRow.Cells["colPrecio"].Value.ToString());
            oProducto.cantDisponible = int.Parse(grdConsultarProductos.CurrentRow.Cells["colCantDisponible"].Value.ToString());
            oProducto.estadoBajaProducto = Convert.ToChar(grdConsultarProductos.CurrentRow.Cells["colEstadoBajaProducto"].Value.ToString());
            oProducto.idProducto = int.Parse(grdConsultarProductos.CurrentRow.Cells["colIdProducto"].Value.ToString());
            return oProducto;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmABMProducto formulario = new frmABMProducto();
            formulario.seleccionarProducto(frmABMProducto.Opcion.update, mapProductoFila());
            formulario.ShowDialog();
        }

        private void grdConsultarProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmABMProducto formulario = new frmABMProducto();
            formulario.seleccionarProducto(frmABMProducto.Opcion.delete, mapProductoFila());
            formulario.ShowDialog();
        }
    }
}
