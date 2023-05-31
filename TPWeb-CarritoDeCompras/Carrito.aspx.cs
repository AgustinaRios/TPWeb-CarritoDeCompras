using Dominio;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

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
            if (carrito.lista == null) carrito.lista = new List<ItemsCarrito>();


            if (id != null)
            {
                if (carrito.lista.Find(x => x.Id.ToString() == id) == null)
                {
                    List<Producto> listado = (List<Producto>)Session["Listaproducto"]; 
                    producto = listado.Find(x => x.Id.ToString() == id);

                    item.Id = producto.Id;
                    item.Nombre = producto.Nombre;
                    item.Cantidad = 1;
                    item.Precio = producto.Precio;
                    carrito.lista.Add(item);

                }
                repetidorCarrito.DataSource = carrito.lista;
                repetidorCarrito.DataBind();
                Session.Add("carrito", carrito);


            }




        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var cantidad = lblTotal.Text;
                if (cantidad != "")
                {
                    var argument = ((Button)sender).CommandArgument;
                    carrito = (carritoclass)Session["carrito"];
                    ItemsCarrito item1 = carrito.lista.Find(x => x.Id.ToString() == argument);
                    item1.Cantidad = int.Parse(cantidad);
                    Session.Add("carrito", carrito);
                    repetidorCarrito.DataSource = null;
                    repetidorCarrito.DataSource = carrito.lista;
                    repetidorCarrito.DataBind();
                    lblTotal.Text = carrito.totalCarrito(carrito).ToString();
                }
            }
            catch (Exception ex)
            {

               // Session.Add("Error", ex.ToString());
              //  Response.Redirect("Error.aspx");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var argument = ((Button)sender).CommandArgument;
                //carrito.Items = (List<ItemCarrito>)Session["carrito"];
                carrito = (carritoclass)Session["carrito"];
                ItemsCarrito item1 = carrito.lista.Find(x => x.Id.ToString() == argument);
                carrito.lista.Remove(item1);
                Session.Add("carrito", carrito);
                repetidorCarrito.DataSource = null;
                repetidorCarrito.DataSource = carrito.lista;
                repetidorCarrito.DataBind();
                lblTotal.Text = carrito.totalCarrito(carrito).ToString();
            }
            catch (Exception ex)
            {

               // Session.Add("Error", ex.ToString());
               // Response.Redirect("Error.aspx");
            }
        }

        protected void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cantidad = ((TextBox)sender).Text;
                lblTotal.Text = cantidad;


            }

            catch (Exception ex)
            {

                //Session.Add("Error", ex.ToString());
               // Response.Redirect("Error.aspx");
            }
        }

        protected void lblTotal_Load(object sender, EventArgs e)
        {

        }
    }
}