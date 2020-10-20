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
    public partial class estadoeditar : System.Web.UI.Page
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
                    Estado obj = BussEstado.Buscar(id);
                    if (obj != null)
                    {
                        idestado.Text = obj.Idestado.ToString();
                        txtdescripcion.Text = obj.Descripcion.ToString();
                    }
                    else
                    {
                        Response.Redirect("estadolistar.aspx");
                    }
                }
                else
                {
                    Response.Redirect("estadolistar.aspx");
                }

            }
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {

            try
            {
                Estado obj = new Estado();
                obj.Idestado = int.Parse(idestado.Text);
                obj.Descripcion = txtdescripcion.Text;
             
                BussEstado.Update(obj);

                Response.Redirect("Estadolistar.aspx");
            }
            catch (Exception exe)
            {
            }

        }
    }
}