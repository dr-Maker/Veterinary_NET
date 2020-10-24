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
    public partial class pacienteeditar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Session["login"].Equals("N3T4CC3SS"))
            {
                Response.Redirect("index.aspx");
            }

            if (Request["id"] != null)
            {
                int id = int.Parse(Request["id"].ToString());
                Paciente obj = BussPaciente.Buscar(id);
                if (obj != null)
                {
                    idpaciente.Text = obj.Idpaciente.ToString();
                    nombres.Text = obj.Nombres.ToString();
                    apellidos.Text = obj.Apellidos.ToString();
                    email.Text = obj.Email.ToString();
                    telefono.Text = obj.Telefono.ToString();
                    genero.Text = obj.Genero.ToString();
                    edad.Text = obj.Edad.ToString();
                }
                else
                {
                    Response.Redirect("pacientelistar.aspx");
                }
            }
            else
            {
                Response.Redirect("pacientelistar.aspx");
            }
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente obj = new Paciente();
                obj.Idpaciente = int.Parse(idpaciente.Text);
                obj.Nombres = nombres.Text;
                obj.Apellidos = apellidos.Text;
                obj.Email = email.Text;
                obj.Telefono = int.Parse(telefono.Text);
                obj.Genero = genero.Text;
                obj.Edad = int.Parse(edad.Text);

                BussPaciente.Update(obj);

                Response.Redirect("pacientelistar.aspx");
            }
            catch (Exception exe)
            {

            }
        }
    }
}