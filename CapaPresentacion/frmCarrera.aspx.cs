﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmCarrera : System.Web.UI.Page
    {
        private void Listar()
        {
            Carrera carrera = new Carrera();
            gvCarrera.DataSource = carrera.Listar();
            gvCarrera.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Carrera carrera = new Carrera();
            carrera.CodCarrera = txtCodCarrera.Text.Trim();
            carrera.NombreCarrera = txtCarrera.Text.Trim();
            if (carrera.Agregar())
                Listar();
            else
            {
                Response.Write("Error : no se agrego correctamente");
            }

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Carrera carrera = new Carrera();
            carrera.CodCarrera  = txtBuscar.Text.Trim();
            gvCarrera.DataSource = carrera.Buscar();
            gvCarrera.DataBind();

        }
    }
}