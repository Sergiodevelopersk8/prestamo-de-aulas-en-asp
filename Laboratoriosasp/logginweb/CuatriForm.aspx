<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CuatriForm.aspx.cs" Inherits="logginweb.CuatriForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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

<h2>Formulario de alta</h2>

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
       --%> <asp:DropDownList ID="Listascuatri" runat="server" Height="58px" Width="208px">
                    <asp:ListItem>Primero</asp:ListItem>
                    <asp:ListItem>Segundo</asp:ListItem>
                    <asp:ListItem>Tercero</asp:ListItem>
                    <asp:ListItem>Cuarto</asp:ListItem>
                    <asp:ListItem>Quinto</asp:ListItem>
                    <asp:ListItem>Sexto</asp:ListItem>
                    <asp:ListItem>Septimo</asp:ListItem>
                    <asp:ListItem>Octavo</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                    
      <%--  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>--%>
      <label for="carer">cuatrimestre</label>
    </span>
          </li>
      </ul>
  </div>

  <p class="ayuda">No te olvides de escribir también tu segundo apellido</p>
</li>

<li>
  &nbsp;<div>
     
  
      <br />
      <ul>
          <li>
 <span>
   <%--   <input id="codigopostal" name="codigopostal" value="" />--%>
    <%-- <asp:DropDownList ID="yeardd" runat="server"></asp:DropDownList>
     --%> &nbsp;</span></li>
      </ul>
   

    <span>
       <%-- <asp:TextBox ID="fechainicio" runat="server" TextMode="Date"></asp:TextBox>--%>

        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
            <WeekendDayStyle BackColor="#CCCCFF" />
      </asp:Calendar>
         
     <%-- <input id="municipio" name="municipio" value="" />--%>
      <label for="turn">fecha_inicio</label>
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
        <%--<asp:TextBox ID="finfecha" runat="server" TextMode="Date"></asp:TextBox>--%>
        <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
            <WeekendDayStyle BackColor="#CCCCFF" />
      </asp:Calendar>
              <label for="telefonofijo">Fecha_Fin</label>
      
    </span>
  </div>

  <p class="ayuda">Asegúrate de que sea válido</p>
</li>


   <%-- <li>

    </li>--%>
<li>
 <%-- <input id="alta" type="submit" value="Darme de alta &rarr;" />--%>
    
    <asp:Button ID="Button2" runat="server" Text="Insertar" OnClick="Button2_Click" />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
   <div id="TodosHorarios">
    <asp:GridView ID="GridView1" runat="server" CssClass="TablasView" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" >
        <Columns>
            <asp:BoundField DataField="Periodo" HeaderText="Periodo" SortExpression="Periodo" />
            <asp:BoundField DataField="fecha_inicio" HeaderText="fecha_inicio" SortExpression="fecha_inicio" />
            <asp:BoundField DataField="fecha_fin" HeaderText="fecha_fin" SortExpression="fecha_fin" />
        </Columns>
   
    </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:abril2ConnectionString3 %>" SelectCommand="SELECT [Periodo], [fecha_inicio], [fecha_fin] FROM [cuatrimestre]"></asp:SqlDataSource>
        </div>
    <br />
    <br />
    <br />
    <br />
</li>

</ul>
           <ul>
               <li>
                    <div>
        </div>
               </li>
           </ul>
    </form>
</body>
</html>
