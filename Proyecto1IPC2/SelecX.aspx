<%@ Page Title="Othello Xtreme" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SelecX.aspx.cs" Inherits="Proyecto1IPC2.SelecX" %>

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
        #ventana{
            background:url(Fondo1.jfif);
            background-size:auto;
            width:600px;
            height:280px;
        }
        #modalletra{
            background:none;
        }
        .Colores1 {
            float: left;
            width: 100px;
            height: 500px;
        }
        .Colores2 {
            float: left;
            width: 100px;
            height: 500px;
        }
        .selec {
            float: left;
            width: 300px;
            height: 500px;
        }
        .principal {
            width: 1200px;
            height: 600px;
        }
    </style>
    <div class="principal">
        <center><h1 id="modalletra">
            <asp:Label ID="Titulo" CssClass="titulo" runat="server" BackColor="#ffcc00" Text="Seleccionar"></asp:Label>
        </h1></center><br>
        <h2></h2>
        <div class="Colores1">
            <asp:Label ID="Label1" runat="server" Text="Jugador 1" Font-Size="Large" BackColor="Red"></asp:Label><br />
            <asp:CheckBoxList ID="Colores1" runat="server" BackColor="SkyBlue">
                <asp:ListItem>Rojo</asp:ListItem>
                <asp:ListItem>Amarrillo</asp:ListItem>
                <asp:ListItem>Azul</asp:ListItem>
                <asp:ListItem>Naranja</asp:ListItem>
                <asp:ListItem>Verde</asp:ListItem>
                <asp:ListItem>Violeta</asp:ListItem>
                <asp:ListItem>Blanco</asp:ListItem>
                <asp:ListItem>Negro</asp:ListItem>
                <asp:ListItem>Celeste</asp:ListItem>
                <asp:ListItem>Gris</asp:ListItem>
            </asp:CheckBoxList><br />
        </div>
        <div class="Colores2">
            <asp:Label ID="Label2" runat="server" Text="Jugador 2" Font-Size="Large" BackColor="Red"></asp:Label><br />
            <asp:CheckBoxList ID="Colores2" runat="server" BackColor="SkyBlue">
                <asp:ListItem>Rojo</asp:ListItem>
                <asp:ListItem>Amarrillo</asp:ListItem>
                <asp:ListItem>Azul</asp:ListItem>
                <asp:ListItem>Naranja</asp:ListItem>
                <asp:ListItem>Verde</asp:ListItem>
                <asp:ListItem>Violeta</asp:ListItem>
                <asp:ListItem>Blanco</asp:ListItem>
                <asp:ListItem>Negro</asp:ListItem>
                <asp:ListItem>Celeste</asp:ListItem>
                <asp:ListItem>Gris</asp:ListItem>
            </asp:CheckBoxList><br />
        </div>
        <div class="selec">
            <div>
                <asp:Label ID="Label3" runat="server" Text="Filas" Font-Size="Large" BackColor="Red"></asp:Label><br />
                <asp:TextBox ID="TextBox1" runat="server" Width="60px" Height="60px"></asp:TextBox><br />
                <asp:Label ID="Columnas" runat="server" Text="Columnas" Font-Size="Large" BackColor="Red"></asp:Label><br />
                <asp:TextBox ID="TextBox2" runat="server" Width="60px" Height="60px"></asp:TextBox>
            </div>
            <div>
                <asp:DropDownList ID="modo" runat="server" Width="300px" Height="40px" BackColor="SkyBlue">
                    <asp:ListItem>Seleccionar Modo De Juego</asp:ListItem>
                    <asp:ListItem>Versus</asp:ListItem>
                    <asp:ListItem>CPU</asp:ListItem>
                </asp:DropDownList><br />
                <asp:DropDownList ID="tipo" runat="server" Width="300px" Height="40px" BackColor="SkyBlue">
                    <asp:ListItem>Seleccionar Tipo De Juego</asp:ListItem>
                    <asp:ListItem>Normal</asp:ListItem>
                    <asp:ListItem>Inverso</asp:ListItem>
                </asp:DropDownList><br />
                <asp:DropDownList ID="Personalizar" runat="server" Width="300px" Height="40px" BackColor="SkyBlue">
                    <asp:ListItem>Personalizar Entrada</asp:ListItem>
                    <asp:ListItem>Si</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:DropDownList><br />
                <asp:Button ID="aceptar" runat="server" Text="Aceptar" BackColor="#c54848" OnClick="aceptar_Click"/><br />
                <asp:Button ID="regresar" runat="server" Text="Regresar" BackColor="#c54848" OnClick="regresar_Click"/>
            </div>
        </div>
    </div>

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