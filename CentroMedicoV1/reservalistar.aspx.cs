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

        int medico;
        string fecha = "";
        int especialidad;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Session["login"].Equals("N3T4CC3SS"))
            {
                Response.Redirect("index.aspx");
            }


            if (!IsPostBack)
            {

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

                LlenarTabla(especialidad, fecha, medico);
            }


        }
        public void LlenarTabla(int especialidad, string fecha, int idmedico)
        {

            tblEspecialidad.Rows.Clear();

            TableRow r;
            TableCell c;

            List<Reserva> lista = BussReserva.Listar02(especialidad, fecha, idmedico);
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
                c.Text = "<a  href='reservaeditar.aspx?id=" + obj.Idreserva.ToString() + "'><img border='0' src='img/editar.png'></a>";
                r.Cells.Add(c);

                c = new TableCell();
                c.HorizontalAlign = HorizontalAlign.Center;
                c.Text = "<a href='reservaborrar.aspx?id=" + obj.Idreserva.ToString() + "'><img border='0' src='img/borrar.png'></a>";
                r.Cells.Add(c);
            }
        }

        protected void txtFecha_TextChanged(object sender, EventArgs e)
        {

            ActualizacionLlenarTabla();
        }

        protected void ddlMedico_SelectedIndexChanged(object sender, EventArgs e)
        {

            ActualizacionLlenarTabla();

        }
        protected void ddlEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizacionLlenarTabla();
        }

        public void ActualizacionLlenarTabla()
        {
            try
            {
                especialidad = int.Parse(ddlEspecialidad.Text);
            }
            catch (Exception)
            {
                especialidad = 0;
            }
            try
            {
                medico = int.Parse(ddlMedico.Text);
            }
            catch (Exception)
            {
                medico = 0;
            }
            fecha = txtFecha.Text;
            LlenarTabla(especialidad, fecha, medico);
        }
    }
}