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
        public List<ItemsCarrito> Listacarrito { set; get; }
        public carritoclass carrito = new carritoclass();
        Producto producto = new Producto();
        ItemsCarrito item = new ItemsCarrito();
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Convert.ToString(Session["idArtCarrito"]);
            carrito = (carritoclass)Session["carrito"];
            if (carrito == null) carrito = new carritoclass();
            //carrito.Items = (List<ItemCarrito>)Session["carrito"];
            if (carrito.lista == null) carrito.lista= new List<ItemsCarrito>();


            if (id != null)
            {
                if (carrito.lista.Find(x => x.Id.ToString() == id) == null)
                {
                    List<Producto> listado = (List<Producto>)Session["Listaproducto"];
                    producto = listado.Find(x => x.Id.ToString() == id);

                    item.Id = producto.Id;
                    item.Nombre = producto.Nombre;
                    item.cantidad = 1;
                    item.precio = producto.Precio;
                    carrito.lista.Add(item);



                } repetidorCarrito.DataSource = carrito.lista;
                repetidorCarrito.DataBind();
               Session.Add("carrito", carrito);
            }

              
            
           

        }
    }
}