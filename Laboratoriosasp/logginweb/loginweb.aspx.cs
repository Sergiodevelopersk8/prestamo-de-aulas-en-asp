using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModeloSql;
using System.Data.SqlClient;
using System.Web;
using System.Web.Security;


namespace logginweb
{
	
	public partial class loginweb : System.Web.UI.Page
    {
		string mensj = "";
		LogicNegoc capa1=new LogicNegoc();
		ManejaSQL acceso1 = new ManejaSQL();
		protected void Page_Load(object sender, EventArgs e)
        {
            Nomostrar();
        }
        string pase = "";
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            //string usuario = TextBox1.Text;
            //string contraseña = capa1.validar(usuario, ref pase);
            //string password = TextBox2.Text;
            //if (usuario == "" || password == "")
            //{
            //    Response.Write("<script>window.alert('Llenar todos los campos')</script>");
            //}
            //else
            //{
            //    if (password == contraseña)
            //    {
            //        FormsAuthentication.RedirectFromLoginPage(usuario, false);
            //        Response.Redirect("menulabora.aspx");
            //    }
            //    else
            //    {
            //        Response.Write("<script>window.alert('Usuario o contraseña incorrecta')</script>");
            //    }
            //}


        }

		protected void Button1_Click1(object sender, EventArgs e)
		{
            string pase = "";
           

                string usuario = TextBox1.Text;
                string contraseña = capa1.validar(usuario, ref pase);
                string password = TextBox2.Text;
                if (usuario == "" || password == "")
                {
                    Response.Write("<script>window.alert('Llenar todos los campos')</script>");
                }
                else
                {
                    if (password == contraseña)
                    {
                        FormsAuthentication.RedirectFromLoginPage(usuario, false);
                        Response.Redirect("menulabora.aspx");
                    }
                    else
                    {
                        Response.Write("<script>window.alert('Usuario o contraseña incorrecta')</script>");
                    }
                }
        }
        public void Nomostrar()
        {
            if (!IsPostBack)
            {

                this.Form.Attributes.Add("autocomplete", "off");

            }
        }
    }
}