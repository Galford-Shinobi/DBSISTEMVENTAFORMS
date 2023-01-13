namespace CapaDatos.CodeDataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Compra")]
    public partial class Compra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Compra()
        {
            Detalle_Compra = new HashSet<Detalle_Compra>();
        }

        public int CompraId { get; set; }

        [StringLength(50)]
        public string TipoDocumento { get; set; }

        [StringLength(50)]
        public string NumeroDocumento { get; set; }

        public decimal? MontoTotal { get; set; }

        public int UsuarioId { get; set; }

        public int? ProveedorId { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public virtual Proveedor Proveedor { get; set; }

        public virtual Usuario Usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Compra> Detalle_Compra { get; set; }
    }
}
