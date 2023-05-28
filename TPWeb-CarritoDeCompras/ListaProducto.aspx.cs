using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
namespace TPWeb_CarritoDeCompras
{
    public partial class ListaProducto : System.Web.UI.Page
    {
        public List<Producto> listaproducto { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();

            listaproducto = negocio.listarConSP();
            Session.Add("Listaproducto", listaproducto);
            RepetidorArticulos.DataSource = listaproducto;
            RepetidorArticulos.DataBind();


        }
        public string obtenerUrl(Int32 idarticulo)
        {

            ProductoNegocio negocio = new ProductoNegocio();
           
            List<ImagenArticulo> ListaImagenProducto = negocio.listarImgArt(idarticulo);
            return ListaImagenProducto[0].Imagen;


        }
    }
}