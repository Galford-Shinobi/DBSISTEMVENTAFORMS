
namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.submenucategoria = new FontAwesome.Sharp.IconMenuItem();
            this.submenuproducto = new FontAwesome.Sharp.IconMenuItem();
            this.menuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuRregistroVentas = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuVerDetallaVentas = new FontAwesome.Sharp.IconMenuItem();
            this.menuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuRegistroCmpras = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuverDetalleCompras = new FontAwesome.Sharp.IconMenuItem();
            this.enuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuReporteVentas = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenureporteCompras = new FontAwesome.Sharp.IconMenuItem();
            this.menuAcercade = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuMantenedor,
            this.menuVentas,
            this.menuCompras,
            this.enuClientes,
            this.menuProveedores,
            this.menuReportes,
            this.menuAcercade});
            this.menuStrip1.Location = new System.Drawing.Point(0, 59);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1431, 77);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menu";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.AutoSize = false;
            this.menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.menuUsuarios.IconColor = System.Drawing.Color.Black;
            this.menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuarios.IconSize = 50;
            this.menuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(122, 73);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click_1);
            // 
            // menuMantenedor
            // 
            this.menuMantenedor.AutoSize = false;
            this.menuMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenucategoria,
            this.submenuproducto});
            this.menuMantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menuMantenedor.IconColor = System.Drawing.Color.Black;
            this.menuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuMantenedor.IconSize = 50;
            this.menuMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuMantenedor.Name = "menuMantenedor";
            this.menuMantenedor.Size = new System.Drawing.Size(122, 73);
            this.menuMantenedor.Text = "Mantenedor";
            this.menuMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenucategoria
            // 
            this.submenucategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenucategoria.IconColor = System.Drawing.Color.Black;
            this.submenucategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenucategoria.Name = "submenucategoria";
            this.submenucategoria.Size = new System.Drawing.Size(137, 24);
            this.submenucategoria.Text = "Categoria";
            this.submenucategoria.Click += new System.EventHandler(this.submenucategoria_Click);
            // 
            // submenuproducto
            // 
            this.submenuproducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuproducto.IconColor = System.Drawing.Color.Black;
            this.submenuproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuproducto.Name = "submenuproducto";
            this.submenuproducto.Size = new System.Drawing.Size(137, 24);
            this.submenuproducto.Text = "Producto";
            this.submenuproducto.Click += new System.EventHandler(this.submenuproducto_Click);
            // 
            // menuVentas
            // 
            this.menuVentas.AutoSize = false;
            this.menuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubmenuRregistroVentas,
            this.SubmenuVerDetallaVentas});
            this.menuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuVentas.IconColor = System.Drawing.Color.Black;
            this.menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVentas.IconSize = 50;
            this.menuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Size = new System.Drawing.Size(122, 73);
            this.menuVentas.Text = "Ventas";
            this.menuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubmenuRregistroVentas
            // 
            this.SubmenuRregistroVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmenuRregistroVentas.IconColor = System.Drawing.Color.Black;
            this.SubmenuRregistroVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuRregistroVentas.Name = "SubmenuRregistroVentas";
            this.SubmenuRregistroVentas.Size = new System.Drawing.Size(144, 24);
            this.SubmenuRregistroVentas.Text = "Registro";
            this.SubmenuRregistroVentas.Click += new System.EventHandler(this.SubmenuRregistroVentas_Click);
            // 
            // SubmenuVerDetallaVentas
            // 
            this.SubmenuVerDetallaVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmenuVerDetallaVentas.IconColor = System.Drawing.Color.Black;
            this.SubmenuVerDetallaVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuVerDetallaVentas.Name = "SubmenuVerDetallaVentas";
            this.SubmenuVerDetallaVentas.Size = new System.Drawing.Size(144, 24);
            this.SubmenuVerDetallaVentas.Text = "Ver Detalle";
            this.SubmenuVerDetallaVentas.Click += new System.EventHandler(this.SubmenuVerDetallaVentas_Click);
            // 
            // menuCompras
            // 
            this.menuCompras.AutoSize = false;
            this.menuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubmenuRegistroCmpras,
            this.SubmenuverDetalleCompras});
            this.menuCompras.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed;
            this.menuCompras.IconColor = System.Drawing.Color.Black;
            this.menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCompras.IconSize = 50;
            this.menuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.Size = new System.Drawing.Size(122, 73);
            this.menuCompras.Text = "Compras";
            this.menuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubmenuRegistroCmpras
            // 
            this.SubmenuRegistroCmpras.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmenuRegistroCmpras.IconColor = System.Drawing.Color.Black;
            this.SubmenuRegistroCmpras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuRegistroCmpras.Name = "SubmenuRegistroCmpras";
            this.SubmenuRegistroCmpras.Size = new System.Drawing.Size(144, 24);
            this.SubmenuRegistroCmpras.Text = "Registro";
            this.SubmenuRegistroCmpras.Click += new System.EventHandler(this.SubmenuRegistroCmpras_Click);
            // 
            // SubmenuverDetalleCompras
            // 
            this.SubmenuverDetalleCompras.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmenuverDetalleCompras.IconColor = System.Drawing.Color.Black;
            this.SubmenuverDetalleCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuverDetalleCompras.Name = "SubmenuverDetalleCompras";
            this.SubmenuverDetalleCompras.Size = new System.Drawing.Size(144, 24);
            this.SubmenuverDetalleCompras.Text = "Ver Detalle";
            this.SubmenuverDetalleCompras.Click += new System.EventHandler(this.SubmenuverDetalleCompras_Click);
            // 
            // enuClientes
            // 
            this.enuClientes.AutoSize = false;
            this.enuClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.enuClientes.IconColor = System.Drawing.Color.Black;
            this.enuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.enuClientes.IconSize = 50;
            this.enuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.enuClientes.Name = "enuClientes";
            this.enuClientes.Size = new System.Drawing.Size(122, 73);
            this.enuClientes.Text = "Clientes";
            this.enuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.enuClientes.Click += new System.EventHandler(this.enuClientes_Click);
            // 
            // menuProveedores
            // 
            this.menuProveedores.AutoSize = false;
            this.menuProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menuProveedores.IconColor = System.Drawing.Color.Black;
            this.menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProveedores.IconSize = 50;
            this.menuProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.Size = new System.Drawing.Size(122, 73);
            this.menuProveedores.Text = "Proveedores";
            this.menuProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuProveedores.Click += new System.EventHandler(this.menuProveedores_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.AutoSize = false;
            this.menuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubmenuReporteVentas,
            this.SubmenureporteCompras});
            this.menuReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.menuReportes.IconColor = System.Drawing.Color.Black;
            this.menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuReportes.IconSize = 50;
            this.menuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(122, 73);
            this.menuReportes.Text = "Reportes";
            this.menuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubmenuReporteVentas
            // 
            this.SubmenuReporteVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmenuReporteVentas.IconColor = System.Drawing.Color.Black;
            this.SubmenuReporteVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuReporteVentas.Name = "SubmenuReporteVentas";
            this.SubmenuReporteVentas.Size = new System.Drawing.Size(228, 24);
            this.SubmenuReporteVentas.Text = "Ver Reporte de Ventas";
            this.SubmenuReporteVentas.Click += new System.EventHandler(this.SubmenuReporteVentas_Click);
            // 
            // SubmenureporteCompras
            // 
            this.SubmenureporteCompras.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmenureporteCompras.IconColor = System.Drawing.Color.Black;
            this.SubmenureporteCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenureporteCompras.Name = "SubmenureporteCompras";
            this.SubmenureporteCompras.Size = new System.Drawing.Size(228, 24);
            this.SubmenureporteCompras.Text = "Ver Reporte de Compras";
            this.SubmenureporteCompras.Click += new System.EventHandler(this.SubmenureporteCompras_Click);
            // 
            // menuAcercade
            // 
            this.menuAcercade.AutoSize = false;
            this.menuAcercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menuAcercade.IconColor = System.Drawing.Color.Black;
            this.menuAcercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAcercade.IconSize = 50;
            this.menuAcercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAcercade.Name = "menuAcercade";
            this.menuAcercade.Size = new System.Drawing.Size(122, 73);
            this.menuAcercade.Text = "Acerca de..";
            this.menuAcercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(1431, 59);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuTitulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1063, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Ventas Curso de Sistema de Ventas en C# y SQL Server - Parte 4 00:08:5" +
    "1";
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 136);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1431, 590);
            this.Contenedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1209, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario : ";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.Color.White;
            this.LblUsuario.Location = new System.Drawing.Point(1274, 25);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(67, 15);
            this.LblUsuario.TabIndex = 5;
            this.LblUsuario.Text = "LblUsuario";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 726);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuMantenedor;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem enuClientes;
        private FontAwesome.Sharp.IconMenuItem menuProveedores;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private FontAwesome.Sharp.IconMenuItem menuAcercade;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblUsuario;
        private FontAwesome.Sharp.IconMenuItem submenucategoria;
        private FontAwesome.Sharp.IconMenuItem submenuproducto;
        private FontAwesome.Sharp.IconMenuItem SubmenuRregistroVentas;
        private FontAwesome.Sharp.IconMenuItem SubmenuVerDetallaVentas;
        private FontAwesome.Sharp.IconMenuItem SubmenuRegistroCmpras;
        private FontAwesome.Sharp.IconMenuItem SubmenuverDetalleCompras;
        private FontAwesome.Sharp.IconMenuItem SubmenuReporteVentas;
        private FontAwesome.Sharp.IconMenuItem SubmenureporteCompras;
    }
}

