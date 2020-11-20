
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
                <td class="auto-style6">
                    <asp:Image ID="PicFoto" runat="server" Height="99px" Width="156px" />
                </td>
                <td>Título:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>               
                </td>
            </tr>
        </table>
    <p>
        <table>
            <tr>
                <td>Código:</td>
                <td>
                    <asp:TextBox ID="txtCodigo" runat="server" Width="157px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Código de Barras:</td>
                <td>
                    <asp:TextBox ID="txtCodigoBarras" runat="server"></asp:TextBox>
                </td>
            </tr>            
            <tr>
                <td>Gêneros:</td>
                <td class="auto-style1">
                    <asp:DropDownList ID="txtGenero" runat="server" Height="26px" Width="160px">
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
                    <asp:RadioButtonList ID="RadionTipo" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True" Value="D">DVD</asp:ListItem>
                    <asp:ListItem Value="B">BLURAY</asp:ListItem>
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
                    <asp:CheckBox ID="txtSituacao" runat="server" Text="Locado" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Atores Participantes:</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="txtAtores" runat="server" Height="26px" Width="160px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Diretor:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtDiretor" runat="server"></asp:TextBox>
                </td>
            </tr>
            </table>
        
    <p>
        &nbsp;</p>
   
</asp:Content>