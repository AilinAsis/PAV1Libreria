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
    public partial class frmABMProducto : Form
    {
        public frmABMProducto()
        {
            InitializeComponent();
        }

        public enum Opcion
        {
            insert,
            update,
            delete,
        }

        private Opcion _action = Opcion.insert;
        private ProductoService oProductoService = new ProductoService();
        private Producto oProductoSelected;

        private void frmABMProducto_Load(object sender, EventArgs e)
        {
            switch (_action)
            {
                case Opcion.insert:
                    {
                        this.Text = "Nuevo producto";
                        break;
                    }
                case Opcion.update:
                    {
                        this.Text = "Actualizar producto";
                        mostrarDatos();
                        break;
                    }
                case Opcion.delete:
                    {
                        this.Text = "Eliminar producto";
                        mostrarDatos();
                        txtCantidad.Enabled = false;
                        txtNombre.Enabled = false;
                        txtDescripcion.Enabled = false;
                        txtPrecio.Enabled = false;
                        break;
                    }
            }
        }

        public void seleccionarProducto(Opcion op, Producto productoSelected)
        {
            _action = op;
            oProductoSelected = productoSelected;
        }

        private void mostrarDatos()
        {
            if (oProductoSelected != null)
            {
                txtNombre.Text = oProductoSelected.nombre;
                txtDescripcion.Text = oProductoSelected.descripcion;
                txtPrecio.Text = oProductoSelected.precio.ToString();
                txtCantidad.Text = oProductoSelected.cantDisponible.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Producto oProducto;
            switch (_action)
            {
                case Opcion.insert:
                    {
                        if (validarCampos())
                        {
                            oProducto = new Producto();
                            oProducto.nombre = txtNombre.Text;
                            oProducto.descripcion = txtDescripcion.Text;
                            oProducto.cantDisponible = int.Parse(txtCantidad.Text);
                            oProducto.precio = double.Parse(txtPrecio.Text);

                            if (oProductoService.crearProducto(oProducto))
                            {
                                MessageBox.Show("Producto creado", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error al crear el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Faltan completar campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case Opcion.update:
                    {
                        if (validarCampos())
                        {
                            oProductoSelected.nombre = txtNombre.Text;
                            oProductoSelected.descripcion = txtDescripcion.Text;
                            oProductoSelected.cantDisponible = int.Parse(txtCantidad.Text);
                            oProductoSelected.precio = double.Parse(txtPrecio.Text);
                            oProductoSelected.estadoBajaProducto = 'S';

                            if (oProductoService.updateProducto(oProductoSelected))
                            {
                                MessageBox.Show("Se actualizó el producto", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error al actualizar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Faltan campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case Opcion.delete:
                    {
                        if (MessageBox.Show("¿Seguro que desea eliminar este producto?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                        {
                            oProductoSelected.estadoBajaProducto = 'N';
                            if (oProductoService.updateProducto(oProductoSelected))
                            {
                                MessageBox.Show("Se eliminó el producto", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    }
            }
        }

        private bool validarCampos()
        {
            if (txtNombre.Text == string.Empty)
            {
                txtNombre.BackColor = Color.Red;
                txtNombre.Focus();
                return false;
            }
            else
                txtNombre.BackColor = Color.White;
            if (txtCantidad.Text == string.Empty)
            {
                txtCantidad.BackColor = Color.Red;
                txtCantidad.Focus();
                return false;
            }
            else
                txtCantidad.BackColor = Color.White;
            if (txtPrecio.Text == string.Empty)
            {
                txtPrecio.BackColor = Color.Red;
                txtPrecio.Focus();
                return false;
            }
            else
                txtPrecio.BackColor = Color.White;

            return true;
        }
    }
}
