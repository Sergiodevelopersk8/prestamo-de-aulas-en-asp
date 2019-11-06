<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Concentrados.aspx.cs" Inherits="logginweb.Concentrados" %>

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
              <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
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
          </li>
      </ul>
   

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
        &nbsp;</span></div>

  <p class="ayuda">Asegúrate de que sea válido</p>
</li>


   <%-- <li>

    </li>--%>
<li>
 <%-- <input id="alta" type="submit" value="Darme de alta &rarr;" />--%>
  <li>
    
  </li>  <br />
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
