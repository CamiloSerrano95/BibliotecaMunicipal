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
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnGuardarPrestamo" runat="server" OnClick="Button1_Click" Text="Guardar prestamo" />
            <br />
            <br />
            Libro&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ListaLibros" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            Cantidad&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Cantidad" runat="server" Width="73px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Limite de entrega&nbsp;
            <asp:TextBox ID="FechaEntrega" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnAgregaLibro" runat="server" Text="Agregar libro" />
            <br />
            <br />
            <asp:GridView ID="TablaLibros" runat="server">
            </asp:GridView>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
