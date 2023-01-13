namespace CapaDatos.CodeDataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Venta")]
    public partial class Venta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venta()
        {
            Detalle_Venta = new HashSet<Detalle_Venta>();
        }

        public int VentaId { get; set; }

        [StringLength(50)]
        public string TipoDocumento { get; set; }

        [StringLength(50)]
        public string NumeroDocumento { get; set; }

        [StringLength(50)]
        public string DocumentoCliente { get; set; }

        [StringLength(150)]
        public string NombreCliente { get; set; }

        public decimal? MontoPago { get; set; }

        public decimal? MontoCambio { get; set; }

        public decimal? MontoTotal { get; set; }

        public int UsuarioId { get; set; }

        public int? ClienteId { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public virtual Cliente Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Venta> Detalle_Venta { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
