<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormPersona.aspx.cs" Inherits="MiProyectoWeb.WebFormPersona" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Hola mundo!!!</h1>
        </div>
        <p>
            Ingrese nombre
        </p>
        <p>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" />
        <p>
            <asp:TextBox ID="txtSalida" runat="server" Width="265px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
