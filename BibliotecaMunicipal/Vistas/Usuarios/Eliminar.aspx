<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="BibliotecaMunicipal.Vistas.Usuarios.Eliminar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ListaUsuarios" runat="server">
            </asp:DropDownList>
&nbsp;
            <asp:Button ID="BtnEliminar" runat="server" OnClick="BtnEliminar_Click" Text="Eliminar" />
        </div>
    </form>
</body>
</html>
