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
    public partial class reservalistar : System.Web.UI.Page
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

            List<Reserva> lista = BussReserva.Listar02();
            foreach (Reserva obj in lista)
            {
                r = new TableRow();
                tblEspecialidad.Rows.Add(r);

                c = new TableCell(); c.Text = obj.Idreserva.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.Hora.FechaTxt.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.Hora.HoraMinutoTxt.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.Medico.NomMedico.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.Medico.NomEspecialidad.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.Paciente.Nombres.ToString(); r.Cells.Add(c);

                c = new TableCell();
                c.HorizontalAlign = HorizontalAlign.Center;
                c.Text = "<a  href='reservaditar.aspx?id=" + obj.Idreserva.ToString() + "'>Editar</a>";
                r.Cells.Add(c);

                c = new TableCell();
                c.HorizontalAlign = HorizontalAlign.Center;
                c.Text = "<a href='reservaborrar.aspx?id=" + obj.Idreserva.ToString() + "'>Borrar</a>";
                r.Cells.Add(c);
            }
        }
    }
}