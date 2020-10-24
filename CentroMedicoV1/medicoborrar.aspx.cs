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
    public partial class medicoborrar : System.Web.UI.Page
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
                    int id = int.Parse(Request["id"].ToString());
                    Medico obj = BussMedico.Buscar(id);
                    if (obj != null)
                    {
                        idmedico.Text = obj.Idmedico.ToString();
                        nombres.Text = obj.Nombres.ToString();
                        apellidos.Text = obj.Apellidos.ToString();
                        email.Text = obj.Email.ToString();
                        telefono.Text = obj.Telefono.ToString();
                        especialidad.Text = obj.NomEspecialidad.ToString();
                    }
                    else
                    {
                        Response.Redirect("medicolistar.aspx");
                    }
                }
                else
                {
                    Response.Redirect("medicolistar.aspx");
                }
            }

        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(idmedico.Text);
                BussMedico.Delete(id);
                Response.Redirect("medicolistar.aspx");
            }
            catch (Exception exe)
            {

            }

        }
    }
}