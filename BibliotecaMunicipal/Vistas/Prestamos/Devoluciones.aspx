<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Devoluciones.aspx.cs" Inherits="BibliotecaMunicipal.Vistas.Prestamos.Devoluciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Fecha&nbsp;
            <asp:TextBox ID="Fecha" runat="server"></asp:TextBox>
            <br />
            <br />
            Usuario&nbsp;&nbsp;
            <asp:DropDownList ID="ListaUsuarios" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            Libro&nbsp; <asp:DropDownList ID="ListaLibros" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" OnClick="BtnGuardar_Click" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
