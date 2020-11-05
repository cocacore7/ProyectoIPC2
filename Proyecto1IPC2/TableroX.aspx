<%@ Page Title="tablero Xtreme" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="TableroX.aspx.cs" Inherits="Proyecto1IPC2.TableroX" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        body {
            background:url(Fondo4.jpg);
            background-size: auto;
        }
        .ariz{
            border-top-left-radius:100%;
        }
        .arde{
            border-top-right-radius:100%;
        }
        .abiz{
            border-bottom-left-radius:100%;
        }
        .abde{
            border-bottom-right-radius:100%;
        }
        .Tablero {
            float:left;
            height:auto;
            width:auto
        }
        .Panel {
            float:right;
            height: auto;
            width: auto;
        }
        .Negro {
            float:left;
            height: auto;
            width: auto;
        }

        .Blanco {
            float:right;
            height: auto;
            width: auto;
        }
        #ventana{
            background:url(Fondo1.jfif);
            background-size:auto;
            width:auto;
            height:auto;
        }
        #modalletra{
            background:none;
        }
        .Jugadores {
            height: auto;
        }
        .Salir {
            height: auto;
        }
        .columnaO {
            background-color:#dcbe17;
            border-collapse:collapse;
            border-style:solid;
            font-size:large;
            text-align:center;
        }
        .columnaC {
            background-color: #5caf90;
            border-collapse:collapse;
            border-style:solid;
            font-size:large;
            text-align:center
        }
        .SegN {
            float:right;
            margin-left: 60px;
        }
        .MinN {
            float:right;
            margin-left: 60px;
        }
        .SegB {
            float:right;
            margin-left: 60px;
        }
        .MinB {
            float:right;
            margin-left: 60px;
        }
    </style>
    <div class="Tablero">
        <asp:Table ID="Table1" runat="server"></asp:Table>
    </div>
        
    <div class="Panel">
        <div class="Jugadores">
            <div class="Negro" align="center">
                <br /><br />
                <asp:Label ID="Jug1" runat="server" Text="Label" Width="200px" Height="40px" BackColor="SkyBlue" Font-Size="Large"></asp:Label>
                <br /><br />
                <asp:Label ID="Pun1" runat="server" Text="Label"  Width="200px" Height="40px" BackColor="#ffcc00" Font-Size="Large"></asp:Label>
                <br /><br />
                <asp:ImageButton ID="Turno1" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false"/>   
                <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick" >
                </asp:Timer>
                <br /><br />
                <asp:UpdatePanel ID="UpdatePanel1" UpdateMode="Conditional" runat="server">
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick"/>
                    </Triggers>
                    <ContentTemplate>
                        <asp:Label ID="Seg1" runat="server" Text="0 seg" BackColor="SkyBlue" Width="80px" Height="40px"></asp:Label> 
                        <asp:Label ID="Min1" runat="server" Text="0 min" BackColor="SkyBlue" Width="80px" Height="40px"></asp:Label>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div class="Blanco" align="center">
                <br /><br />
                <asp:Label ID="Jug2" runat="server" Text="Label" Width="200px" Height="40px" BackColor="SkyBlue" Font-Size="Large"></asp:Label>
                <br /><br />
                <asp:Label ID="Pun2" runat="server" Text="Label" Width="200px" Height="40px" BackColor="#ffcc00" Font-Size="Large"></asp:Label>
                <br /><br />
                <asp:ImageButton ID="Turno2" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false"/>
                <asp:Timer ID="Timer2" runat="server" Interval="1000" OnTick="Timer2_Tick"></asp:Timer>
                <br /><br />
                <asp:UpdatePanel ID="UpdatePanel2" UpdateMode="Conditional" runat="server">
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="Timer2" EventName="Tick"/>
                    </Triggers>
                    <ContentTemplate>
                        <asp:Label ID="Seg2" runat="server" Text="0 seg" BackColor="SkyBlue" Width="80px" Height="40px"></asp:Label> 
                        <asp:Label ID="Min2" runat="server" Text="0 min" BackColor="SkyBlue" Width="80px" Height="40px"></asp:Label>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
        <div class="Salir" align="center">
            <asp:Button ID="guardar" runat="server" Text="Guardar Y Salir" BackColor="#3366ff" Font-Size="Large" Font-Bold="true" Width="200px" Height="60px" OnClick="guardar_Click" />
        </div>
    </div>
    <div class="ventana modal" id="ventana" role="dialog" aria-labelledby="equiquetaModal" aria-hidden="true" align="center">
        <div class="dialogo">
            <asp:UpdatePanel ID="panelModal" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="contenido">
                        <div class="cuerpo" align="center">
                            <h1 id="modalletra"><asp:Label ID="Titulo" runat="server" BackColor="#ffcc00" Text=""></asp:Label></h1><br>
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