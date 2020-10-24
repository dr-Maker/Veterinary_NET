using Buss;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentroMedicoV1
{
    public partial class reservanuevo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Session["login"].Equals("N3T4CC3SS"))
            {
                Response.Redirect("index.aspx");
            }

            if (!IsPostBack)
            {
                DataTable dtm = BussReserva.Listar();
                idmedico.Items.Add(new ListItem("Seleccione..", ""));

                foreach (DataRow r in dtm.Rows)
                {
                    string texto = r["medico_nombre"].ToString() + " " + r["medico_apellido"].ToString();
                    string valor = r["idmedico"].ToString();
                    idmedico.Items.Add(new ListItem(texto, valor));
                }

                
                dlespecialidad.Items.Add(new ListItem("Seleccione..", ""));

                foreach (DataRow r in dtm.Rows)
                {
                    string texto = r["especialidad"].ToString();
                    string valor = r["idespecialidad"].ToString();
                    dlespecialidad.Items.Add(new ListItem(texto, valor));
                }


                idpaciente.Items.Add(new ListItem("Seleccione..", ""));
                foreach (DataRow r in dtm.Rows)
                {
                    string texto = r["paciente_nombres"].ToString() + " " + r["paciente_apellidos"].ToString();
                    string valor = r["idpaciente"].ToString();
                    idpaciente.Items.Add(new ListItem(texto, valor));
                }
                dlHoraMinuto.Items.Add(new ListItem("Seleccione..", ""));

            }

        }     

        protected void EspecialidadSelected(object sender, EventArgs e)
        {
            int ddlespecialidad;
            idmedico.Items.Clear();
            try
            {
                ddlespecialidad = int.Parse(dlespecialidad.Text);
            }
            catch (Exception exe)
            {
                ddlespecialidad = 0;
            }

            DataTable dtm = BussReserva.BuscarMedicoEspecialidad(ddlespecialidad);
            idmedico.Items.Add(new ListItem("Seleccione..", ""));

            foreach (DataRow r in dtm.Rows)
            {
                string texto = r["nombres"].ToString() + " " + r["apellidos"].ToString();
                string valor = r["idmedico"].ToString();
                idmedico.Items.Add(new ListItem(texto, valor));
            }     
        }

        protected void tbfecha_TextChanged(object sender, EventArgs e)
        {

            int txmedico;
            try
            {
                txmedico = int.Parse(idmedico.Text);
            }
            catch (Exception exe)
            {
                txmedico = 0;
            }

            string fecha = tbfecha.Text;

            dlHoraMinuto.Items.Clear();

            DataTable dtmh = BussReserva.BuscarMedicoFecha(txmedico, fecha, 1);
            dlHoraMinuto.Items.Add(new ListItem("Seleccione..", ""));
            foreach (DataRow r in dtmh.Rows)
            {
                string texto = r["horaminuto"].ToString();
                string valor = r["idhora"].ToString();
                dlHoraMinuto.Items.Add(new ListItem(texto, valor));
            }
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Reserva obj = new Reserva();
                obj.Idreserva = 0;

                obj.Medico = new Medico();
                obj.Medico.Idmedico = int.Parse(idmedico.Text);

                obj.Paciente = new Paciente();
                obj.Paciente.Idpaciente = int.Parse(idpaciente.Text);

                obj.Hora = new Hora();
                obj.Hora.Idhora = int.Parse(dlHoraMinuto.Text);

                BussReserva.Insert(obj);

                Response.Redirect("reservalistar.aspx");
            }
            catch (Exception exe)
            {
            }
        }
    }   
}