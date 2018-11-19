<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="BibliotecaMunicipal.Vistas.Eliminar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Elimina Area</h1>
        <asp:Label ID="Label1" runat="server" Text="Seleccione Area"></asp:Label>
        <asp:DropDownList ID="AreasSelect" runat="server">
        </asp:DropDownList>
        <asp:Button ID="EliminarArea" runat="server" OnClick="EliminarArea_Click" Text="Eliminar" />
    </div>
    </form>
</body>
</html>
