<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cuatriregisform.aspx.cs" Inherits="logginweb.Cuatriregisform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       <link rel="stylesheet" href="parabotones/estilocuatricss.css">
    <link rel="stylesheet" href="parabotones/estilopavdos.css">
    <link rel="stylesheet" href="parabotones/fonts/style.css">
    <title></title>
       <style type="text/css">
           #provincia {
               width: 55px;
           }
           #pais {
               width: 60px;
           }
       </style>
</head>
<body>
   <%-- <asp:Button ID="Button2" runat="server" Text="Button" />--%>
     <nav>
           
            <ul>
               
                <li><a href='menulabora.aspx'><span class="primero"><i class="icon icon-home"></i></span>Inicio</a>
               </ul>
        </nav>
                
    <form id="form1" runat="server">
       <div id="contenedor">

<h2>Formulario de registro de cuatri</h2>

<%--<form method="post" action="#">--%>
<ul>
<li>
<%--  <label class="titulo" for="nombre">Nombre y apellidos <span class="requerido">*</span></label>--%>
  <div>
    <span>
     
       
      <label for="nombre">Periodo</label>
         <asp:DropDownList ID="comboperiodo" runat="server"></asp:DropDownList>
       <label for="yerad">año</label>
        <asp:TextBox ID="Txtyear" runat="server"></asp:TextBox>
    </span>

    <span>
      <%--<input id="apellido1" name="apellido1" value="" />
       <br />
        <br />
        <%-- <label for="yerad">año</label>
        <asp:TextBox ID="Txtyear" runat="server"></asp:TextBox>--%>

     
    </span>

    <span>
     <%-- <input id="apellido2" name="apellido2" value="" />--%>
        <label for="fechin">&nbsp; Fecha de Inicio</label>
      <asp:TextBox ID="Txtfechainicio" runat="server" OnTextChanged="Txtfechainicio_TextChanged" Height="19px" Width="155px" TextMode="Date"></asp:TextBox>
       <label for="fechin">&nbsp; Fecha Final</label>
        <asp:TextBox ID="Txtfechafin" runat="server" TextMode="Date"></asp:TextBox><br />
        <label for="anon">&nbsp; Extra anotacion</label>
        </span>
  </div>

<%--  <p class="ayuda">No te olvides de escribir también tu segundo apellido</p>--%>
</li>

<li>
 <%-- <label class="titulo" for="direccion">Carrera <span class="requerido">*</span></label>--%>

  <div>
    <span>
     <%-- <input id="direccion" name="direccion" value="" />
       --%> 
    </span>

    <span>
   <%--   <input id="codigopostal" name="codigopostal" value="" />--%>
        
    </span>

    <span>
      
    </span>

    <span>
      <%--<select id="provincia" name="provincia">
        <option value=""></option>
       <option value="provincia1">Provincia 1</option>
        <option value="provincia2">Provincia 2</option>
        <option value="provincia3">Provincia 3</option>
      </select>--%>
      <%--<label for="catri">Cuatrimestre</label>--%>
    </span>

    <span>
     <%-- <select id="pais" name="pais">
        <option value=""></option>
       <%-- <option value="pais1">País 1</option>
        <option value="pais2">País 2</option>
        <option value="pais3">País 3</option>
      </select>--%>
      <%--<label for="grup">Grupo</label>--%>
    </span>
  </div>

  <%--<p class="ayuda">El código postal es imprescindible para poder recibir los pedidos</p>--%>
</li>

<li>
  <%--<label class="titulo" for="email">Email</label>--%>

  <div>
    <span>
     <%-- <input id="email" name="email" value="" />--%>
    </span>
  </div>

 <%-- <p class="ayuda">Asegúrate de que sea válido</p>--%>
</li>

<li>
  <%--<label class="titulo" for="telefonofijo">Teléfono <span class="requerido">*</span></label>--%>

  <div>
    <span>
     <%-- <input id="telefonofijo" name="telefonofijo" value="" />
      <label for="telefonofijo">Fijo</label>--%>
    </span>

    <span>
     <%-- <input id="telefonomovil" name="telefonomovil" value="" />
      <label for="telefonomovil">Móvil</label>--%>
    </span>
  </div>

<%--  <p class="ayuda">Sin prefijo de país y sin espacios en blanco</p>--%>
</li>
   <%-- <li>

    </li>--%>
<li>
 <%-- <input id="alta" type="submit" value="Darme de alta &rarr;" />--%><asp:Button ID="Button1" runat="server" Text="Insertar" OnClick="Button1_Click" />
</li>

</ul>
    </form>
</body>
</html>

