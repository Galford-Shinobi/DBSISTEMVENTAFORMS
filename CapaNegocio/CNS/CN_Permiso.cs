using CapaDatos.CD_ADO.NET;
using CapaEntidad.Entidades;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Permiso
    {

        private CD_Permiso objcd_permiso = new CD_Permiso();


        public List<Permiso> Listar(int IdUsuario)
        {
            return objcd_permiso.Listar(IdUsuario);
        }
    }
}
