<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaProducto.aspx.cs" Inherits="TPWeb_CarritoDeCompras.ListaProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <div class="row row-cols-1 row-cols-md-3 g-4">
        <% 
            foreach (Dominio.Producto producto in listaproducto)
            {
        %>
        <div class="col">

            <div class="card">


                <img src="<%:obtenerUrl(producto.Id)%>" class="card-img-top" alt=".Imagen del producto">
                <div class="card-body">
                    <h5 class="card-title"><%:producto.Nombre%></h5>
                    <p class="card-text">Precio: $<%:producto.Precio %></p>
                    <a href="Detalle.aspx?id=<%:producto.Id %>" class="btn btn-success">Ver Detalle</a>
                    <a href="ListaProducto.aspx?id=<%:producto.Id %>" class="btn btn-success">Carrito</a>

                </div>
            </div>
        </div>

        <%  }%>
    </div>
</asp:Content>
