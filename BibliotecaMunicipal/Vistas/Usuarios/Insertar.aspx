<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insertar.aspx.cs" Inherits="BibliotecaMunicipal.Vistas.Usuarios.Insertar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <title>Insertar Usuario</title>
</head>
<body>
         <h3 class="text-center mt-5">Sistema de Gestion de Prestamos de Libros de la Biblioteca Municipal</h3>
    <form id="form1" runat="server">
        <div class="container mt-4">
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Documento"></asp:Label>
                <asp:TextBox ID="Documento" runat="server" class="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="Nombre" runat="server" class="form-control"></asp:TextBox>
            </div>    
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Direccion"></asp:Label>
                <asp:TextBox ID="Direccion" runat="server" class="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Telefono"></asp:Label>
                <asp:TextBox ID="Telefono" runat="server" class="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Correo"></asp:Label>
                <asp:TextBox ID="Correo" runat="server" class="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="Estado"></asp:Label>
                <br />
            </div>
            <asp:TextBox ID="Estado" runat="server" class="form-control"></asp:TextBox>
            <br />
            <asp:Button ID="BtnIngresar" runat="server" OnClick="BtnIngresar_Click" Text="Ingresar" class="btn btn-success" />
            <a href="../../default.aspx" class="btn btn-success">Volver al Inicio</a>
            <br />
            <br />
               
                <asp:GridView ID="TablaUsuarios" runat="server" AutoGenerateColumns="false"  class="table table-striped" Height="123px" Width="567px" >
                    <Columns>
                        <asp:BoundField HeaderText="Documento" DataField="usuDocumento" />
                        <asp:BoundField HeaderText="Nombre" DataField="usuNombre" />
                        <asp:BoundField HeaderText="Direccion" DataField="usuDireccion" />
                        <asp:BoundField HeaderText="Telefono" DataField="usuTelefono" />
                        <asp:BoundField HeaderText="Email" DataField="usuCorreo" />
                        <asp:BoundField HeaderText="Estado" DataField="usuEstado" />
                    </Columns>
        </asp:GridView>
        </div>
    </form>

<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>

</body>
</html>
