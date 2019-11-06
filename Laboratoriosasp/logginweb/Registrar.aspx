<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="logginweb.Consultasdos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="parabotones/cuatrihoja.css">
    <link rel="stylesheet" href="parabotones/estilopavdos.css">
    <link rel="stylesheet" href="parabotones/fonts/style.css">
    <title></title>
</head>
<body>
     <nav>
           
            <ul>
               
                <li><a href='menulabora.aspx'><span class="primero"><i class="icon icon-home"></i></span>Inicio</a>
               </ul>
        </nav>
    <form id="form1" runat="server">
          <div id="contenedor">

<h2>Formulario de prestar</h2>

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
                <span>
     <%-- <input id="direccion" name="direccion" value="" />
       --%> <%--<asp:DropDownList ID="Listascuatric" runat="server" Height="25px" Width="208px"></asp:DropDownList>--%>
      <%--  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>--%>
      <label for="carer">Matricula</label>
    </span>
          </li>
      </ul>
  </div>

  
</li>

<li>
  

  <div>
     
  
      <br />
      <ul>
          <li>
 <span>
   <%--  <asp:DropDownList ID="Listaaula" runat="server" Height="22px" Width="179px"></asp:DropDownList>
       <label for="carer">Aula</label>--%>
  </span>

          </li>
      </ul>
   
      <ul>
          <li>
              <span>
                   <label for="carer">Horario disponible</label>

                                </span>
          </li>
      </ul>

      <ul>
          <li>
              <span>
                  <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
                   <label for="carer">Aula</label>&nbsp;&nbsp;

          </li>
      </ul>
    
      </div>

  <p class="ayuda">El código postal es imprescindible para poder recibir los pedidos</p>
</li>

<li>
 

  <div>
  </div>

  <p class="ayuda">Asegúrate de que sea válido</p>
</li>


   <%-- <li>

    </li>--%>
    <br />
    <br />
<li>
 <%-- <input id="alta" type="submit" value="Darme de alta &rarr;" />--%>
  <ul>  
  <li>
                        <asp:Image ID="imgBarra" runat="server" Height="249px" Width="450px" />
    
                        <br />
                        <br />
                        <br />
                        <asp:TextBox ID="TextBox_alumno" runat="server"></asp:TextBox>
                        <br />
    
 </li></ul>
</li>
    <li>
        <div id="TablaAlumnos">
            <asp:GridView ID="GridView1" runat="server" class="TablasView" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ButtonType="Image" SelectImageUrl="~/Imagenes/button_blank_blue_14984.png" ShowSelectButton="True" />
                </Columns>
        </asp:GridView>
        </div>
        
</li>
    <li>
        <div id="TablaAlumnos0">
            <asp:GridView ID="GridView2" runat="server"  class="TablasView" >
                <Columns>
                    <asp:CommandField ButtonType="Image" SelectImageUrl="~/Imagenes/button_blank_blue_14984.png" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
</li>
    <li>
    <asp:Button ID="Button1" runat="server" Text="Generar codigo" OnClick="Button1_Click" />
</li>

</ul>
           <ul>
               <li>
                    <div>
        </div>
    </form>
</body>
</html>
