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
    public partial class _Default : Page
    {
        public List <Producto> ListaProducto { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            ListaProducto = negocio.listarConSP();
        }
        public string obtenerUrl(int id)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            return negocio.buscarImagen(id);

        }


    }



}