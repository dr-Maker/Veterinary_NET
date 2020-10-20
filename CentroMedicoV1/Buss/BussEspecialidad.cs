using Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Modelos;

namespace Buss
{
    public class BussEspecialidad
    {
        static BaseDatos db = new BaseDatos();
        public static DataTable Listar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from especialidad";
            return db.ejecutarConsulta(cmd);
        }

        public static List<Especialidad> Listar02()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_listar_especialidad";
            DataTable dt = db.ejecutarConsulta(cmd);

            List<Especialidad> lista = new List<Especialidad>();
            Especialidad obj;

            foreach (DataRow fila in dt.Rows)
            {
                obj = new Especialidad();
                obj.Idespecialidad = int.Parse(fila["idespecialidad"].ToString());
                obj.Descripcion = fila["descripcion"].ToString();

                lista.Add(obj);
            }

            return lista;

        }

        public static bool Insert(Especialidad obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insert_especialidad";
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = obj.Descripcion;
            return db.ejecutarAccion(cmd);
        }

        public static Especialidad Buscar(int id)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_buscar_especialidad";
            cmd.Parameters.Add("@idespecialidad", SqlDbType.Int).Value = id;
            DataTable dt = db.ejecutarConsulta(cmd);

            Especialidad obj = new Especialidad();
            if (dt != null && dt.Rows.Count > 0)
            {
                obj.Idespecialidad = int.Parse(dt.Rows[0]["idespecialidad"].ToString());
                obj.Descripcion = dt.Rows[0]["descripcion"].ToString();
            }
            return obj;
        }

        public static bool Update(Especialidad obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_update_especialidad";
            cmd.Parameters.Add("@idespecialidad", SqlDbType.Int).Value = obj.Idespecialidad;
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = obj.Descripcion;
            return db.ejecutarAccion(cmd);
        }


        public static bool Delete(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_delete_especialidad";
            cmd.Parameters.Add("@idespecialidad", SqlDbType.Int).Value = id;
            return db.ejecutarAccion(cmd);
        }


    }


}