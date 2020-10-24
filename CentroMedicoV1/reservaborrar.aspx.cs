using Buss;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentroMedicoV1
{
    public partial class reservaborrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Session["login"].Equals("N3T4CC3SS"))
            {
                Response.Redirect("index.aspx");
            }

            if (!IsPostBack)
            {
                if (Request["id"] != null)
                {

                    int id = Convert.ToInt32(Request["id"].ToString());
                    Reserva obj = BussReserva.Buscar(id);
                    if (obj != null)
                    {
                        idreserva.Text = obj.Idreserva.ToString();
                        dlespecialidad.Text = obj.Medico.NomEspecialidad.ToString();
                        idmedico.Text = obj.Medico.Nombres.ToString() + " " + obj.Medico.Apellidos.ToString();
                        idpaciente.Text = obj.Paciente.Nombres.ToString() + " " + obj.Paciente.Apellidos.ToString();
                        tbfecha.Text = obj.Hora.FechaTxt.ToString();
                        tbidhora.Text = obj.Hora.Idhora.ToString();
                        dlHoraMinuto.Text = obj.Hora.HoraMinutoTxt.ToString();

                        tbidhora.Visible = false;

                    }
                    else
                    {
                        Response.Redirect("reservadolistar.aspx");
                    }
                }
                else
                {
                    Response.Redirect("reservalistar.aspx");
                }

            }

        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {

            try
            {
                int idreservatxt = int.Parse(idreserva.Text);
                int idhoratxt = int.Parse(tbidhora.Text);
                BussReserva.Delete(idreservatxt, idhoratxt);
                Response.Redirect("reservalistar.aspx");
            }
            catch (Exception exe)
            {

            }

        }
    }
}