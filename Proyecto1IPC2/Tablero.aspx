<%@ Page Title="Tablero" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tablero.aspx.cs" Inherits="Proyecto1IPC2.Tablero" %>

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

        <asp:Table ID="Table1" runat="server">
            <asp:TableFooterRow>
                <asp:TableCell CssClass="ariz" Width="60px" Height="60px" BackColor="#d2bb5a" ></asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="A0" runat="server" Text="A" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="B0" runat="server" Text="B" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="C0" runat="server" Text="C" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="D0" runat="server" Text="D" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="E0" runat="server" Text="E" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="F0" runat="server" Text="F" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="G0" runat="server" Text="G" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="H0" runat="server" Text="H" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell CssClass="arde" Width="60px" Height="60px" BackColor="#d2bb5a" ></asp:TableCell>
            </asp:TableFooterRow>
            <asp:TableFooterRow>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="A0A" runat="server" Text="1" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="A1" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="A1_Click" />
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="B1" runat="server"  Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="B1_Click" />
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="C1" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="C1_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="D1" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="D1_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="E1" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="E1_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="F1" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="F1_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="G1" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="G1_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="H1" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="H1_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="A9A" runat="server" Text="1" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
            </asp:TableFooterRow>
            <asp:TableFooterRow>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="B0B" runat="server" Text="2" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="A2" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="A2_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="B2" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="B2_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="C2" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="C2_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="D2" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="D2_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="E2" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="E2_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="F2" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="F2_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="G2" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="G2_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="H2" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="H2_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="B9B" runat="server" Text="2" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
            </asp:TableFooterRow>
            <asp:TableFooterRow>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="C0C" runat="server" Text="3" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="A3" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="A3_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="B3" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="B3_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="C3" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="C3_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="D3" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="D3_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="E3" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="E3_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="F3" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="F3_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="G3" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="G3_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="H3" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="H3_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="C9C" runat="server" Text="3" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
            </asp:TableFooterRow>
            <asp:TableFooterRow>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="D0D" runat="server" Text="4" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="A4" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="A4_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="B4" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="B4_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="C4" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="C4_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="D4" runat="server" Width="60px" Height="60px" ImageUrl="~/blanco.png" Enabled="false"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="E4" runat="server" Width="60px" Height="60px" ImageUrl="~/negro.png" Enabled="false"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="F4" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="F4_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="G4" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="G4_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="H4" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="H4_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="D9D" runat="server" Text="4" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
            </asp:TableFooterRow>
            <asp:TableFooterRow>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="E0E" runat="server" Text="5" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="A5" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="A5_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="B5" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="B5_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="C5" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="C5_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="D5" runat="server" Width="60px" Height="60px" ImageUrl="~/negro.png" Enabled="false"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="E5" runat="server" Width="60px" Height="60px" ImageUrl="~/blanco.png" Enabled="false"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="F5" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="F5_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="G5" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="G5_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="H5" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="H5_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="E9E" runat="server" Text="5" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
            </asp:TableFooterRow>
            <asp:TableFooterRow>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="F0F" runat="server" Text="6" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="A6" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="A6_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="B6" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="B6_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="C6" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="C6_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="D6" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="D6_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="E6" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="E6_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="F6" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="F6_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="G6" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="G6_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="H6" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="H6_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="F9F" runat="server" Text="6" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
            </asp:TableFooterRow>
            <asp:TableFooterRow>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="G0G" runat="server" Text="7" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="A7" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="A7_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="B7" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="B7_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="C7" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="C7_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="D7" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="D7_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="E7" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="E7_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="F7" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="F7_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="G7" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="G7_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="H7" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="H7_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="G9G" runat="server" Text="7" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
            </asp:TableFooterRow>
            <asp:TableFooterRow>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="H0H" runat="server" Text="8" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="A8" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="A8_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="B8" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="B8_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="C8" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="C8_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="D8" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="D8_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="E8" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="E8_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="F8" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="F8_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="G8" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="G8_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="H8" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" Enabled="false" OnClick="H8_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="H9H" runat="server" Text="8" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
            </asp:TableFooterRow>
            <asp:TableFooterRow>
                <asp:TableCell CssClass="abiz" Width="60px" Height="60px" BackColor="#d2bb5a" ></asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="A9" runat="server" Text="A" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="B9" runat="server" Text="B" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="C9" runat="server" Text="C" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="D9" runat="server" Text="D" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="E9" runat="server" Text="E" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="F9" runat="server" Text="F" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="G9" runat="server" Text="G" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="H9" runat="server" Text="H" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell CssClass="abde" Width="60px" Height="60px" BackColor="#d2bb5a" ></asp:TableCell>
            </asp:TableFooterRow>
        </asp:Table>
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
        .Jugadores {
            height: 450px;
        }
        .Salir {
            height: 151px;
        }
    </style>
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

