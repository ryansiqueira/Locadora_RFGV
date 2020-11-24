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
        </asp:GridView>    
        <%--<asp:SqlDataSource ID="BancoLocadora" runat="server" 
       ConnectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Locadora;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False" 
        ProviderName="System.Data.SqlClient"  
        SelectCommand="SELECT Titulo From Itens">
     </asp:SqlDataSource>--%>
    </div>
</asp:Content>
