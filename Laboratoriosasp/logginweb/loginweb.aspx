<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginweb.aspx.cs" Inherits="logginweb.loginweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="icon" href="parabotones/sobrasshtml/sharingan.png">
   <link rel="stylesheet" href="parabotones/fonts/style.css">
<link href="https://fonts.googleapis.com/css?family=Great+Vibes|Pacifico" rel="stylesheet">
<link rel="stylesheet" href="parabotones/paralog.css">
<%-- <link rel="stylesheet" href="parabotones/redess.css">--%>

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="contenedor">
<header>
<h1 class="title">Skaters</h1>
<%--<a href='Registrousuform.aspx'>Registrarte</a>--%>
</header>
<div id="login">
<article id="fondo">
     <img src="parabotones/sobrasshtml/spidy.jpg" alt="User">
    <h3>Inicio de Sesión</h3>
    <%--<div class="login">
<article class="fondo"> %>
    <img src="parabotones/sobrasshtml/spidy.jpg" alt="User">
    <h3>Inicio de Sesión</h3>
   <%--<form class="" action="projectoavion2.html" method="post" href="projectoavion2.html">
       
    </form>--%>
    <%-- <span class="icon-user"></span><input class="inp" type="text" name="user" value="" runat="server"><br>--%>
  <span class="icon-user"></span> <asp:TextBox ID="TextBox1"  type="text" name="user" value="" runat="server"></asp:TextBox>
    <span class="icon-key"></span><asp:TextBox ID="TextBox2"  type="password" name="pass" value=""   runat="server"></asp:TextBox>
         <%--<span class="icon-key"></span><input class="inp" type="password" name="pass" value="" runat="server">--%><br>
       <%--  <a href="" class="he">He olvidado mi contraseña</a>--%>
        <%-- <input class="boton" type="submit" name="inicio" value="Iniciar sesión">--%>
    <asp:Button ID="Button1" runat="server" Text="Inicio" OnClick="Button1_Click1" />

</article>    
</div>   
    </div>
    </form>
</body>
</html>
