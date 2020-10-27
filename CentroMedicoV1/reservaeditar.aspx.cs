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

                DataTable dtesp = BussEspecialidad.Listar();
                dlespecialidad.Items.Add(new ListItem("Seleccione..", ""));
                foreach (DataRow r in dtesp.Rows)
                {
                    string texto = r["descripcion"].ToString();
                    string valor = r["idespecialidad"].ToString();
                    dlespecialidad.Items.Add(new ListItem(texto, valor));
                }

                DataTable dtmed = BussMedico.Listar();
                idmedico.Items.Add(new ListItem("Seleccione..", ""));
                foreach (DataRow r in dtmed.Rows)
                {
                    string texto = r["nombres"].ToString() + " " + r["apellidos"].ToString();
                    string valor = r["idmedico"].ToString();
                    idmedico.Items.Add(new ListItem(texto, valor));
                }

                DataTable dtpac = BussPaciente.Listar();
                idpaciente.Items.Add(new ListItem("Seleccione..", ""));
                foreach (DataRow r in dtpac.Rows)
                {
                    string texto = r["nombres"].ToString() + " " + r["apellidos"].ToString();
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
                        tbidhoraantiguo.Text = obj.Hora.Idhora.ToString();
                        tbidhoraantiguo.Visible = false;
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

            tbfecha.Text = "";
            dlHoraMinuto.Items.Clear();
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

            if (dtmh.Rows.Count == 0)
            {
                dlHoraMinuto.Items.Clear();
                dlHoraMinuto.Items.Add(new ListItem("No existen horas diponibles con los datos seleccionados..", ""));
            }
        }

        protected void idmedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbfecha.Text = "";
            dlHoraMinuto.Items.Clear();
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {

                int idhoraanterior;

                Reserva obj = new Reserva();
                obj.Idreserva = int.Parse(idreserva.Text);

                obj.Medico = new Medico();
                obj.Medico.Idmedico = int.Parse(idmedico.Text);

                obj.Paciente = new Paciente();
                obj.Paciente.Idpaciente = int.Parse(idpaciente.Text);

                obj.Hora = new Hora();
                obj.Hora.Idhora = int.Parse(dlHoraMinuto.Text);

                 idhoraanterior = int.Parse(tbidhoraantiguo.Text);


                BussReserva.Update(obj, idhoraanterior);
                Response.Redirect("reservalistar.aspx");

            }
            catch (Exception)
            {

            }
        }
    }
}