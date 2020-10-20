﻿using Buss;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentroMedicoV1
{
    public partial class especialidadeditar : System.Web.UI.Page
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
                    Especialidad obj = BussEspecialidad.Buscar(id);
                    if (obj != null)
                    {
                        idespecialidad.Text = obj.Idespecialidad.ToString();
                        txtespecialidad.Text = obj.Descripcion.ToString();
                    }
                    else
                    {
                        Response.Redirect("especialidadlistar.aspx");
                    }
                }
                else
                {
                    Response.Redirect("especialidadlistar.aspx");
                }
            }

        }
        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Especialidad obj = new Especialidad();
                obj.Idespecialidad = int.Parse(idespecialidad.Text);
                obj.Descripcion = txtespecialidad.Text;

                BussEspecialidad.Update(obj);

                Response.Redirect("especialidadlistar.aspx");
            }
            catch (Exception exe)
            {
            }
        }
    }
}