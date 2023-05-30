using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
namespace TPWeb_CarritoDeCompras
{
    public partial class Carrito : System.Web.UI.Page
    {
        public List<Producto> Listacarrito { set; get; }
        protected void Page_Load(object sender, EventArgs e)
        {

            repetidorCarrito.DataSource = Session["CarritoCargado"];
            repetidorCarrito.DataBind();
        }
    }
}