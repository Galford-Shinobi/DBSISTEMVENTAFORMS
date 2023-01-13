namespace CapaDatos.CodeDataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Detalle_Compra
    {
        [Key]
        public int DetalleCompraId { get; set; }

        public int? CompraId { get; set; }

        public int? ProductoId { get; set; }

        public decimal? PrecioCompra { get; set; }

        public decimal? PrecioVenta { get; set; }

        public int? Cantidad { get; set; }

        public decimal? MontoTotal { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public virtual Compra Compra { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
