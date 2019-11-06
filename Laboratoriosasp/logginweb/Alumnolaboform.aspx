<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alumnolaboform.aspx.cs" Inherits="logginweb.Alumnolaboform" %>

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
                    <asp:DropDownList ID="Listascuatric" runat="server" OnSelectedIndexChanged="Listascuatric_SelectedIndexChanged"></asp:DropDownList>
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
     <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
  &nbsp;&nbsp;
  </span>

          </li>
      </ul>
   
      <ul>
          <li>
              <span>
                  <%--<asp:DropDownList ID="DropDownList1" runat="server">
                      <asp:ListItem>9:00am-10:00am</asp:ListItem>
                      <asp:ListItem>11:00am-1:00pm</asp:ListItem>
                      <asp:ListItem>2:00pm-3:00pm</asp:ListItem>
                      <asp:ListItem>6:00pm-7:00pm</asp:ListItem>
              </asp:DropDownList>--%>
                   <%--<label for="carer">Horario disponible</label>--%>

                                </span>
              <asp:DropDownList ID="diasdrop" runat="server">
              </asp:DropDownList>
              <label>dias</label>
          </li>
      </ul>

      <ul>
          <li>
              <span>
                  <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
                   <label for="carer">Aula</label>

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
                        <asp:Image ID="imgBarra" runat="server" Height="156px" Width="658px" />
    
                        <br />
                        <br />
                        <br />
                       <%-- <input id="Fecha_inicio" runat="server" type="date" />--%>
                        <br />
    
      <asp:Label ID="Label1" runat="server" Text="alumno"></asp:Label>      
    <br />
      <br />
      <asp:Label ID="Label2" runat="server" Text="alumno"></asp:Label>      
    
      <br />
    
 </li></ul>
</li>
    
        <div id="TablaAlumnos">
            <asp:GridView ID="GridView1" runat="server" class="TablasView" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AllowPaging="True">
                <Columns>
                    <asp:CommandField ButtonType="Image" SelectImageUrl="~/Imagenes/button_blank_blue_14984.png" ShowSelectButton="True" />
                </Columns>
        </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView4" runat="server" AllowPaging="True" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" OnSelectedIndexChanged="GridView4_SelectedIndexChanged" OnSelectedIndexChanging="GridView4_SelectedIndexChanging" PageSize="3" AllowSorting="True">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                <SortedAscendingCellStyle BackColor="#F4F4FD" />
                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                <SortedDescendingCellStyle BackColor="#D8D8F0" />
                <SortedDescendingHeaderStyle BackColor="#3E3277" />
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
        


        <div id="TablaAlumnos1">
            <asp:GridView ID="GridView2" runat="server"  class="TablasView" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" >
                <Columns>
                    <asp:CommandField ButtonType="Image" SelectImageUrl="~/Imagenes/button_blank_blue_14984.png" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView5" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" OnSelectedIndexChanged="GridView5_SelectedIndexChanged" AllowPaging="True" OnSelectedIndexChanging="GridView5_SelectedIndexChanging">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <Columns>
                    <asp:CommandField ButtonType="Image" ShowSelectButton="True" UpdateImageUrl="~/Imagenes/button_blank_blue_14984.png" />
                </Columns>
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                <SortedAscendingCellStyle BackColor="#F4F4FD" />
                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                <SortedDescendingCellStyle BackColor="#D8D8F0" />
                <SortedDescendingHeaderStyle BackColor="#3E3277" />
            </asp:GridView>
            <br />
            <br />
            <br />
        </div>

    <li>
    <asp:Button ID="Button1" runat="server" Text="Generar codigo" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="regisprest" runat="server" Text="prestar" OnClick="regisprest_Click" Width="178px" />
</li>

</ul>
           <ul>
               <li>
                    <div>
                        <asp:GridView ID="GridView3" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" DataKeyNames="ID Alumno" DataSourceID="SqlDataSource1" GridLines="None" OnSelectedIndexChanged="GridView3_SelectedIndexChanged">
                            <Columns>
                                <asp:BoundField DataField="ID Alumno" HeaderText="ID Alumno" InsertVisible="False" ReadOnly="True" SortExpression="ID Alumno" />
                                <asp:BoundField DataField=" prestamos" HeaderText=" prestamos" ReadOnly="True" SortExpression=" prestamos" />
                                <asp:BoundField DataField="Matricula" HeaderText="Matricula" SortExpression="Matricula" />
                                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                                <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                            </Columns>
                            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#594B9C" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#33276A" />
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:abril2ConnectionString3 %>" SelectCommand="MayorPrestamoFechass" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
        </div>
          </div>
          <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    </form>
</body>
</html>
