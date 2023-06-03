<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaProducto.aspx.cs" Inherits="TPWeb_CarritoDeCompras.ListaProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="updatePanel" runat="server">
        <ContentTemplate>
            <div class="row">
                <div class="col-3">

                    <asp:Label Text="Buscar por Nombre" runat="server" />
                    <asp:TextBox runat="server" ID="txtFiltro" CssClass="form-control" AutoPostBack="true" OnTextChanged="filtro_textChanged" />
                </div>
            </div>
            <div class="col-6" style="display: flex; flex-direction: column; justify-content: flex-end">
                <div class="mb-3">
                    <asp:CheckBox Text="Filtro Avanzado" CssClass="" ID="chkAvanzado" runat="server" AutoPostBack="true" OnCheckedChanged="chkAvanzado_ChekedChanged" />

                </div>
            </div>
            <%if (filtroAvanzado)
                {%>

            <div class="row">
                <div class="col-3">
                    <div class="mb-3">
                        <asp:Label Text="Buscar por" runat="server" />
                        <asp:DropDownList runat="server" CssClass="form-control1" ID="ddlCampo" AutoPostBack="true">
                            <asp:ListItem Text="Nombre" />
                            <asp:ListItem Text="Marca" />
                            <asp:ListItem Text="Codigo" />
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="col-3">
                    <div class="mb-3">
                        <asp:Label Text="Criterio" runat="server" />
                        <asp:DropDownList runat="server" CssClass="form-control1" ID="ddlCriterio" AutoPostBack="true">
                            <asp:ListItem Text="Contiene" />
                            <asp:ListItem Text="Comienza con" />
                            <asp:ListItem Text="Termina con" />
                        </asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-3">
                    <div class="mb-3">
                        <asp:Label Text="Filtro" runat="server" />
                        <asp:TextBox runat="server" CssClass="form-control1" ID="txtFiltroAvanzado" />
                    </div>
                </div>
                <div class="col-3">
                    <div class="mb-3">
                        <asp:Button Text="Buscar" runat="server" CssClass="btn btn-primary" ID="btnBuscar" OnClick="BtnBuscar_clik" />
                    </div>
                </div>
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
            </div>
            <%}

            %>

    <%else
        {
    %>
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
    <%} %>
            
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
