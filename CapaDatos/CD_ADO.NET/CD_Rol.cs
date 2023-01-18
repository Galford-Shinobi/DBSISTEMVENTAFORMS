using CapaDatos.Connections;
using CapaEntidad.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos.CD_ADO.NET
{
    public class CD_Rol
    {
        public List<Rol> Listar()
        {
            List<Rol> lista = new List<Rol>();

            using (SqlConnection oconexion = new SqlConnection(Connection.DefaultConnections))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select RolId,Descripcion from ROL");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Rol()
                            {
                                IdRol = Convert.ToInt32(dr["RolId"]),
                                Descripcion = dr["Descripcion"].ToString()
                            });
                        }
                    }
                }
                catch (Exception)
                {

                    lista = new List<Rol>();
                }
            }

            return lista;

        }


    }
}
