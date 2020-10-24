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
    public partial class especialidadlistar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Session["login"].Equals("N3T4CC3SS"))
            {
                Response.Redirect("index.aspx");
            }
            LlenarTabla();
        }

        public void LlenarTabla()
        {
            TableRow r;
            TableCell c;

            List<Especialidad> lista = BussEspecialidad.Listar02();
            foreach (Especialidad obj in lista)
            {
                r = new TableRow();
                tblEspecialidad.Rows.Add(r);

                c = new TableCell(); c.Text = obj.Idespecialidad.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.Descripcion.ToString(); r.Cells.Add(c);


                c = new TableCell();
                c.HorizontalAlign = HorizontalAlign.Center;
                c.Text = "<a  href='especialidadeditar.aspx?id=" + obj.Idespecialidad.ToString() + "'><img border='0' src='img/editar.png'></a>";
                r.Cells.Add(c);

                c = new TableCell();
                c.HorizontalAlign = HorizontalAlign.Center;
                c.Text = "<a href='especialidadborrar.aspx?id=" + obj.Idespecialidad.ToString() + "'><img border='0' src='img/borrar.png'></a>";
                r.Cells.Add(c);
            }
        }
    }
}