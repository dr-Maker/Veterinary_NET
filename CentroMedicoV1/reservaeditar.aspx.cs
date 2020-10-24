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
    public partial class reservaeditar : System.Web.UI.Page
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
                idmedico.Items.Add(new ListItem("Todos los medicos", ""));

                foreach (DataRow r in dtm.Rows)
                {
                    string texto = r["medico_nombre"].ToString() + " " + r["medico_apellido"].ToString();
                    string valor = r["idmedico"].ToString();
                    idmedico.Items.Add(new ListItem(texto, valor));
                }


                dlespecialidad.Items.Add(new ListItem("Todas las especialidades Medicas", ""));

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

                if (Request["id"] != null)
                {
                    int id = int.Parse(Request["id"].ToString());
                    Reserva obj = BussReserva.Buscar(id);
                    if (obj != null)
                    {
                        idreserva.Text = obj.Idreserva.ToString();
                        dlespecialidad.Text = obj.Medico.Especialidad.Idespecialidad.ToString();
                        idmedico.Text = obj.Medico.Idmedico.ToString();
                        idpaciente.Text = obj.Paciente.Idpaciente.ToString();
                        tbfecha.Text = obj.Hora.FechaTxtBox.ToString();
                        dlHoraMinuto.Items.Add(new ListItem(obj.Hora.HoraMinutoTxt.ToString(), obj.Hora.Idhora.ToString()));



                    }
                    else
                    {
                        Response.Redirect("reservalistar.aspx");
                    }
                }
                 else
                {
                    Response.Redirect("reservalistar.aspx");
                }

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

        }
    }
}