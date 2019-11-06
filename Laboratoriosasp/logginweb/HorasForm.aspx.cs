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
    public partial class HorasForm : System.Web.UI.Page
    {
        LogicNegoc logica = new LogicNegoc();
        ManejaSQL modelo2 = new ManejaSQL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarHorarios();
                CargarDiasCombo();
                CargarLaboratoriosCombo();
                CargarMateriasCombo();
                CargarGrupoCombo();
                CargarProfesoresCombo();
                CargarHorariosCombo();
            }
        }
        string mensaje;

        List<int> IdLabos = new List<int>();
        List<int> IdProfes = new List<int>();
        List<int> IdMates = new List<int>();
        List<int> IdGrupos = new List<int>();
        List<int> IdDias = new List<int>();
        List<int> IdHorario = new List<int>();

        List<string> labos = new List<string>();
        List<string> profes = new List<string>();
        List<string> apellidos = new List<string>();
        List<string> mates = new List<string>();
        List<string> grupos = new List<string>();
        List<string> dias = new List<string>();
        List<string> horarios = new List<string>();
        protected void Button1_Click(object sender, EventArgs e)
        {
            int grupo, laboratorio, dia, materia, profesor, horario;

            IdLabos = logica.devuelveLaboratorios(ref labos, ref mensaje);
            laboratorio = IdLabos[DropDownList1.SelectedIndex];

            IdProfes = logica.devuelveProfesores(ref profes, ref mensaje);
            profesor = IdProfes[DropDownList2.SelectedIndex];

            IdHorario = logica.devuelveHoras(ref horarios, ref mensaje);
            horario = IdHorario[DropDownList3.SelectedIndex];
            int un = 0;
            IdMates = logica.devuelveSoloMaterias(ref mates, ref mensaje);
            materia = IdMates[DropDownList4.SelectedIndex];

            IdGrupos = logica.devuelveGrupos(ref grupos, ref mensaje);
            grupo = IdGrupos[Listgrupo.SelectedIndex];
            int dos = 0;
            IdDias = logica.Diascombo(ref dias, ref mensaje);
            dia = IdDias[DropDownList5.SelectedIndex];
            int tre = 0;
            SqlConnection cn2 = modelo2.AbrirConexion();
          logica.InsertarAsigna(cn2, grupo, laboratorio, dia, materia, profesor, horario);
            
        }
        public void CargarLaboratoriosCombo()
        {
            IdLabos = logica.devuelveLaboratorios(ref labos, ref mensaje);
            DropDownList1.Items.Clear();

            foreach (string a in labos)
            {
                DropDownList1.Items.Add(a.ToString());
            }
        }
        public void CargarProfesoresCombo()
        {
            IdProfes = logica.devuelveProfesores(ref profes, ref mensaje);
            DropDownList2.Items.Clear();

            foreach (string a in profes)
            {
                DropDownList2.Items.Add(a.ToString());
            }
        }
        public void CargarMateriasCombo()
        {
            IdMates = logica.devuelveSoloMaterias(ref mates, ref mensaje);
            DropDownList4.Items.Clear();

            foreach (string a in mates)
            {
                DropDownList4.Items.Add(a.ToString());
            }

        }
        public void CargarGrupoCombo()
        {
            IdGrupos = logica.devuelveGrupos(ref grupos, ref mensaje);
            Listgrupo.Items.Clear();

            foreach (string a in grupos)
            {
                // DropDownList3.Items.Add(a.ToString());
                Listgrupo.Items.Add(a.ToString());
            }
        }
        public void CargarDiasCombo()
        {
            IdDias = logica.Diascombo(ref dias, ref mensaje);
            DropDownList5.Items.Clear();

            foreach (string a in dias)
            {
                DropDownList5.Items.Add(a.ToString());
            }
        }
        public void CargarHorariosCombo()
        {
            IdHorario = logica.devuelveHoras(ref horarios, ref mensaje);
            DropDownList3.Items.Clear();

            foreach (string a in horarios)
            {
                //DropDownList5.Items.Add(a.ToString());
                DropDownList3.Items.Add(a.ToString());
            }
        }

        public void CargarHorarios()
        {
           
        }

        protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}