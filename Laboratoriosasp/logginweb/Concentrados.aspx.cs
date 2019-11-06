using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModeloSql;

namespace logginweb {
    public partial class Concentrados : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }
        LogicNegoc logica = new LogicNegoc();
        List<int> IdMatriculas = new List<int>();
        List<string> matriculas = new List<string>();


        public void CargarHorarioProf() {
            //IdMatriculas = logica.gridprof(ref matriculas, ref mensaje);
            //int prof = IdMatriculas[DropDownList1.SelectedIndex];
            //string dia = Calendar1.TodaysDate.DayOfWeek.ToString();
            //dia = españolIngles(dia);
            //GridView1.DataSource = logica.ConsultarHorariosProfDia(prof, dia, ref mensaje);
            //GridView1.DataBind();
        }

    }
}