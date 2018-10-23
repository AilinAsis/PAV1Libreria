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
using Innovazione.DataLayer;
using Innovazione.Bussines_Layer.Services;

namespace Innovazione.GUILayer
{
    public partial class frmABMProveedor : Form
    {
        public frmABMProveedor()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public enum Opcion
        {
            insert,
            update,
            delete,
        }

        private Opcion _action = Opcion.insert;
        private ProveedorService oProveedorService = new ProveedorService();
        private Proveedor oProveedorSelected;

        private void frmABMProveedor_Load(object sender, EventArgs e)
        {
            switch (_action)
            {
                case Opcion.insert:
                    {
                        this.Text = "Nuevo proveedor";
                        break;
                    }
                case Opcion.update:
                    {
                        this.Text = "Modificar proveedor";
                        mostrarDatos();
                        break;
                    }
                case Opcion.delete:
                    {
                        this.Text = "Eliminar proveedor";
                        mostrarDatos();
                        txtApellido.Enabled = false;
                        txtNombre.Enabled = false;
                        txtCuil.Enabled = false;
                        break;
                    }
            }
        }

        public void seleccionarProveedor (Opcion op, Proveedor proveedorSelected)
        {
            _action = op;
            oProveedorSelected = proveedorSelected;
        }

        private void mostrarDatos()
        {
            if (oProveedorSelected != null)
            {
                txtNombre.Text = oProveedorSelected.nombre;
                txtCuil.Text = oProveedorSelected.CUIL.ToString();
                txtApellido.Text = oProveedorSelected.apellido;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Proveedor oProveedor;
            switch (_action)
            {
                case Opcion.insert:
                    {
                        if (existeProveedor())
                        {
                            if (validarCampos())
                            {
                                oProveedor = new Proveedor();
                                oProveedor.nombre = txtNombre.Text;
                                oProveedor.apellido = txtApellido.Text;
                                oProveedor.CUIL = txtCuil.Text;
                                if (oProveedorService.crearProveedor(oProveedor))
                                {
                                    MessageBox.Show("Proveedor creado", "Creación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error al crear el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Faltan completar campos obligatorios (*)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ya existe un proveedor con el CUIL " + txtCuil.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case Opcion.update:
                    {
                        if (validarCampos())
                        {
                            oProveedorSelected.nombre = txtNombre.Text;
                            oProveedorSelected.apellido = txtApellido.Text;
                            oProveedorSelected.CUIL = txtCuil.Text;
                            oProveedorSelected.estadoBajaProveedor = 'S';

                            if (oProveedorService.actualizarProveedor(oProveedorSelected))
                            {
                                MessageBox.Show("Se actualizó el proveedor", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error al actualizar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Faltan completar campos obligatorios (*)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case Opcion.delete:
                    {
                        if (MessageBox.Show("¿Seguro que desea eliminar el proveedor?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                        {
                            oProveedorSelected.estadoBajaProveedor = 'N';
                            if (oProveedorService.actualizarProveedor(oProveedorSelected))
                            {
                                MessageBox.Show("El proveedor fue dado de baja", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar al proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    }
            }
        }
        private bool validarCampos()
        {
            if (txtApellido.Text == string.Empty)
            {
                txtApellido.BackColor = Color.Red;
                txtApellido.Focus();
                return false;
            }
            else
                txtApellido.BackColor = Color.White;
            if (txtNombre.Text == string.Empty)
            {
                txtNombre.BackColor = Color.Red;
                txtNombre.Focus();
                return false;
            }
            else
                txtNombre.BackColor = Color.White;
            if (txtCuil.Text == string.Empty)
            {
                txtCuil.BackColor = Color.Red;
                txtCuil.Focus();
                return false;
            }
            else
                txtCuil.BackColor = Color.White;
            return true;
        }

        public bool existeProveedor()
        {
            return (oProveedorService.validarProveedor(txtCuil.Text) == null);
        }
    }
}
