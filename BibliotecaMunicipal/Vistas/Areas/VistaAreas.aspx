<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VistaAreas.aspx.cs" Inherits="BibliotecaMunicipal.Vistas.VistaAreas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Insertar un area</h1>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Codigo Area"></asp:Label>
        <asp:TextBox ID="CodigoArea" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nombre Area"></asp:Label>
        <asp:TextBox ID="NombreArea" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Tiempo Area"></asp:Label>
        <asp:TextBox ID="TiempoArea" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="InsertarArea" runat="server" OnClick="Button1_Click" Text="Insertar" />
    </div>
        <asp:GridView ID="TableAllAreas" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
