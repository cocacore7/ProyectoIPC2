<%@ Page Title="O" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proyecto1IPC2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <center><h1>Bienvenido a Othello!</h1></center>
    <div>
        <center><form>
            <label>Correo: </label><input type="email" id="email" name="email" placeholder="ejemplo123@gmail.com"><br>
            <label>Contraseña: </label><input type="password" id="pass" name="pass"><br>
            <input type="submit" name="enviar" value="Ingresar"><br><br>
            <label>¿Aun no esta registrado? <a> Registrarse </a></label>
        </form></center>
    </div>
		

    </asp:Content>
