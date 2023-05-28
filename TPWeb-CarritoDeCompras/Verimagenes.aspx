<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Verimagenes.aspx.cs" Inherits="TPWeb_CarritoDeCompras.Verimagenes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div id="carouselExample" class="carousel slide" data-ride="carousel">
    <div class="carousel-inner">
        <% for (int i = 0; i < listaImagenes.Count; i++) { %>
            <div class="carousel-item<%= i == 0 ? " active" : "" %>">
                <img src="<%= listaImagenes[i].Imagen %>" class="d-block w-30 h-30" style="object-fit: contain;" />
            </div>
        <% } %>
    </div>
    <a class="carousel-control-prev" href="#imagenArticulo" role="button" data-slide="prev">
        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
        <span class="sr-only">Anterior</span>
    </a>
    <a class="carousel-control-next" href="#imagenArticulo" role="button" data-slide="next">
        <span class="carousel-control-next-icon" aria-hidden="true"></span>
        <span class="sr-only">Siguiente</span>
    </a>
</div>
</asp:Content>
