﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="practica1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label><br />
            <asp:TextBox ID="txtNombreProducto" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Cantidad"></asp:Label><br />
            <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Precio"></asp:Label><br />
            <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Registrar" OnClick="Button1_Click" /><br />
            <div runat="server" id="respuesta"></div>

        </div>
    </form>
</body>
</html>
