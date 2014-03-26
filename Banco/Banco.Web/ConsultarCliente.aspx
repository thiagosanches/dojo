<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="ConsultarCliente.aspx.cs"
    Inherits="Banco.Web.ConsultarCliente"
    MasterPageFile="~/Site.Master" %>


<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h2>Consultar Cliente</h2>
            </hgroup>
        </div>
    </section>

</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <asp:GridView ID="grdCliente" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Nome" HeaderText="Nome" />
            <asp:BoundField DataField="Sobrenome" HeaderText="Sobrenome" />
            <asp:BoundField DataField="Cpf" HeaderText="Cpf" />
            <asp:BoundField DataField="SaldoConta" HeaderText="Saldo" DataFormatString="{0:c}"/>
            <asp:BoundField DataField="ValidadeCartao" HeaderText="Validade Cartao" DataFormatString="{0:d}"/>

        </Columns>
    </asp:GridView>
</asp:Content>

