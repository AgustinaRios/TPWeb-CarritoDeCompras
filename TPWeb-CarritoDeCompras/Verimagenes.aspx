<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Verimagenes.aspx.cs" Inherits="TPWeb_CarritoDeCompras.Verimagenes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="carouselExample" class="carousel slide" data-ride="carousel">
        <div class="carousel-inner">
            <% for (int i = 0; i < listaImagenes.Count; i++) { %>
                <div class="carousel-item<%= i == 0 ? " active" : "" %>">
                    <img src="<%= listaImagenes[i].Imagen %>" class="d-block mx-auto" style="object-fit: contain;" />
                </div>
            <% } %>
        </div>
        <a class="carousel-control-prev" href="#" role="button" data-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="sr-only">Anterior</span>
        </a>
        <a class="carousel-control-next" href="#" role="button" data-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="sr-only">Siguiente</span>
        </a>
    </div>

    <style>
        .carousel-item img {
            display: block;
            margin: 0 auto;
        }

        .carousel-control-prev,
        .carousel-control-next,
        .carousel-control-prev:visited,
        .carousel-control-next:visited {
            color: red; /* Cambia el color de los enlaces aquí */
        }
    </style>

    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        $(document).ready(function () {
            $('.carousel-control-prev').click(function () {
                $('.carousel').carousel('prev');
            });

            $('.carousel-control-next').click(function () {
                $('.carousel').carousel('next');
            });
        });
    </script>
</asp:Content>





