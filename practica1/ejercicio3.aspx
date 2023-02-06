<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejercicio3.aspx.cs" Inherits="practica1.ejercicio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtNumber1" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtNumber2" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:RadioButton ID="rbSuma" runat="server" Text="Suma"  GroupName="operacion"/>
            <asp:RadioButton ID="rbResta" runat="server" Text="Resta"  GroupName="operacion"/>
            <asp:RadioButton ID="rbMultiplicacion" runat="server" Text="Multiplicación"  GroupName="operacion"/>
            <asp:RadioButton ID="rbDivision" runat="server" Text="División"  GroupName="operacion"/>
        </div>
         <asp:Button ID="calculateButton" runat="server" Text="Calcular" OnClick="CalculateButton_Click"/>

        <div id="result">
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
