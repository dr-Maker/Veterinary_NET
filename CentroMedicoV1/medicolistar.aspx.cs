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
    public partial class medicolistar : System.Web.UI.Page
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

            List<Medico> lista = BussMedico.Listar02();
            foreach (Medico obj in lista)
            {
                r = new TableRow();
                tblMedicos.Rows.Add(r);

                c = new TableCell(); c.Text = obj.Idmedico.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.NomMedico.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.Email.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.Telefono.ToString(); r.Cells.Add(c);
                c = new TableCell(); c.Text = obj.NomEspecialidad; r.Cells.Add(c);


                c = new TableCell();
                c.Text = "<a href='medicoeditar.aspx?id=" + obj.Idmedico.ToString() + "'><img border='0' src='img/editar.png'></a>";
                r.Cells.Add(c);

                c = new TableCell();
                c.Text = "<a href='medicoborrar.aspx?id=" + obj.Idmedico.ToString() + "'><img border='0' src='img/borrar.png'></a>";
                r.Cells.Add(c);
            }
        }
    }
}