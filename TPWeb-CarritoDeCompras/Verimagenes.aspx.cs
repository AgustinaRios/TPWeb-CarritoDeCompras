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
    public partial class Verimagenes : System.Web.UI.Page
    {
        public List<ImagenArticulo> listaImagenes { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            Int32 IdArt = Int32.Parse( Request.QueryString["id"]);
            List<ImagenArticulo> Lista = negocio.listarImgArt(IdArt);
                listaImagenes = Lista;
            
           
        }
    }
}