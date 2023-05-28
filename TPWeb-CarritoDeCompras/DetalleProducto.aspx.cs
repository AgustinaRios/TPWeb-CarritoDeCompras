using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPWeb_CarritoDeCompras
{
    public partial class DetalleProducto : System.Web.UI.Page
    {
        public List<Producto> listaproducto { get; set; }
        public Producto productoSeleccionado { get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string ID = Request.QueryString["id"];
            int id  = Int32.Parse(ID);

            ProductoNegocio negocio = new ProductoNegocio();

            productoSeleccionado = negocio.ObtenerProducto(id);
            Session.Add("producto",productoSeleccionado);
        }
        public string obtenerUrl(int id)
        {
            try
            {
                ProductoNegocio negocio = new ProductoNegocio();
                List<ImagenArticulo> ListaImagenProducto = negocio.listarImgArt(id);
                return ListaImagenProducto[0].Imagen;



            }
            catch (Exception ex)
            {
                string url = "https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png";

                return url;
            }


        }

    }
}