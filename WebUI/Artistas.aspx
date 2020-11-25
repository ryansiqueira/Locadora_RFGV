<%@ Page Title="Artistas" Language="C#" MasterPageFile="~/Mestre.Master" AutoEventWireup="true"  CodeBehind="Artistas.aspx.cs" Inherits="WebUI.Artistas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
    <div class="row">
        <div class="col-sm-12 text-center">
            <h3>Lista de Artistas</h3>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-3">
            <label class="label">Nome Artista</label>
            <label class="input">
                <asp:TextBox ID="txtNome" CssClass="form-control" runat="server"></asp:TextBox>
            </label>
        </div>
        <div class="col-sm-3">
            <label class="label">Pais Nascimento</label>
            <label class="input">
                <asp:TextBox ID="txtPaisNasc" CssClass="form-control" runat="server"></asp:TextBox>
            </label>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-12">
            <asp:Button ID="btnFiltrar" CssClass="btn btn-primary" Text="Filtrar" runat="server" OnClick="btnFiltrar_Click"/>
        </div>
    </div>
       <asp:GridView ID="grvArtistas" OnRowCommand="grvArtistas_RowCommand"
            runat="Server" AutoGenerateColumns="false" CssClass="table table-bordered table-hover mt-5 w-100" > 
            <Columns>
                <asp:BoundField DataField="Nome" HeaderText="Nome" />
                <asp:TemplateField HeaderText="Foto" ItemStyle-Width="10">
                    <ItemTemplate>
                        <asp:Image ID="foto" runat="server" Height="60px" Width="50px" ImageUrl='<%# Eval("FotodoArtista64") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField  ItemStyle-CssClass="text-right" ItemStyle-Width="10">
                    <ItemTemplate >
                        <asp:Button Text="Ver Detalhes"  ButtonType="Button" ControlStyle-CssClass="btn btn-info" CommandArgument='<%# Eval("CdArtista") %>' runat="server"/>
                    </ItemTemplate>
                </asp:TemplateField>
                
            </Columns>            
        </asp:GridView>    
</asp:Content>