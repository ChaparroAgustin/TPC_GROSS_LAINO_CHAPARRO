﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPC_GROSS_LAINO_CHAPARRO
{
    public partial class WebInterna : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Session.Add("error", "Debes loguearte para ingresar.");
                Response.Redirect("Error.aspx", false);
            }

            validarNivelUsuario();
        }

        protected void btnABMProductos_Click(object sender, EventArgs e)
        {
            Response.Redirect("ABMProductos.aspx");
        }

        protected void btnABMTiposProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("ABMTiposProducto.aspx");
        }

        protected void btnABMMarcasProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("ABMMarcasProducto.aspx");
        }

        protected void btnABMProveedores_Click(object sender, EventArgs e)
        {
            //Response.Redirect("ABMProveedores.aspx");
        }

        protected void btnAMBMarcaVehiculos_Click(object sender, EventArgs e)
        {
            Response.Redirect("ABMMarcasVehiculo.aspx");
        }

        protected void btnABMEmpleados_Click(object sender, EventArgs e)
        {
            Response.Redirect("ABMEmpleado.aspx");
        }

        protected void btnABMUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("ABMUsuario.aspx");
        }

        protected void validarNivelUsuario()
        {
            if (Session["usuario"] != null && ((Dominio.Usuario)Session["usuario"]).TipoUsuario == Dominio.TipoUsuario.ADMIN)
            {
                btnABMEmpleados.CssClass = "btn-interna-empleados";
                btnABMUsuario.CssClass = "btn-crear-usuario";
            }
        }
       
    }
}