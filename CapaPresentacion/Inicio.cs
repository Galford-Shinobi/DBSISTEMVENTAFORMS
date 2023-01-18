using CapaEntidad.Entidades;
using CapaNegocio;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public Inicio(Usuario objusuario = null)
        {
            if (objusuario == null)
                usuarioActual = new Usuario() { NombreCompleto = "ADMIN PREDEFINIDO", IdUsuario = 1 };
            else
                usuarioActual = objusuario;

            InitializeComponent();
        }
        

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);

            foreach (IconMenuItem iconmenu in menuStrip1.Items)
            {

                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconmenu.Name);

                if (encontrado == false)
                {
                    iconmenu.Visible = false;
                }

            }
            LblUsuario.Text = usuarioActual.NombreCompleto;
        }
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {

            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            Contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void menuUsuarios_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }

        private void submenucategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuMantenedor, new frmCategoria());
        }

        private void submenuproducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuMantenedor, new frmProducto());
        }

        private void SubmenuRregistroVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuMantenedor, new frmVentas());
        }

        private void SubmenuVerDetallaVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuMantenedor, new frmDetalleVenta());
        }

        private void SubmenuverDetalleCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuMantenedor, new frmDetalleCompra()); 
        }

        private void SubmenuRegistroCmpras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuMantenedor, new frmCompras());
        }

        private void enuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());
        }

        private void SubmenuReporteVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuMantenedor, new frmReporteVentas());
        }

        private void SubmenureporteCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuMantenedor, new frmReporteCompras());
        }
    }
}
