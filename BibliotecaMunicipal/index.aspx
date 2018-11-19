<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="BibliotecaMunicipal.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <link rel="stylesheet" href="estilos/estilos.css">
    <title></title>
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-sm" >
                <img src="imagenes/imagen1.jpg" alt="imagen1">
            </div>
            <div class="col-sm">
                <h1>Biblioteca Municipal</h1>
            </div>
            <div class="col-sm-3" >
                <img src="imagenes/imagen2.jpeg" alt="imagen2">
            </div>
        </div>

       <nav class="navbar navbar-expand-lg navbar-light bg-success mt-3">
        <a class="navbar-brand text-white" href="#">INICIO</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>
      
        <div class="collapse navbar-collapse" id="navbarSupportedContent">
          <ul class="navbar-nav mr-auto">
            <li class="nav-item dropdown">
                <a class="nav-link dropdown-toggle text-white" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                  Areas
                </a>
                <div class="dropdown-menu" aria-labelledby="navbarDropdown">
                  <a class="dropdown-item" href="Vistas/VistaAreas.aspx">Ingresar Nueva Area</a>
                  <a class="dropdown-item" href="#">Consultar Area</a>
                  <a class="dropdown-item" href="#">Modificar Area</a>
                  <a class="dropdown-item" href="#">Eliminar Area</a>
              </li>
              <li class="nav-item dropdown">
                <a class="nav-link dropdown-toggle text-white" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                  Libros
                </a>
                <div class="dropdown-menu" aria-labelledby="navbarDropdown">
                  <a class="dropdown-item" href="#">Ingresar Nuevos Libros</a>
                  <a class="dropdown-item" href="#">Consultar Libros</a>
                  <a class="dropdown-item" href="#">Modificar Libros</a>
                  <a class="dropdown-item" href="#">Eliminar Libros</a>
                </div>
              </li>
              <li class="nav-item dropdown">
                <a class="nav-link dropdown-toggle text-white" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                  Prestamos
                </a>
                <div class="dropdown-menu" aria-labelledby="navbarDropdown">
                  <a class="dropdown-item" href="#">Action</a>
                  <a class="dropdown-item" href="#">Another action</a>
              </li>
            <li class="nav-item dropdown">
              <a class="nav-link dropdown-toggle text-white" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                Sanciones
              </a>
              <div class="dropdown-menu" aria-labelledby="navbarDropdown">
                <a class="dropdown-item" href="#">Action</a>
                <a class="dropdown-item" href="#">Another action</a>
            </li>
            <li class="nav-item dropdown">
                <a class="nav-link dropdown-toggle text-white" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                  Usuarios
                </a>
                <div class="dropdown-menu" aria-labelledby="navbarDropdown">
                  <a class="dropdown-item" href="#">Ingresar Nuevos Usuarios</a>
                  <a class="dropdown-item" href="#">Consultar Usuarios</a>
                  <a class="dropdown-item" href="#">Modificar Usuarios</a>
                  <a class="dropdown-item" href="#">Eliminar Usuarios</a>
                </div>
              </li>
          </ul>
        </div>
      </nav> 

      <h3 class="text-center mt-5">Sistema de Gestion de Prestamos de Libros de la Biblioteca Municipal</h3>

      <p class="text-justify mt-3"><strong>Mision:</strong> La Biblioteca publica municipal, esta comprometida con la implementacion de programas
          tendientes a lograr que la comunidad en general, adquiera el habito de la lectura y que cada usuario lea como minimos
          seis(6) libros por año.
      </p>
      <p class="text-justify "> <strong>Objetivos:</strong> Proporcionar el habito de la lectura. Apoyar la consulta de informacion local
          a los usuarios, manejar la Biblioteca, planear, dirigir y controlar todas las actividades tecnicas de la Biblioteca
          municipal organizar programas de lectura, tertulias literarias y actividades culturales dentro y fuera de la 
          Biblioteca.
      </p>
      <p class="text-justify"><strong>Metas:</strong> Lograr el incremento y sostenimiento de los indices estadisticos, en lo 
          relacionado con la consulta y la lectura en la Biblioteca publica municipal.
      </p>
    </div>

     <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"
        crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49"
        crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy"
        crossorigin="anonymous"></script>
</body>
</html>
