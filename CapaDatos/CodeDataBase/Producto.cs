namespace CapaDatos.CodeDataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producto")]
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            Detalle_Compra = new HashSet<Detalle_Compra>();
            Detalle_Venta = new HashSet<Detalle_Venta>();
        }

        public int ProductoId { get; set; }

        [Required]
        [StringLength(50)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string descripcion { get; set; }

        public int Stock { get; set; }

        public decimal? unit_price { get; set; }

        public decimal? PrecioCompra { get; set; }

        public decimal? PrecioVenta { get; set; }

        public int? Pieza { get; set; }

        public int? CategoriaId { get; set; }

        public bool? Estado { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public virtual Categoria Categoria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Compra> Detalle_Compra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Venta> Detalle_Venta { get; set; }
    }
}
