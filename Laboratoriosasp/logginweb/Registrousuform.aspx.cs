using System;
using System.Collections.Generic;
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


namespace logginweb
{
    public partial class Registrousuform : System.Web.UI.Page
    {
        LogicNegoc logica = new LogicNegoc();
        ManejaSQL modelo2 = new ManejaSQL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void mensaje(string mensaje)
        {
            Response.Write("<script type='text/javascript'>" + " alert('" + mensaje + "');</script>");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string mensj = "";
            //string mensaj = "";
            SqlConnection cn2 = modelo2.AbrirConexion();
            try { 
            if (Txtcontrase.Text == Txtverificar.Text)
            {
                logica.InsertarUsuario(cn2, Txtnombreusu.Text, Txtcontrase.Text,
                               ref mensj);
                mensaje("Insercion correcta");
            }
            else
            {
                mensaje("Verifica tu contraseña");
            }
            } catch { }
            cn2.Close();
            cn2.Dispose();
        }
    }
}