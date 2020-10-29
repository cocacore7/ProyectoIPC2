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
            width:650px;
            height:800px;
        }
        .Panel {
            float:right;
            height: 800px;
            width: 420px;
        }
        .Negro {
            float:left;
            height: 350px;
            width: 200px;
        }

        .Blanco {
            float:right;
            height: 350px;
            width: 200px;
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
        .Jugadores {
            height: 450px;
        }
        .Salir {
            height: 151px;
        }
    </style>
    <div class="Tablero">
        <asp:Table ID="Table1" runat="server"></asp:Table>
    </div>
        
    <div class="Panel">
        <div class="Jugadores">
            <div class="Negro" align="center">
                <br /><br />
                <asp:Label ID="JugN" runat="server" Text="Label" Width="200px" Height="40px" BackColor="SkyBlue" Font-Size="Large"></asp:Label>
                <br /><br />
                <asp:Label ID="PunN" runat="server" Text="Label"  Width="200px" Height="40px" BackColor="#ffcc00" Font-Size="Large"></asp:Label>
                <br /><br />
                <asp:ImageButton ID="TurnoNegro" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false"/>
                <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick" >
                </asp:Timer>
                <br /><br />
                <asp:UpdatePanel ID="UpdatePanel1" UpdateMode="Conditional" runat="server">
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick"/>
                    </Triggers>
                    <ContentTemplate>
                        <asp:Label ID="SegN" runat="server" Text="0 seg" BackColor="SkyBlue" Width="80px" Height="40px"></asp:Label> 
                        <asp:Label ID="MinN" runat="server" Text="0 min" BackColor="SkyBlue" Width="80px" Height="40px"></asp:Label>
                    </ContentTemplate>
                </asp:UpdatePanel>    
            </div>
            <div class="Blanco" align="center">
                <br /><br />
                <asp:Label ID="JugB" runat="server" Text="Label" Width="200px" Height="40px" BackColor="SkyBlue" Font-Size="Large"></asp:Label>
                <br /><br />
                <asp:Label ID="PunB" runat="server" Text="Label" Width="200px" Height="40px" BackColor="#ffcc00" Font-Size="Large"></asp:Label>
                <br /><br />
                <asp:ImageButton ID="TurnoBlanco" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false"/>
                <asp:Timer ID="Timer2" runat="server" Interval="1000"  OnTick="Timer2_Tick1" >
                </asp:Timer>
                <br /><br />
                <asp:UpdatePanel ID="UpdatePanel2" UpdateMode="Conditional" runat="server">
                   <Triggers>
                       <asp:AsyncPostBackTrigger ControlID="Timer2" EventName="Tick" />
                   </Triggers>
                    <ContentTemplate>
                        <asp:Label ID="SegB" runat="server" Text="0 seg" BackColor="SkyBlue" Width="80px" Height="40px"></asp:Label>
                        <asp:Label ID="MinB" runat="server" Text="0 min" BackColor="SkyBlue" Width="80px" Height="40px"></asp:Label>
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