namespace CapaEntidad.Entidades
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public Usuario oUsuario { get; set; }
        public int IdUsuario { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
    }
}
