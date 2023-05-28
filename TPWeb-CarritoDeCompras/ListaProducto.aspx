<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaProducto.aspx.cs" Inherits="TPWeb_CarritoDeCompras.ListaProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="row row-cols-1 row-cols-md-3 g-4">
        <asp:Repeater  runat="server" ID="RepetidorArticulos">
        
      <ItemTemplate>   
      
        <div class="col">
            <div class="card">

                 <img src="<%obtenerUrl(%><%#Eval("Id")%><%)%>" class="card-img-top" alt="Imagen del producto">
                 <div class="card-body"
                    <h5 class="card-title"><%#Eval("Nombre")%></h5> 
                    <p class="card-text">Precio: $<%#Eval("Precio")%></p>
                    <a href="DetalleProducto.aspx?id=<%#Eval("Id") %>"class="btn btn-success">Ver Detalle</a>
                    <a href="Verimagenes.aspx?id=<%#Eval("Id") %>"class="btn btn-success"> Mas imagenes</a>
                </div>
            </div>
        </div>

        
        </ItemTemplate> 
        </asp:Repeater>
    </div>
</asp:Content>
