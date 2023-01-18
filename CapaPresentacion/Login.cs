using CapaEntidad.Entidades;
using CapaNegocio;
using Library.Common.Responses;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        private CN_Usuario cN_Usuario = new CN_Usuario();
        private EncryptDepcryptGenericResponse depcryptGenericResponse = new EncryptDepcryptGenericResponse();
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidationForm() == 1)
            {
                var passworld = depcryptGenericResponse.GetSHA256(txtClave.Text);

                Usuario ousuario = cN_Usuario.Listar()
                    .Where(u => u.Documento == txtIngresar.Text && u.Clave == depcryptGenericResponse.GetSHA256(txtClave.Text)).FirstOrDefault();
                if (ousuario != null) 
                {
                    Inicio form = new Inicio(ousuario);
                    form.Show();
                    this.Hide();
                    form.FormClosing += frm_Clising;
                }
                else
                {
                    Cleaning();
                    MessageBox.Show("no se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void frm_Clising(object sender, FormClosingEventArgs e)
        {
            Cleaning();
            this.Show();
        }

        private void Cleaning()
        {
            txtIngresar.Text = string.Empty;
            txtClave.Text = string.Empty;
        }

        private int ValidationForm()
        {
            if (string.IsNullOrEmpty(txtIngresar.Text))
            {
                MessageBox.Show("Debe de capturar el campo Nro De Documento", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIngresar.Focus();
                return 0;
            }
            if (string.IsNullOrEmpty(txtClave.Text))
            {
                MessageBox.Show("Debe de capturar el campo Contraseña", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
                return 0;
            }
            return 1;
        }  
    }
}
