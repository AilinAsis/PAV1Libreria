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
    public partial class frmCliente : Form
    {

        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            //cargarCombo(cmbTipoDni, "TipoDni");

            //grdConsultaClientes.DataSource = oDatos.consultaSQL("Select * from cliente");

        }



        /*private void cargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable tabla = oDatos.consultarTabla(nombreTabla);
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void llenarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    grilla.Rows.Add(tabla.Rows[i]["nroDni"],
                                    tabla.Rows[i]["tipoDni"],
                                    tabla.Rows[i]["apellido"],
                                    tabla.Rows[i]["nombre"],
                                    tabla.Rows[i]["mail"],
                                    tabla.Rows[i]["telefono"]);
                }
            }
        }

        private void tbpConsultarCliente_Click(object sender, EventArgs e)
        {
            //cargarCombo(cmbTipoDni, "TipoDni");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //llenarGrilla(grdConsultaClientes, );
        }
    }
}*/
    }
}
