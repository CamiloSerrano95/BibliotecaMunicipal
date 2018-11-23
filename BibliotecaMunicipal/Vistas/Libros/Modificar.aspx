<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="BibliotecaMunicipal.Vistas.Libros.Modificar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Modificar un libro</h1>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Seleccione libro"></asp:Label>
        <asp:DropDownList ID="LibrosSelect" runat="server">
        </asp:DropDownList>
        <asp:Button ID="BuscarLibro" runat="server" OnClick="BuscarLibro_Click" Text="Consultar" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Codigo"></asp:Label>
        <asp:TextBox ID="CodigoLibro" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="NombreLibro" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Numero Paginas"></asp:Label>
        <asp:TextBox ID="NumPagLibro" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Autor"></asp:Label>
        <asp:TextBox ID="AutorLibro" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Editorial"></asp:Label>
        <asp:TextBox ID="EditorialLibro" runat="server"></asp:TextBox>
        <br />
        Area
        <asp:DropDownList ID="AreasSelect" runat="server">
        </asp:DropDownList>
&nbsp;<br />
        <asp:Button ID="ActualizarLibro" runat="server" OnClick="ActualizarLibro_Click" Text="Guardar Cambios" />
    </div>
    </form>
</body>
</html>
