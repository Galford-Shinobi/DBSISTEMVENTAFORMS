using CapaDatos.Connections;
using CapaEntidad.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos.CD_ADO.NET
{
    public class CD_Permiso
    {

        public List<Permiso> Listar(int idusuario)
        {
            List<Permiso> lista = new List<Permiso>();

            using (SqlConnection oconexion = new SqlConnection(Connection.DefaultConnections))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.RolId,p.NombreMenu from PERMISO p");
                    query.AppendLine("inner join ROL r on r.RolId = p.RolId");
                    query.AppendLine("inner join USUARIO u on u.RolId = r.RolId");
                    query.AppendLine("where u.UsuarioId = @idusuario");


                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@idusuario", idusuario);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {

                            lista.Add(new Permiso()
                            {
                                oRol = new Rol() { IdRol = Convert.ToInt32(dr["RolId"]) },
                                NombreMenu = dr["NombreMenu"].ToString(),
                            });

                        }

                    }


                }
                catch (Exception)
                {

                    lista = new List<Permiso>();
                }
                finally 
                {
                    oconexion.Close();
                    oconexion.Dispose();
                }
            }

            return lista;

        }

    }
}
