<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="BibliotecaMunicipal.Vistas.Consultar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Consultar un area</h1>

        <asp:Label ID="Label1" runat="server" Text="Seleccione area"></asp:Label>
        <asp:DropDownList ID="AreasSelect" runat="server">
        </asp:DropDownList>
        <asp:Button ID="ConsultarArea" runat="server" OnClick="ConsultarArea_Click" Text="Consultar" />
        <br />
        <br />
    </div>
        <asp:GridView ID="TableConsultaArea" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
