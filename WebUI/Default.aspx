<%@ Page Title="" Language="C#" MasterPageFile="~/Mestre.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebUI.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table border="0" align="center">
        <tr>
            <td>
                <font face="Arial" size="5" color="black"><b>LANÇAMENTOS</b></font>
            </td>
        </tr>
    </table>
    <br />
        <asp:GridView ID="grvFilmes"
            DataKeyNames="Titulo"
            GridLines="Horizontal"
            AutoGenerateColumns="false"
            runat="Server" OnRowCommand="grvFilmes_RowCommand" Width="1199px">
            <Columns>
                               <asp:TemplateField>
    <ItemTemplate>
        <asp:Label ID="Text1" runat="server" Text='<%# Eval("Titulo") %>' />
    </ItemTemplate>
</asp:TemplateField>
               <asp:TemplateField>
    <ItemTemplate>
        <asp:LinkButton ID="link1" runat="server" OnClick="link1_Click" CommandName="CarregaFilme"  CommandArgument='<%# Eval("Titulo") %>'>
        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Caminho") %>'  Height="100px" Width="156px"   />
    </asp:LinkButton>

    </ItemTemplate>
</asp:TemplateField>
            </Columns>

        </asp:GridView>    
</asp:Content>
