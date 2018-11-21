<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="BibliotecaMunicipal.Vistas.Usuarios.Modificar" %>

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
            <asp:Button ID="BtnBuscar" runat="server" OnClick="BtnBuscar_Click" Text="Buscar" />
            <br />
            Nombre<br />
            <asp:TextBox ID="NombreBusqueda" runat="server"></asp:TextBox>
            <br />
            Direccion<br />
            <asp:TextBox ID="DireccionBusqueda" runat="server"></asp:TextBox>
            <br />
            Telefono<br />
            <asp:TextBox ID="TelefonoBusqueda" runat="server"></asp:TextBox>
            <br />
            Correo<br />
            <asp:TextBox ID="CorreoBusqueda" runat="server"></asp:TextBox>
            <br />
            Estado<br />
            <asp:TextBox ID="EstadoBusqueda" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnActualizar" runat="server" OnClick="BtnActualizar_Click" Text="Actualizar" />
        </div>
    </form>
</body>
</html>
