using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaDatos.CD_ADO.NET;
using CapaEntidad;
using CapaEntidad.Entidades;

namespace CapaNegocio
{
    public class CN_Rol
    {

        private CD_Rol objcd_rol = new CD_Rol();


        public List<Rol> Listar()
        {
            return objcd_rol.Listar();
        }
    }
}
