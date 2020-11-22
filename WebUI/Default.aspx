<%@ Page Title="" Language="C#" MasterPageFile="~/Mestre.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebUI.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table border ="0" align ="center">
        <tr>
            <td>
                <font face ="Arial" size ="5" color ="black" ><b>LANÇAMENTOS</b></font>
            </td>
        </tr>
    </table>
    <br />
    <asp:ImageButton ID="ImageButton1" CommandArgument='<%#Eval("product.ProductId")%>' NavigateUrl="~/CadastroFIlmes.aspx" runat="server" Height="185px" Width="144px" ImageUrl="~/CapasFilmes/Pantera Negra.jpg" OnClick="ImageButton1_Click"/>
    
</asp:Content>
