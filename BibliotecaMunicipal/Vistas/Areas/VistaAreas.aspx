<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VistaAreas.aspx.cs" Inherits="BibliotecaMunicipal.Vistas.VistaAreas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <title>Insertar Area</title>
</head>
<body>
         <h3 class="text-center mt-5">Sistema de Gestion de Prestamos de Libros de la Biblioteca Municipal</h3>
    <form id="form1" runat="server">
    <div class="container mt-4">
        <h1>Insertar un area</h1>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Codigo Area"></asp:Label>
            <asp:TextBox ID="CodigoArea" runat="server" class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Nombre Area"></asp:Label>
            <asp:TextBox ID="NombreArea" runat="server" class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Tiempo Area"></asp:Label>
            <asp:TextBox ID="TiempoArea" runat="server" class="form-control"></asp:TextBox> <br />
        </div>
        <div class="from-group">
            <asp:Button ID="InsertarArea" runat="server" OnClick="Button1_Click" Text="Insertar" class="btn btn-success"/>
            <a href="../../default.aspx" class="btn btn-success">Volver al Inicio</a>
        <div class="form-group">
             <br />
             s<br />
                  <asp:GridView ID="TableAllAreas" runat="server" AutoGenerateColumns="false" cellpadding="3" class="table table-striped" Height="123px" Width="567px" >
                      <Columns>
                          <asp:BoundField HeaderText="Codigo" DataField="areCodigo" />
                          <asp:BoundField HeaderText="Nombre" DataField="areNombre" />
                          <asp:BoundField HeaderText="Tiempo" DataField="areTiempo" />
                      </Columns>
                   </asp:GridView>
        </div>
      
    </div>
    </form>

<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
</body>
</html>
