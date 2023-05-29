using Dominio;
using Negocio;
using System;
using System.Collections.Generic;

namespace TPWeb_CarritoDeCompras
{
    public partial class ListaProducto : System.Web.UI.Page
    {
        public List<Producto> listaproducto { get; set; }
        public List<Int32> listacarrito { get; set; }
        public Int32 IdArt = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();

            listaproducto = negocio.listarConSP();
            Session.Add("Listaproducto", listaproducto);


            if (IsPostBack)
            {
                IdArt = Int32.Parse(Request.QueryString["id"]);

            }





        }
        public string obtenerUrl(Int32 idarticulo)
        {
            try
            {
                ProductoNegocio negocio = new ProductoNegocio();


                List<ImagenArticulo> ListaImagenProducto = negocio.listarImgArt(idarticulo);
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