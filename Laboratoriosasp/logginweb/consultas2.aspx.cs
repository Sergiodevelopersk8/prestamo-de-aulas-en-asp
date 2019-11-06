using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModeloSql;
using System.Text.RegularExpressions;

namespace logginweb
{
    public partial class consultas2 : System.Web.UI.Page
    {
        LogicNegoc logica = new LogicNegoc();
        protected void Page_Load(object sender, EventArgs e)
        {
           TextBox2.Visible=false;
            Label1.Visible = false;
        }
        string mensaje = "";
        protected void Button1_Click(object sender, EventArgs e)
        {
            string inicial, final;
            inicial = TextBox1.Text;
            final = TextBox2.Text;

            bool validarInicial = Regex.IsMatch(inicial, @"^([0-2][0-9]|3[0-1])(\/|-)(0[1-9]|1[0-2])\2(\d{4})$");
          //  bool validarFinal = Regex.IsMatch(final, @"^([0-2][0-9]|3[0-1])(\/|-)(0[1-9]|1[0-2])\2(\d{4})$");

            if (!validarInicial)
            {
                Response.Write("<script>window.alert('Fecha inicial no valida (DD/MM/YYYY)')</script>");
            }
            //else if (!validarFinal)
            //{
            //    Response.Write("<script>window.alert('Fecha final no valida (DD/MM/YYYY)')</script>");
            //}
            else
            {
                //GridView1.DataSource = logica.ConsultarMayorAsistenciasGrupo(inicial, final, ref mensaje);
                //GridView1.DataBind();


                GridView1.DataSource = logica.ConsultarMayorAsistenciasGruposss(inicial,ref mensaje);
                GridView1.DataBind();
            }
        }
    }
}