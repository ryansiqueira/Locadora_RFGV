<%@ Page Title="" Language="C#" MasterPageFile="~/Mestre.Master" AutoEventWireup="true" CodeBehind="Mensagens.aspx.cs" Inherits="WebUI.Mensagens" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>:: Mensagens</h2>
    <p>&nbsp;&nbsp;<asp:GridView ID="gvMensagens" runat="server" AutoGenerateColumns="False" BorderStyle="Outset">
        <Columns>
            <asp:BoundField DataField="DataMensagem" HeaderText="Data da Mensagem" />
            <asp:BoundField DataField="Email" HeaderText="Email" />
            <asp:BoundField DataField="Nome" HeaderText="Nome" />
            <asp:BoundField DataField="Assunto" HeaderText="Assunto" />
            <asp:BoundField DataField="Mensagem" HeaderText="Mensagem" />
        </Columns>
        </asp:GridView>
    </p>
</asp:Content>
