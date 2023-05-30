<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleProducto.aspx.cs" Inherits="TPWeb_CarritoDeCompras.DetalleProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="container">
  <div class="row">
    <div class="col-md-6">
       <% 
           Dominio.Producto producto = productoSeleccionado;
        %>
      <h2>Características destacadas</h2>
      <ul class="list-group">
        <li class="list-group-item">Código "<%:producto.CodArtículo%>"</li>
        <li class="list-group-item">Nombre "<%:producto.Nombre%>"</li>
        <li class="list-group-item">Descripción "<%:producto.Descripción%>"</li>
        <li class="list-group-item">Marca</li>
        <li class="list-group-item">Categoría</li>
      </ul>
    </div>
    <div class="col-md-6">
      <img src="<%:obtenerUrl(producto.Id)%>"  class="img-fluid">
    </div>
  </div>
   
       
        <%  %>

</div>
</asp:Content>
 