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
using System.Web.UI.HtmlControls;
namespace logginweb
{
    public partial class CuatriForm : System.Web.UI.Page 
    {
        LogicNegoc logica = new LogicNegoc();
        ManejaSQL modelo2 = new ManejaSQL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       

        protected void Button2_Click(object sender, EventArgs e)
        {
            string mensj = "";
            SqlConnection cn2 = modelo2.AbrirConexion();
            // string fechaInicio = fechainicio.ToString();//.SelectedDate.ToShortDateString();

            // string fechaFinal = finfecha.ToString();
            //  string nombre = TextBox_RazonSocial.Text;
            string fechainicio = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
            string fechaifin = Calendar2.SelectedDate.ToString("yyyy-MM-dd");

            string mensaj = "verifica tus fechas";
            if (fechainicio == "" || fechaifin == "" || Listascuatri == null)
            {
                mensaje("verifica tus fechas o selecciona un cuatrimestre");
            }
            else
            {


                //logica.metercuatri(cn2,Listascuatri.SelectedItem.Text, int.Parse(yeardd.Text), fechainicio,fechaifin ,ref mensj);
                logica.ingresarcuatrimestre(cn2, Listascuatri.SelectedItem.Text, fechainicio, fechaifin, ref mensj);

                mensaje("inserccion Correcta");
            }


        }

        public void mensaje(string mensaje)
        {
            Response.Write("<script type='text/javascript'>" + " alert('" + mensaje + "');</script>");

        }
    }
}