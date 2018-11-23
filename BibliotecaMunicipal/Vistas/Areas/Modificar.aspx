<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="BibliotecaMunicipal.Vistas.Modificar" %>

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
        <h1>Modificar Area</h1>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Selecionar Area"></asp:Label>
            <asp:DropDownList ID="AreasSelect" runat="server" class="btn btn-success dropdown-toggle">
            </asp:DropDownList>
            <asp:Button ID="BuscarArea" runat="server" Text="Consultar"  OnClick="BuscarArea_Click1" class="btn btn-success" />
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Codigo Area   "></asp:Label>
            <asp:TextBox ID="EditarCodigo" runat="server" class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Nombre Area   "></asp:Label>
            <asp:TextBox ID="EditarNombre" runat="server" class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="Tiempo Area   "></asp:Label>
            <asp:TextBox ID="EditarTiempo" runat="server" class="form-control"></asp:TextBox>
        </div>
        <asp:Button ID="ActualizarCambios" runat="server" Text="Guardar Cambios" OnClick="ActualizarCambios_Click" class="btn btn-success mt-3"/>
    </div>
    </form>

<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
</body>
</html>
