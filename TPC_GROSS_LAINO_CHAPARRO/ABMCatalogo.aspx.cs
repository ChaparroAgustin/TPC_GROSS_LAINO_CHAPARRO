﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPC_GROSS_LAINO_CHAPARRO
{
    public partial class ABMCatalogo : System.Web.UI.Page
    {
        public List<Producto> lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoDB productoDB = new ProductoDB();
            try
            {
                lista = productoDB.Listar();

                Session.Add("listadoProductos", lista);

                dgvCatalogo.DataSource = lista;
                dgvCatalogo.DataBind();
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }

        protected void BtnDelAbmCat_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in dgvCatalogo.Rows)
            {
                CheckBox chk = (CheckBox)(row.FindControl("chkActivo"));
                if (chk.Checked)
                {
                    
                }
            }
        }
    }
}