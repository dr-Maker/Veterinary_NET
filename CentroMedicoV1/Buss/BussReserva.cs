using Data;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Buss
{
    public class BussReserva
    {
        static BaseDatos db = new BaseDatos();

        public static DataTable Listar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_listar_reserva01";
            return db.ejecutarConsulta(cmd);
        }

        public static List<Reserva> Listar02(int idespecialidad, string fecha, int idmedico)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_listar_reserva";
            cmd.Parameters.Add("@idespecialidad",SqlDbType.Int).Value = idespecialidad;

            cmd.Parameters.Add("@fecha", SqlDbType.VarChar, 10).Value = fecha;
            cmd.Parameters.Add("@idmedico", SqlDbType.Int).Value = idmedico;
            DataTable dt = db.ejecutarConsulta(cmd);

            List<Reserva> lista = new List<Reserva>();
            Reserva obj;

            if (dt.Rows != null)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    obj = new Reserva();
                    obj.Idreserva = int.Parse(fila["idreserva"].ToString());

                    obj.Medico = new Medico();
                    obj.Medico.Idmedico = int.Parse(fila["idmedico"].ToString());
                    obj.Medico.Nombres = fila["medico_nombre"].ToString();
                    obj.Medico.Apellidos = fila["medico_apellido"].ToString();
                    obj.Medico.Email = fila["medico_email"].ToString();
                    obj.Medico.Telefono = int.Parse(fila["medico_telefono"].ToString());

                    obj.Medico.Especialidad = new Especialidad();
                    obj.Medico.Especialidad.Idespecialidad = int.Parse(fila["idespecialidad"].ToString());
                    obj.Medico.Especialidad.Descripcion = fila["especialidad"].ToString();

                    obj.Paciente = new Paciente();
                    obj.Paciente.Idpaciente = int.Parse(fila["idpaciente"].ToString());
                    obj.Paciente.Nombres = fila["paciente_nombres"].ToString();
                    obj.Paciente.Apellidos = fila["paciente_apellidos"].ToString();
                    obj.Paciente.Email = fila["paciente_email"].ToString();
                    obj.Paciente.Telefono = int.Parse(fila["paciente_telefono"].ToString());
                    obj.Paciente.Genero = fila["genero"].ToString();
                    obj.Paciente.Edad = int.Parse(fila["edad"].ToString());

                    obj.Hora = new Hora();
                    obj.Hora.Idhora = int.Parse(fila["idhora"].ToString());
                    obj.Hora.Fecha = DateTime.Parse(fila["fecha"].ToString());
                    obj.Hora.Horaminuto = TimeSpan.Parse(fila["horaminuto"].ToString());
                    obj.Hora.Medico = new Medico();
                    obj.Hora.Medico.Idmedico = int.Parse(fila["idmedico"].ToString());
                    obj.Hora.Medico.Nombres = fila["medico_nombre"].ToString();
                    obj.Hora.Medico.Apellidos = fila["medico_apellido"].ToString();
                    obj.Hora.Medico.Email = fila["medico_email"].ToString();
                    obj.Hora.Medico.Telefono = int.Parse(fila["medico_telefono"].ToString());

                    obj.Hora.Estado = new Estado();
                    obj.Hora.Estado.Idestado = int.Parse(fila["idestado"].ToString());
                    obj.Hora.Estado.Descripcion = fila["estado"].ToString();

                    lista.Add(obj);
                }               
            }
            return lista;
        }


        public static DataTable BuscarMedicoEspecialidad(int idespecialidad)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_busqueda_medico_especialidad";
            cmd.Parameters.Add("@idespecialidad ", SqlDbType.Int).Value = idespecialidad;
            return db.ejecutarConsulta(cmd);
        }

        public static DataTable BuscarMedicoFecha(int idmedico, string fecha, int estado)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_busqueda_medico_fecha";
            cmd.Parameters.Add("@idmedico", SqlDbType.Int).Value = idmedico;
            cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fecha;
            cmd.Parameters.Add("@idestado", SqlDbType.Int).Value = estado;
            return db.ejecutarConsulta(cmd);
        }

        public static Reserva Buscar(int id)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            //SP_
            cmd.CommandText = "sp_buscar_reserva";
            //parametros
            cmd.Parameters.Add("@idreserva", SqlDbType.Int).Value = id;
            DataTable dt = db.ejecutarConsulta(cmd);

            Reserva obj = new Reserva();
            if (dt != null && dt.Rows.Count > 0)
            {
                obj = new Reserva();
                obj.Idreserva = int.Parse(dt.Rows[0]["idreserva"].ToString());

                obj.Medico = new Medico();
                obj.Medico.Idmedico = int.Parse(dt.Rows[0]["idmedico"].ToString());
                obj.Medico.Nombres = dt.Rows[0]["medico_nombre"].ToString();
                obj.Medico.Apellidos = dt.Rows[0]["medico_apellido"].ToString();
                obj.Medico.Email = dt.Rows[0]["medico_email"].ToString();
                obj.Medico.Telefono = int.Parse(dt.Rows[0]["medico_telefono"].ToString());

                obj.Medico.Especialidad = new Especialidad();
                obj.Medico.Especialidad.Idespecialidad = int.Parse(dt.Rows[0]["idespecialidad"].ToString());
                obj.Medico.Especialidad.Descripcion = dt.Rows[0]["especialidad"].ToString();

                obj.Paciente = new Paciente();
                obj.Paciente.Idpaciente = int.Parse(dt.Rows[0]["idpaciente"].ToString());
                obj.Paciente.Nombres = dt.Rows[0]["paciente_nombres"].ToString();
                obj.Paciente.Apellidos = dt.Rows[0]["paciente_apellidos"].ToString();
                obj.Paciente.Email = dt.Rows[0]["paciente_email"].ToString();
                obj.Paciente.Telefono = int.Parse(dt.Rows[0]["paciente_telefono"].ToString());
                obj.Paciente.Genero = dt.Rows[0]["genero"].ToString();
                obj.Paciente.Edad = int.Parse(dt.Rows[0]["edad"].ToString());

                obj.Hora = new Hora();
                obj.Hora.Idhora = int.Parse(dt.Rows[0]["idhora"].ToString());
                obj.Hora.Fecha = DateTime.Parse(dt.Rows[0]["fecha"].ToString());
                obj.Hora.Horaminuto = TimeSpan.Parse(dt.Rows[0]["horaminuto"].ToString());
                obj.Hora.Medico = new Medico();
                obj.Hora.Medico.Idmedico = int.Parse(dt.Rows[0]["idmedico"].ToString());
                obj.Hora.Medico.Nombres = dt.Rows[0]["medico_nombre"].ToString();
                obj.Hora.Medico.Apellidos = dt.Rows[0]["medico_apellido"].ToString();
                obj.Hora.Medico.Email = dt.Rows[0]["medico_email"].ToString();
                obj.Hora.Medico.Telefono = int.Parse(dt.Rows[0]["medico_telefono"].ToString());

                obj.Hora.Estado = new Estado();
                obj.Hora.Estado.Idestado = int.Parse(dt.Rows[0]["idestado"].ToString());
                obj.Hora.Estado.Descripcion = dt.Rows[0]["estado"].ToString();
            }
            return obj;
        }


        public static bool Insert(Reserva obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insert_reserva";
            cmd.Parameters.Add("@idmedico", SqlDbType.Int).Value = obj.Medico.Idmedico;
            cmd.Parameters.Add("@idpaciente", SqlDbType.Int).Value = obj.Paciente.Idpaciente;
            cmd.Parameters.Add("@idhora", SqlDbType.Int).Value = obj.Hora.Idhora;

            return db.ejecutarAccion(cmd);
        }


        public static bool Update(Reserva obj, int idhoraAnterior)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_update_reserva";
            cmd.Parameters.Add("@idhoraestadoanterior", SqlDbType.Int).Value = idhoraAnterior;
            cmd.Parameters.Add("@idreserva", SqlDbType.Int).Value = obj.Idreserva;
            cmd.Parameters.Add("@idmedico", SqlDbType.Int).Value = obj.Medico.Idmedico;
            cmd.Parameters.Add("@idpaciente", SqlDbType.Int).Value = obj.Paciente.Idpaciente;
            cmd.Parameters.Add("@idhora", SqlDbType.Int).Value = obj.Hora.Idhora;

            return db.ejecutarAccion(cmd);
        }

        public static bool Delete(int idreserva, int idhora)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_eliminar_reserva";
            cmd.Parameters.Add("@idreserva", SqlDbType.Int).Value = idreserva;
            cmd.Parameters.Add("@idhora", SqlDbType.Int).Value = idhora;

            return db.ejecutarAccion(cmd);
        }
    }   
}