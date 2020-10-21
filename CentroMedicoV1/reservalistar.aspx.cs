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
    public partial class reservalistar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Session["login"].Equals("N3T4CC3SS"))
            {
                Response.Redirect("index.aspx");
            }

            DataTable dtm = BussMedico.Listar();
            ddlMedico.Items.Add(new ListItem("Seleccione..", ""));
            foreach (DataRow r in dtm.Rows)
            {
                string texto = r["nombres"].ToString() + " " + r["apellidos"].ToString();
                string valor = r["idmedico"].ToString();
                ddlMedico.Items.Add(new ListItem(texto, valor));
            }

            DataTable dte = BussEspecialidad.Listar();
            ddlEspecialidad.Items.Add(new ListItem("Seleccione..", ""));
            foreach (DataRow r in dte.Rows)
            {
                string texto = r["descripcion"].ToString();
                string valor = r["idespecialidad"].ToString();
                ddlEspecialidad.Items.Add(new ListItem(texto, valor));
               
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
                c = new TableCell(); c.Text = obj.Paciente.NomPaciente.ToString(); r.Cells.Add(c);

                c = new TableCell();
                c.HorizontalAlign = HorizontalAlign.Center;
                c.Text = "<a  href='reservaeditar.aspx?id=" + obj.Idreserva.ToString() + "'>Editar</a>";
                r.Cells.Add(c);

                c = new TableCell();
                c.HorizontalAlign = HorizontalAlign.Center;
                c.Text = "<a href='reservaborrar.aspx?id=" + obj.Idreserva.ToString() + "'>Borrar</a>";
                r.Cells.Add(c);
            }
        }
    }
}