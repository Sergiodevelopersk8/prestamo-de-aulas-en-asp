using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ModeloSql;
using System.Data.SqlClient;
using System.Web.Security;
using System.Data;
using System.Configuration;
using System.Text.RegularExpressions;


namespace logginweb
{
    public partial class ConsultasForm : System.Web.UI.Page
    {
        LogicNegoc logica = new LogicNegoc();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string inicial, final;
            inicial = TextBox1.Text;
            final = TextBox1.Text;
            string mensj = "";
            bool validarInicio = Regex.IsMatch(inicial, @"^([0-2][0-9]|3[0-1])(\/|-)(0[1-9]|1[0-2])\2(\d{4})$");
            bool validaFinal = Regex.IsMatch(final, @"^([0-2][0-9]|3[0-1])(\/|-)(0[1-9]|1[0-2])\2(\d{4})$");

            if (!validarInicio)
            {
                Response.Write("<script>window.alert('Fecha inicial no valida (DD/MM/YYYY)')</script>");
            }
            else if (!validaFinal)
            {
                Response.Write("<script>window.alert('Fecha final no valida (DD/MM/YYYY)')</script>");
            }
            else
            {
                GridView1.DataSource = logica.mayorprestamo(inicial, final, ref mensj);
                GridView1.DataBind();

            }
        }


        //protected void GridView_Profesores_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int idProf = int.Parse(GridView_Profesores.SelectedRow.Cells[1].Text.ToString());
        //    GridView_HorarioProf.DataSource = log.ConsultarHorariosProf(idProf, ref mensaje);
        //    GridView_HorarioProf.DataBind();
        //}
    }   }

