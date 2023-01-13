namespace CapaDatos.CodeDataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Detalle_Venta
    {
        [Key]
        public int DetalleVentaId { get; set; }

        public int? VentaId { get; set; }

        public int? ProductoId { get; set; }

        public decimal? PrecioVenta { get; set; }

        public int? Cantidad { get; set; }

        public decimal? SubTotal { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public virtual Producto Producto { get; set; }

        public virtual Venta Venta { get; set; }
    }
}
