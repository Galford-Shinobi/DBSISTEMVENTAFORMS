namespace CapaDatos.CodeDataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Permiso")]
    public partial class Permiso
    {
        public int PermisoId { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreMenu { get; set; }

        public int? RolId { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public virtual Rol Rol { get; set; }
    }
}
