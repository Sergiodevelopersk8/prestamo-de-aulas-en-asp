<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profesform.aspx.cs" Inherits="logginweb.Profesform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link rel="stylesheet" href="parabotones/hojaprofes.css">
    <link rel="stylesheet" href="parabotones/estilopavdos.css">
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
            background: url(/Imagenes/pccolor.gif);
            padding: 5px;
            color: red;
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
    <nav>
           
            <ul>
               
                <li><a href='menulabora.aspx'><span class="primero"><i class="icon icon-home"></i></span>Inicio</a>
               </ul>
        </nav>
    <form id="form1" runat="server">
       <h2>Formulario Profe</h2>

<%--<form method="post" action="#">--%>
<ul>
<li>
  <label class="titulo" for="nombre">Nombre y apellidos <span class="requerido">*</span></label>
  <div>
    <span>
        
     <asp:TextBox ID="Txtnombrep" runat="server" Width="186px"></asp:TextBox>
      <label for="nombre">Nombre</label>
    </span>

    <span>
        
    
        <asp:TextBox ID="Txtapellidop1" runat="server"></asp:TextBox>
      <label for="apellido1">Primer apellido</label>
    </span>

    <span>
     <%-- <input id="apellido2" name="apellido2" value="" />--%>
          <%--<asp:TextBox ID="Txtapellido2" runat="server" OnTextChanged="Txtapellido2_TextChanged" Height="19px" Width="247px"></asp:TextBox>--%>
        <asp:TextBox ID="Txtapellidop2" runat="server"></asp:TextBox>
      <label for="apellido2">Segundo apellido</label>
    </span>
  </div>

  <p class="ayuda">No te olvides de escribir también tu segundo apellido</p>
</li>

<li>
 
  <div>
    <span>
     <%-- <input id="direccion" name="direccion" value="" />
       --%> 
      
    </span>

    <span>
   <%--   <input id="codigopostal" name="codigopostal" value="" />--%>
        <asp:TextBox ID="Txtmatriculap" runat="server"></asp:TextBox>
      <label for="matri">Matricula</label>
        
      <li>
          <asp:Button ID="Button1" runat="server" Text="Insertar" OnClick="Button1_Click" />
      </li>
          
         <ul>
               <li>
                    <div>
            <table>
                <tr>
                    <td style="background-image: url('Imagenes/1.gif'); text-align: center; font-weight: 700; font-size: x-large; color: #FFFFFF;">
                        Profesores</td>
                </tr>
                <tr>
                    <td style="background-image: url('Imagenes/2.gif')">
                        <asp:GridView ID="GridDatosRegistro" AutoGenerateColumns="False" runat="server" CellPadding="20" ForeColor="#333333" GridLines="None" Width="426px" OnSelectedIndexChanged="GridDatosRegistro_SelectedIndexChanged">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:TemplateField HeaderText="Id">
                                    <ItemStyle Width="80px" HorizontalAlign="Center" />
                                    <ItemTemplate>
                                        <a href="http://www.sistemasddm.blogspot.com" target="_BLANK" class="grilla">
                                            <%# Eval("IdProfesor")%> </a>
                                        <div id="tooltip" style="display: none;">
                                            <table>
                                                <tr>
                                                    <td style="white-space: nowrap;"><b>Nombre_P:</b>&nbsp;</td>
                                                    <td><%# Eval("Nombre_P")%></td>
                                                </tr>
                                                <tr>
                                                    <td style="white-space: nowrap;"><b>Apellido_P:</b>&nbsp;</td>
                                                    <td><%# Eval("Apellido_P")%></td>
                                                </tr>
                                                <tr>
                                                    <td style="white-space: nowrap;"><b>Apellido_M:</b>&nbsp;</td>
                                                    <td><%# Eval("Apellido_M")%></td>
                                                </tr>
                                                <tr>
                                                    <td style="white-space: nowrap;"><b>Matricula:</b>&nbsp;</td>
                                                    <td><%# Eval("Matricula")%></td>
                                                </tr>
                                               <%-- <tr>
                                                    <td style="white-space: nowrap;"><b>Cargo:</b>&nbsp;</td>
                                                    <td><%# Eval("cargo")%></td>
                                                </tr>
                                                <tr>
                                                    <td style="white-space: nowrap;"><b>Estado:</b>&nbsp;</td>
                                                    <td><%# Eval("estado")%></td>
                                                </tr>
                                                <tr>
                                                    <td style="white-space: nowrap;"><b>Fecha:</b>&nbsp;</td>
                                                    <td><%# Eval("fecha")%></td>
                                                </tr>--%>
                                            </table>
                                        </div>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="Nombre_P" DataField="Nombre_P">
                                    <ItemStyle Width="130px" />
                                </asp:BoundField>
                                <asp:BoundField HeaderText="Apellido_P" DataField="Apellido_P">
                                    <ItemStyle Width="200px" />
                                </asp:BoundField>
                                <asp:BoundField HeaderText="Apellido_M" DataField="Apellido_M">
                                    <ItemStyle Width="100px" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Nombre_P" HeaderText="Nombre_P" Visible="False" />
                                <asp:BoundField DataField="Apellido_P" HeaderText="Apellido_P" Visible="False" />
                                <asp:BoundField DataField="Apellido_M" HeaderText="Apellido_M" Visible="False" />
                                <%--<asp:BoundField DataField="cargo" HeaderText="Cargo" Visible="False" />--%>
                            </Columns>
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td style="background-image: url('Imagenes/1.gif')">&nbsp;
                    </td>
                </tr>
            </table>
        </div>
               </li>
           </ul>
    </span>
     
    </form>
</body>
</html>
