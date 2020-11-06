<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MenuPrincipal.aspx.cs" Inherits="Proyecto1IPC2.MenuPrincipal" %>

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
            font-weight:bolder;;
        }
        label{
            font-weight:bolder;
            height:auto;
            width:auto;
            background:#c54848
        }
    </style>
     <div class="jumbotron" align="center">
        <h1>Bienvenido a Othello</h1>
    </div>
     <div class="row" align="center">
         <form>
             <asp:Button ID="Perfil" runat="server" Text="Perfil" BackColor="SkyBlue" OnClick="Perfil_Click" /><br><br>
             <asp:Button ID="cargar" runat="server" BackColor="#c54848" Text="Cargar Partida Normal" OnClick="cargar_Click" /><br><br>
             <asp:Button ID="maquina" runat="server" BackColor="#92c15c" Text="Partida Normal" OnClick="maquina_Click" /><br><br>
             <asp:Button ID="carga2" runat="server" BackColor="#c54848" Text="Cargar Partida Xtreme" OnClick="carga2_Click" /><br><br>
             <asp:Button ID="versus" runat="server" BackColor="#92c15c" Text="Partida Xtreme" OnClick="versus_Click" /><br><br>
             <asp:Button ID="torneo" runat="server" BackColor="#ffcc00" Text="Torneo!" OnClick="torneo_Click" /><br><br>
         </form>
    </div>
</asp:Content>
