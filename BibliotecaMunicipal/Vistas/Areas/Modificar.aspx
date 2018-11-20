<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="BibliotecaMunicipal.Vistas.Modificar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Modificar Area</h1>
        <asp:Label ID="Label1" runat="server" Text="Selecionar Area"></asp:Label>
        <asp:DropDownList ID="AreasSelect" runat="server">
        </asp:DropDownList>
        <asp:Button ID="BuscarArea" runat="server" Text="Consultar" Height="25px" OnClick="BuscarArea_Click1" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Codigo Area   "></asp:Label>
        <asp:TextBox ID="EditarCodigo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Nombre Area   "></asp:Label>
        <asp:TextBox ID="EditarNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Tiempo Area   "></asp:Label>
        <asp:TextBox ID="EditarTiempo" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="ActualizarCambios" runat="server" Text="Guardar Cambios" OnClick="ActualizarCambios_Click" />

    </div>
    </form>
</body>
</html>
