<%@ Page Title="InicioSesion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="Proyecto1IPC2.InicioSesion" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        body {
            background:url(Fondo4.jpg);
            background-size: auto;
        }
        input {
            font-weight:bolder;
            height: 40px;
			width: 300px;
            border-radius:5%;
            background:SkyBlue;
        }
        .jumbotron{
            background:url(Fondo3.jfif);
            background-size:auto;
        }
        h1 {
            height:auto;
            width:auto;
            background:gray;
            text-decoration-color:black;
        }
        input[type=button]{
            font-weight:bolder;
            background: #92c15c;
        }
        label{
            font-weight:bolder;
            height:auto;
            width:auto;
            background:#c54848
        }
        h2{
            height:auto;
            width:300px;
            background:#cbc53d
        }
    </style>
    <div class="jumbotron" align="center">
        <h1>Bienvenido a Othello</h1>
    </div>

    <div class="row" align="center">
        <h2>Iniciar Sesion</h2>
        <form>
            <asp:TextBox ID="nickname" runat="server" placeholder="Nombre De Usuario"></asp:TextBox><br><br>
            <asp:TextBox ID="password" runat="server" placeholder="Contraseña" TextMode="Password"></asp:TextBox><br><br>
            <asp:Button ID="login" runat="server" Text="Iniciar Sesion" OnClick="login_Click" BackColor="#c54848" /><br><br>
        </form>
    </div>

    <style>
        #ventana{
            background:url(Fondo1.jfif);
            background-size:auto;
            width:600px;
            height:280px;
        }
        #modalletra{
            background:none;
        }
    </style>
    <div class="ventana modal" id="ventana" role="dialog" aria-labelledby="equiquetaModal" aria-hidden="true" align="center">
        <div class="dialogo">
            <asp:UpdatePanel ID="panelModal" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="contenido">
                        <div class="cuerpo" align="center">
                            <h1 id="modalletra"><asp:Label ID="Titulo" runat="server" BackColor="#ffcc00" Text=""></asp:Label></h1><br>
                            <h1 id="modalletra"><asp:Label ID="Cuerpo" runat="server" BackColor="#ffcc00" Text=""></asp:Label></h1>
                       </div>
                        <div class="modal-footer" align="center">
                           <button class="info" data-dismiss="modal" aria-hidden="true">Aceptar</button>
                       </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
