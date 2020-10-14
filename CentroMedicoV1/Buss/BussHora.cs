using Data;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace Buss
{
    public class BussHora
    {
        static BaseDatos db = new BaseDatos();

        public static DataTable Listar01()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_listar_hora";
            cmd.Parameters.Add("@idestado", SqlDbType.Int).Value = 0;
            return db.ejecutarConsulta(cmd);
        }

        public static List<Hora> Listar02(int idestado)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_listar_hora";
            cmd.Parameters.Add("@idestado", SqlDbType.Int).Value = idestado;
            DataTable dt = db.ejecutarConsulta(cmd);
            // new traspazar el dt a un List<Hora>
            List<Hora> lista = new List<Hora>();
            Hora obj;
            foreach (DataRow fila in dt.Rows)
            {
                obj = new Hora();
                obj.Idhora = int.Parse(fila["idhora"].ToString());
                obj.Fecha = DateTime.Parse(fila["fecha"].ToString());
                obj.Horaminuto = TimeSpan.Parse(fila["horaminuto"].ToString());

                obj.Medico = new Medico();
                obj.Medico.Idmedico = int.Parse(fila["idmedico"].ToString());

                obj.Estado = new Estado();
                obj.Estado.Idestado = int.Parse(fila["idestado"].ToString());

                lista.Add(obj);
            }

            return lista;
        }
    }
}