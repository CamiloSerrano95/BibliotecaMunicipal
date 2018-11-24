<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="BibliotecaMunicipal.Vistas.Prestamos.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Fecha&nbsp;&nbsp;
            <asp:TextBox ID="Fecha" runat="server"></asp:TextBox>
            <br />
            <br />
            Usuario&nbsp;
            <asp:DropDownList ID="ListaUsuarios" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="BtnGuardarPrestamo" runat="server" OnClick="BtnGuardarPrestamo_Click" Text="Guardar  prestamo" />
            <br />
            <br />
            Libro&nbsp; <asp:DropDownList ID="ListaLibros" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            Cantidad&nbsp;
            <asp:TextBox ID="Cantidad" runat="server" Width="80px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Fecha entrega&nbsp;
            <asp:TextBox ID="FechaEntrega" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="IdPrestamo" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:Button ID="GuardarDetalles" runat="server" OnClick="GuardarDetalles_Click" Text="Agregar" />
            <br />
            <br />
            <asp:GridView ID="TablaDetallesPrestamo" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
