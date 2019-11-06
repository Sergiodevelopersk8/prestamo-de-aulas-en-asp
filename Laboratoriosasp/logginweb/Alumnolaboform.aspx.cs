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
using System.Drawing;
using System.IO;

namespace logginweb
{
    public partial class Alumnolaboform : System.Web.UI.Page
    {
        LogicNegoc logica = new LogicNegoc();
        ManejaSQL modelo2 = new ManejaSQL();
        string mensj = "";
        ///SqlConnection cn2 = modelo2.AbrirConexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                actuzalizar();
                CargarGruposCombo();
                CargarAlumnos();
                CargarHorariosCombo();
                CargarDiasCombo();
            }
            GridView2.Visible = false;
            GridView1.Visible = false;
        }

        List<int> Diasli = new List<int>();
        List<string> Diasstr = new List<string>();
        List<int> idObraDetalle = null;
        List<string> Nomobra = new List<string>();
        List<int> IdGrupos = new List<int>();
        List<string> grupos = new List<string>();
        List<string> agregarhora = new List<string>();
        List<int> IdHorario = new List<int>();
        List<string> horarios = new List<string>();
        void actuzalizar()
        {
            string j = "";
            List<string> matriculaalumno = null;

            matriculaalumno = logica.categorias(ref j);
            Listascuatric.Items.Clear();
            //Listascuatric.Items.Add("Matriculas");
            foreach (string a in matriculaalumno)
            {
                Listascuatric.Items.Add(a);
            }
            //idObraDetalle = logica.devulveIdalumno(ref Nomobra, ref j);
            //Listascuatric.Items.Clear();
            //foreach (string a in Nomobra)
            //{
            //    Listascuatric.Items.Add(a);
            //}
            //Session["idObraDetalle"] = idObraDetalle;
        }

        public void CargarGruposCombo()
        {
            IdGrupos = logica.devuelvelibres(ref grupos, ref mensj);
            DropDownList2.Items.Clear();
            foreach (string a in grupos)
            {
                DropDownList2.Items.Add(a.ToString());
            }
        }

        List<int> IdDias = new List<int>();
        List<string> dias = new List<string>();
        public void CargarDiasCombo()
        {
            IdDias = logica.Diascombo(ref dias, ref mensaje);
            diasdrop.Items.Clear();

            foreach (string a in dias)
            {
                diasdrop.Items.Add(a.ToString());
            }

            Calendar1.Visible = false;
        }

        //public void Cargardiascom()
        //{
        //    Diasli = logica.Diascombo(ref Diasstr, ref mensj);
        //    diasdrop.Items.Clear();
        //    foreach (string a in grupos)
        //    {
        //        diasdrop.Items.Add(a.ToString());
        //    }
        //}

        public void CargarAlumnos()
        {
            //GridView1.DataSource = logica.GridparaAlumnos(ref mensj);
            //GridView1.DataBind();

            //GridView4.DataSource = logica.GridparaAlumnos(ref mensj);
            //GridView4.DataBind();
            GridView4.DataSource = logica.Alumnosperio(ref mensj);
            GridView4.DataBind();
            
           
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            string mengrup = "";
            int grupitos;
            string agreg;
           // agreg = DropDownList1.SelectedItem;
            IdGrupos = logica.devuelvelibres(ref grupos, ref mengrup);
            //grupitos = IdGrupos[DropDownList2.SelectedIndex];
            SqlConnection cn2 = modelo2.AbrirConexion();

            // int idAlum = int.Parse(GridView1.SelectedRow.Cells[1].Text.ToString());
            //logica.Insertarlibres(cn2,DropDownList1.SelectedItem.ToString(), grupitos,ref mengrup);
            //string matricula = GridView1.SelectedRow.Cells[2].Text.ToString();

            Session["paracode"] = Listascuatric.SelectedIndex.ToString();
           System.Drawing.Image img;

           //     BarcodeLib.Barcode codigo = new BarcodeLib.Barcode();

           //     {
           //         codigo.IncludeLabel = false;
           //     };
           // img = codigo.Encode(BarcodeLib.TYPE.CODE128, Listascuatric.SelectedIndex.ToString(), Color.Green, Color.White, 1000, 100);
           ////img = codigo.Encode(BarcodeLib.TYPE.CODE128, matricula, Color.Green, Color.White, 1000, 100);

            string base64String;


                //using (MemoryStream ms = new MemoryStream())
                //{
                //    //Convert Image to byte[]
                //    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //    byte[] imageBytes = ms.ToArray();

                //    // Convert byte[] to Base64 String
                //    base64String = "data:image/jpg;base64," + Convert.ToBase64String(imageBytes);
                //}

                imgBarra.ImageUrl = "WebForm1.aspx";
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idAlum = int.Parse(GridView1.SelectedRow.Cells[1].Text.ToString());
           string matricula = GridView1.SelectedRow.Cells[2].Text.ToString();
            Label1.Text = matricula;   
            //TextBox_alumno.Text = matricula;
            //Barras(matricula);
            ViewState["matricula"] = idAlum;
            int POS = GridView1.SelectedIndex;
            DataKey Obj = GridView1.DataKeys[POS];

            CargarDisponnibles();
        }

        public int TransformarID(string dia)
        {
            int IdDia = 0;
            switch (dia)
            {
                case "Monday":
                    IdDia = 1;
                    break;
                case "Tuesday":
                    IdDia = 2;
                    break;
                case "Wednesday":
                    IdDia = 3;
                    break;
                case "Thursday":
                    IdDia = 4;
                    break;
                case "Friday":
                    IdDia = 5;
                    break;
            }
            return IdDia;
        }
        int horario;
        string mensaje = "";
        protected void regisprest_Click(object sender, EventArgs e)
        {
            string fecha = "";
            int alumno, hora, labo;
            IdHorario = logica.devuelveHoras(ref horarios, ref mensaje);
            horario = IdHorario[DropDownList1.SelectedIndex];
           // string fecha = Fecha_inicio.Value.ToString();
            alumno = (int)ViewState["matricula"];
            hora = (int)ViewState["idhoras"];
            labo = (int)ViewState["idlabo"];
            fecha = Calendar1.TodaysDate.ToShortDateString();
            if (logica.InsertarPrestamoLab(alumno, fecha, hora, labo))
            {
                Response.Write("<script>window.alert('laboratorio registrado')</script>");
            }
            else
            {
                Response.Write("<script>window.alert('Error')</script>");
            }
        }
        public void CargarHorariosCombo()
        {
            IdHorario = logica.devuelveHoras(ref horarios, ref mensaje);
            DropDownList1.Items.Clear();

            foreach (string a in horarios)
            {
                //DropDownList5.Items.Add(a.ToString());
                DropDownList1.Items.Add(a.ToString());
            }
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string laboratorio = GridView2.SelectedRow.Cells[2].Text.ToString();
            // Label_alumno.Text = TextBox_alumno.Text;
            Label2.Text = laboratorio;
            //Label1.Text = DropDownList1.SelectedValue.ToString();
            ViewState["idlabo"] = int.Parse(GridView2.SelectedRow.Cells[1].Text.ToString());
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDisponnibles();
        }

        public void CargarDisponnibles()
        {
            //IdHorario = logica.devuelveHoras(ref horarios, ref mensaje);
            //int hor = IdHorario[DropDownList1.SelectedIndex];
            //// int fecha = TransformarID(Calendar1.TodaysDate.DayOfWeek.ToString());

            //int fecha = diasdrop.SelectedIndex;
            //GridView2.DataSource = logica.ConsultarDisponiblesLab(fecha, hor, ref mensaje);
            //GridView2.DataBind();
            //ViewState["idhoras"] = hor;

            IdHorario = logica.devuelveHoras(ref horarios, ref mensaje);
            int hor = IdHorario[DropDownList1.SelectedIndex];
            // int fecha = TransformarID(Calendar1.TodaysDate.DayOfWeek.ToString());

            int fecha = diasdrop.SelectedIndex;
            GridView5.DataSource = logica.ConsultarDisponiblesLab(fecha, hor, ref mensaje);
            GridView5.DataBind();
            ViewState["idhoras"] = hor;

        }

        protected void Listascuatric_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idAlum = int.Parse(GridView4.SelectedRow.Cells[1].Text.ToString());
            string matricula = GridView4.SelectedRow.Cells[2].Text.ToString();
            Label1.Text = matricula;
            //TextBox_alumno.Text = matricula;
            //Barras(matricula);
            ViewState["matricula"] = idAlum;
            int POS = GridView4.SelectedIndex;
            //DataKey Obj = GridView4.DataKeys[POS];

            CargarDisponnibles();
        }

        protected void GridView5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string laboratorio = GridView5.SelectedRow.Cells[2].Text.ToString();
            // Label_alumno.Text = TextBox_alumno.Text;
            Label2.Text = laboratorio;
            //Label1.Text = DropDownList1.SelectedValue.ToString();
            ViewState["idlabo"] = int.Parse(GridView5.SelectedRow.Cells[1].Text.ToString());

        }
        string grii = "";

        protected void GridView4_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            int POS = GridView4.SelectedIndex;
            //DataKey Obj = GridView4.DataKeys[POS];
            GridView4.DataSource = logica.GridparaAlumnos(ref grii);
        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e) {

        }

        protected void GridView5_SelectedIndexChanging(object sender, GridViewSelectEventArgs e) {

        }
    }



}