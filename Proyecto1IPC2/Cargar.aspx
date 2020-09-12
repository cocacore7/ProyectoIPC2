<%@ Page Title="Cargar Partida" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Cargar.aspx.cs" Inherits="Proyecto1IPC2.Cargar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        input {
            font-weight:bolder;
            height: 40px;
			width: 300px;
            border-radius:5%;
            background:SkyBlue;
        }
        body {
            background:url(Fondo4.jpg);
            background-size: auto;
        }
        #titulo{
            width:600px;
            height:200px;
        }
    </style>
    <div align="center">
        <h1 id="modalletra">
            <asp:Label ID="Titulo" CssClass="titulo" runat="server" BackColor="#ffcc00" Text="Cargar Partida"></asp:Label>
        </h1><br>
        <asp:DropDownList ID="partidas" runat="server" OnSelectedIndexChanged="partidas_SelectedIndexChanged"></asp:DropDownList><br />
        <asp:Button ID="aceptar" runat="server" Text="Cargar" OnClick="aceptar_Click" /><br />
        <asp:Button ID="regresar" runat="server" Text="Regresar" OnClick="regresar_Click" />
    </div>
</asp:Content>
