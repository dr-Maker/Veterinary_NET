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
    public partial class especialidadnuevo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Session["login"].Equals("N3T4CC3SS"))
            {
                Response.Redirect("index.aspx");
            }
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Especialidad obj = new Especialidad();

                obj.Idespecialidad = 0;
                obj.Descripcion = txtespecialidad.Text;
                BussEspecialidad.Insert(obj);
                Response.Redirect("especialidadlistar.aspx");
            }
            catch (Exception exe)
            {
            }
        }
    }
}