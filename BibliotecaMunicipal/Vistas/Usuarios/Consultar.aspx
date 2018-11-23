<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="BibliotecaMunicipal.Vistas.Usuarios.Consultar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <p>
        &nbsp;</p>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ListaUsuarios" runat="server">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnConsultar" runat="server" OnClick="Button1_Click" Text="Consultar" />
            <br />
            <asp:GridView ID="TablaUsuarios" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
