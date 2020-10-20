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
                obj.Medico.Idmedico = int.Parse(fila["idestado"].ToString());
                obj.Medico.Nombres = fila["idestado"].ToString();
                obj.Medico.Apellidos = fila["idestado"].ToString();
                obj.Medico.Email = fila["idestado"].ToString();
                obj.Medico.Telefono = int.Parse(fila["idestado"].ToString());

                obj.Medico.Especialidad = new Especialidad();
                obj.Medico.Especialidad.Idespecialidad = int.Parse(fila["idestado"].ToString());
                obj.Medico.Especialidad.Descripcion = fila["idestado"].ToString();

                obj.Paciente = new Paciente();
                obj.Paciente.Idpaciente = int.Parse(fila["idestado"].ToString());
                obj.Paciente.Nombres = fila["idestado"].ToString();
                obj.Paciente.Apellidos = fila["idestado"].ToString();
                obj.Paciente.Email = fila["idestado"].ToString();
                obj.Paciente.Telefono = int.Parse(fila["idestado"].ToString());
                obj.Paciente.Genero = fila["idestado"].ToString();
                obj.Paciente.Edad = int.Parse(fila["idestado"].ToString());

                obj.Hora = new Hora();
                obj.Hora.Idhora = int.Parse(fila["idestado"].ToString());
                obj.Hora.Horaminuto = TimeSpan.Parse(fila["idestado"].ToString());
                obj.Hora.Medico = new Medico();
                obj.Hora.Medico.Idmedico = int.Parse(fila["idestado"].ToString());
                obj.Hora.Medico.Nombres = fila["idestado"].ToString();
                obj.Hora.Medico.Apellidos = fila["idestado"].ToString();
                obj.Hora.Medico.Email = fila["idestado"].ToString();
                obj.Hora.Medico.Telefono = int.Parse(fila["idestado"].ToString());

                obj.Hora.Estado = new Estado();
                obj.Hora.Estado.Idestado = int.Parse(fila["idestado"].ToString());
                obj.Hora.Estado.Descripcion = fila["idestado"].ToString();

                 lista.Add(obj);
            }

            return lista;
        }

    }

    
}