<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="CadastrarCliente.aspx.cs"
    Inherits="Banco.Web.CadastrarCliente"
    MasterPageFile="~/Site.Master" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
        <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h2>Cadastrar Cliente</h2>
            </hgroup>
        </div>
    </section>

</asp:Content>



<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <asp:Label ID="lblNome" runat="server" Text="Nome:" AssociatedControlID="txtNome"></asp:Label>
    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>

    <asp:Label ID="lblSobrenome" runat="server" Text="Sobrenome:" AssociatedControlID="txtSobrenome"></asp:Label>
    <asp:TextBox ID="txtSobrenome" runat="server"></asp:TextBox>
    
    <asp:Label ID="lblIdade" runat="server" Text="Idade:" AssociatedControlID="txtIdade"></asp:Label>
    <asp:TextBox ID="txtIdade" runat="server"></asp:TextBox>
    
    <asp:Label ID="lblCpf" runat="server" Text="CPF" AssociatedControlID="txtCpf"></asp:Label>
    <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox>

    <asp:Label ID="lblRg" runat="server" Text="RG" AssociatedControlID="txtRg"></asp:Label>
    <asp:TextBox ID="txtRg" runat="server"></asp:TextBox>

    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click"/>
</asp:Content>





