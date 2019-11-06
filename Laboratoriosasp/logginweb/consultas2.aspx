<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consultas2.aspx.cs" Inherits="logginweb.consultas2" %>

<!DOCTYPE html>

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

<h2>Formulario de de asistencias</h2>


<ul>
<li>
 
    <br />
  <div>

      <asp:Label ID="Label2" runat="server" Text="Fecha inicial"></asp:Label>
 <br />
       <br />
     
          <asp:TextBox ID="TextBox1" runat="server" Width="237px"></asp:TextBox>
          
         &nbsp;
      <br />
      
          <asp:Label ID="Label1" runat="server" Text="Fecha Final"></asp:Label>
          
         </div>
         
     
          <br />
                    <div>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                        <br />
                        <br />
                        <br />
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
                        <br />
                        <br />
                        <br />
                        <br />
        </div>
               </div>
    </form>
</body>
</html>
