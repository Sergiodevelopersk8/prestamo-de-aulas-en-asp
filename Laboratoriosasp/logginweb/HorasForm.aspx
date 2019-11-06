<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HorasForm.aspx.cs" Inherits="logginweb.HorasForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       <link rel="stylesheet" href="parabotones/Alumnosfc.css"/>
    <link rel="stylesheet" href="parabotones/estilopavdos.css"/>
    <link rel="stylesheet" href="parabotones/fonts/style.css"/>
    <link rel="stylesheet" href="parabotones/gridhoja.css"/>
   
    <title></title>
    <script src="Script_Jquery/jquery-1.8.2.js" type="text/javascript"></script>
    <script src="Script_Jquery/jquery-tooltip/jquery.tooltip.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        function InitializeToolTip() {
            $(".grilla").tooltip({
                track: true,
                delay: 0,
                showURL: false,
                fade: 100,
                bodyHandler: function () {
                    return $($(this).next().html());
                },
                showURL: false
            });
        }
    </script>
    <script type="text/javascript">
        $(function () {
            InitializeToolTip();
        })
    </script>
    <style type="text/css">
        #tooltip {
            position: absolute;
            z-index: 3000;
            border: 1px solid #111;
            background: url(/Imagenes/1.gif);
            padding: 5px;
            color: White;
            border-radius: 10px;
            width: 350px;
            border: 0px;
            font-size: 18px;
        }

            #tooltip h3, #tooltip div {
                margin: 0;
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

<h2>Formulario de Horas</h2>

<%--<form method="post" action="#">--%>
<ul>
<li>
  &nbsp;<div>
    <span>
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
      <label for="nombre">Laboratorio</label>
    </span>

    <span>
      <%--<input id="apellido1" name="apellido1" value="" />--%>
        <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
      <label for="apellido1">Profesor</label>
    </span>

    <span>
     <%-- <input id="apellido2" name="apellido2" value="" />--%>
          <%--<asp:TextBox ID="Txtapellido2" runat="server" OnTextChanged="TextBox2_TextChanged" Height="19px" Width="247px"></asp:TextBox>--%>
        <asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList>
      <label for="apellido2">Horas</label>&nbsp;&nbsp;
    </span>
  </div>

  <p class="ayuda">No te olvides de escribir también tu segundo apellido</p>
</li>

<li>
  &nbsp;<div>
    <span>
     <%-- <input id="direccion" name="direccion" value="" />
       --%> &nbsp;</span><span><asp:DropDownList ID="DropDownList4" runat="server"></asp:DropDownList>
      <label for="matri">Materias</label>
    </span>

    <span>&nbsp;
    </span>

    <span>
    
    </span>
  </div>

  <p class="ayuda">El código postal es imprescindible para poder recibir los pedidos</p>
</li>

<li>
  

  <div>
    <span>
        <asp:DropDownList ID="Listgrupo" runat="server" Width="138px">

      </asp:DropDownList>
        <option value=""></option>
       <%-- <option value="pais1">País 1</option>
        <option value="pais2">País 2</option>
        <option value="pais3">País 3</option>--%>
      </select>
      <label for="grup">Grupo</label>
    </span>
  </div>

  <p class="ayuda">Asegúrate de que sea válido</p>
</li>

<li>
  

  <div>
   

      <asp:DropDownList ID="DropDownList5" runat="server" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged"></asp:DropDownList>
      <br />
      <br />
      <br />
      <br />
      <div id="TodosHorarios">
        
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:abril2ConnectionString3 %>" SelectCommand="SELECT [Hora_Entrada_Salida], [AMoPM] FROM [Horario]"></asp:SqlDataSource>
      </div>
      <br />
  </div>

  <p class="ayuda">Sin prefijo de país y sin espacios en blanco</p>
</li>
   <%-- <li>

    </li>--%>
<li>
 <%-- <input id="alta" type="submit" value="Darme de alta &rarr;" />--%><asp:Button ID="Button1" runat="server" Text="Insertar" OnClick="Button1_Click" />
</li>

</ul>
           <ul>
               <li>
                    <div>
          
              
        </div>
               </li>
           </ul>
    </form>
</body></html>
