<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Devoluciones.aspx.cs" Inherits="BibliotecaMunicipal.Vistas.Prestamos.Devoluciones" %>

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
            <div class="form-group">
                Fecha&nbsp;
                <asp:TextBox ID="Fecha" runat="server" class="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                Usuario&nbsp;&nbsp;
                <asp:DropDownList ID="ListaUsuarios" runat="server" class="btn btn-success dropdown-toggle">
                </asp:DropDownList>
            </div>
            <div class="form-group">
                Libro&nbsp; <asp:DropDownList ID="ListaLibros" runat="server" class="btn btn-success dropdown-toggle">
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" OnClick="BtnGuardar_Click" class="btn btn-success " />
                <a href="../../default.aspx" class="btn btn-success">Volver al Inicio</a>
            </div>
        </div>
    </form>

<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
</body>
</html>
