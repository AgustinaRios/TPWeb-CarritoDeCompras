<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPWeb_CarritoDeCompras._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row row-cols-1 row-cols-md-3 g-4">
        <% 
            foreach (Dominio.Producto producto in ListaProducto)
            {
        %>
        <div class="col">
            <div class="card">
                <img src="..." class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title"><%:producto.Nombre%></h5>
                    <p class="card-text"><%:producto.Descripción %></p>
                    <p class="card-text">Precio: $<%:producto.Precio %></p>
                </div>
            </div>
        </div>

        <%  }%>
    </div>

</asp:Content>
