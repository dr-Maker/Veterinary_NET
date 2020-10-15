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
    public partial class horanuevo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {

            try
            {
                Hora obj = new Hora();

                obj.Idhora = 0;
                obj.Fecha = DateTime.Parse(fecha.Text);
                obj.Horaminuto = TimeSpan.Parse(horaminuto.Text);

                obj.Medico = new Medico();
                obj.Medico.Idmedico = int.Parse(idmedico.Text);

                obj.Estado = new Estado();
                obj.Estado.Idestado = int.Parse(idestado.Text);

                BussHora.Insert(obj);

                Response.Redirect("horalistar.aspx");
            }
            catch (Exception exe)
            {
            }
        }
    }
}