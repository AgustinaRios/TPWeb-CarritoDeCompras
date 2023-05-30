<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="TPWeb_CarritoDeCompras.Carrito" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table class="table">
        <thead>
            <tr>
                <th scope="col">
                    <h4 class="titulo">Nombre</h4>
                </th>
                <th scope="col">
                    <h4 class="titulo">Cantidad</h4>
               </tr>
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
                        <p><%#Eval("Cantidad")%></p>
                    </td>
                    <td>
                        <p><%#Eval("Precio")%></p>
                    </td>


                </tbody>
            </ItemTemplate>
        </asp:Repeater>

    </table>


</asp:Content>
