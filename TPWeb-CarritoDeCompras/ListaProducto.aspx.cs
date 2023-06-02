using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;

namespace TPWeb_CarritoDeCompras
{
    public partial class ListaProducto : System.Web.UI.Page
    {
        public List<Producto> listaproducto { get; set; }
        public List<Producto> listacarrito { get; set; }

        public bool filtroAvanzado { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ProductoNegocio negocio = new ProductoNegocio();

                listaproducto = negocio.listar();
                listacarrito = listaproducto;
                Session.Add("Listaproducto", listaproducto);
                filtroAvanzado = chkAvanzado.Checked;

                if (Request.QueryString["id"] != null)
                {
                    Int32 IdArt = Int32.Parse(Request.QueryString["id"]);
                    Session.Add("idArtCarrito", IdArt);

                    Session.Add("items", 1);


                }

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
        protected void filtro_textChanged(object sender, EventArgs e)
        {
            listaproducto = (List<Producto>)Session["Listaproducto"];
            listaproducto = listaproducto.FindAll(x => x.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()));

        }
        protected void chkAvanzado_ChekedChanged(object sender, EventArgs e)
        {
            filtroAvanzado = chkAvanzado.Checked;
            txtFiltro.Enabled = !filtroAvanzado;

        }

        protected void BtnBuscar_clik(object sender, EventArgs e)
        {
            try
            {
                ProductoNegocio negocio = new ProductoNegocio();
                listaproducto = negocio.filtrar(ddlCampo.SelectedItem.ToString(), ddlCriterio.SelectedItem.ToString(), txtFiltroAvanzado.Text);

            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }
        }

    }
}










