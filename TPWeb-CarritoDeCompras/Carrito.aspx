<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="TPWeb_CarritoDeCompras.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table class="table table-hover table-dark">
        <thead>
            <tr>

                <th scope="col">Nombre</th>
                <th scope="col">Descripcion</th>
                <th scope="col">Precio</th>
            </tr>
        </thead>
        <%   foreach (Dominio.Producto producto in Listacarrito)
            {%>

        <tbody>
            <tr>

                <td><%:producto.Nombre%></td>
                <td><%:producto.Descripción %></td>
                <td><%:producto.Precio %></td>
            </tr>

            <%} %>
          
            <tr>
                 <th scope="col"> </th>
                <th scope="col">TOTAL</th>
                <th scope="col"><%:TotalCarrito()%> </th>
                
                
            </tr>
       
    </table>









    <%-- <asp:GridView ID="dgvProductos" Cssclass="table" runat="server"></asp:GridView>--%>
</asp:Content>


<%--<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table class="table">
        <thead>
            <tr>
                <th scope="col">
                    <h4 class="titulo">Nombre</h4>
                </th>
                <th scope="col">
                    <h4 class="titulo">Precio</h4>

            </tr>
        </thead>

         
        <asp:Repeater runat="server" ID="repetidorCarrito">
            <ItemTemplate>
                <tbody>
                    <td>
                        <p><%#Eval("Nombre")%></p>
                    </td>
                    <td>
                        <p><%#Eval("Precio")%></p>
                    </td>


                </tbody>
            </ItemTemplate>
        </asp:Repeater>

    </table>


</asp:Content>--%>
