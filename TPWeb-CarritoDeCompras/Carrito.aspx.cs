using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
namespace TPWeb_CarritoDeCompras
{
    public partial class Carrito : System.Web.UI.Page
    {
        public List<Producto> Listacarrito=new List<Producto>();
        protected void Page_Load(object sender, EventArgs e)
        {

            Int32 IdArt = Int32.Parse(Request.QueryString["id"]);
            ProductoNegocio negocio = new ProductoNegocio();
            Producto productocomprado= new Producto();
            productocomprado=negocio.ObtenerProducto(IdArt);
            Listacarrito.Add(productocomprado);
           
            
            // dgvProductos.DataSource = Listacarrito;    
           // dgvProductos.DataBind();

            /// repetidorCarrito.DataSource = Session["CarritoCargado"];
            /// repetidorCarrito.DataBind();
        }

        protected float TotalCarrito ()
        {
            float total = 0;
            foreach (Producto producto in Listacarrito)
            {
                total += producto.Precio;
            }
            return total;
        }
    }
}