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

namespace Innovazione.GUILayer
{
    public partial class frmFactura : Form
    {
        //Ordenar el código
        private FacturaService oFacturaService = new FacturaService();

        public frmFactura()
        {
            InitializeComponent();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            int numVenta = oFacturaService.calcularNumeroVenta();
            txtNumeroPedido.Text = numVenta.ToString();
        }

        private void txtNroCliente_TextChanged(object sender, EventArgs e)
        {
            
            int numero;
            if (Int32.TryParse(txtNroCliente.Text, out numero))
            {
                DataTable tabla = new DataTable();
                tabla = BDHelper.getBDHelper().ConsultaSQL("Select apellido, nombre from Cliente where estadoBajaCliente = 'S' AND idCliente=" + txtNroCliente.Text);
                if (tabla.Rows.Count > 0)
                {
                    txtNombreCliente.Text = tabla.Rows[0]["apellido"].ToString() + ", " + tabla.Rows[0]["nombre"].ToString();
                }
                else
                {
                    MessageBox.Show("No existe ningún cliente con ese ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Se debe ingresar un número de cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtNroArticulo_TextChanged(object sender, EventArgs e)
        {
            int numero;
            if (Int32.TryParse(txtNroArticulo.Text, out numero))
            {
                DataTable tabla = new DataTable();
                tabla = BDHelper.getBDHelper().ConsultaSQL("Select nombre, precio FROM Producto WHERE idProducto=" + txtNroArticulo.Text);
                if (tabla.Rows.Count > 0)
                {
                    txtNombreArticulo.Text = tabla.Rows[0]["nombre"].ToString();
                    txtPrecio.Text = tabla.Rows[0]["precio"].ToString();
                }
                else
                {
                    MessageBox.Show("Artículo no encontrado", "Error");
                }
            }
            else
            {
                MessageBox.Show("Se debe ingresar un número de artículo válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            double a, b;
            if (txtCantidad.Text != "" & txtPrecio.Text != "")
            {
                a = Convert.ToDouble(txtCantidad.Text);
                b = Convert.ToDouble(txtPrecio.Text);
                txtTotalParcial.Text = Math.Round(a * b).ToString();
            }
        }

        private double calcularTotal()
        {
            double total = 0;
            for (int i = 0; i < grdGrilla.Rows.Count; i++)
                total += Convert.ToDouble(grdGrilla.Rows[i].Cells[4].Value);

            return total;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            grdGrilla.Rows.Add(new string[] { txtCantidad.Text, txtNroArticulo.Text, txtNombreArticulo.Text, txtPrecio.Text, txtTotalParcial.Text });
            txtSubtotal.Text = calcularTotal().ToString();
            txtTotal.Text = txtSubtotal.Text;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validar())
                if (grdGrilla.Rows.Count > 0)
                {
                    BDHelper.getBDHelper().conectarConTransaccion();
                    grabarFactura();
                    grabarDetalleFactura();
                    BDHelper.getBDHelper().desconectar();
                }
                else
                {
                    MessageBox.Show("Debe tener al menos un item de pedido...");
                }
        }

        private bool validarChequeo()
        {
            if (!chkPagado.Checked)
            {
                return false;
            }
            return true;
        }

        private void grabarFactura()
        {
            char pago = 'S';
            if (validarChequeo())
            {
                pago = 'N';
            }
            //validarNoExistePK();
            string consulta = "insert into Venta (idCliente, fechaFactura, pagado, total) values("
                                                        + txtNroCliente.Text + ",'"
                                                        + dtpFecha.Value.Date + "','"
                                                        + pago + "',"
                                                        + txtTotal.Text + ")";
            BDHelper.getBDHelper().EjecutarSqlConTransaccion(consulta);
        }

        private void grabarDetalleFactura()
        {
            for (int i = 0; i < grdGrilla.Rows.Count; i++)
            {
                BDHelper.getBDHelper().EjecutarSqlConTransaccion("insert into DetalleVenta values("
                                                        + txtNumeroPedido.Text + ","
                                                        + grdGrilla.Rows[i].Cells["colId"].Value.ToString() + ","
                                                        + grdGrilla.Rows[i].Cells["colCantidad"].Value.ToString().Replace(',', '.') + ","
                                                        + grdGrilla.Rows[i].Cells["colSubtotal"].Value.ToString().Replace(',', '.') + ")");
            }
        }

        private bool validar()
        {
            if (dtpFecha.Value == null)
            {
                MessageBox.Show("Debe ingresar fecha");
                dtpFecha.CalendarTitleBackColor = Color.Red;
                dtpFecha.Focus();
                return false;
            }
            return true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtNroCliente.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtNroArticulo.Text = string.Empty;
            txtNombreArticulo.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            //Ver como hacer para que no salten todos los carteles
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            //Ver como aplicar descuento
        }
    } 
}
