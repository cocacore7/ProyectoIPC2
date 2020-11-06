<%@ Page Title="Perfil" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Perfil.aspx.cs" Inherits="Proyecto1IPC2.Perfil" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
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
        <asp:Label ID="titulo" runat="server" Text="Perfil: " BackColor="Yellow" Font-Size="Larger" Width="300px" Height="40px"></asp:Label><br /><br />
        <asp:Label ID="pg" runat="server" Text="Partidas Normales Ganadas" BackColor="Red" Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="pag" runat="server" Enabled="false" BackColor="SkyBlue"></asp:TextBox><br /><br />
        <asp:Label ID="pp" runat="server" Text="Partidas Normales Perdidas" BackColor="Red" Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="pap" runat="server" Enabled="false" BackColor="SkyBlue"></asp:TextBox><br /><br />
        <asp:Label ID="pe" runat="server" Text="Partidas Normales Empatadas" BackColor="Red" Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="pae" runat="server" Enabled="false" BackColor="SkyBlue"></asp:TextBox><br /><br />
        <asp:Label ID="pxg" runat="server" Text="Partidas Xtreme Ganadas" BackColor="Red" Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="paxg" runat="server" Enabled="false" BackColor="SkyBlue"></asp:TextBox><br /><br />
        <asp:Label ID="pxp" runat="server" Text="Partidas Xtreme Perdidas" BackColor="Red" Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="paxp" runat="server" Enabled="false" BackColor="SkyBlue"></asp:TextBox><br /><br />
        <asp:Label ID="pxe" runat="server" Text="Partidas Xtreme Empatadas" BackColor="Red" Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="paxe" runat="server" Enabled="false" BackColor="SkyBlue"></asp:TextBox><br /><br />
        <asp:Button ID="regresar" runat="server" Text="Regresar" BackColor="#c54848" OnClick="regresar_Click"/>
    </div>
</asp:Content>