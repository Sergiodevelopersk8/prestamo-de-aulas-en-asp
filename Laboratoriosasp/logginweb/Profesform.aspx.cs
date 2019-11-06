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


namespace logginweb
{
    public partial class Profesform : System.Web.UI.Page
    {
        LogicNegoc logica = new LogicNegoc();
        ManejaSQL modelo2 = new ManejaSQL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarRegistro();
            }
            ListarRegistro();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string mensj = "";
            string aviso = "se inserto";
            SqlConnection cn2 = modelo2.AbrirConexion();

            if (Txtnombrep.Text != "" & Txtapellidop1.Text != "" & Txtapellidop2.Text != "" & Txtmatriculap.Text != "") {

                logica.InsertarProfesor(cn2, Txtnombrep.Text, Txtapellidop1.Text, Txtapellidop2.Text, Txtmatriculap.Text,
              ref mensj);

            } else {
                string avisos = "error";
                mensaje(avisos);
            }
          
            cn2.Close();
            cn2.Dispose();
            //vista.MiLetrero(mensj);
            //Txtnombre.Text = "";
            //Txtapellido1.Text = "";
            //Txtapellido2.Text = "";
            //Txtmatricula.Text = "";
            mensaje(aviso);
        }

        private void ListarRegistro()
        {
            try
            {
                using (SqlConnection conexi = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionConfigu"].ToString()))
                using (SqlDataAdapter da = new SqlDataAdapter("usp_Listar_Registro", conexi))
                {
                    DataTable tbRegistro = new DataTable();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.Fill(tbRegistro);
                    GridDatosRegistro.DataSource = tbRegistro;
                    GridDatosRegistro.DataBind();
                    Session["Registro"] = tbRegistro;
                }
            }
            catch (Exception)
            {
                throw;
            }


        }

        public void mensaje(string mensaje) {
            Response.Write("<script type='text/javascript'>" + " alert('" + mensaje + "');</script>");

        }

        protected void GridDatosRegistro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}