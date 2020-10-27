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
    public partial class pacienteborrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Session["login"].Equals("N3T4CC3SS"))
            {
                Response.Redirect("index.aspx");
            }

            if (Request["id"] != null)
            {
                int id = int.Parse(Request["id"].ToString());
                Paciente obj = BussPaciente.Buscar(id);
                if (obj != null)
                {
                    idpaciente.Text = obj.Idpaciente.ToString();
                    nombres.Text = obj.Nombres.ToString();
                    apellidos.Text = obj.Apellidos.ToString();
                    email.Text = obj.Email.ToString();
                    telefono.Text = obj.Telefono.ToString();
                  
                    edad.Text = obj.Edad.ToString();
                }
                else
                {
                    Response.Redirect("pacientelistar.aspx");
                }
            }
            else
            {
                Response.Redirect("pacientelistar.aspx");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(idpaciente.Text);
                BussPaciente.Delete(id);
                Response.Redirect("pacientelistar.aspx");
            }
            catch (Exception exe)
            {

            }
        }
    }
}