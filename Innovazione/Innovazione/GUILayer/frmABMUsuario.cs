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
    public partial class frmABMUsuario : Form
    {
        
        public frmABMUsuario()
        {
            InitializeComponent();
        }

        public enum Opcion
        {
            insert,
            update,
            delete,
        }

        private Opcion oOpcion = Opcion.insert;
        private UsuarioService oUsuarioService = new UsuarioService();
        private Usuario oUsuarioSelected;
        

        private void frmABMUsuario_Load(object sender, EventArgs e)
        {
            switch (oOpcion)
            {
                case Opcion.insert:
                    {
                        
                        this.Text = "Nuevo usuario";
                       
                        
                        break;
                    }
                case Opcion.update:
                    {
                        mostrarDatos();
                        this.Text = "Modificar usuario";
                        txtNuevoUsuario.Enabled = true;
                        txtContrasenia.Enabled = true;
                        break;
                    }
                case Opcion.delete:
                    {
                        mostrarDatos();
                        this.Text = "Deshabilitar usuario";
                        txtNuevoUsuario.Enabled = false;
                        txtContrasenia.Enabled = false;
                        txtRepetirContrasenia.Visible = false;
                        break;
                    }
            }
            
        }

        public void SeleccionarUsuario (Opcion op, Usuario usuarioSelected)
        {
            oOpcion = op;
            oUsuarioSelected = usuarioSelected;
        }

        private void mostrarDatos()
        {
            if (oUsuarioSelected != null)
            {
                txtNuevoUsuario.Text = oUsuarioSelected.nomUser;
                txtContrasenia.Text = oUsuarioSelected.contraseña;
            }
        }

        private void btnAceptarUser_Click(object sender, EventArgs e)
        {   Usuario oUsuario;

            switch (oOpcion)
            {
                case Opcion.insert:
                    {
                        if (oUsuarioService.validarNombreUsuario(txtNuevoUsuario.Text) != null)
                        {
                            MessageBox.Show("Este usuario ya fue encontrado. Ingrese otro nombre de usuario", "Usuario existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (validarCampos())
                            {
                                oUsuario = new Usuario();
                                oUsuario.nomUser = txtNuevoUsuario.Text;
                                oUsuario.contraseña = txtContrasenia.Text;

                                if (oUsuarioService.crearUsuario(oUsuario))
                                {
                                    MessageBox.Show("Se ha creado el usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("No se ha podido crear el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        break;
                    }
                case Opcion.update:
                    {
                        if (validarCampos())
                        {
                            oUsuarioSelected.nomUser = txtNuevoUsuario.Text;
                            oUsuarioSelected.contraseña = txtContrasenia.Text;
                            
                            if (oUsuarioService.actualizarUsuario(oUsuarioSelected))
                            {
                                MessageBox.Show("El usuario " + txtNuevoUsuario.Text + " ha sido actualizado", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                            {
                                MessageBox.Show("El usuario " + txtNuevoUsuario.Text + " no pudo ser actualizado", "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }break;

                    }
                case Opcion.delete:
                    {
                        if (MessageBox.Show("¿Seguro que desea deshabilitar/habilitar el usuario seleccionado?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                        {
                            if (oUsuarioSelected.activo == "N") {
                                oUsuarioSelected.activo = "S";
                            }
                            else
                            {
                                oUsuarioSelected.activo = "N";
                            }

                            if (oUsuarioService.modificarEstadoUsuario(oUsuarioSelected))
                            {
                                MessageBox.Show("El usuario ha sido habilitado/deshabilitado", "Habilitado/Deshabilitado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("El usuario no ha sido habilitado/deshabilitado", "Error habilitar/deshabilitar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    }
            }
            

        }

        private bool validarCampos()
        {
            if (txtNuevoUsuario.Text == String.Empty || txtContrasenia.Text == String.Empty)
            {
                MessageBox.Show("Debe llenar los campos obligatorios (*)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtContrasenia.Text != txtRepetirContrasenia.Text)
            {
                MessageBox.Show("No coinciden las contraseñas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }

        private void btnSalirUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
