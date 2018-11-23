<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="BibliotecaMunicipal.Vistas.Usuarios.Modificar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-4">
            <asp:DropDownList ID="ListaUsuarios" runat="server" class="btn btn-success dropdown-toggle">
            </asp:DropDownList>
&nbsp;
            <asp:Button ID="BtnBuscar" runat="server" OnClick="BtnBuscar_Click" Text="Buscar" class="btn btn-success"/>
            
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="NombreBusqueda" runat="server" class="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Direccion"></asp:Label>
                <asp:TextBox ID="DireccionBusqueda" runat="server" class="form-control"></asp:TextBox>
            </div>
           <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Telefono"></asp:Label>
                <asp:TextBox ID="TelefonoBusqueda" runat="server" class="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Correo"></asp:Label>
                <asp:TextBox ID="CorreoBusqueda" runat="server" class="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Estado"></asp:Label>
                <asp:TextBox ID="EstadoBusqueda" runat="server" class="form-control"></asp:TextBox>
            </div>            
            <asp:Button ID="BtnActualizar" runat="server" OnClick="BtnActualizar_Click" Text="Actualizar" class="btn btn-success" />
            <a href="../../default.aspx" class="btn btn-success">Volver al Inicio</a>
        </div>
    </form>

<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>

</body>
</html>
