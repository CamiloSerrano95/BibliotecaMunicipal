<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insertar.aspx.cs" Inherits="BibliotecaMunicipal.Vistas.Usuarios.Insertar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Documento<br />
            <asp:TextBox ID="Documento" runat="server"></asp:TextBox>
            <br />
            Nombre<br />
            <asp:TextBox ID="Nombre" runat="server"></asp:TextBox>
            <br />
            Direccion<br />
            <asp:TextBox ID="Direccion" runat="server"></asp:TextBox>
            <br />
            Telefono<br />
            <asp:TextBox ID="Telefono" runat="server"></asp:TextBox>
            <br />
            Correo<br />
            <asp:TextBox ID="Correo" runat="server"></asp:TextBox>
            <br />
            Estado<br />
            <asp:TextBox ID="Estado" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnIngresar" runat="server" OnClick="BtnIngresar_Click" Text="Ingresar" />
        </div>
    </form>
</body>
</html>
