
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
        #Select1 {
            height: 24px;
            width: 162px;
        }
        #Checkbox1 {
            height: 24px;
            width: 153px;
        }
        #Select2 {
            height: 24px;
            width: 162px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>
        :: Informações do Filme</h2>
   
        <table class="m6">
            <tr>
                <td class="auto-style5">&nbsp;</td>
        <asp:LinkButton ID="link2" runat="server" >
        <asp:Image ID="PicFoto" runat="server" ImageUrl='<%# Eval("Caminho") %>'  Height="100px" Width="156px"   />
    </asp:LinkButton>
                <td>Título:</td>
                <td class="auto-style2">
                    <asp:Label ID="lblTitulo" runat="server"></asp:Label>               
                </td>
            </tr>
        </table>
    <p>
        <table>
            <tr>
                <td>Código:</td>
                <td>
                    <asp:Label ID="lblCodigo" runat="server" Width="157px"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Código de Barras:</td>
                <td>
                    <asp:Label ID="lblCodigoBarras" runat="server"></asp:Label>
                </td>
            </tr>            
            <tr>
                <td>Gêneros:</td>
                <td class="auto-style1">
                    <asp:Label ID="lblGenero" runat="server" Height="26px" Width="160px">
                    </asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Ano:</td>
                <td class="auto-style4">
                    <asp:Label ID="lblAno" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Tipo:</td>
                <td class="auto-style1">
                    <asp:Label ID="lblTipo" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Preço:</td>
                <td class="auto-style1">
                    <asp:Label ID="lblPreco" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Data Adquirida:</td>
                <td class="auto-style1">
                    <asp:Label ID="lblDataAdquirida" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Valor de Custo:</td>
                <td class="auto-style1">
                    <asp:Label ID="lblValorCusto" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Situação:</td>
                <td class="auto-style6">
                    <asp:Label ID="lblSituacao" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Atores Participantes:</td>
                <td class="auto-style6">
                    <asp:Label ID="lblAtores" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Diretor:</td>
                <td class="auto-style6">
                    <asp:Label ID="lblDiretor" runat="server"></asp:Label>
                </td>
            </tr>
            </table>
        
    <p>
        &nbsp;</p>
   
</asp:Content>