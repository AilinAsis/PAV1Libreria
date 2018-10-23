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
    public partial class frmCliente : Form
    {
        private ClienteService oClienteService;
        public frmCliente()
        {
            InitializeComponent();
            oClienteService = new ClienteService();

        }

        private void llenarCombo(ComboBox cmb, Object source, string display, String value)
        {
            cmb.DataSource = source;
            cmb.DisplayMember = display;
            cmb.ValueMember = value;
            cmb.SelectedIndex = -1;
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            llenarCombo(cmbTipoDni, BDHelper.getBDHelper().ConsultaSQL("SELECT * FROM TipoDni WHERE idTipoDni >= 1"), "descripcion", "idTipoDni");
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        

        private void tbpConsultarCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                cmbTipoDni.Enabled = false;
                txtDNICliente.Enabled = false;
                txtApellido.Enabled = false;
                txtNombre.Enabled = false;
            }
            else
            {
                cmbTipoDni.Enabled = true;
                txtDNICliente.Enabled = true;
                txtApellido.Enabled = true;
                txtNombre.Enabled = true;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<object> filtros = new List<object>();
            bool banderaFiltros = false;

            if (!chkTodos.Checked)
            {
                if (cmbTipoDni.Text != string.Empty)
                {
                    filtros.Add(cmbTipoDni.SelectedValue);
                    banderaFiltros = true;
                }
                else
                {
                    filtros.Add(null);
                }
                if (txtDNICliente.Text != string.Empty)
                {
                    filtros.Add(txtDNICliente.Text);
                    banderaFiltros = true;
                }
                else
                {
                    filtros.Add(null);
                }
                if (txtNombre.Text != string.Empty)
                {
                    filtros.Add(txtNombre.Text);
                    banderaFiltros = true;
                }
                else
                {
                    filtros.Add(null);
                }
                if (txtApellido.Text != string.Empty)
                {
                    filtros.Add(txtApellido.Text);
                    banderaFiltros = true;
                }
                else
                {
                    filtros.Add(null);
                }

                if (banderaFiltros)
                {
                    llenarGrilla(oClienteService.consultarUsuarioConFiltros(filtros));
                }
                else
                {
                    MessageBox.Show("Ingrese un criterio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                llenarGrilla(oClienteService.allClientes());
            }
            
        }

        

        private void llenarGrilla(IList<Cliente> source)
        {
            grdConsultaClientes.Rows.Clear();
            foreach (Cliente oCliente in source)
                grdConsultaClientes.Rows.Add(new string[] {oCliente.nroDni.ToString(), oCliente.descripcionTipoDni,
                oCliente.apellido, oCliente.nombre, oCliente.mail, oCliente.telefono.ToString(), oCliente.idTipoDni.ToString(), oCliente.estadoBajaCliente.ToString(), oCliente.idCliente.ToString()});
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMClientes nuevoCliente = new frmABMClientes();
            nuevoCliente.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmABMClientes formClientes = new frmABMClientes();
            formClientes.seleccionarCliente(frmABMClientes.Opcion.update, mapClienteFila());
            formClientes.ShowDialog();
            //btnModificar_Click(sender, e);
        }

        private Cliente mapClienteFila()
        {
            Cliente oCliente = new Cliente();
            oCliente.nroDni = Convert.ToInt32(grdConsultaClientes.CurrentRow.Cells["columnNroDni"].Value.ToString());
            oCliente.descripcionTipoDni = grdConsultaClientes.CurrentRow.Cells["columnTipoDni"].Value.ToString();
            oCliente.apellido = grdConsultaClientes.CurrentRow.Cells["columnApellido"].Value.ToString();
            oCliente.nombre = grdConsultaClientes.CurrentRow.Cells["columnNombre"].Value.ToString();
            oCliente.mail = grdConsultaClientes.CurrentRow.Cells["columnMail"].Value.ToString();
            oCliente.telefono = grdConsultaClientes.CurrentRow.Cells["columnTelefono"].Value.ToString();
            oCliente.idTipoDni = Convert.ToInt32(grdConsultaClientes.CurrentRow.Cells["columnIdTipoDni"].Value.ToString());
            oCliente.estadoBajaCliente = Convert.ToChar(grdConsultaClientes.CurrentRow.Cells["colEstadoBajaCliente"].Value.ToString());
            oCliente.idCliente = Convert.ToInt32(grdConsultaClientes.CurrentRow.Cells["colIdCliente"].Value.ToString());
            return oCliente;
        }

        private void grdConsultaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmABMClientes formClientes = new frmABMClientes();
            formClientes.seleccionarCliente(frmABMClientes.Opcion.delete, mapClienteFila());
            formClientes.ShowDialog();
            //btnEliminar_Click(sender, e);
        }
    }
}
