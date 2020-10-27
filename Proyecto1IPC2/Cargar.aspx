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
        <asp:Label ID="Label2" runat="server" BackColor="Green" Text="Partida SQL" Width="300px" Height="20px"></asp:Label><br />
        <asp:DropDownList ID="partidas" runat="server" Width="300px" Height="40px" BackColor="SkyBlue" OnSelectedIndexChanged="partidas_SelectedIndexChanged"></asp:DropDownList><br />
        <asp:Button ID="aceptar" runat="server" Text="Cargar SQL" OnClick="aceptar_Click" BackColor="#c54848"/><br /><br />
        <asp:Label ID="Label3" runat="server" BackColor="Green" Text="Partida Carpeta" Width="300px" Height="20px"></asp:Label><br />
        <asp:FileUpload ID="FileUpload1" runat="server" /><br />
        <asp:Button ID="Button1" runat="server" Text="Cargar Carpeta" BackColor="#c54848" OnClick="Button1_Click"/><br />
        <asp:Button ID="regresar" runat="server" Text="Regresar" OnClick="regresar_Click" BackColor="#c54848"/>
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
                            <h1 id="modalletra"><asp:Label ID="Label1" runat="server" BackColor="#ffcc00" Text=""></asp:Label></h1><br>
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
