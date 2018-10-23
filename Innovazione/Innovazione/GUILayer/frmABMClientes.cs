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
using Innovazione.Bussines_Layer;

namespace Innovazione.GUILayer
{
    public partial class frmABMClientes : Form
    {

        
        public frmABMClientes()
        {
            InitializeComponent();
        }

        public enum Opcion
        {
            insert,
            update,
            delete,
        }

        private Opcion action = Opcion.insert;
        private ClienteService oClienteService = new ClienteService();
        private Cliente oClienteSelected;

        private void frmABMClientes_Load(object sender, EventArgs e)
        {
            llenarCombo(cmbTipoDniNuevo, BDHelper.getBDHelper().ConsultaSQL("SELECT * FROM TipoDni"), "descripcion", "idTipoDni");
            switch (action)
            {
                case Opcion.insert:
                    {
                        this.Text = "Nuevo Cliente";
                        break;
                    }
                case Opcion.update:
                    {
                        this.Text = "Modificar Cliente";
                        mostrarDatos();
                        break;
                    }
                case Opcion.delete:
                    {
                        this.Text = "Eliminar cliente";
                        mostrarDatos();
                        cmbTipoDniNuevo.Enabled = false;
                        txtNumeroDniNuevo.Enabled = false;
                        txtApellidoNuevo.Enabled = false;
                        txtNombreNuevo.Enabled = false;
                        txtEmailNuevo.Enabled = false;
                        txtTelefonoNuevo.Enabled = false;
                        
                        break;
                    }
            }

        }

        public void seleccionarCliente (Opcion op, Cliente clienteSelected)
        {
            action = op;
            oClienteSelected = clienteSelected;
        }

        private void mostrarDatos()
        {
            if (oClienteSelected != null)
            {
                cmbTipoDniNuevo.Text = oClienteSelected.descripcionTipoDni;
                txtNumeroDniNuevo.Text = oClienteSelected.nroDni.ToString();
                txtApellidoNuevo.Text = oClienteSelected.apellido;
                txtNombreNuevo.Text = oClienteSelected.nombre;
                txtEmailNuevo.Text = oClienteSelected.mail;
                txtTelefonoNuevo.Text = oClienteSelected.telefono;
            }
        }

        private void llenarCombo(ComboBox cmb, Object source, string display, String value)
        {
            cmb.DataSource = source;
            cmb.DisplayMember = display;
            cmb.ValueMember = value;
            cmb.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cliente oCliente;
            switch (action)
            {
                case Opcion.insert:
                    {
                        if (validarIngresoDatos())
                        {
                            if (existeEsteDni() == false)
                            {
                                oCliente = new Cliente();
                                oCliente.nroDni = Convert.ToInt32(txtNumeroDniNuevo.Text);
                                oCliente.idTipoDni = Convert.ToInt32(cmbTipoDniNuevo.SelectedValue.ToString());
                                oCliente.apellido = txtApellidoNuevo.Text;
                                oCliente.nombre = txtNombreNuevo.Text;
                                oCliente.mail = txtEmailNuevo.Text;
                                oCliente.telefono = txtTelefonoNuevo.Text;
                                oCliente.estadoBajaCliente = 'S';

                                if (oClienteService.create(oCliente))
                                {
                                    MessageBox.Show("Cliente creado", "Creación cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo crear el cliente", "Creación cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ya hay un cliente con ese dni", "Creación cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe llenar los campos obligatorios (*)", "Creación cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case Opcion.update:
                    {
                        if (validarIngresoDatos())
                        {
                            oClienteSelected.nroDni = Convert.ToInt32(txtNumeroDniNuevo.Text);
                            oClienteSelected.idTipoDni = Convert.ToInt32(cmbTipoDniNuevo.SelectedValue.ToString());
                            oClienteSelected.apellido = txtApellidoNuevo.Text;
                            oClienteSelected.nombre = txtNombreNuevo.Text;
                            oClienteSelected.telefono = txtTelefonoNuevo.Text;
                            oClienteSelected.mail = txtEmailNuevo.Text;
                            oClienteSelected.estadoBajaCliente = 'S';

                            if (oClienteService.update(oClienteSelected))
                            {
                                MessageBox.Show("El cliente ha sido actualizado", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                            {
                                MessageBox.Show("El cliente no pudo ser actualizado", "Error actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    }
                case Opcion.delete:
                    {
                        if (MessageBox.Show("¿Seguro que desea eliminar este cliente?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            oClienteSelected.estadoBajaCliente = 'N';
                            if (oClienteService.delete(oClienteSelected))
                            {
                                MessageBox.Show("Cliente eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    }
                    
            }
            
        }

        private bool existeEsteDni()
        {
            return (oClienteService.verificarExistenciaCliente(txtNumeroDniNuevo.Text) != null);
        }

        private bool validarIngresoDatos()
        {
            if (cmbTipoDniNuevo.Text == String.Empty)
            {
                cmbTipoDniNuevo.Focus();
                return false;
            }
            if (txtNumeroDniNuevo.Text == String.Empty)
            {
                txtNumeroDniNuevo.Focus();
                return false;
            }
            if (txtApellidoNuevo.Text == String.Empty)
            {
                txtApellidoNuevo.Focus();
                return false;
            }
            if (txtNombreNuevo.Text == String.Empty)
            {
                txtNombreNuevo.Focus();
                return false;
            }

            return true;
        }
    }
}
