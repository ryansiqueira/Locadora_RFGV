<%@ Page Title="" Language="C#" MasterPageFile="~/Mestre.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebUI.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table border="0" align="center">
        <tr>
            <td>
                <font face="Arial" size="5" color="black" align="center"><b>LANÇAMENTOS</b></font>
            </td>
        </tr>
    </table>

    <asp:Label ID="Label1" runat="server" Text="Pesquisa"></asp:Label>

    <br />
    
    <asp:TextBox ID="txtPesquisa" runat="server" Height="34px" Width="1190px" OnTextChanged="txtPesquisa_TextChanged"></asp:TextBox>
    <br />
    <br />
        <asp:GridView ID="grvFilmes"
            DataKeyNames="Titulo"
            GridLines="Vertical"
            AutoGenerateColumns="False"
            runat="Server" OnRowCommand="grvFilmes_RowCommand" Width="1199px" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                               <asp:TemplateField AccessibleHeaderText="Titulo" HeaderText="Titulo do Filme">
    <ItemTemplate>
        <asp:Label ID="Text1" runat="server" Text='<%# Eval("Titulo") %>' />
    </ItemTemplate>
</asp:TemplateField>
               <asp:TemplateField HeaderText="Capa">
    <ItemTemplate>
        <asp:LinkButton ID="link1" runat="server" OnClick="link1_Click" CommandName="CarregaFilme"  CommandArgument='<%# Eval("Titulo") %>'>
        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Caminho") %>'  Height="100px" Width="156px"   />
    </asp:LinkButton>

    </ItemTemplate>
</asp:TemplateField>
            </Columns>

            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="Gray" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />

        </asp:GridView>    
</asp:Content>
