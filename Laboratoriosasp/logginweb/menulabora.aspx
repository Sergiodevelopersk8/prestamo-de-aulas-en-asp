<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menulabora.aspx.cs" Inherits="logginweb.menulabora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="icon" href="imagen avion/aviondos.ico">
<meta charset="UTF-8"> 

<link rel="stylesheet" href="parabotones/fonts/style.css">
 <link rel="stylesheet" href="parabotones/estilopavdos.css">
  <link rel="stylesheet" href="parabotones/redess.css">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
    
h1 span{
color:orangered;
margin-right: 20px;
font-size: 80px;          
font-size: 80px;          
     }   
     h1{
         color:#cd486b;
         font-family:fantasy;
     }
</style>

</head>
<body>
    <form id="form1" runat="server">
        <h1><span class="icon-aircraft"></span> Laboratorios </h1> 
<header>
        <nav>
           
            <ul>
               
                <li><a href='CuatriForm.aspx'><span class="primero"><i class="icon icon-home"></i></span>Cuatrimestre</a>
               
                </li>
                <li><a href='Alumnoform.aspx'><span class="segundo"><i class="icon icon-home"> </i></span>alumno</a>
                  
                    <ul>
                   
                </ul>
                </li>
                <li><a href='Profesform.aspx'><span class="tercero"><i class="icon icon-globe"></i></span>Profe</a>
              <link rel='Profesform.aspx' href='Profesform.aspx'>
                </li>
                <li><a href='ConsultasForm.aspx'><span class="cuarto"><i class="icon icon-credit"></i></span>Consulta</a></li>
                
                <li><a href=' Alumnolaboform.aspx'><span class="quinto"><i class="icon icon-ticket"></i></span>Alaborat</a></li>
                <li>
                   <a href=' Asistenciaprof.aspx'><span class="quinto"><i class="icon icon-ticket"></i></span>Asisprofe</a></li>
                 <li>
                   <a href=' consultas2.aspx'><span class="quinto"><i class="icon icon-ticket"></i></span>consultas2</a></li>
                 <li>
                   <a href=' HorasForm.aspx'><span class="quinto"><i class="icon icon-ticket"></i></span>Horas</a></li>
                 <li>
                   <a href=' Registrousuform.aspx'><span class="quinto"><i class="icon icon-ticket"></i></span>Reg_USUA </a></li>
                
                
            </ul>
        </nav>
        <div class="social">
    <ul>
        <li><a href='' target="_blank" class="icon-facebook"></a></li>
         <li><a href='Alumnolaboform.aspx' target="_blank" class="icon-instagram"></a></li>
          <li><a href='Asistenciaprof.aspx' target="_blank" class="icon-twitter"></a></li>
            <li><a href="https://www.tumblr.com/blog/sersk8cbr" target="_blank" class="icon-tumblr"></a></li>
            <li><a href="mailto:davidcidgar@gmail.com"  class="icon-mail"></a></li>
            <li> <asp:Button ID="Button1" runat="server" Text="Cerrar" OnClick="Button1_Click" /></li>
            
            
    </ul>
    
</div>



</header>

    </form>
</body>
</html>






  

 

 

