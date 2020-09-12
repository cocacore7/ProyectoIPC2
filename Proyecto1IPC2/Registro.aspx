<%@ Page Title="Registro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Proyecto1IPC2.Registro" %>

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
        #login{
            font-weight:bolder;
            background: #c54848;
        }
        label{
            font-weight:bolder;
            height:auto;
            width:auto;
            background:#c54848
        }
        h2{
            height:auto;
            width:400px;
            background:#cbc53d
        }
        label{
            height:auto;
            width:400px;
            background:#cbc53d
        }
    </style>

    <div class="jumbotron" align ="center">
        <h1>Bienvenido a Othello</h1>
    </div>

    <div class="row" align ="center">
        <h2>Formulario de Registro</h2>
        <form>
            <asp:TextBox ID="nombre" runat="server" placeholder="Nombres"></asp:TextBox><br><br>
            <asp:TextBox ID="apellido" runat="server" placeholder="Apellidos"></asp:TextBox><br><br>
            <asp:TextBox ID="nickname" runat="server" placeholder="Nombre De Usuario"></asp:TextBox><br><br>
            <asp:TextBox ID="password" runat="server" placeholder="Contraseña" TextMode="Password"></asp:TextBox><br><br>
            <asp:TextBox ID="fecha" runat="server" placeholder="Fecha De Nacimiento" TextMode="Date"></asp:TextBox><br><br>
            <asp:DropDownList ID="pais" runat="server" Width="300px" Height="40px" BackColor="SkyBlue">
                <asp:ListItem>Elegir Opcion</asp:ListItem>
                <asp:ListItem>AFG</asp:ListItem>
                <asp:ListItem>ALA</asp:ListItem>
                <asp:ListItem>ALB</asp:ListItem>
                <asp:ListItem>ASM</asp:ListItem>
                <asp:ListItem>AND</asp:ListItem>
                <asp:ListItem>AGO</asp:ListItem>
                <asp:ListItem>AIA</asp:ListItem>
                <asp:ListItem>ATA</asp:ListItem>
                <asp:ListItem>ATG</asp:ListItem>
                <asp:ListItem>ARG</asp:ListItem>
                <asp:ListItem>ARM</asp:ListItem>
                <asp:ListItem>ABW</asp:ListItem>
                <asp:ListItem>AUS</asp:ListItem>
                <asp:ListItem>AUT</asp:ListItem>
                <asp:ListItem>AZE</asp:ListItem>
                <asp:ListItem>BHS</asp:ListItem>
                <asp:ListItem>BHR</asp:ListItem>
                <asp:ListItem>BGD</asp:ListItem>
                <asp:ListItem>BRB</asp:ListItem>
                <asp:ListItem>BRL</asp:ListItem>
                <asp:ListItem>BEL</asp:ListItem>
                <asp:ListItem>BLZ</asp:ListItem>
                <asp:ListItem>BEN</asp:ListItem>
                <asp:ListItem>BMU</asp:ListItem>
                <asp:ListItem>BTN</asp:ListItem>
                <asp:ListItem>BES</asp:ListItem>
                <asp:ListItem>BIH</asp:ListItem>
                <asp:ListItem>BWA</asp:ListItem>
                <asp:ListItem>BVT</asp:ListItem>
                <asp:ListItem>BRA</asp:ListItem>
                <asp:ListItem>IOT</asp:ListItem>
                <asp:ListItem>VGB</asp:ListItem>
                <asp:ListItem>BRN</asp:ListItem>
                <asp:ListItem>BGR</asp:ListItem>
                <asp:ListItem>BFA</asp:ListItem>
                <asp:ListItem>BDI</asp:ListItem>
                <asp:ListItem>KHM</asp:ListItem>
                <asp:ListItem>CMR</asp:ListItem>
                <asp:ListItem>CAN</asp:ListItem>
                <asp:ListItem>CPV</asp:ListItem>
                <asp:ListItem>CYM</asp:ListItem>
                <asp:ListItem>CAF</asp:ListItem>
                <asp:ListItem>TCD</asp:ListItem>
                <asp:ListItem>CHL</asp:ListItem>
                <asp:ListItem>CHN</asp:ListItem>
                <asp:ListItem>CXR</asp:ListItem>
                <asp:ListItem>CCK</asp:ListItem>
                <asp:ListItem>COL</asp:ListItem>
                <asp:ListItem>COM</asp:ListItem>
                <asp:ListItem>COK</asp:ListItem>
                <asp:ListItem>CRI</asp:ListItem>
                <asp:ListItem>HRV</asp:ListItem>
                <asp:ListItem>CUB</asp:ListItem>
                <asp:ListItem>CUW</asp:ListItem>
                <asp:ListItem>CYP</asp:ListItem>
                <asp:ListItem>CZE</asp:ListItem>
                <asp:ListItem>COD</asp:ListItem>
                <asp:ListItem>DNK</asp:ListItem>
                <asp:ListItem>DJI</asp:ListItem>
                <asp:ListItem>DMA</asp:ListItem>
                <asp:ListItem>DOM</asp:ListItem>
                <asp:ListItem>TLS</asp:ListItem>
                <asp:ListItem>ECU</asp:ListItem>
                <asp:ListItem>EGY</asp:ListItem>
                <asp:ListItem>SLV</asp:ListItem>
                <asp:ListItem>GNQ</asp:ListItem>
                <asp:ListItem>ERI</asp:ListItem>
                <asp:ListItem>EST</asp:ListItem>
                <asp:ListItem>ETH</asp:ListItem>
                <asp:ListItem>FLK</asp:ListItem>
                <asp:ListItem>FRO</asp:ListItem>
                <asp:ListItem>FJI</asp:ListItem>
                <asp:ListItem>FIN</asp:ListItem>
                <asp:ListItem>FRA</asp:ListItem>
                <asp:ListItem>GUF</asp:ListItem>
                <asp:ListItem>PYF</asp:ListItem>
                <asp:ListItem>ATF</asp:ListItem>
                <asp:ListItem>GAB</asp:ListItem>
                <asp:ListItem>GMB</asp:ListItem>
                <asp:ListItem>GEO</asp:ListItem>
                <asp:ListItem>DEU</asp:ListItem>
                <asp:ListItem>GHA</asp:ListItem>
                <asp:ListItem>GIB</asp:ListItem>
                <asp:ListItem>GRC</asp:ListItem>
                <asp:ListItem>GRL</asp:ListItem>
                <asp:ListItem>GRD</asp:ListItem>
                <asp:ListItem>GLP</asp:ListItem>
                <asp:ListItem>GUM</asp:ListItem>
                <asp:ListItem>GTM</asp:ListItem>
                <asp:ListItem>GGY</asp:ListItem>
                <asp:ListItem>GIN</asp:ListItem>
                <asp:ListItem>GNB</asp:ListItem>
                <asp:ListItem>GUY</asp:ListItem>
                <asp:ListItem>HTI</asp:ListItem>
                <asp:ListItem>HMD</asp:ListItem>
                <asp:ListItem>HND</asp:ListItem>
                <asp:ListItem>HKG</asp:ListItem>
                <asp:ListItem>HUN</asp:ListItem>
                <asp:ListItem>ISL</asp:ListItem>
                <asp:ListItem>IND</asp:ListItem>
                <asp:ListItem>IDN</asp:ListItem>
                <asp:ListItem>IRN</asp:ListItem>
                <asp:ListItem>IRQ</asp:ListItem>
                <asp:ListItem>IRL</asp:ListItem>
                <asp:ListItem>IMN</asp:ListItem>
                <asp:ListItem>ISR</asp:ListItem>
                <asp:ListItem>ITA</asp:ListItem>
                <asp:ListItem>CIV</asp:ListItem>
                <asp:ListItem>JAM</asp:ListItem>
                <asp:ListItem>JPN</asp:ListItem>
                <asp:ListItem>JEY</asp:ListItem>
                <asp:ListItem>JOR</asp:ListItem>
                <asp:ListItem>KAZ</asp:ListItem>
                <asp:ListItem>KEN</asp:ListItem>
                <asp:ListItem>KIR</asp:ListItem>
                <asp:ListItem>XKX</asp:ListItem>
                <asp:ListItem>KWT</asp:ListItem>
                <asp:ListItem>KGZ</asp:ListItem>
                <asp:ListItem>LAO</asp:ListItem>
                <asp:ListItem>LVA</asp:ListItem>
                <asp:ListItem>LBN</asp:ListItem>
                <asp:ListItem>LBY</asp:ListItem>
                <asp:ListItem>LIE</asp:ListItem>
                <asp:ListItem>LTU</asp:ListItem>
                <asp:ListItem>LUX</asp:ListItem>
                <asp:ListItem>MAC</asp:ListItem>
                <asp:ListItem>MKD</asp:ListItem>
                <asp:ListItem>MDG</asp:ListItem>
                <asp:ListItem>MWI</asp:ListItem>
                <asp:ListItem>MYS</asp:ListItem>
                <asp:ListItem>MDV</asp:ListItem>
                <asp:ListItem>MLI</asp:ListItem>
                <asp:ListItem>MLT</asp:ListItem>
                <asp:ListItem>MHL</asp:ListItem>
                <asp:ListItem>MTQ</asp:ListItem>
                <asp:ListItem>MRT</asp:ListItem>
                <asp:ListItem>MUS</asp:ListItem>
                <asp:ListItem>MYT</asp:ListItem>
                <asp:ListItem>MEX</asp:ListItem>
                <asp:ListItem>FSM</asp:ListItem>
                <asp:ListItem>MDA</asp:ListItem>
                <asp:ListItem>MNG</asp:ListItem>
                <asp:ListItem>MNE</asp:ListItem>
                <asp:ListItem>MSR</asp:ListItem>
                <asp:ListItem>MAR</asp:ListItem>
                <asp:ListItem>MOZ</asp:ListItem>
                <asp:ListItem>MMR</asp:ListItem>
                <asp:ListItem>NAM</asp:ListItem>
                <asp:ListItem>NRU</asp:ListItem>
                <asp:ListItem>NLD</asp:ListItem>
                <asp:ListItem>NLD</asp:ListItem>
                <asp:ListItem>ANT</asp:ListItem>
                <asp:ListItem>NCL</asp:ListItem>
                <asp:ListItem>NZL</asp:ListItem>
                <asp:ListItem>NIC</asp:ListItem>
                <asp:ListItem>NER</asp:ListItem>
                <asp:ListItem>NGA</asp:ListItem>
                <asp:ListItem>NIU</asp:ListItem>
                <asp:ListItem>NFK</asp:ListItem>
                <asp:ListItem>PRK</asp:ListItem>
                <asp:ListItem>MNP</asp:ListItem>
                <asp:ListItem>NOR</asp:ListItem>
                <asp:ListItem>OMN</asp:ListItem>
                <asp:ListItem>PAK</asp:ListItem>
                <asp:ListItem>PLW</asp:ListItem>
                <asp:ListItem>PSE</asp:ListItem>
                <asp:ListItem>PAN</asp:ListItem>
                <asp:ListItem>PNG</asp:ListItem>
                <asp:ListItem>PER</asp:ListItem>
                <asp:ListItem>PHL</asp:ListItem>
                <asp:ListItem>PCN</asp:ListItem>
                <asp:ListItem>POL</asp:ListItem>
                <asp:ListItem>PRT</asp:ListItem>
                <asp:ListItem>PRI</asp:ListItem>
                <asp:ListItem>QAT</asp:ListItem>
                <asp:ListItem>COG</asp:ListItem>
                <asp:ListItem>REU</asp:ListItem>
                <asp:ListItem>ROU</asp:ListItem>
                <asp:ListItem>RUS</asp:ListItem>
                <asp:ListItem>RWA</asp:ListItem>
                <asp:ListItem>BLM</asp:ListItem>
                <asp:ListItem>SHN</asp:ListItem>
                <asp:ListItem>KNA</asp:ListItem>
                <asp:ListItem>LCA</asp:ListItem>
                <asp:ListItem>MAF</asp:ListItem>
                <asp:ListItem>SPM</asp:ListItem>
                <asp:ListItem>VCT</asp:ListItem>
                <asp:ListItem>WSM</asp:ListItem>
                <asp:ListItem>SMR</asp:ListItem>
                <asp:ListItem>STP</asp:ListItem>
                <asp:ListItem>SAU</asp:ListItem>
                <asp:ListItem>SEN</asp:ListItem>
                <asp:ListItem>SRB</asp:ListItem>
                <asp:ListItem>SCG</asp:ListItem>
                <asp:ListItem>SYC</asp:ListItem>
                <asp:ListItem>SLE</asp:ListItem>
                <asp:ListItem>SXM</asp:ListItem>
                <asp:ListItem>SXM</asp:ListItem>
                <asp:ListItem>SVK</asp:ListItem>
                <asp:ListItem>SVN</asp:ListItem>
                <asp:ListItem>SLB</asp:ListItem>
                <asp:ListItem>SOM</asp:ListItem>
                <asp:ListItem>ZAF</asp:ListItem>
                <asp:ListItem>SGS</asp:ListItem>
                <asp:ListItem>KOR</asp:ListItem>
                <asp:ListItem>SSD</asp:ListItem>
                <asp:ListItem>ESP</asp:ListItem>
                <asp:ListItem>LKA</asp:ListItem>
                <asp:ListItem>SDN</asp:ListItem>
                <asp:ListItem>SUR</asp:ListItem>
                <asp:ListItem>SJM</asp:ListItem>
                <asp:ListItem>SWZ</asp:ListItem>
                <asp:ListItem>SWE</asp:ListItem>
                <asp:ListItem>CHE</asp:ListItem>
                <asp:ListItem>SYR</asp:ListItem>
                <asp:ListItem>TWN</asp:ListItem>
                <asp:ListItem>TJK</asp:ListItem>
                <asp:ListItem>TZA</asp:ListItem>
                <asp:ListItem>THA</asp:ListItem>
                <asp:ListItem>TGO</asp:ListItem>
                <asp:ListItem>TKL</asp:ListItem>
                <asp:ListItem>TON</asp:ListItem>
                <asp:ListItem>TTO</asp:ListItem>
                <asp:ListItem>TUN</asp:ListItem>
                <asp:ListItem>TUR</asp:ListItem>
                <asp:ListItem>TKM</asp:ListItem>
                <asp:ListItem>TCA</asp:ListItem>
                <asp:ListItem>TUV</asp:ListItem>
                <asp:ListItem>VIR</asp:ListItem>
                <asp:ListItem>UGA</asp:ListItem>
                <asp:ListItem>UKR</asp:ListItem>
                <asp:ListItem>ARE</asp:ListItem>
                <asp:ListItem>GBR</asp:ListItem>
                <asp:ListItem>USA</asp:ListItem>
                <asp:ListItem>UMI</asp:ListItem>
                <asp:ListItem>URY</asp:ListItem>
                <asp:ListItem>UZB</asp:ListItem>
                <asp:ListItem>VUT</asp:ListItem>
                <asp:ListItem>VAT</asp:ListItem>
                <asp:ListItem>VEN</asp:ListItem>
                <asp:ListItem>VNM</asp:ListItem>
                <asp:ListItem>WLF</asp:ListItem>
                <asp:ListItem>ESH</asp:ListItem>
                <asp:ListItem>YEM</asp:ListItem>
                <asp:ListItem>ZMB</asp:ListItem>
                <asp:ListItem>ZWE</asp:ListItem>
            </asp:DropDownList><br><br>
            <asp:TextBox ID="email" runat="server" TextMode="Email" placeholder="Correo"></asp:TextBox><br><br>
            <asp:Button ID="registrar" runat="server" Text="Registrarse" BackColor="#cc0000" OnClick="registrar_Click"/><br><br>
            <asp:Label ID="login" runat="server" Text="¿Ya estas registrado? " BackColor="Yellow"><a runat="server" href="~/InicioSesion"> Inicio de Sesion</a></asp:Label>
        </form>
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
                            <h1 id="modalletra"><asp:Label ID="Titulo" runat="server" BackColor="#ffcc00" Text=""></asp:Label></h1><br>
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
