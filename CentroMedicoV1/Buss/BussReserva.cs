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
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from paciente";
            return db.ejecutarConsulta(cmd);
        }

        public static List<Reserva> Listar02()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_listar_reserva";
            DataTable dt = db.ejecutarConsulta(cmd);

            List<Reserva> lista = new List<Reserva>();
            Reserva obj;

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

           

            return lista;
        }

    }

    
}