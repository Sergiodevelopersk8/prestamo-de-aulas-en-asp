<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alumnoform.aspx.cs" Inherits="logginweb.Alumnoform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       <link rel="stylesheet" href="parabotones/Alumnosfc.css"/>
    <link rel="stylesheet" href="parabotones/estilopavdos.css"/>
    <link rel="stylesheet" href="parabotones/gridhoja.css"/>
    
    <link rel="stylesheet" href="parabotones/fonts/style.css"/>
   
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

<h2>Formulario de alta</h2>

<%--<form method="post" action="#">--%>
<ul>
<li>
  <label class="titulo" for="nombre">Nombre y apellidos <span class="requerido">*</span></label>
  <div>
    <span>
     <asp:TextBox ID="Txtnombre" runat="server" Width="186px"></asp:TextBox>
      <label for="nombre">Nombre</label>
    </span>

    <span>
      <%--<input id="apellido1" name="apellido1" value="" />--%>
        <asp:TextBox ID="Txtapellido1" runat="server"></asp:TextBox>
      <label for="apellido1">Primer apellido</label>
    </span>

    <span>
     <%-- <input id="apellido2" name="apellido2" value="" />--%>
          <%--<asp:TextBox ID="Txtapellido2" runat="server" OnTextChanged="TextBox2_TextChanged" Height="19px" Width="247px"></asp:TextBox>--%>
        <asp:TextBox ID="Txtapellido2" runat="server"></asp:TextBox>
      <label for="apellido2">Segundo apellido</label>
    </span>
  </div>

  <p class="ayuda">No te olvides de escribir también tu segundo apellido</p>
</li>

<li>
  &nbsp;<div>
    <span>
     <%-- <input id="direccion" name="direccion" value="" />
       --%> &nbsp;</span><span><%--   <input id="codigopostal" name="codigopostal" value="" />--%><asp:TextBox ID="Txtmatricula" runat="server"></asp:TextBox>
      <label for="matri">Matricula</label>
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
        <%--<asp:DropDownList ID="Listgrupo" runat="server" Width="138px">

      </asp:DropDownList>--%>
        <asp:DropDownList ID="Dropgrup" runat="server"></asp:DropDownList>
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
                    <div id="TodosHorarios">
          
              
                        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1"  CssClass="TablasView">
                            <Columns>
                                <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                                <asp:BoundField DataField="apellidoP" HeaderText="apellidoP" SortExpression="apellidoP" />
                                <asp:BoundField DataField="apellidoM" HeaderText="apellidoM" SortExpression="apellidoM" />
                                <asp:BoundField DataField="Matricula" HeaderText="Matricula" SortExpression="Matricula" />
                            </Columns>
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:abril2ConnectionString3 %>" SelectCommand="SELECT [nombre], [apellidoP], [apellidoM], [Matricula] FROM [Alumno]"></asp:SqlDataSource>
                        <asp:EntityDataSource ID="EntityDataSource1" runat="server">
                        </asp:EntityDataSource>
          
              
        </div>
               </li>
           </ul>
    </form>
</body>
</html>
