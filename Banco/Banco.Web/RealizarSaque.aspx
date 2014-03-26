<%@ Page Language="C#" 
    AutoEventWireup="true" 
    CodeBehind="RealizarSaque.aspx.cs" 
    Inherits="Banco.Web.RealizarSaque" 
    MasterPageFile="~/Site.Master"

    %>


<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
        <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h2>Realizar Saque</h2><br />
                <asp:Label ID="lblMensagem" runat="server"></asp:Label>
            </hgroup>
        </div>
    </section>

</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <asp:Label ID="lblCodigoCliente" runat="server" Text="Codigo do Cliente" AssociatedControlID="txtCodigoCliente"></asp:Label>
    <asp:TextBox ID="txtCodigoCliente" runat="server"></asp:TextBox>
    
    <asp:Label ID="lblValor" runat="server" Text="Valor" AssociatedControlID="txtValor"></asp:Label>
    <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>

    <asp:Button ID="Button1" runat="server" Text="Realizar saque" OnClick="Button1_Click"/>
</asp:Content>
