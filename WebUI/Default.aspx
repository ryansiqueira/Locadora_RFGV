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
    <div>
        <asp:GridView ID="grvFilmes"
            DataKeyNames="Titulo"
            GridLines="Horizontal"
            runat="Server" OnRowCommand="grvFilmes_RowCommand" Width="1199px">
            <Columns>
                <asp:TemplateField HeaderText="Capa Filme">
                    <ItemTemplate>
                        <asp:ImageButton ID="CapaPantera" runat="server" Height="168px" ImageUrl='<%# Eval("Caminho") %>' Width="123px" CommandName="CarregaFilme" CommandArgument='<%# Eval("Titulo") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>            
        </asp:GridView>        
    </div>
</asp:Content>
