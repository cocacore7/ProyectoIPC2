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
        .ande{
            border-bottom-right-radius:100%;
        }
    </style>
    <div class="Tablero" align="center">
        
        <asp:Table ID="tabla" runat="server">
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
            <asp:TableFooterRow Width="60px" Height="60px">
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="A0A" runat="server" Text="1" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="A1" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="A1_Click" />
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="B1" runat="server"  Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="B1_Click" />
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="C1" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="C1_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="D1" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="D1_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="E1" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="E1_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="F1" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="F1_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="G1" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="G1_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="H1" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="H1_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="A9A" runat="server" Text="1" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
            </asp:TableFooterRow>
            <asp:TableFooterRow Width="60px" Height="60px">
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="B0B" runat="server" Text="2" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="A2" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="A2_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="B2" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="B2_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="C2" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="C2_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="D2" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="D2_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="E2" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="E2_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="F2" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="F2_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="G2" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="G2_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="H2" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="H2_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="B9B" runat="server" Text="2" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
            </asp:TableFooterRow>
            <asp:TableFooterRow Width="60px" Height="60px">
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="C0C" runat="server" Text="3" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="A3" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="A3_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="B3" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="B3_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="C3" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="C3_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="D3" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="D3_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="E3" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="E3_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="F3" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="F3_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="G3" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="G3_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="H3" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="H3_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="C9C" runat="server" Text="3" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
            </asp:TableFooterRow>
            <asp:TableFooterRow Width="60px" Height="60px">
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="D0D" runat="server" Text="4" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="A4" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="A4_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="B4" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="B4_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="C4" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="C4_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="D4" runat="server" Width="60px" Height="60px" ImageUrl="~/blanco.png" Enabled="false"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="E4" runat="server" Width="60px" Height="60px" ImageUrl="~/negro.png" Enabled="false"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="F4" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="F4_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="G4" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="G4_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="H4" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="H4_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="D9D" runat="server" Text="4" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
            </asp:TableFooterRow>
            <asp:TableFooterRow Width="60px" Height="60px">
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="E0E" runat="server" Text="5" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="A5" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="A5_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="B5" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="B5_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="C5" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="C5_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="D5" runat="server" Width="60px" Height="60px" ImageUrl="~/negro.png" Enabled="false"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="E5" runat="server" Width="60px" Height="60px" ImageUrl="~/blanco.png" Enabled="false"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="F5" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="F5_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="G5" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="G5_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="H5" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="H5_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="E9E" runat="server" Text="5" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
            </asp:TableFooterRow>
            <asp:TableFooterRow Width="60px" Height="60px">
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="F0F" runat="server" Text="6" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="A6" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="A6_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="B6" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="B6_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="C6" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="C6_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="D6" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="D6_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="E6" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="E6_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="F6" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="F6_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="G6" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="G6_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="H6" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="H6_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="F9F" runat="server" Text="6" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
            </asp:TableFooterRow>
            <asp:TableFooterRow Width="60px" Height="60px">
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="G0G" runat="server" Text="7" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="A7" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="A7_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="B7" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="B7_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="C7" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="C7_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="D7" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="D7_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="E7" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="E7_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="F7" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="F7_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="G7" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="G7_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="H7" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="H7_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="G9G" runat="server" Text="7" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
            </asp:TableFooterRow>
            <asp:TableFooterRow Width="60px" Height="60px">
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="H0H" runat="server" Text="8" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="A8" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="A8_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="B8" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="B8_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="C8" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="C8_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="D8" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="D8_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="E8" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="E8_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="F8" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="F8_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="G8" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="G8_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#5caf90" BorderStyle="solid" BorderColor="Black">
                    <asp:ImageButton ID="H8" runat="server" Width="60px" Height="60px" ImageUrl="~/vacio.png" OnClick="H8_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="60px" Height="60px" BackColor="#d2bb5a">
                    <center><asp:Label ID="H9H" runat="server" Text="8" Font-Size="Large" Font-Bold="true"></asp:Label></center>
                </asp:TableCell>
            </asp:TableFooterRow>
            <asp:TableFooterRow Width="60px" Height="60px">
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
</asp:Content>

