<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insertar.aspx.cs" Inherits="BibliotecaMunicipal.Vistas.Libros.Insertar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Insertar un libro</h1>
    <form id="form1" runat="server">
    <div>
        
        <asp:Label ID="Label1" runat="server" Text="Codigo"></asp:Label>
        <asp:TextBox ID="CodigoLibro" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="NombreLibro" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Numero Paginas"></asp:Label>
        <asp:TextBox ID="NumPagLibro" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Autor"></asp:Label>
        <asp:TextBox ID="AutorLibro" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Editorial"></asp:Label>
        <asp:TextBox ID="EditorialLibro" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Area"></asp:Label>
        <asp:DropDownList ID="AreasSelect" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Button ID="InsertarLibro" runat="server" Text="Insertar" OnClick="InsertarLibro_Click" />
        <br />        
    </div>
        <asp:GridView ID="TablaLibros" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
