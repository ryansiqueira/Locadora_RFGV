<%@ Page Title="" Language="C#" MasterPageFile="~/Mestre.Master" AutoEventWireup="true" CodeBehind="CadastroFIlmes.aspx.cs" Inherits="WebUI.CadastroFIlmes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style2 {
            margin-left: 120px;
        }
        .auto-style1 {
            margin-left: 40px;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
            margin-left: 40px;
        }
        .auto-style5 {
            height: 34px;
        }
        .auto-style6 {
            margin-left: 40px;
            height: 34px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>
        :: Cadastro de Filmes</h2>
    <p>
        <table>
            <tr>
                <td>Código:</td>
                <td>
                    <asp:TextBox ID="txtCodigo" runat="server" Width="62px"></asp:TextBox>
                    <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
                </td>
            </tr>
            <tr>
                <td>Código de Barras:</td>
                <td>
                    <asp:TextBox ID="txtCodigoBarras" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Título:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Gêneros:</td>
                <td class="auto-style1">
                    <asp:DropDownList ID="dropGeneros" runat="server">
                        <asp:ListItem>Teste</asp:ListItem>
                        <asp:ListItem>Teste1</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Ano:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtAno" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Tipo:</td>
                <td class="auto-style1">
                    <asp:RadioButtonList ID="radionTipo" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Selected="True" Value="D">DVD</asp:ListItem>
                        <asp:ListItem Value="B">BLU RAY</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>Preço:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtPreco" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Data Adquirida:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtDataAdquirida" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Valor de Custo:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtValorCusto" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Situação:</td>
                <td class="auto-style6">
                    <asp:CheckBox ID="checkboxSituacao" runat="server" Text="Locado" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Atores Participantes:</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="dropAtores" runat="server">
                        <asp:ListItem>Teste</asp:ListItem>
                        <asp:ListItem>Teste1</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Diretor:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtDiretor" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Foto da Capa do Filme:</td>
                <td class="auto-style6">
                    <asp:Image ID="Image1" runat="server" Height="99px" Width="156px" />
                </td>
            </tr>
        </table>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
