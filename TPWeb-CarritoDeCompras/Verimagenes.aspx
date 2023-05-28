<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Verimagenes.aspx.cs" Inherits="TPWeb_CarritoDeCompras.Verimagenes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="row row-cols-1 row-cols-md-3 g-4">
        <% 
            foreach (Dominio.ImagenArticulo imagen in listaImagenes)
            {
        %>
        <div class="col">
  <img src="<%:imagen.Imagen%>" class="card-img-top" alt="Imagen Articulo ">
  <div class="card-body">  
      <button type="button" class="btn btn-warning">Modificar</button>
      <button type="button" class="btn btn-danger">Eliminar</button>
  </div>
</div>
    <%} %>

</asp:Content>
