<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Banco.Web._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h2>Bem vindo ao nosso banco</h2>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <ol class="round">
        <li class="one">
            <h5>Cliente</h5>
            <a href="CadastrarCliente.aspx">Cadastrar</a><br />
            <a href="ConsultarCliente.aspx">Consultar</a>
        </li>
        <li class="two">
            <h5>Operações</h5>
            <a href="RealizarSaque.aspx">Realizar Saque</a>
        </li>
    </ol>
</asp:Content>
