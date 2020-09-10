﻿<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MenuPrincipal.aspx.cs" Inherits="Proyecto1IPC2.MenuPrincipal" %>

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
             <asp:Button ID="cargar" runat="server" BackColor="#c54848" Text="Cargar Partida" OnClick="cargar_Click" /><br><br>
             <asp:Button ID="maquina" runat="server" BackColor="#92c15c" Text="Partida CPU" OnClick="maquina_Click" /><br><br>
             <asp:Button ID="versus" runat="server" BackColor="#92c15c" Text="Partida Versus" OnClick="versus_Click" /><br><br>
             <asp:Button ID="torneo" runat="server" BackColor="#92c15c" Text="Torneo!" /><br><br>
             <asp:Button ID="reporte" runat="server" BackColor="#c54848" Text="Reporte" />
         </form>
    </div>
</asp:Content>
