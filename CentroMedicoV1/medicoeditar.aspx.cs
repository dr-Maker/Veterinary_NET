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
    public partial class medicoeditar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Session["login"].Equals("N3T4CC3SS"))
            {
                Response.Redirect("index.aspx");
            }

            if (!IsPostBack)
            {
                // llenar el DropDownList idespecialidad
                DataTable dt = BussEspecialidad.Listar();
                idespecialidad.Items.Add(new ListItem("Seleccionar...", ""));
                foreach (DataRow row in dt.Rows)
                {
                    string texto = row["descripcion"].ToString();
                    string valor = row["idespecialidad"].ToString();
                    idespecialidad.Items.Add(new ListItem(texto, valor));
                }

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
                        idespecialidad.Text = obj.Especialidad.Idespecialidad.ToString();
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

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Medico obj = new Medico();
                obj.Idmedico = int.Parse(idmedico.Text);
                obj.Nombres = nombres.Text;
                obj.Apellidos = apellidos.Text;
                obj.Email = email.Text;
                obj.Telefono = int.Parse(telefono.Text);

                obj.Especialidad = new Especialidad();
                obj.Especialidad.Idespecialidad = int.Parse(idespecialidad.Text);

                BussMedico.Update(obj);

                Response.Redirect("medicolistar.aspx");
            }
            catch (Exception exe)
            {

            }
        }
    }
}