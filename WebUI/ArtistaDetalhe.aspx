<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Mestre.Master" CodeBehind="ArtistaDetalhe.aspx.cs" Inherits="WebUI.ArtistaDetalhe" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mb-5">
        <div class="col-sm-12">
             <h3>Detalhes do Artista</h3>
        </div>
    </div>
    <div style="display:inline-flex; ">
        <div>
            <div class="row">
                <div class="col-sm-6 " style="display:inline-flex">
                    <label style="font-weight:700">Codigo:&nbsp</label>
                    <asp:Label ID="txtCodigo" Text="" runat="server"></asp:Label>
                </div>
            </div>
                <div class="row">
                <div class="col-sm-6 " style="display:inline-flex">
                    <label style="font-weight:700">Nome:&nbsp</label>
                    <asp:Label ID="txtNome" Text="" runat="server"></asp:Label>
                </div>
            </div>
                <div class="row">
                <div class="col-sm-12 " style="display:inline-flex">
                    <label style="font-weight:700">Data de Nascimento:&nbsp</label>
                    <asp:Label ID="txtDtNasc" Text="" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12 " style="display:inline-flex">
                    <label style="font-weight:700">Pais de Nascimento:&nbsp</label>
                    <asp:Label ID="txtPaisNasc" Text="" runat="server"></asp:Label>
                </div>
            </div>
        </div>
        <div>
              <div class="row pl-5">
                <div class="col-sm-6 ml=5" style="vertical-align:middle">
                    <asp:Image ID="imgFoto" runat="server" CssClass="ml-5" Width="150" Height="160"/>
                  </div>
                  <div>
&nbsp;<asp:GridView ID="gvFilmesArtista" runat="server" AutoGenerateColumns="False">
                          <Columns>
                              <asp:BoundField DataField="Titulo" HeaderText="Filmes" />
                          </Columns>
                      </asp:GridView>
                  </div>
             </div>
        </div>
    </div>
           <div class="row mt-5">
                <div class="col-sm-12">
                    <a class="btn btn-danger" href="Artistas.aspx">Voltar</a>
                </div>
            </div>

</asp:Content>