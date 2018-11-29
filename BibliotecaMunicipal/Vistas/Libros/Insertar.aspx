<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insertar.aspx.cs" Inherits="BibliotecaMunicipal.Vistas.Libros.Insertar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <title>Insertar Libro</title>
</head>
<body>
         <h3 class="text-center mt-5">Sistema de Gestion de Prestamos de Libros de la Biblioteca Municipal</h3>
    <form id="form1" runat="server">
    <div class="container mt-4">
        <h1>Insertar un libro</h1>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Codigo"></asp:Label>
            <asp:TextBox ID="CodigoLibro" runat="server" class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="NombreLibro" runat="server" class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Numero Paginas"></asp:Label>
            <asp:TextBox ID="NumPagLibro" runat="server" class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="Autor"></asp:Label>
            <asp:TextBox ID="AutorLibro" runat="server" class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label5" runat="server" Text="Editorial"></asp:Label>
            <asp:TextBox ID="EditorialLibro" runat="server" class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label6" runat="server" Text="Area"></asp:Label>
            <asp:DropDownList ID="AreasSelect" runat="server" class="btn btn-success dropdown-toggle">
            </asp:DropDownList> 
        </div>        
        <div class="form-group">
            <asp:Button ID="InsertarLibro" runat="server" Text="Insertar" OnClick="InsertarLibro_Click" class="btn btn-success" />
            <a href="../../default.aspx" class="btn btn-success">Volver al Inicio</a>
        </div>
        <asp:GridView ID="TablaLibros" runat="server" AutoGenerateColumns="false"  class="table table-striped" Height="123px" Width="567px" >
            <Columns>
            <asp:BoundField HeaderText="Codigo" Datafield="libCodigo"/>
            <asp:BoundField HeaderText="Nombre" Datafield="libNombre"/>
            <asp:BoundField HeaderText="Autor" Datafield="libAutor" />
            <asp:BoundField HeaderText="Editorial" Datafield="libEditorial" />
            <asp:BoundField HeaderText="Area" Datafield="libArea" />   
            </Columns>
        </asp:GridView>
    </div>
    </form>

<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
</body>
</html>
