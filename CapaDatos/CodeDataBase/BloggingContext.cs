using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CapaDatos.CodeDataBase
{
    public partial class BloggingContext : DbContext
    {
        public BloggingContext()
            : base("name=BloggingContext")
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<Detalle_Compra> Detalle_Compra { get; set; }
        public virtual DbSet<Detalle_Venta> Detalle_Venta { get; set; }
        public virtual DbSet<Permiso> Permiso { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Compra>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<Compra>()
                .Property(e => e.NumeroDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<Compra>()
                .Property(e => e.MontoTotal)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Detalle_Compra>()
                .Property(e => e.PrecioCompra)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Detalle_Compra>()
                .Property(e => e.PrecioVenta)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Detalle_Compra>()
                .Property(e => e.MontoTotal)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Detalle_Venta>()
                .Property(e => e.PrecioVenta)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Detalle_Venta>()
                .Property(e => e.SubTotal)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Permiso>()
                .Property(e => e.NombreMenu)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.unit_price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Producto>()
                .Property(e => e.PrecioCompra)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Producto>()
                .Property(e => e.PrecioVenta)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.RazonSocial)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Rol>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.NombreCompleto)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Compra)
                .WithRequired(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Venta)
                .WithRequired(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Venta>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<Venta>()
                .Property(e => e.NumeroDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<Venta>()
                .Property(e => e.DocumentoCliente)
                .IsUnicode(false);

            modelBuilder.Entity<Venta>()
                .Property(e => e.NombreCliente)
                .IsUnicode(false);

            modelBuilder.Entity<Venta>()
                .Property(e => e.MontoPago)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Venta>()
                .Property(e => e.MontoCambio)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Venta>()
                .Property(e => e.MontoTotal)
                .HasPrecision(10, 2);
        }
    }
}
