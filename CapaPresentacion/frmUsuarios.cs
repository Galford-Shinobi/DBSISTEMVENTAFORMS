using CapaEntidad.Entidades;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().Listar();

            foreach (Rol item in listaRol)
            {
                cborol.Items.Add(new OpcionCombo() { Valor = item.RolId, Texto = item.Descripcion });
            }
            cborol.DisplayMember = "Texto";
            cborol.ValueMember = "Valor";
            cborol.SelectedIndex = 0;
        }

        private void Limpiar()
        {

            //txtindice.Text = "-1";
            //txtid.Text = "0";
            txtdocumento.Text = "";
            txtnombrecompleto.Text = "";
            txtcorreo.Text = "";
            txtclave.Text = "";
            txtconfirmarclave.Text = "";
            cborol.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;

            txtdocumento.Select();

        }

        private bool ControlValidators() 
        {
            if (string.IsNullOrEmpty(txtdocumento.Text))
            {
                MessageBox.Show("Debe ingresar No de documento del Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtdocumento.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtnombrecompleto.Text))
            {
                MessageBox.Show("Debe ingresar el Nombre Completo del Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnombrecompleto.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtcorreo.Text))
            {
                MessageBox.Show("Debe ingresar el Correo Electronico del Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtcorreo.Focus();
                return false;
            }
            if (!IsValidEmail(txtcorreo.Text)) 
            {
                MessageBox.Show("El Correo electronico no tiene el formato correcto del Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtclave.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtclave.Text))
            {
                MessageBox.Show("Debe ingresar la contraseña del Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtcorreo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtconfirmarclave.Text))
            {
                MessageBox.Show("Debe ingresar la Confirmacion de la contraseña del Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtconfirmarclave.Focus();
                return false;
            }

            if (txtclave.Text != txtconfirmarclave.Text)
            {
                MessageBox.Show("Contraseña  y  Confirmacion de la contraseña no son iguales del Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtclave.Focus();
                return false;
            }

            if (cborol.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un tipo de rol", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboestado.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un estado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
