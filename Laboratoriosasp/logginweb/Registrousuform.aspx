<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrousuform.aspx.cs" Inherits="logginweb.Registrousuform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="parabotones/Regishoja.css">
    <link rel="stylesheet" href="parabotones/estilopavdos.css">
    <link rel="stylesheet" href="parabotones/fonts/style.css">
    <title></title>
</head>
     <nav>
           
            <ul>
               
                <li><a href='menulabora.aspx'><span class="primero"><i class="icon icon-home"></i></span>Inicio</a>
               </ul>
        </nav>
<body>
    <form id="form1" runat="server">
         <div id="contenedor">

<h2>Formulario&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Registrar&nbsp; Usuario</h2>

<%--<form method="post" action="#">--%>
<ul>
<li>
 
  <div>
  <%--  <span>
     <asp:TextBox ID="Txtnombre" runat="server" Width="186px"></asp:TextBox>
      <label for="nombre">Periodo</label>
    </span>--%>

    <span>
      <%--<input id="apellido1" name="apellido1" value="" />--%>
    <%--    <asp:TextBox ID="Txtapellido1" runat="server"></asp:TextBox>
      <label for="apellido1">Primer apellido</label>--%>
    </span>

   <ul>
          <li>
          </li>
      </ul>
  </div>

  <p class="ayuda">No te olvides de escribir también tu segundo apellido</p>
</li>

<li>
  

  <div>
     
  
      <br />
      <ul>
          <li>
 <span>
   <%--   <input id="codigopostal" name="codigopostal" value="" />--%>
        <asp:TextBox ID="Txtnombreusu" runat="server"></asp:TextBox>
    <%-- <asp:DropDownList ID="yeardd" runat="server"></asp:DropDownList>
     --%> <label for="matri">Usuario</label>
    </span>
          </li>
      </ul>
   

    <span>
        <%--<asp:TextBox ID="fechainicio" runat="server"></asp:TextBox>--%>
     <%-- <input id="municipio" name="municipio" value="" />--%>
         <asp:TextBox ID="Txtcontrase" runat="server"></asp:TextBox>
      <label for="turn">Password</label>
    </span>

    <span>
     
    </span>

    <span>
     <%-- <select id="pais" name="pais">
        <option value=""></option>
       <%-- <option value="pais1">País 1</option>
        <option value="pais2">País 2</option>
        <option value="pais3">País 3</option
      </select>--%>
     <%-- <label for="grup">Grupo</label>--%>
       
    </span>
  </div>

  <p class="ayuda">El código postal es imprescindible para poder recibir los pedidos</p>
</li>

<li>
 

  <div>
    <span>
       <%-- <asp:TextBox ID="finfecha" runat="server" TextMode="Date"></asp:TextBox>--%>
        <asp:TextBox ID="Txtverificar" runat="server"></asp:TextBox>
              <label for="telefonofijo">Verificar password</label>
      
    </span>
  </div>

  <p class="ayuda">Asegúrate de que sea válido</p>
</li>


   <%-- <li>

    </li>--%>
<li>
 <%-- <input id="alta" type="submit" value="Darme de alta &rarr;" />--%>
  <li>
    
  </li>  <br />
    <asp:Button ID="Button2" runat="server" Text="Insertar" OnClick="Button2_Click" />
</li>

</ul>
           <ul>
               <li>
                    <div>
        </div>
    </form>
    </form>
    
</body>
</html>
