<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="TPWeb_CarritoDeCompras.Carrito" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <table class="table table-striped">
  
    <thead>
     <tr>
      <th scope="col">Nombre</th>
      <th scope="col">Precio</th>
      <th scope="col">Cantidad</th>
    </tr>
       </thead>
   

     <tbody>
        
        <asp:Repeater runat="server" ID="repetidorCarrito">
            <ItemTemplate>
                     <tr>
                     <th><p><%#Eval("Nombre")%></p></th>
                     <th> <p><%#Eval("Precio")%></p></th>
                     <th>
                  <asp:TextBox TextMode="Number" runat="server" OnTextChanged="txtCantidad_TextChanged" text='<%#Eval("Cantidad")%>' ID="txtCantidad" min="1"/>
                        <asp:Button Text="Agregar" CssClass="btn btn-primary" AutoPostBack="true" ID="btnAgregar" OnClick="btnAgregar_Click"  CommandArgument='<%#Eval("Id")%>' runat="server" />
                    
                    <asp:Button Text="Eliminar" CssClass="btn btn-danger" AutoPostBack="true" ID="btnEliminar" OnClick="btnEliminar_Click" CommandArgument='<%#Eval("Id")%>' runat="server" />
                 </th>
                </tr>
            </ItemTemplate> 
        </asp:Repeater>
          
    </tbody>
    </table>
<p>Total: <asp:Label ID="lblTotal" runat="server" OnLoad="lblTotal_Load" /></p>
         
   
 
                   


</asp:Content>
