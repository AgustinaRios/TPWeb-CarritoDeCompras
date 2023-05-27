using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;
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
            
        }
        public string obtenerUrl(int id)
        {
            
            ProductoNegocio negocio = new ProductoNegocio();
             List<ImagenArticulo>ListaImagenProducto=negocio.listarImgArt(id);       
            return ListaImagenProducto[0].Imagen;
            

        }
    }
}