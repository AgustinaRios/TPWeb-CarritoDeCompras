﻿using Dominio;
using Negocio;
using System;
using System.Collections.Generic;

namespace TPWeb_CarritoDeCompras
{
    public partial class ListaProducto : System.Web.UI.Page
    {
        public List<Producto> listaproducto { get; set; }
        public List<Producto> listacarrito { get; set; }


        Int32 cantItems = 0;


        protected void Page_Load(object sender, EventArgs e)
        {

            ProductoNegocio negocio = new ProductoNegocio();

            listaproducto = negocio.listar();
            listacarrito = listaproducto;
            Session.Add("Listaproducto", listaproducto);


            if (Request.QueryString["id"] != null)
            {
                Int32 IdArt = Int32.Parse(Request.QueryString["id"]);
                Session.Add("idArtCarrito", IdArt);
                foreach (Producto producto in listacarrito)
                {
                    if ( listacarrito[IdArt].Estado == true)
                    {

                        listacarrito[IdArt].Estado = false;
                      
                        cantItems = cantItems + 1;

                        Session.Add("items", cantItems);
                    }

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
    }
}










