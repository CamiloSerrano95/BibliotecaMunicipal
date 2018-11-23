<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="BibliotecaMunicipal.Vistas.Libros.Eliminar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Eliminar un libro</h1>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Selecione Libro"></asp:Label>
        <asp:DropDownList ID="LibrosSelect" runat="server">
        </asp:DropDownList>
        <asp:Button ID="EliminarLibro" runat="server" OnClick="EliminarLibro_Click" Text="Eliminar" />
    </div>
    </form>
</body>
</html>
