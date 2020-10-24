using Data;
using System;
using Modelos;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Buss
{
    public class BussMedico
    {
        static BaseDatos db = new BaseDatos();

        public static DataTable Listar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_listar_medico";
            return db.ejecutarConsulta(cmd);
        }

        public static List<Medico> Listar02()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_listar_medico";
            DataTable dt = db.ejecutarConsulta(cmd);
            List<Medico> lista = new List<Medico>();
            Medico obj;
            foreach (DataRow row in dt.Rows)
            {
                obj = new Medico();
                obj.Idmedico = int.Parse(row["idmedico"].ToString());
                obj.Nombres = row["nombres"].ToString();
                obj.Apellidos = row["apellidos"].ToString();
                obj.Email = row["email"].ToString();
                obj.Telefono = int.Parse(row["telefono"].ToString());

                obj.Especialidad = new Especialidad();
                obj.Especialidad.Idespecialidad = int.Parse(row["idespecialidad"].ToString());
                obj.Especialidad.Descripcion = row["nom_especialidad"].ToString();

                lista.Add(obj);
            }
            return lista;
        }

        public static bool Insert(Medico obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insert_medico";

            cmd.Parameters.Add("@nombres", SqlDbType.VarChar,50).Value = obj.Nombres;
            cmd.Parameters.Add("@apellidos", SqlDbType.VarChar, 50).Value = obj.Apellidos;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = obj.Email;
            cmd.Parameters.Add("@telefono", SqlDbType.Int).Value = obj.Telefono;
            cmd.Parameters.Add("@idespecialidad", SqlDbType.Int).Value = obj.Especialidad.Idespecialidad;
            return db.ejecutarAccion(cmd);
        }

        public static Medico Buscar(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_buscar_medico";
            cmd.Parameters.Add("@idmedico", SqlDbType.Int).Value = id;
            DataTable dt = db.ejecutarConsulta(cmd);
            Medico obj = new Medico();
            if (dt != null && dt.Rows.Count > 0)
            {
                obj.Idmedico = int.Parse(dt.Rows[0]["idmedico"].ToString());
                obj.Nombres = dt.Rows[0]["nombres"].ToString();
                obj.Apellidos = dt.Rows[0]["apellidos"].ToString();
                obj.Email = dt.Rows[0]["email"].ToString();
                obj.Telefono = int.Parse(dt.Rows[0]["telefono"].ToString());

                obj.Especialidad = new Especialidad();
                // si esta insatanciado podemos setear los atributos
                obj.Especialidad.Idespecialidad = int.Parse(dt.Rows[0]["idespecialidad"].ToString());
                obj.Especialidad.Descripcion = dt.Rows[0]["nom_especialidad"].ToString();
            }
            else
            {
                obj = null;
            }
            return obj;
        }

        public static bool Update(Medico obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_update_medico";
            cmd.Parameters.Add("@nombres", SqlDbType.VarChar, 50).Value = obj.Nombres;
            cmd.Parameters.Add("@apellidos", SqlDbType.VarChar, 50).Value = obj.Apellidos;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = obj.Email;
            cmd.Parameters.Add("@telefono", SqlDbType.Int).Value = obj.Telefono;
            cmd.Parameters.Add("@idespecialidad", SqlDbType.Int).Value = obj.Especialidad.Idespecialidad;
            // parámetro necesario para el WHERE del UPDATE
            cmd.Parameters.Add("@idmedico", SqlDbType.Int).Value = obj.Idmedico;

            return db.ejecutarAccion(cmd);
        }

        public static bool Delete(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_delete_medico";
            cmd.Parameters.Add("@idmedico", SqlDbType.Int).Value = id;

            return db.ejecutarAccion(cmd);
        }
    }
}