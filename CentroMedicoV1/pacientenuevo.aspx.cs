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
    public partial class pacientenuevo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Session["login"].Equals("N3T4CC3SS"))
            {
                Response.Redirect("index.aspx");
            }

        }


        protected void rbm_CheckedChanged(object sender, EventArgs e)
        {
            if (rbm.Checked)
            {
                rbf.Checked = false;
                rbm.Text = "M";
            }

        }

        protected void rbf_CheckedChanged(object sender, EventArgs e)
        {
            if (rbf.Checked)
            {
                rbm.Checked = false;
                rbf.Text = "F";
            }

        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {

            try
            {

                Paciente obj = new Paciente();

                obj.Idpaciente = 0;
                obj.Nombres = nombres.Text;
                obj.Apellidos = apellidos.Text;
                obj.Email = email.Text;
                obj.Telefono = int.Parse(telefono.Text);
                obj.Edad = int.Parse(edad.Text);

                if (rbm.Checked)
                {
                    obj.Genero = rbm.Text;
                }
                else
                {
                    obj.Genero = rbf.Text;
                }

                BussPaciente.Insert(obj);

                Response.Redirect("pacientelistar.aspx");
            }
            catch (Exception exe)
            {


            }

        }


    }
}