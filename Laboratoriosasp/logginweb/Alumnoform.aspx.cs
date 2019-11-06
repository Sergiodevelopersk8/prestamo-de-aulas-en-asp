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
    public partial class Alumnoform : System.Web.UI.Page
    {
        string mensj = "";
        LogicNegoc logica = new LogicNegoc();
        ManejaSQL modelo2 = new ManejaSQL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //ListarRegistro();
                actuzalizar();
            }
        }
        List<int> IdGrupos = new List<int>();
        List<string> grupos = new List<string>();
        public void CargarGruposCombo()
        {
            IdGrupos = logica.devuelveGrupos(ref grupos, ref mensj);
            Dropgrup.Items.Clear();
            foreach (string a in grupos)
            {
                Dropgrup.Items.Add(a.ToString());
            }
        }

        void actuzalizar()
        {
            string j = "";
            List<string> grupos = new List<string>();

            grupos = logica.devulvegrups(ref j);
            Dropgrup.Items.Clear();
           
            foreach (string a in grupos)
            {
                Dropgrup.Items.Add(a);
            }
        }
            protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void mensaje(string mensaje)
        {
            Response.Write("<script type='text/javascript'>" + " alert('" + mensaje + "');</script>");

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string mengrup = "";
            int grupitos;

            IdGrupos = logica.devuelveGrupos(ref grupos, ref mengrup);
            grupitos = IdGrupos[Dropgrup.SelectedIndex];

            string mensj = "";
            SqlConnection cn2 = modelo2.AbrirConexion();
            logica.InsertarAlumno(cn2, Txtnombre.Text, Txtapellido1.Text, Txtapellido2.Text, Txtmatricula.Text,
            grupitos, ref mensj);
            cn2.Close();
            cn2.Dispose();
            //vista.MiLetrero(mensj);
            mensaje("inserccion Correcta");
            Txtnombre.Text = "";
            Txtapellido1.Text = "";
            Txtapellido2.Text = "";
            Txtmatricula.Text = "";
        }
        //private void ListarRegistro()
        //{
        //    try
        //    {
        //        using (SqlConnection conexi = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionConfigu"].ToString()))
        //        using (SqlDataAdapter da = new SqlDataAdapter("usp_Listar_Registrolum", conexi))
        //        {
        //            DataTable tbRegistro = new DataTable();
        //            da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //            da.Fill(tbRegistro);
        //            GridDatosRegistro.DataSource = tbRegistro;
        //            GridDatosRegistro.DataBind();
        //            Session["Registro"] = tbRegistro;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
    }
}