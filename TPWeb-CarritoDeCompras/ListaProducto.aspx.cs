using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace TPWeb_CarritoDeCompras
{
    public partial class ListaProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio producto = new ProductoNegocio();
            dgvProductos.DataSource = producto.listarConSP();
            dgvProductos.DataBind();
        }
    }
}