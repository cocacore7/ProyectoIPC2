<%@ Page Title="Seleccionar Color" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SelecColor.aspx.cs" Inherits="Proyecto1IPC2.SelecColor" %>

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
            <asp:Label ID="Titulo" CssClass="titulo" runat="server" BackColor="#ffcc00" Text="Seleccionar Color"></asp:Label>
        </h1><br>
        <asp:DropDownList ID="Color" Width="300px" Height="40px" BackColor="SkyBlue" runat="server">
            <asp:ListItem>Seleccionar Color</asp:ListItem>
            <asp:ListItem>Negro</asp:ListItem>
            <asp:ListItem>Blanco</asp:ListItem>
        </asp:DropDownList><br />
        <asp:Button ID="Selec" runat="server" Text="Seleccionar" OnClick="aceptar_Click" BackColor="#c54848"/><br />
        <asp:Button ID="Random" runat="server" Text="Aleatorio" OnClick="regresar_Click" BackColor="#c54848"/>
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

