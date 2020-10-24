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
    public partial class pacientelistar : System.Web.UI.Page
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

            List<Paciente> lista = BussPaciente.Listar02();
            foreach (Paciente obj in lista)
            {
                r = new TableRow();
                tblMedicos.Rows.Add(r);

                c = new TableCell(); c.Text = obj.Idpaciente.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.NomPaciente.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.Email.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.Telefono.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.Genero.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.Edad.ToString(); r.Cells.Add(c);



                c = new TableCell();
                c.Text = "<a href='pacienteeditar.aspx?id=" + obj.Idpaciente.ToString() + "'><img border='0' src='img/editar.png'></a>";
                r.Cells.Add(c);

                c = new TableCell();
                c.Text = "<a href='pacienteborrar.aspx?id=" + obj.Idpaciente.ToString() + "'><img border='0' src='img/borrar.png'></a>";
                r.Cells.Add(c);
            }
        }
    }
}