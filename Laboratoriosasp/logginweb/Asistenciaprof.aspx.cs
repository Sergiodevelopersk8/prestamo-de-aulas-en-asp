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
    public partial class Asistenciaprof : System.Web.UI.Page
    {
        LogicNegoc logica = new LogicNegoc();
        string mens = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarLaboratorios();
                CargarMatriculasCombo();
                CargarLaboratorios();
            }
            Calendar1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CargarHorarioProf();
        }
        List<int> IdMatriculas = new List<int>();
        List<string> matriculas = new List<string>();
        public void CargarMatriculasCombo()
        {
            string k = "";
            IdMatriculas = logica.gridprof(ref matriculas, ref k);
            DropDownList1.Items.Clear();

            foreach (string a in matriculas)
            {
                DropDownList1.Items.Add(a.ToString());
            }
        }
        public void CargarLaboratorios()
        {
            GridView1.DataSource = logica.gridlaboratorios(ref mens);
            GridView1.DataBind();
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int horario, asis;
            string fecha, asis1;
            horario = int.Parse(GridView2.SelectedRow.Cells[1].Text.ToString());
            asis1 = Txtasis.Text;
            fecha = Calendar1.TodaysDate.ToShortDateString();

            bool validarAsistencia = Regex.IsMatch(asis1, @"^[0-9]+$");

            if (!validarAsistencia)
            {
                Response.Write("<script>window.alert('Asistencia no valida')</script>");
            }
            else
            {
                asis = int.Parse(asis1);
                if (logica.InsertarAsistencia(horario, fecha, asis))
                {
                    Response.Write("<script>window.alert('registrado')</script>");
                }
                else
                {
                    Response.Write("<script>window.alert('ERROR')</script>");
                }
            }
        }

        public string españolIngles(string dia)
        {
            switch (dia)
            {
                case "Monday":
                    dia = "Lunes";
                    break;
                case "Tuesday":
                    dia = "Martes";
                    break;
                case "Wednesday":
                    dia = "Miercoles";
                    break;
                case "Thursday":
                    dia = "Jueves";
                    break;
                case "Friday":
                    dia = "Viernes";
                    break;
            }
            return dia;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarLaboratorios();
        }

        string mensaje = "";
        public void CargarHorarioProf()
        {
            IdMatriculas = logica.gridprof(ref matriculas, ref mensaje);
            int prof = IdMatriculas[DropDownList1.SelectedIndex];
            string dia = Calendar1.TodaysDate.DayOfWeek.ToString();
            dia = españolIngles(dia);
            GridView2.DataSource = logica.ConsultarHorariosProfDia(prof, dia, ref mensaje);
            GridView2.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}