<%@ Page Title="" Language="C#" MasterPageFile="~/Mestre.Master" AutoEventWireup="true" CodeBehind="PageContato.aspx.cs" Inherits="WebUI.PageContato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>:: Contato</h2>
    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label1" runat="server" Text="Email:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    &nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" BorderStyle="Outset" ControlToValidate="txtEmail" ErrorMessage="RequiredFieldValidator" InitialValue=" ">O Campo Email é Obrigatório!!</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" BorderStyle="Outset" ControlToValidate="txtEmail" ErrorMessage="Email Inválido!!" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    </p>
    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="NomeCompleto:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    </p>
    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Assunto:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAssunto" runat="server"></asp:TextBox>
    </p>
    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Mensagem:"></asp:Label>
&nbsp;&nbsp;&nbsp; </p>
    <p>&nbsp;&nbsp;
        <asp:TextBox ID="txtMensagem" runat="server" Height="60px" TextMode="MultiLine" Width="288px"></asp:TextBox>
    </p>
    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEnviar" runat="server" OnClick="btnEnviar_Click" Text="Enviar" Width="95px" />
    </p>
    <p>
        <asp:Label ID="lblMensagemTela" runat="server"></asp:Label>
    </p>
</asp:Content>
