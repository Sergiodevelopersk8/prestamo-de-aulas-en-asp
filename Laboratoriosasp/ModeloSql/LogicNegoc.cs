using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using ModeloSql;


namespace ModeloSql
{
    public class LogicNegoc
    {
		ManejaSQL capa1 = new ManejaSQL();
		public LogicNegoc()
		{
			//capa1.CadCone = @"Data Source=SERGIOMERINOSK8\SERGIOSKATERSQL;Initial Catalog =logprueba;Integrated Security=True";
		}
		SqlCommand carrito;
        string mensj = "";
        ManejaSQL msql = new ManejaSQL();

        // /////////////////////////////////////////////////////////////////// LISTS PARA SQL ///////////////////////////////////////////////////////////////////////////////
        List<int> idforeign = new List<int>();
        List<int> labora = new List<int>();
        List<int> diass = new List<int>();
        List<int> materiass = new List<int>();
        List<int> profess = new List<int>();
        List<int> horass = new List<int>();
        List<int> asignaaa = new List<int>();
        List<int> alumnoss = new List<int>();
        List<int> hola = new List<int>();
        List<int> cuatriss = new List<int>();

        /// ///////////////////////////////////////////// METODOS PARA INSERTAR ///////////////////////////////////////////////////////////////////////////////////
        /// 
        //public int validar(SqlConnection carretera, String user, String clave)
        //{
        //	carrito = new SqlCommand("Select * from usuario where usuario='" + user + "'and clave='" + clave + "'");
        //	return carrito.ExecuteNonQuery();
        //}

        //public string validar(SqlConnection carretera, String user, String clave)
        //{
        //	carrito = new SqlCommand("Select * from usuario where usuario='" + user + "'and clave='" + clave + "'");
        // carrito.ExecuteNonQuery();
        //}
       public string validar (string usuarios, ref string mnsj)
        {
            string abrir = "";
        string contraseña = "";
        string query = "select contrasena from Usuarios where nombre_usu='" + usuarios + "'";
        SqlConnection cnt2 = null;
        SqlDataReader dr1 = null;
        cnt2 = capa1.AbrirConexion();
            if (cnt2 != null)
            {
                dr1 = capa1.ConsultaDataReader(ref cnt2, query, ref mnsj);
                if (dr1 != null)
                {
                    while (dr1.Read())
                    {
                        contraseña=((string) dr1[0]);
                    }
}
cnt2.Close();
                cnt2.Dispose();
            }
            return contraseña;
        }


        public void InsertarUsuario(SqlConnection carretera, string nombre, string clave,ref string mensj)
        {
           String query = "INSERT INTO Usuarios(nombre_usu,contrasena)values(@nombreus,@clavusu)";

            if (carretera != null)
            {
                try
                {
                    SqlParameter uno = new SqlParameter("nombreus", SqlDbType.VarChar, 50);
                    uno.Direction = ParameterDirection.Input;
                    uno.Value = nombre;

                    SqlParameter dos = new SqlParameter("clavusu", SqlDbType.VarChar, 50);
                    dos.Direction = ParameterDirection.Input;
                    dos.Value = clave;



                    carrito = new SqlCommand();
                    carrito.Parameters.Add(uno);
                    carrito.Parameters.Add(dos);
               

                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    mensj = "Modificacion correcta";
                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }



        public void InsertarAlumno(SqlConnection carretera, string nombre, string apellidop, string apellidom, string matricula, int grupos, ref string mensj)
        {
            //LlenarArreglo(carretera);
            //int grupo = idforeign[grupos];
            // String query = "INSERT INTO Alumno(nombre,apellidoP,apellidoM,Matricula,IdGrupo)values(@nombre,@paterno,@materno,@matricula,"+ grupos+")";
            // String query = "INSERT INTO Alumno(nombre,apellidoP,apellidoM,Matricula)values(@nombre,@paterno,@materno,@matricula )";
            String query = "INSERT INTO Alumno(nombre,apellidoP,apellidoM,Matricula,IdGrupo)values(@nombre,@paterno,@materno,@matricula,@grupos)";
            if (carretera != null)
            {
                try
                {
                    SqlParameter uno = new SqlParameter("nombre", SqlDbType.VarChar, 50);
                    uno.Direction = ParameterDirection.Input;
                    uno.Value = nombre;

                    SqlParameter dos = new SqlParameter("paterno", SqlDbType.VarChar, 50);
                    dos.Direction = ParameterDirection.Input;
                    dos.Value = apellidop;

                    SqlParameter tres = new SqlParameter("materno", SqlDbType.VarChar, 50);
                    tres.Direction = ParameterDirection.Input;
                    tres.Value = apellidom;

                    SqlParameter cuatro = new SqlParameter("matricula", SqlDbType.VarChar, 50);
                    cuatro.Direction = ParameterDirection.Input;
                    cuatro.Value = matricula;

                    SqlParameter cinco = new SqlParameter("grupos", SqlDbType.Int);
                    cinco.Direction = ParameterDirection.Input;
                    cinco.Value = grupos;


                    carrito = new SqlCommand();
                    carrito.Parameters.Add(uno);
                    carrito.Parameters.Add(dos);
                    carrito.Parameters.Add(tres);
                    carrito.Parameters.Add(cuatro);
                    carrito.Parameters.Add(cinco);

                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    //int n = carrito.ExecuteNonQuery();
                    //return n > 0;
                    mensj = "Modificacion correcta";
                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;
                  
                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }

        public void Insertarlibres(SqlConnection carretera, string horariolibb, int idlab, ref string mensj)
        {
          String query = "INSERT INTO horarioLibres(horariolib,IdLaboratorio)values(@horar,@idlabb)";
            if (carretera != null)
            {
                try
                {
                    SqlParameter uno = new SqlParameter("horar", SqlDbType.VarChar, 50);
                    uno.Direction = ParameterDirection.Input;
                    uno.Value = horariolibb;

                    SqlParameter dos = new SqlParameter("grupos", SqlDbType.Int);
                    dos.Direction = ParameterDirection.Input;
                    dos.Value = idlab;





                    carrito = new SqlCommand();
                    carrito.Parameters.Add(uno);
                   
                    carrito.Parameters.Add(dos);

                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    //int n = carrito.ExecuteNonQuery();
                    //return n > 0;
                    mensj = "Modificacion correcta";
                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;

                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }



        public void InsertarAsignacionesLabo(SqlConnection carretera, int idGrup, int idLabo, int idDia, int idMate, int idProfe, int idHor, ref string mensj)
        {
            DevuelveGrupos2(carretera);
            int misGrupos = hola[idGrup];

            DevuelveLabo(carretera);
            int misAulas = labora[idLabo];

            DevuelveDias(carretera);
            int misDias = diass[idDia];

            DevuelveMaterias(carretera);
            int misMates = materiass[idMate];

            DevuelveProfes(carretera);
            int misProfes = profess[idProfe];

            DevuelveHorarios(carretera);
            int misHoras = horass[idHor];

            String query = "insert into AsignaHorario (IdGrupo,IdLaboratorio,IdDia,IdMateria,IdProfesor,IdHorario)values(@grupo,@aula,@dia,@mate,@profe,@horari)";
            hola.Clear();
            labora.Clear();
            diass.Clear();
            materiass.Clear();
            profess.Clear();
            horass.Clear();

            if (carretera != null)
            {
                try
                {
                    SqlParameter grup = new SqlParameter("grupo", SqlDbType.Int, 50);
                    grup.Direction = ParameterDirection.Input;
                    grup.Value = misGrupos;

                    SqlParameter au = new SqlParameter("aula", SqlDbType.Int, 50);
                    au.Direction = ParameterDirection.Input;
                    au.Value = misAulas;

                    SqlParameter diaa = new SqlParameter("dia", SqlDbType.Int, 50);
                    diaa.Direction = ParameterDirection.Input;
                    diaa.Value = misDias;

                    SqlParameter mater = new SqlParameter("mate", SqlDbType.Int, 50);
                    mater.Direction = ParameterDirection.Input;
                    mater.Value = misMates;

                    SqlParameter prof = new SqlParameter("profe", SqlDbType.Int, 50);
                    prof.Direction = ParameterDirection.Input;
                    prof.Value = misProfes;

                    SqlParameter hor = new SqlParameter("horari", SqlDbType.Int, 50);
                    hor.Direction = ParameterDirection.Input;
                    hor.Value = misHoras;

                    carrito = new SqlCommand();
                    carrito.Parameters.Add(grup);
                    carrito.Parameters.Add(au);
                    carrito.Parameters.Add(diaa);
                    carrito.Parameters.Add(mater);
                    carrito.Parameters.Add(prof);
                    carrito.Parameters.Add(hor);

                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    mensj = "Horario asignado";
                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }

        public void InsertarCuatri(SqlConnection carretera, string periodo, int yearrd, string Fecha_Ini, string fecha_Fin, ref string mensj)
        {
            String query = "INSERT INTO cuatrimestre (Periodo,yeardd,fecha_inicio,fecha_fin) values(@meses,@elAño,@fechainic@fechafinn)";

            if (carretera != null)
            {
                try
                {
                    SqlParameter uno = new SqlParameter("meses", SqlDbType.VarChar, 50);
                    uno.Direction = ParameterDirection.Input;
                    uno.Value = periodo;

                    SqlParameter dos = new SqlParameter("elAño", SqlDbType.Int);
                    dos.Direction = ParameterDirection.Input;
                    dos.Value = yearrd;

                    SqlParameter tres = new SqlParameter("fechainic", SqlDbType.VarChar, 50);
                    tres.Direction = ParameterDirection.Input;
                    tres.Value = Fecha_Ini;

                    SqlParameter cuatro = new SqlParameter("fechafinn", SqlDbType.VarChar,50);
                    cuatro.Direction = ParameterDirection.Input;
                    cuatro.Value = fecha_Fin;

                    carrito = new SqlCommand();
                    carrito.Parameters.Add(uno);
                    carrito.Parameters.Add(dos);
                    carrito.Parameters.Add(tres);
                    carrito.Parameters.Add(cuatro);

                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    mensj = "Cuatrimestre agregado";
                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }


        public void metercuatri(SqlConnection carretera, string period, int yearddd, string fechaini, string fechafin,ref string mensj)
        {
            //SqlConnection carretera = null;
            //carretera = capa1.AbrirConexion(ref mensj);
            if (carretera != null)
            {
                try
                {
                    String SqlString = "insert into cuatrimestre(Periodo,yeardd,fecha_inicio,fecha_fin)" +
                        "values(@perio,@yearm,@fechai,@fechaf)";
                    using (carrito = new SqlCommand(SqlString, carretera))
                    {
                        carrito.CommandType = CommandType.Text;
                        carrito.Parameters.AddWithValue("@perio", period);
                        carrito.Parameters.AddWithValue("@yearm", yearddd);
                        carrito.Parameters.AddWithValue("@fechai", fechaini);
                        carrito.Parameters.AddWithValue("@fechaf", fechafin);
                     

                        carrito.Connection = carretera;
                        carrito.ExecuteNonQuery();
                        mensj = "Modificacion carrecta";
                    }
                }
                catch (Exception e)
                {
                    mensj = e.Message;
                }
                carretera.Close();

            }

        }


        public void ingresarcuatrimestre(SqlConnection carretera, string period,  string fechaini, string fechafin, ref string mensj)
        {
            //SqlConnection carretera = null;
            //carretera = capa1.AbrirConexion(ref mensj);
            if (carretera != null)
            {
                try
                {
                    String SqlString = "insert into cuatrimestre(Periodo,fecha_inicio,fecha_fin)" +
                        "values(@perio,@fechai,@fechaf)";
                    using (carrito = new SqlCommand(SqlString, carretera))
                    {
                        carrito.CommandType = CommandType.Text;
                        carrito.Parameters.AddWithValue("@perio", period);
                        //carrito.Parameters.AddWithValue("@yearm", yearddd);
                        carrito.Parameters.AddWithValue("@fechai", fechaini);
                        carrito.Parameters.AddWithValue("@fechaf", fechafin);


                        carrito.Connection = carretera;
                        carrito.ExecuteNonQuery();
                        mensj = "Modificacion carrecta";
                    }
                }
                catch (Exception e)
                {
                    mensj = e.Message;
                }
                carretera.Close();

            }

        }

        public void InsertarProfesor(SqlConnection carretera, string nomP, string apeP, string apeM, string matriP, ref string mensj)
        {
            String query = "INSERT INTO profesor(Nombre_P,Apellido_P,Apellido_M,Matricula) values(@nombrep,@paternop,@maternop,@matriculap)";

            if (carretera != null)
            {
                try
                {
                    SqlParameter nom1 = new SqlParameter("nombrep", SqlDbType.VarChar, 50);
                    nom1.Direction = ParameterDirection.Input;
                    nom1.Value = nomP;

                    SqlParameter apeP1 = new SqlParameter("paternop", SqlDbType.VarChar, 50);
                    apeP1.Direction = ParameterDirection.Input;
                    apeP1.Value = apeP;

                    SqlParameter apeM1 = new SqlParameter("maternop", SqlDbType.VarChar, 50);
                    apeM1.Direction = ParameterDirection.Input;
                    apeM1.Value = apeM;

                    SqlParameter matri1 = new SqlParameter("matriculap", SqlDbType.VarChar, 50);
                    matri1.Direction = ParameterDirection.Input;
                    matri1.Value = matriP;

                    carrito = new SqlCommand();
                    carrito.Parameters.Add(nom1);
                    carrito.Parameters.Add(apeP1);
                    carrito.Parameters.Add(apeM1);
                    carrito.Parameters.Add(matri1);

                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    mensj = "Profesor agregado";
                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }

        public void InsertarDias(SqlConnection carretera, string diass, ref string mensj)
        {
            String query = "INSERT INTO Dias(Dia)values(@elDia)";

            if (carretera != null)
            {
                try
                {
                    SqlParameter di = new SqlParameter("elDia", SqlDbType.VarChar, 50);
                    di.Direction = ParameterDirection.Input;
                    di.Value = diass;

                    carrito = new SqlCommand();
                    carrito.Parameters.Add(di);

                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    mensj = "Dia agregado";
                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }


        public void InsertarHoras(SqlConnection carretera, string horaI, string horaF, ref string mensj)
        {
            String query = "INSERT INTO Horario(Hora_Entrada,Hora_Salida)values(@entrada,@salida)";

            if (carretera != null)
            {
                try
                {
                    SqlParameter horaE = new SqlParameter("entrada", SqlDbType.VarChar, 50);
                    horaE.Direction = ParameterDirection.Input;
                    horaE.Value = horaI;

                    SqlParameter horaS = new SqlParameter("salida", SqlDbType.VarChar, 50);
                    horaS.Direction = ParameterDirection.Input;
                    horaS.Value = horaF;

                    carrito = new SqlCommand();
                    carrito.Parameters.Add(horaE);
                    carrito.Parameters.Add(horaS);

                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    mensj = "Horario agregado";
                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }


        public void InsertarAsigna(SqlConnection carretera,int grupo, int laboratorio, int dia, int materia, int profesor, int horario)
        {

            
           
                string query = "insert into Asigna (IdGrupo,IdLaboratorio,IdDia,IdMateria,IdProfesor,IdHorario)values(@idgrup, @idlaborato,@iddias,@idmaterias,@idprofesor,@idhorarios)";

                if (carretera != null)
                {
                    try
                    {
                       SqlParameter grups = new SqlParameter("idgrup", SqlDbType.Int);
                    grups.Direction = ParameterDirection.Input;
                    grups.Value = grupo;

                    SqlParameter laboralab = new SqlParameter("idlaborato", SqlDbType.Int);
                    laboralab.Direction = ParameterDirection.Input;
                    laboralab.Value = laboratorio;

                    SqlParameter diass = new SqlParameter("iddias", SqlDbType.Int);
                    diass.Direction = ParameterDirection.Input;
                    diass.Value = dia;

                    SqlParameter materiiis = new SqlParameter("idmaterias", SqlDbType.Int);
                    materiiis.Direction = ParameterDirection.Input;
                    materiiis.Value = materia;

                    SqlParameter proff = new SqlParameter("idprofesor", SqlDbType.Int);
                    proff.Direction = ParameterDirection.Input;
                    proff.Value = profesor;

                    SqlParameter horitass = new SqlParameter("idhorarios", SqlDbType.Int);
                    horitass.Direction = ParameterDirection.Input;
                    horitass.Value = horario;

                   

                    carrito = new SqlCommand();
                        carrito.Parameters.Add(grups);
                        carrito.Parameters.Add(laboralab);
                    carrito.Parameters.Add(diass);
                    carrito.Parameters.Add(materiiis);
                    carrito.Parameters.Add(proff);
                    carrito.Parameters.Add(horitass);

                    carrito.Connection = carretera;
                        carrito.CommandText = query;
                        carrito.ExecuteNonQuery();
                        mensj = "Horario agregado";

                    }
                    catch (Exception)
                    {

                    }
                }
            
        }

        public void InsertarAula(SqlConnection carretera, string aula1, string edificio1, ref string mensj)
        {
            String query = "INSERT INTO Laboratorios_Edificios(Aula,Edificio)values(@aula2,@edificio2)";

            if (carretera != null)
            {
                try
                {
                    SqlParameter aula3 = new SqlParameter("aula2", SqlDbType.VarChar, 50);
                    aula3.Direction = ParameterDirection.Input;
                    aula3.Value = aula1;

                    SqlParameter edifi3 = new SqlParameter("edificio2", SqlDbType.VarChar, 50);
                    edifi3.Direction = ParameterDirection.Input;
                    edifi3.Value = edificio1;

                    carrito = new SqlCommand();
                    carrito.Parameters.Add(aula3);
                    carrito.Parameters.Add(edifi3);

                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    mensj = "Salon agregado para disponibilidad";
                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }

        public void InsertarMateria(SqlConnection carretera, string asignat, ref string mensj)
        {
            String query = "insert into Materias (Asignatura) values(@laMateria)";

            if (carretera != null)
            {
                try
                {
                    SqlParameter mate1 = new SqlParameter("laMateria", SqlDbType.VarChar, 50);
                    mate1.Direction = ParameterDirection.Input;
                    mate1.Value = asignat;

                    carrito = new SqlCommand();
                    carrito.Parameters.Add(mate1);

                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    mensj = "Materia agregada";
                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }

        //       public void InsertarPrestamoAlumn(SqlConnection carretera, string nom, string apep, string apem, string matri, int grupo, int dia, string aula, string edi, string horae, string horas, ref string mensj)
        //       {
        //           DevuelveDias(carretera);
        //           DevuelveGrupos2(carretera);
        //           int misDias = diass[dia];
        //           int misGrupos = hola[grupo];
        //           String query = @"INSERT INTO SolicitarAulaLaboratorio(nombreA,apellidoPA,apellidoMA,MatriculaA,IdGrupo,IdDia, aula,edifi,he,hs)
        //values(@nomm,@apepp,@apemm,@matrii," + 2 + "," + 3 + ",@aulaaaa,@efiii,@horaeee,@horasss)";

        //           if (carretera != null)
        //           {
        //               try
        //               {
        //                   SqlParameter uno = new SqlParameter("nomm", SqlDbType.VarChar, 50);
        //                   uno.Direction = ParameterDirection.Input;
        //                   uno.Value = nom;

        //                   SqlParameter dos = new SqlParameter("apepp", SqlDbType.VarChar, 50);
        //                   dos.Direction = ParameterDirection.Input;
        //                   dos.Value = apep;

        //                   SqlParameter tres = new SqlParameter("apemm", SqlDbType.VarChar, 50);
        //                   tres.Direction = ParameterDirection.Input;
        //                   tres.Value = apem;

        //                   SqlParameter cua = new SqlParameter("matrii", SqlDbType.VarChar, 50);
        //                   cua.Direction = ParameterDirection.Input;
        //                   cua.Value = matri;

        //                   SqlParameter cin = new SqlParameter("aulaaaa", SqlDbType.VarChar, 50);
        //                   cin.Direction = ParameterDirection.Input;
        //                   cin.Value = aula;

        //                   SqlParameter seis = new SqlParameter("efiii", SqlDbType.VarChar, 50);
        //                   seis.Direction = ParameterDirection.Input;
        //                   seis.Value = edi;

        //                   SqlParameter sie = new SqlParameter("horaeee", SqlDbType.VarChar, 50);
        //                   sie.Direction = ParameterDirection.Input;
        //                   sie.Value = horae;

        //                   SqlParameter och = new SqlParameter("horasss", SqlDbType.VarChar, 50);
        //                   och.Direction = ParameterDirection.Input;
        //                   och.Value = horas;

        //                   carrito = new SqlCommand();
        //                   carrito.Parameters.Add(uno);
        //                   carrito.Parameters.Add(dos);
        //                   carrito.Parameters.Add(tres);
        //                   carrito.Parameters.Add(cua);
        //                   carrito.Parameters.Add(cin);
        //                   carrito.Parameters.Add(seis);
        //                   carrito.Parameters.Add(sie);
        //                   carrito.Parameters.Add(och);

        //                   carrito.Connection = carretera;
        //                   carrito.CommandText = query;
        //                   carrito.ExecuteNonQuery();
        //                   mensj = "Registro guardado";
        //               }
        //               catch (Exception h)
        //               {
        //                   mensj = "Error " + h.Message;
        //               }
        //               carretera.Close();
        //           }
        //           else
        //           {
        //               mensj = "No hay conexion abierta";
        //           }
        //       }

        public bool InsertarPrestamoLab(int alumno, string fecha, int hora, int labo)
        {
            
            try
            {
                string query = "insert into Solicitar_Labora_Alumno values(" + alumno + ",'" + fecha + "'," + hora + "," + labo + ")";
                SqlCommand cmd = new SqlCommand(query, capa1.AbrirConexion());
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }



        public void InsertarGrupos(SqlConnection carretera, string grado, string grupo, string turno, string especi, int cuatri, ref string mensj)
        {
            DevuelveCuatrimestres(carretera);
            int losCuatris = idforeign[cuatri];
            String query = "INSERT INTO Grupo (Grado,Grupo,Turno,especialidad,IdCuatrimestre)values(@grad,@grup,@turn,@especi," + losCuatris + ")";

            if (carretera != null)
            {
                try
                {
                    SqlParameter misGrados = new SqlParameter("grad", SqlDbType.VarChar, 50);
                    misGrados.Direction = ParameterDirection.Input;
                    misGrados.Value = grado;

                    SqlParameter misGrupos = new SqlParameter("grup", SqlDbType.VarChar, 50);
                    misGrupos.Direction = ParameterDirection.Input;
                    misGrupos.Value = grupo;

                    SqlParameter misTurnos = new SqlParameter("turn", SqlDbType.VarChar, 50);
                    misTurnos.Direction = ParameterDirection.Input;
                    misTurnos.Value = turno;

                    SqlParameter misEspecia = new SqlParameter("especi", SqlDbType.VarChar, 50);
                    misEspecia.Direction = ParameterDirection.Input;
                    misEspecia.Value = especi;



                    carrito = new SqlCommand();
                    carrito.Parameters.Add(misGrados);
                    carrito.Parameters.Add(misGrupos);
                    carrito.Parameters.Add(misTurnos);
                    carrito.Parameters.Add(misEspecia);

                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    mensj = "Grupo agregado";
                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }

        /// ////////////////////////////////////////////// METODOS PARA ELIMINAR /////////////////////////////////////////////////////////////////////////////////
        public void ElimimarDias(SqlConnection carretera, int selecc, ref string mensj)
        {
            DevuelveDias(carretera);
            int misDias = diass[selecc];
            if (carretera != null)
            {
                try
                {
                    String query = "delete from Dias where IdDia = @id";
                    using (carrito = new SqlCommand(query, carretera))
                    {
                        carrito.CommandType = CommandType.Text;
                        carrito.Parameters.AddWithValue("@id", misDias);

                        carrito.Connection = carretera;
                        carrito.ExecuteNonQuery();
                        mensj = "Eliminacion correcta";
                    }
                }
                catch (Exception e)
                {
                    mensj = e.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "Verifique la conexion";
            }
        }

        public void EliminarHorarios(SqlConnection carretera, int selecc, ref string mensj)
        {
            DevuelveHorarios(carretera);
            int misHorarios = horass[selecc];
            if (carretera != null)
            {
                try
                {
                    String query = "delete from Horario where IdHorario = @id";
                    using (carrito = new SqlCommand(query, carretera))
                    {
                        carrito.CommandType = CommandType.Text;
                        carrito.Parameters.AddWithValue("@id", misHorarios);

                        carrito.Connection = carretera;
                        carrito.ExecuteNonQuery();
                        mensj = "Eliminacion correcta";
                    }
                }
                catch (Exception e)
                {
                    mensj = e.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "Verifique la conexion";
            }
        }

        public void EliminarMateria(SqlConnection carretera, int selecc, ref string mensj)
        {
            DevuelveMaterias(carretera);
            int misMateria = materiass[selecc];
            if (carretera != null)
            {
                try
                {
                    String query = "delete from Materias where IdMateria = @id";
                    using (carrito = new SqlCommand(query, carretera))
                    {
                        carrito.CommandType = CommandType.Text;
                        carrito.Parameters.AddWithValue("@id", misMateria);

                        carrito.Connection = carretera;
                        carrito.ExecuteNonQuery();
                        mensj = "Eliminacion correcta";
                    }
                }
                catch (Exception e)
                {
                    mensj = e.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "Verifique la conexion";
            }
        }

        public void EliminarProfesor(SqlConnection carretera, int selecc, ref string mensj)
        {
            DevuelveProfes(carretera);
            int misProfes = idforeign[selecc];
            if (carretera != null)
            {
                try
                {
                    String query = "delete from Profesor where IdProfesor = @id";
                    using (carrito = new SqlCommand(query, carretera))
                    {
                        carrito.CommandType = CommandType.Text;
                        carrito.Parameters.AddWithValue("@id", misProfes);

                        carrito.Connection = carretera;
                        carrito.ExecuteNonQuery();
                        mensj = "Eliminacion correcta";
                    }
                }
                catch (Exception e)
                {
                    mensj = e.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "Verifique la conexion";
            }
        }

        public void EliminarAulas(SqlConnection carretera, int selecc, ref string mensj)
        {
            DevuelveLabo(carretera);
            int misAulas = labora[selecc];
            if (carretera != null)
            {
                try
                {
                    String query = "delete from Laboratorios_Edificios where IdLaboratorio = @id";
                    using (carrito = new SqlCommand(query, carretera))
                    {
                        carrito.CommandType = CommandType.Text;
                        carrito.Parameters.AddWithValue("@id", misAulas);

                        carrito.Connection = carretera;
                        carrito.ExecuteNonQuery();
                        mensj = "Eliminacion correcta";
                    }
                }
                catch (Exception e)
                {
                    mensj = e.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "Verifique la conexion";
            }
        }

        public void ElimimarCuatri(SqlConnection carretera, int selecc, ref string mensj)
        {
            DevuelveCuatrimestres(carretera);
            int misCuatris = idforeign[selecc];
            if (carretera != null)
            {
                try
                {
                    String query = "delete from cuatrimestre where IdCuatrimestre = @id";
                    using (carrito = new SqlCommand(query, carretera))
                    {
                        carrito.CommandType = CommandType.Text;
                        carrito.Parameters.AddWithValue("@id", misCuatris);

                        carrito.Connection = carretera;
                        carrito.ExecuteNonQuery();
                        mensj = "Eliminacion correcta";
                    }
                }
                catch (Exception e)
                {
                    mensj = e.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "Verifique la conexion";
            }
        }

        public void ElimimarGrupo(SqlConnection carretera, int selecc, ref string mensj)
        {
            DevuelveGrupos2(carretera);
            int misGrupos = hola[selecc];

            if (carretera != null)
            {
                try
                {
                    String query = "delete from Grupo where IdGrupo = " + misGrupos;
                    using (carrito = new SqlCommand(query, carretera))
                    {
                        //carrito.CommandType = CommandType.Text;
                        //  carrito.Parameters.AddWithValue("@id", misGrupos);

                        carrito.Connection = carretera;
                        carrito.ExecuteNonQuery();
                        mensj = "Eliminacion correcta";

                        hola.Clear();
                    }
                }
                catch (Exception e)
                {
                    mensj = e.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "Verifique la conexion";
            }
        }

        public void EliminaAsignaciones(SqlConnection carretera, int selecc, ref string mensj)
        {
            DevuelveAsignaciones(carretera);
            int misAsigna = asignaaa[selecc];
            if (carretera != null)
            {
                try
                {
                    String query = "delete from AsignaHorario where IdAsignacion = @id";
                    using (carrito = new SqlCommand(query, carretera))
                    {
                        carrito.CommandType = CommandType.Text;
                        carrito.Parameters.AddWithValue("@id", misAsigna);

                        carrito.Connection = carretera;
                        carrito.ExecuteNonQuery();
                        mensj = "Eliminacion correcta";
                    }
                }
                catch (Exception e)
                {
                    mensj = e.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "Verifique la conexion";
            }
        }

        // /////////////////////////////////////   METODOS PARA MODIFICAR  ////////////////////////////////////////////////////////////////////////////////////
        public void ModificarCuatri(SqlConnection carretera, int selecc, string periodo, string anual, ref string mensj)
        {
            DevuelveCuatrimestres(carretera);
            int misCuatris = idforeign[selecc];
            //String query = "INSERT INTO cuatrimestre(MesInicio,MesFin,Año)values(@inicio,@fin,@elAño)";
            String query = "update cuatrimestre set Periodo=@meses,Año=@elAño where IdCuatrimestre=" + misCuatris;


            if (carretera != null)
            {
                try
                {
                    SqlParameter uno = new SqlParameter("meses", SqlDbType.VarChar, 50);
                    uno.Direction = ParameterDirection.Input;
                    uno.Value = periodo;

                    SqlParameter dos = new SqlParameter("elAño", SqlDbType.VarChar, 50);
                    dos.Direction = ParameterDirection.Input;
                    dos.Value = anual;

                    carrito = new SqlCommand();
                    carrito.Parameters.Add(uno);
                    carrito.Parameters.Add(dos);

                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    mensj = "Modificacion correcta";
                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }

        public void ModificarGrupos(SqlConnection carretera, int selecc, string grado, string grupo, string turno, string especi, int cuatri, ref string mensj)
        {
            DevuelveCuatrimestres(carretera);

            DevuelveGrupos2(carretera);
            int losGrupos = hola[selecc];
            int cuatrimestre = idforeign[cuatri];
            //String query = "INSERT INTO Grupo (Grado,Grupo,Turno,especialidad,IdCuatrimestre)values(@grad,@grup,@turn,@especi," + losCuatris + ")";
            String query = "update Grupo set Grado=@grad,Grupo=@grup,Turno=@turn,especialidad=@especi,IdCuatrimestre=" + cuatrimestre + "where IdGrupo=" + losGrupos;

            if (carretera != null)
            {
                try
                {
                    SqlParameter misGrados = new SqlParameter("grad", SqlDbType.VarChar, 50);
                    misGrados.Direction = ParameterDirection.Input;
                    misGrados.Value = grado;

                    SqlParameter misGrupos = new SqlParameter("grup", SqlDbType.VarChar, 50);
                    misGrupos.Direction = ParameterDirection.Input;
                    misGrupos.Value = grupo;

                    SqlParameter misTurnos = new SqlParameter("turn", SqlDbType.VarChar, 50);
                    misTurnos.Direction = ParameterDirection.Input;
                    misTurnos.Value = turno;

                    SqlParameter misEspecia = new SqlParameter("especi", SqlDbType.VarChar, 50);
                    misEspecia.Direction = ParameterDirection.Input;
                    misEspecia.Value = especi;



                    carrito = new SqlCommand();
                    carrito.Parameters.Add(misGrados);
                    carrito.Parameters.Add(misGrupos);
                    carrito.Parameters.Add(misTurnos);
                    carrito.Parameters.Add(misEspecia);

                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    mensj = "Modificacion correcta";
                    hola.Clear();

                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }

        public void ModificarHoras(SqlConnection carretera, int selecc, string horaI, string horaF, ref string mensj)
        {
            DevuelveHorarios(carretera);
            int misHoras = horass[selecc];
            //String query1 = "INSERT INTO Horario(Hora_Entrada,Hora_Salida)values(@entrada,@salida)";
            String query = "update Horario set Hora_Entrada=@entrada,Hora_Salida=@salida where IdHorario=" + misHoras;

            if (carretera != null)
            {
                try
                {
                    SqlParameter horaE = new SqlParameter("entrada", SqlDbType.VarChar, 50);
                    horaE.Direction = ParameterDirection.Input;
                    horaE.Value = horaI;

                    SqlParameter horaS = new SqlParameter("salida", SqlDbType.VarChar, 50);
                    horaS.Direction = ParameterDirection.Input;
                    horaS.Value = horaF;

                    carrito = new SqlCommand();
                    carrito.Parameters.Add(horaE);
                    carrito.Parameters.Add(horaS);

                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    mensj = "Modificacion correcta";
                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }

        public void ModificarAula(SqlConnection carretera, int selecc, string aula1, string edificio1, ref string mensj)
        {
            DevuelveLabo(carretera);
            int misAulas = labora[selecc];
            //String query1 = "INSERT INTO Laboratorios_Edificios(Aula,Edificio)values(@aula2,@edificio2)";
            String query = "update Laboratorios_Edificios set Aula=@aula2,Edificio=@edificio2 where IdLaboratorio=" + misAulas;


            if (carretera != null)
            {
                try
                {
                    SqlParameter aula3 = new SqlParameter("aula2", SqlDbType.VarChar, 50);
                    aula3.Direction = ParameterDirection.Input;
                    aula3.Value = aula1;

                    SqlParameter edifi3 = new SqlParameter("edificio2", SqlDbType.VarChar, 50);
                    edifi3.Direction = ParameterDirection.Input;
                    edifi3.Value = edificio1;

                    carrito = new SqlCommand();
                    carrito.Parameters.Add(aula3);
                    carrito.Parameters.Add(edifi3);

                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    mensj = "Modificacion correcta";
                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }

        public void ModificarMateria(SqlConnection carretera, int selecc, string asignat, ref string mensj)
        {
            DevuelveMaterias(carretera);
            int misMaterias = materiass[selecc];
            //String query1 = "insert into Materias (Asignatura) values(@laMateria)";
            String query = "update Materias set Asignatura=@laMateria where IdMateria=" + misMaterias;

            if (carretera != null)
            {
                try
                {
                    SqlParameter mate1 = new SqlParameter("laMateria", SqlDbType.VarChar, 50);
                    mate1.Direction = ParameterDirection.Input;
                    mate1.Value = asignat;

                    carrito = new SqlCommand();
                    carrito.Parameters.Add(mate1);

                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    mensj = "Modificacion correcta";
                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }

        public void ModificarProfesor(SqlConnection carretera, int selecc, string nomP, string apeP, string apeM, string matriP, ref string mensj)
        {
            DevuelveProfes(carretera);
            int misProfes = profess[selecc];
            //String query1 = "INSERT INTO profesor(Nombre_P,Apellido_P,Apellido_M,Matricula) values(@nombre,@paterno,@materno,@matricula)";
            String query = "update profesor set Nombre_P=@nombre,Apellido_P=@paterno,Apellido_M=@materno,Matricula=@matricula where IdProfesor=" + misProfes;

            if (carretera != null)
            {
                try
                {
                    SqlParameter nom1 = new SqlParameter("nombre", SqlDbType.VarChar, 50);
                    nom1.Direction = ParameterDirection.Input;
                    nom1.Value = nomP;

                    SqlParameter apeP1 = new SqlParameter("paterno", SqlDbType.VarChar, 50);
                    apeP1.Direction = ParameterDirection.Input;
                    apeP1.Value = apeP;

                    SqlParameter apeM1 = new SqlParameter("materno", SqlDbType.VarChar, 50);
                    apeM1.Direction = ParameterDirection.Input;
                    apeM1.Value = apeM;

                    SqlParameter matri1 = new SqlParameter("matricula", SqlDbType.VarChar, 50);
                    matri1.Direction = ParameterDirection.Input;
                    matri1.Value = matriP;

                    carrito = new SqlCommand();
                    carrito.Parameters.Add(nom1);
                    carrito.Parameters.Add(apeP1);
                    carrito.Parameters.Add(apeM1);
                    carrito.Parameters.Add(matri1);

                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    mensj = "Modificacion correcta";
                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }

        public void ModificarAsignaciones(SqlConnection carretera, int selecc, int idGrup, int idLabo, int idDia, int idMate, int idProfe, int idHor, ref string mensj)
        {
            DevuelveAsignaciones(carretera);
            int misAsigna = asignaaa[selecc];

            DevuelveGrupos2(carretera);
            int misGrupos = hola[idGrup];

            DevuelveLabo(carretera);
            int misAulas = labora[idLabo];

            DevuelveDias(carretera);
            int misDias = diass[idDia];

            DevuelveMaterias(carretera);
            int misMates = materiass[idMate];

            DevuelveProfes(carretera);
            int misProfes = profess[idProfe];

            DevuelveHorarios(carretera);
            int misHoras = horass[idHor];

            String query = @"update AsignaHorario set IdGrupo=@grupo,IdLaboratorio=@aula,IdDia=@dia,IdMateria=@mate,IdProfesor=@profe,IdHorario=@horari 
where IdAsignacion=" + misAsigna;
            hola.Clear();
            labora.Clear();
            diass.Clear();
            materiass.Clear();
            profess.Clear();
            horass.Clear();

            if (carretera != null)
            {
                try
                {
                    SqlParameter grup = new SqlParameter("grupo", SqlDbType.Int, 50);
                    grup.Direction = ParameterDirection.Input;
                    grup.Value = misGrupos;

                    SqlParameter au = new SqlParameter("aula", SqlDbType.Int, 50);
                    au.Direction = ParameterDirection.Input;
                    au.Value = misAulas;

                    SqlParameter diaa = new SqlParameter("dia", SqlDbType.Int, 50);
                    diaa.Direction = ParameterDirection.Input;
                    diaa.Value = misDias;

                    SqlParameter mater = new SqlParameter("mate", SqlDbType.Int, 50);
                    mater.Direction = ParameterDirection.Input;
                    mater.Value = misMates;

                    SqlParameter prof = new SqlParameter("profe", SqlDbType.Int, 50);
                    prof.Direction = ParameterDirection.Input;
                    prof.Value = misProfes;

                    SqlParameter hor = new SqlParameter("horari", SqlDbType.Int, 50);
                    hor.Direction = ParameterDirection.Input;
                    hor.Value = misHoras;

                    carrito = new SqlCommand();
                    carrito.Parameters.Add(grup);
                    carrito.Parameters.Add(au);
                    carrito.Parameters.Add(diaa);
                    carrito.Parameters.Add(mater);
                    carrito.Parameters.Add(prof);
                    carrito.Parameters.Add(hor);

                    carrito.Connection = carretera;
                    carrito.CommandText = query;
                    carrito.ExecuteNonQuery();
                    mensj = "Horario asignado";
                }
                catch (Exception h)
                {
                    mensj = "Error " + h.Message;
                }
                carretera.Close();
            }
            else
            {
                mensj = "No hay conexion abierta";
            }
        }

        // ////////////////////////////////////    CONSULTAS PARA LAS FOREIGN KEY ////////////////////////////////////////////////////////////////////////////////// 
        public SqlDataReader ConsultaGrupos2(SqlConnection cn_abierta, ref string mensj)
        {
            SqlDataReader contenedor = null;
            carrito = new SqlCommand("select * from Grupo order by Grupo asc;", cn_abierta);

            if (cn_abierta != null)
            {
                try
                {
                    contenedor = carrito.ExecuteReader();
                    mensj = "Consulta correcta";
                }
                catch (Exception g)
                {
                    mensj = "Error: " + g.Message;
                    contenedor = null;
                }
            }
            else
            {
                mensj = "No hay conexión abierta";
                contenedor = null;
            }
            return contenedor;
        }

        public SqlDataReader ConsultaCuatri(SqlConnection cn_abierta, ref string mensj)
        {
            SqlDataReader contenedor = null;
            carrito = new SqlCommand("SELECT * FROM cuatrimestre order by IdCuatrimestre", cn_abierta);

            if (cn_abierta != null)
            {
                try
                {
                    contenedor = carrito.ExecuteReader();
                    mensj = "Consulta correcta";
                }
                catch (Exception g)
                {
                    mensj = "Error: " + g.Message;
                    contenedor = null;
                }
            }
            else
            {
                mensj = "No hay conexión abierta";
                contenedor = null;
            }
            return contenedor;
        }

        public SqlDataReader ConsultaAlumnos(SqlConnection cn_abierta, ref string mensj)
        {
            SqlDataReader contenedor = null;
            carrito = new SqlCommand("SELECT * FROM SolicitarAulaLaboratorio order by idalumno", cn_abierta);

            if (cn_abierta != null)
            {
                try
                {
                    contenedor = carrito.ExecuteReader();
                    mensj = "Consulta correcta";
                }
                catch (Exception g)
                {
                    mensj = "Error: " + g.Message;
                    contenedor = null;
                }
            }
            else
            {
                mensj = "No hay conexión abierta";
                contenedor = null;
            }
            return contenedor;
        }

        public SqlDataReader ConsultaDias(SqlConnection cn_abierta, ref string mensj)
        {
            SqlDataReader contenedor = null;
            carrito = new SqlCommand("SELECT * FROM Dias order by idDia asc", cn_abierta);

            if (cn_abierta != null)
            {
                try
                {
                    contenedor = carrito.ExecuteReader();
                    mensj = "Consulta correcta";
                }
                catch (Exception g)
                {
                    mensj = "Error: " + g.Message;
                    contenedor = null;
                }
            }
            else
            {
                mensj = "No hay conexión abierta";
                contenedor = null;
            }
            return contenedor;
        }

        public SqlDataReader ConsultaHoras(SqlConnection cn_abierta, ref string mensj)
        {
            SqlDataReader contenedor = null;
            carrito = new SqlCommand("SELECT * FROM Horario", cn_abierta);

            if (cn_abierta != null)
            {
                try
                {
                    contenedor = carrito.ExecuteReader();
                    mensj = "Consulta correcta";
                }
                catch (Exception g)
                {
                    mensj = "Error: " + g.Message;
                    contenedor = null;
                }
            }
            else
            {
                mensj = "No hay conexión abierta";
                contenedor = null;
            }
            return contenedor;
        }

        public SqlDataReader ConsultaMaterias(SqlConnection cn_abierta, ref string mensj)
        {
            SqlDataReader contenedor = null;
            carrito = new SqlCommand("SELECT * FROM Materias order by idMateria ASC", cn_abierta);

            if (cn_abierta != null)
            {
                try
                {
                    contenedor = carrito.ExecuteReader();
                    mensj = "Consulta correcta";
                }
                catch (Exception g)
                {
                    mensj = "Error: " + g.Message;
                    contenedor = null;
                }
            }
            else
            {
                mensj = "No hay conexión abierta";
                contenedor = null;
            }
            return contenedor;
        }

        public SqlDataReader ConsultaProfesor(SqlConnection cn_abierta, ref string mensj)
        {
            SqlDataReader contenedor = null;
            carrito = new SqlCommand("SELECT * FROM Profesor", cn_abierta);

            if (cn_abierta != null)
            {
                try
                {
                    contenedor = carrito.ExecuteReader();
                    mensj = "Consulta correcta";
                }
                catch (Exception g)
                {
                    mensj = "Error: " + g.Message;
                    contenedor = null;
                }
            }
            else
            {
                mensj = "No hay conexión abierta";
                contenedor = null;
            }
            return contenedor;
        }

        public SqlDataReader ConsultaLaboratorios(SqlConnection cn_abierta, ref string mensj)
        {
            SqlDataReader contenedor = null;
            carrito = new SqlCommand("SELECT * FROM Laboratorios_Edificios ", cn_abierta);

            if (cn_abierta != null)
            {
                try
                {
                    contenedor = carrito.ExecuteReader();
                    mensj = "Consulta correcta";
                }
                catch (Exception g)
                {
                    mensj = "Error: " + g.Message;
                    contenedor = null;
                }
            }
            else
            {
                mensj = "No hay conexión abierta";
                contenedor = null;
            }
            return contenedor;
        }

        public SqlDataReader ConsultaAsignaciones2(SqlConnection cn_abierta, ref string mensj)
        {
            SqlDataReader contenedor = null;
            carrito = new SqlCommand("SELECT * FROM AsignaHorario ", cn_abierta);

            if (cn_abierta != null)
            {
                try
                {
                    contenedor = carrito.ExecuteReader();
                    mensj = "Consulta correcta";
                }
                catch (Exception g)
                {
                    mensj = "Error: " + g.Message;
                    contenedor = null;
                }
            }
            else
            {
                mensj = "No hay conexión abierta";
                contenedor = null;
            }
            return contenedor;
        }


        public SqlDataReader ConsultaAsignaciones3(SqlConnection cn_abierta, ref string mensj)
        {
            SqlDataReader contenedor = null;
            carrito = new SqlCommand(@"select distinct CONCAT(grup.Grado,' ',grup.Grupo) as Grupo,grup.Turno,grup.Especialidad,diaSem.Dia,
CONCAT(labo_e.Aula,' del ',labo_e.Edificio) as Aula, concat(horas.Hora_Entrada,' a ',horas.Hora_Salida) as Horario
from AsignaHorario asig
JOIN Grupo grup ON grup.IdGrupo = asig.IdGrupo
JOIN cuatrimestre cuatri ON cuatri.IdCuatrimestre = grup.IdCuatrimestre
JOIN Laboratorios_Edificios labo_e ON labo_e.IdLaboratorio = asig.IdLaboratorio
JOIN Dias diaSem ON diaSem.IdDia = asig.IdDia
JOIN Horario horas ON horas.IdHorario = asig.IdHorario", cn_abierta);

            if (cn_abierta != null)
            {
                try
                {
                    contenedor = carrito.ExecuteReader();
                    mensj = "Consulta correcta";
                }
                catch (Exception g)
                {
                    mensj = "Error: " + g.Message;
                    contenedor = null;
                }
            }
            else
            {
                mensj = "No hay conexión abierta";
                contenedor = null;
            }
            return contenedor;
        }
        // /////////////////////////////////////// CONSULTAS PARA DEVOLVER INFORMACION EN COMBOBOX O LISTBOX ///////////////////////////////////////////////////////

        public SqlDataReader ConsultaNoDisponibles(SqlConnection cn_abierta, int selecc, int selecc2, ref string mensj)
        {
            DevuelveDias(cn_abierta);
            int misDias = diass[selecc];
            DevuelveCuatrimestres(cn_abierta);
            int misCuatris = cuatriss[selecc2];
            SqlDataReader contenedor = null;
            carrito = new SqlCommand(@"select distinct CONCAT(grup.Grado,' ',grup.Grupo) as Grupo,grup.Turno,grup.Especialidad,diaSem.Dia,
CONCAT(labo_e.Aula,' del ',labo_e.Edificio) as Aula, concat(horas.Hora_Entrada,' a ',horas.Hora_Salida) as Horario
from AsignaHorario asig
JOIN Grupo grup ON grup.IdGrupo = asig.IdGrupo
JOIN cuatrimestre cuatri ON cuatri.IdCuatrimestre = grup.IdCuatrimestre
JOIN Laboratorios_Edificios labo_e ON labo_e.IdLaboratorio = asig.IdLaboratorio
JOIN Dias diaSem ON diaSem.IdDia = asig.IdDia
JOIN Horario horas ON horas.IdHorario = asig.IdHorario
where diaSem.IdDia= " + misDias + "and cuatri.IdCuatrimestre = " + misCuatris, cn_abierta);

            if (cn_abierta != null)
            {
                try
                {
                    contenedor = carrito.ExecuteReader();
                    mensj = "Consulta correcta";
                }
                catch (Exception g)
                {
                    mensj = "Error: " + g.Message;
                    contenedor = null;
                }
            }
            else
            {
                mensj = "No hay conexión abierta";
                contenedor = null;
            }
            return contenedor;
        }

        public SqlDataReader ConsultaAsiganciones(SqlConnection cn_abierta, ref string mensj)
        {
            SqlDataReader contenedor = null;
            carrito = new SqlCommand(@"select distinct concat(cuatri.Periodo,' ',cuatri.Año)as Cuatrimestre, grup.Grado, grup.Grupo,grup.Turno,labo_e.Aula,labo_e.Edificio, diaSem.Dia,
mate.Asignatura, concat(profe.Nombre_P,' ',profe.Apellido_P,' ',profe.Apellido_M) as Docente, concat(horas.Hora_Entrada,' a ',horas.Hora_Salida) as Horario
from AsignaHorario asig
JOIN Grupo grup ON grup.IdGrupo = asig.IdGrupo
JOIN cuatrimestre cuatri ON cuatri.IdCuatrimestre = grup.IdCuatrimestre
JOIN Laboratorios_Edificios labo_e ON labo_e.IdLaboratorio = asig.IdLaboratorio
JOIN Dias diaSem ON diaSem.IdDia = asig.IdDia
JOIN Materias mate ON mate.IdMateria = asig.IdMateria
JOIN Profesor profe ON profe.IdProfesor = asig.IdProfesor
JOIN Horario horas ON horas.IdHorario = asig.IdHorario", cn_abierta);

            /*"concat(mat.Descripcion, CHAR(10), pp.Nombre_P)"*/

            if (cn_abierta != null)
            {
                try
                {
                    contenedor = carrito.ExecuteReader();
                    mensj = "Consulta correcta";
                }
                catch (Exception g)
                {
                    mensj = "Error: " + g.Message;
                    contenedor = null;
                }
            }
            else
            {
                mensj = "No hay conexión abierta";
                contenedor = null;
            }
            return contenedor;
        }

        public SqlDataReader ConsultaGrupos(SqlConnection cn_abierta, ref string mensj)
        {
            SqlDataReader contenedor = null;
            carrito = new SqlCommand(@"select grup.Grado,grup.Grupo,grup.Turno, grup.Especialidad,cuatri.Periodo,cuatri.Año
            from Grupo grup
            JOIN cuatrimestre cuatri ON cuatri.IdCuatrimestre = grup.IdCuatrimestre order by grup.Grupo asc;", cn_abierta);

            if (cn_abierta != null)
            {
                try
                {
                    contenedor = carrito.ExecuteReader();
                    mensj = "Consulta correcta";
                }
                catch (Exception g)
                {
                    mensj = "Error: " + g.Message;
                    contenedor = null;
                }
            }
            else
            {
                mensj = "No hay conexión abierta";
                contenedor = null;
            }
            return contenedor;
        }

        public SqlDataReader ConsultaAlumnos2(SqlConnection cn_abierta, ref string mensj)
        {
            SqlDataReader contenedor = null;
            carrito = new SqlCommand(@"select distinct NombreA as Nombre,apellidoPA as Apellido_paterno,apellidoMA as Apellido_materno,MatriculaA as Matricula
                                     from SolicitarAulaLaboratorio
                                     order by idalumno asc;", cn_abierta);

            if (cn_abierta != null)
            {
                try
                {
                    contenedor = carrito.ExecuteReader();
                    mensj = "Consulta correcta";
                }
                catch (Exception g)
                {
                    mensj = "Error: " + g.Message;
                    contenedor = null;
                }
            }
            else
            {
                mensj = "No hay conexión abierta";
                contenedor = null;
            }
            return contenedor;
        }

        ///////////////////////////////////////////////////// METODOS QUE DEVUELVEN IDS // /////////////////////////////////////////////////////////////////

        public void DevuelveCuatrimestres(SqlConnection cn)
        {
            int posicion = 0;
            string j = "";
            SqlDataReader ids = ConsultaCuatri(cn, ref j);
            while (ids.Read())
            {
                idforeign.Add((int)ids[0]);
                posicion++;
            }
            ids.Close();
        }

        public void DevuelveAlumnos(SqlConnection cn)
        {
            int posicion = 0;
            string j = "";
            SqlDataReader ids = ConsultaAlumnos(cn, ref j);
            while (ids.Read())
            {
                alumnoss.Add((int)ids[0]);
                posicion++;
            }
            ids.Close();
        }

        public void DevuelveGrupos(SqlConnection cn)
        {
            int posicion = 0;
            string j = "";
            SqlDataReader ids = ConsultaGrupos2(cn, ref j);
            while (ids.Read())
            {
                idforeign.Add((int)ids[0]);

                posicion++;
            }
            ids.Close();
        }

        public void DevuelveGrupos2(SqlConnection cn)
        {
            int posicion = 0;
            string j = "";
            SqlDataReader ids = ConsultaGrupos2(cn, ref j);
            while (ids.Read())
            {
                hola.Add((int)ids[0]);

                posicion++;
            }
            ids.Close();
        }

        public void DevuelveHorarios(SqlConnection cn)
        {
            int posicion = 0;
            string j = "";
            SqlDataReader ids = ConsultaHoras(cn, ref j);
            while (ids.Read())
            {
                horass.Add((int)ids[0]);
                posicion++;
            }
            ids.Close();
        }

        public void DevuelveLabo(SqlConnection cn)
        {
            int posicion = 0;
            string j = "";
            SqlDataReader ids = ConsultaLaboratorios(cn, ref j);
            while (ids.Read())
            {
                labora.Add((int)ids[0]);
                posicion++;
            }
            ids.Close();
        }

        public void DevuelveMaterias(SqlConnection cn)
        {
            int posicion = 0;
            string j = "";
            SqlDataReader ids = ConsultaMaterias(cn, ref j);
            while (ids.Read())
            {
                materiass.Add((int)ids[0]); //+ (int)ids[1] + (int)ids[2]//);
                posicion++;
            }
            ids.Close();
        }

        public void DevuelveProfes(SqlConnection cn)
        {
            int posicion = 0;
            string j = "";
            SqlDataReader ids = ConsultaProfesor(cn, ref j);
            while (ids.Read())
            {
                profess.Add((int)ids[0]); //+ (int)ids[1] + (int)ids[2]//);
                posicion++;
            }
            ids.Close();
        }

        public void DevuelveDias(SqlConnection cn)
        {
            int posicion = 0;
            string j = "";
            SqlDataReader ids = ConsultaDias(cn, ref j);
            while (ids.Read())
            {
                diass.Add((int)ids[0]); //+ (int)ids[1] + (int)ids[2]//);
                posicion++;
            }
            ids.Close();
        }

        public void DevuelveAsignaciones(SqlConnection cn)
        {
            int posicion = 0;
            string j = "";
            SqlDataReader ids = ConsultaAsignaciones2(cn, ref j);
            while (ids.Read())
            {
                asignaaa.Add((int)ids[0]); //+ (int)ids[1] + (int)ids[2]//);
                posicion++;
            }
            ids.Close();
        }

        public List<string> categorias(ref string msj)
        {
            List<string> ids = new List<string>();
            SqlConnection cnt2 = null;
            SqlDataReader dr1 = null;

            cnt2 = capa1.AbrirConexion();
            if (cnt2 != null)
            {
                dr1 = capa1.ConsultaDataReader(ref cnt2, "select  Matricula from Alumno", ref msj);
                if (dr1 != null)
                {
                    ids.Clear();
                    while (dr1.Read())
                    {
                        ids.Add((string)dr1[0]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }
            return ids;
        }
        public List<int> devulveIdalumno(ref List<string> nombres, ref string msj)
        {
            List<int> ids = new List<int>();
            SqlConnection cnt2 = null;
            SqlDataReader dr1 = null;

            cnt2 = capa1.AbrirConexion();
            if (cnt2 != null)
            {
                dr1 = capa1.ConsultaDataReader(ref cnt2, "select Matricula from Alumno", ref msj);
                if (dr1 != null)
                {
                    ids.Clear();
                    while (dr1.Read())
                    {
                        ids.Add((int)dr1[0]);
                        nombres.Add((string)dr1[4]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }
            return ids;
        }

        public List<string> devulvegrups( ref string msj)
        {
            List<string> ids = new List<string>();
            SqlConnection cnt2 = null;
            SqlDataReader dr1 = null;

            cnt2 = capa1.AbrirConexion();
            if (cnt2 != null)
            {
                dr1 = capa1.ConsultaDataReader(ref cnt2, "select Grupo from Grupo", ref msj);
                if (dr1 != null)
                {
                    ids.Clear();
                    while (dr1.Read())
                    {
                        ids.Add((string)dr1[0]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }
            return ids;
        }



        public List<int> devuelveGrupos(ref List<string> grupos, ref string mnsj)
        {
            ManejaSQL cn = new ManejaSQL();
            List<int> ids = new List<int>();
          //  string query = "select * from Grupo";
            SqlConnection cnt2 = null;
            SqlDataReader dr1 = null;
            cnt2 = capa1.AbrirConexion();
            if (cnt2 != null)
            {
                dr1 = capa1.ConsultaDataReader(ref cnt2, "select * from Grupo", ref mensj);

                if (dr1 != null)
                {
                    while (dr1.Read())
                    {
                        ids.Add((int)dr1[0]);
                        grupos.Add((string)dr1[2]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }
           
                cnt2.Close();
                cnt2.Dispose();
            
            return ids;
        }

        public List<int> devuelvelibres(ref List<string> edificio, ref string mnsj)
        {
            ManejaSQL cn = new ManejaSQL();
            List<int> ids = new List<int>();
            string query = "select * from Laboratorios_Edificios";
            SqlConnection cnt2 = null;
            SqlDataReader dr1 = null;
            cnt2 = cn.AbrirConexion();
            if (cnt2 != null)
            {
                dr1 = cn.ConsultaDataReader(ref cnt2, query, ref mnsj);
                if (dr1 != null)
                {
                    while (dr1.Read())
                    {
                        ids.Add((int)dr1[0]);
                        edificio.Add((string)dr1[1]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }
            else if (cn != null)
            {
                dr1 = cn.ConsultaDataReader(ref cnt2, query, ref mnsj);
                if (dr1 != null)
                {
                    while (dr1.Read())
                    {
                        ids.Add((int)dr1[0]);
                        edificio.Add((string)dr1[1]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }
            return ids;
        }

        public List<int> devuelveLaboratorios(ref List<string> grupos, ref string mnsj)
        {
            
            List<int> ids = new List<int>();
            //string query = "select*from Laboratorios_Edificios;";
            SqlConnection cnt2 = null;
            SqlDataReader dr1 = null;
            cnt2 = capa1.AbrirConexion();
            if (cnt2 != null)
            {
                dr1 = capa1.ConsultaDataReader(ref cnt2, "select*from Laboratorios_Edificios", ref mensj);
                if (dr1 != null)
                {
                    while (dr1.Read())
                    {
                        ids.Add((int)dr1[0]);
                        grupos.Add((string)dr1[1]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }
            return ids;
        }

        public List<int> devuelveProfesores(ref List<string> nombres, ref string mnsj)
        {
            ManejaSQL cn = new ManejaSQL();
            List<int> ids = new List<int>();
            string query = "select*from Profesor;";
            SqlConnection cnt2 = null;
            SqlDataReader dr1 = null;
            cnt2 = cn.AbrirConexion();
            if (cnt2 != null)
            {
                dr1 = cn.ConsultaDataReader(ref cnt2, query, ref mnsj);
                if (dr1 != null)
                {
                    while (dr1.Read())
                    {
                        ids.Add((int)dr1[0]);
                        nombres.Add((string)dr1[1]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }
            return ids;
        }

        public List<int> devuelveSoloMaterias(ref List<string> materias, ref string mnsj)
        {
            ManejaSQL cn = new ManejaSQL();
            List<int> ids = new List<int>();
            string query = "select*from Materias;";
            SqlConnection cnt2 = null;
            SqlDataReader dr1 = null;
            cnt2 = cn.AbrirConexion();
            if (cnt2 != null)
            {
                dr1 = cn.ConsultaDataReader(ref cnt2, query, ref mnsj);
                if (dr1 != null)
                {
                    while (dr1.Read())
                    {
                        ids.Add((int)dr1[0]);
                        materias.Add((string)dr1[1]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }
            return ids;
        }

        public List<int> devuelveGruposs(ref List<string> grupos, ref string mnsj)
        {
            ManejaSQL cn = new ManejaSQL();
            List<int> ids = new List<int>();
            string query = "select * from Grupo";
            SqlConnection cnt2 = null;
            SqlDataReader dr1 = null;
            cnt2 = cn.AbrirConexion();
            if (cnt2 != null)
            {
                dr1 = cn.ConsultaDataReader(ref cnt2, query, ref mnsj);
                if (dr1 != null)
                {
                    while (dr1.Read())
                    {
                        ids.Add((int)dr1[0]);
                        grupos.Add((string)dr1[1]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }
            return ids;
        }

        public List<int> Diascombo(ref List<string> dias, ref string mnsj)
        {
            ManejaSQL cn = new ManejaSQL();
            List<int> ids = new List<int>();
           // string query = "select*from Dias";
            SqlConnection cnt2 = null;
            SqlDataReader dr1 = null;
            cnt2 = capa1.AbrirConexion();
            if (cnt2 != null)
            {
                dr1 = capa1.ConsultaDataReader(ref cnt2, "select*from Dias", ref mensj);
                if (dr1 != null)
                {
                    while (dr1.Read())
                    {
                        ids.Add((int)dr1[0]);
                        dias.Add((string)dr1[1]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }
            return ids;
        }

        public List<int> devuelveHoras(ref List<string> horas, ref string mnsj)
        {
            ManejaSQL cn = new ManejaSQL();
            List<int> ids = new List<int>();
           // string query = "select*from Horario";
            SqlConnection cnt2 = null;
            SqlDataReader dr1 = null;
            cnt2 = cn.AbrirConexion();
            if (cnt2 != null)
            {
                dr1 = capa1.ConsultaDataReader(ref cnt2, "select*from Horario", ref mensj);
                if (dr1 != null)
                {
                    while (dr1.Read())
                    {
                        ids.Add((int)dr1[0]);
                        horas.Add((string)dr1[1]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }
            return ids;
        }

        public List<int> listadedias(ref List<string> horas, ref string mnsj)
        {
            ManejaSQL cn = new ManejaSQL();
            List<int> ids = new List<int>();
            // string query = "select*from Horario";
            SqlConnection cnt2 = null;
            SqlDataReader dr1 = null;
            cnt2 = cn.AbrirConexion();
            if (cnt2 != null)
            {
                dr1 = capa1.ConsultaDataReader(ref cnt2, "select*from Dias", ref mensj);
                if (dr1 != null)
                {
                    while (dr1.Read())
                    {
                        ids.Add((int)dr1[0]);
                        horas.Add((string)dr1[1]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }
            return ids;
        }

        //public List<string> horariolib(ref string msj)
        //{
        //    List<string> ids = new List<string>();
        //    SqlConnection cnt2 = null;
        //    SqlDataReader dr1 = null;

        //    cnt2 = capa1.AbrirConexion();
        //    if (cnt2 != null)
        //    {
        //        dr1 = capa1.ConsultaDataReader(ref cnt2, "select  Matricula from Alumno", ref msj);
        //        if (dr1 != null)
        //        {
        //            ids.Clear();
        //            while (dr1.Read())
        //            {
        //                ids.Add((string)dr1[0]);
        //            }
        //        }
        //        cnt2.Close();
        //        cnt2.Dispose();
        //    }
        //    return ids;
        //}
        public bool InsertarAsistencia(int horario, string fecha, int asistencias)
        {
            ManejaSQL cn = new ManejaSQL();
            try
            {
                string query = "insert into Asistencias_Laboratorios values(@horario,@fecha,@asistencias)";

                SqlParameter uno = new SqlParameter("horario", SqlDbType.Int);
                uno.Direction = ParameterDirection.Input;
                uno.Value = horario;

                SqlParameter dos = new SqlParameter("fecha", SqlDbType.VarChar, 50);
                dos.Direction = ParameterDirection.Input;
                dos.Value = fecha;

                SqlParameter tres = new SqlParameter("asistencias", SqlDbType.Int);
                tres.Direction = ParameterDirection.Input;
                tres.Value = asistencias;

                SqlCommand cmd = new SqlCommand(query, cn.AbrirConexion());

                cmd.Parameters.Add(uno);
                cmd.Parameters.Add(dos);
                cmd.Parameters.Add(tres);

                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // ///////////////////////////////////////// CONSULTA dataSet ////////////////////////////////////////////////////////////

        public System.Data.DataTable ConsultarHorarios(ref string ms)
        {
            //Conectar cn = new Conectar();
            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = capa1.AbrirConexion();
            if (cnt3 != null)
            {
                Caja = capa1.ConsultaDataSet(cnt3, "ConsultarHorario", ref ms);
                if (Caja != null)
                {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }

        public System.Data.DataTable ConsultarHorariosProf(int id, ref string ms)
        {
           // C/*onectar cn = new Conectar();*/
            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = capa1.AbrirConexion();
            if (cnt3 != null)
            {
                Caja = capa1.ConsultaDataSet(cnt3, "ConsultaHorarioProf " + id + "", ref ms);
                if (Caja != null)
                {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }



        public System.Data.DataTable ConsultarProfesores(ref string ms)
        {
            ManejaSQL cn = new ManejaSQL();
            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = cn.AbrirConexion();
            if (cnt3 != null)
            {
                Caja = cn.ConsultaDataSet(cnt3, "select IdProfesor as 'Id Profesor', Nombre_P as 'Nombre', Apellido_P as 'Apellido paterno', " +
                    "Apellido_M as 'Apellido materno', Matricula as 'Matricula' from profesor;", ref ms);
                if (Caja != null)
                {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }



        public System.Data.DataTable GridparaAlumnos(ref string ms)
        {
            //ManejaSQL cn = new ManejaSQL();
            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = capa1.AbrirConexion();
            if (cnt3 != null)
            {
                Caja = capa1.ConsultaDataSet(cnt3, "ConsultarAlumnos", ref ms);
                if (Caja != null)
                {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }






        public System.Data.DataTable Alumnosperio(ref string ms) {
            ManejaSQL cn = new ManejaSQL();
            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = capa1.AbrirConexion();
            if (cnt3 != null) 
                {
                Caja = capa1.ConsultaDataSet(cnt3, "ConsultarAlumnosperio", ref ms);
                if (Caja != null) {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }
















        public System.Data.DataTable ConsultarDisponiblesLab(int dia, int hora, ref string ms)
        {
            //ma cn = new Conectar();
            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = capa1.AbrirConexion();
            if (cnt3 != null)
            {
                Caja = capa1.ConsultaDataSet(cnt3, "LaboratoriosDisponibles " + dia + "," + hora + "", ref ms);
                if (Caja != null)
                {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }

        public System.Data.DataTable mayorprestamo(string inicial, string final, ref string ms)
        {
          
            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = capa1.AbrirConexion();
            if (cnt3 != null)
            {
                Caja = capa1.ConsultaDataSet(cnt3, "MayorPrestamoFecha '" + inicial + "','" + final + "'", ref ms);
                if (Caja != null)
                {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }


        public System.Data.DataTable prestabro(string inicial, string final, ref string ms) {

            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = capa1.AbrirConexion();
            if (cnt3 != null) {
                Caja = capa1.ConsultaDataSet(cnt3, "MayorPrestamoFechass '" + inicial +  "'", ref ms);
                if (Caja != null) {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }

        public System.Data.DataTable ConsultarMayorAsistenciasGrupo(string inicial, string final, ref string ms)
        {
           
            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = capa1.AbrirConexion();
            if (cnt3 != null)
            {
                Caja = capa1.ConsultaDataSet(cnt3, "ConsultarAsistenciasGrupos '" + inicial + "','" + final + "'", ref ms);
                if (Caja != null)
                {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }


        public System.Data.DataTable ConsultarMayorAsistenciasGruposss(string inicial ,ref string ms)
        {

            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = capa1.AbrirConexion();
            if (cnt3 != null)
            {
                Caja = capa1.ConsultaDataSet(cnt3, "ConsultarAsistenciasGruposss '" + inicial + "'", ref ms);
                if (Caja != null)
                {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }

        //public System.Data.DataTable ConsultarLaboratorios(ref string ms)
        //{

        //    SqlConnection cnt3 = null;
        //    System.Data.DataSet Caja = null;
        //    System.Data.DataTable Salida = null;
        //    cnt3 = capa1.AbrirConexion();
        //    if (cnt3 != null)
        //    {
        //        Caja = capa1.ConsultaDataSet(cnt3, "select IdLaboratorio as 'Clave',Aula as 'Laboratorio',Edificio from Laboratorios_Edificios", ref ms);
        //        if (Caja != null)
        //        {
        //            Salida = Caja.Tables[0];
        //        }
        //    }
        //    return Salida;
        //}


        public System.Data.DataTable gridlaboratorios(ref string ms)
        {

            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = capa1.AbrirConexion();
            if (cnt3 != null)
            {
                Caja = capa1.ConsultaDataSet(cnt3, "select IdLaboratorio as 'Clave',Aula as 'Laboratorio',Edificio from Laboratorios_Edificios", ref ms);
                if (Caja != null)
                {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }

        //public List<int> devuelveMatriculasProf(ref List<string> matriculas, ref string mnsj)
        //{
        //    Conectar cn = new Conectar();
        //    List<int> ids = new List<int>();
        //    string query = "select IdProfesor,Matricula from profesor";
        //    SqlConnection cnt2 = null;
        //    SqlDataReader dr1 = null;
        //    cnt2 = cn.GetConnection();
        //    if (cnt2 != null)
        //    {
        //        dr1 = cn.ConsultaDataReader(ref cnt2, query, ref mnsj);
        //        if (dr1 != null)
        //        {
        //            while (dr1.Read())
        //            {
        //                ids.Add((int)dr1[0]);
        //                matriculas.Add((string)dr1[1]);
        //            }
        //        }
        //        cnt2.Close();
        //        cnt2.Dispose();
        //    }
        //    return ids;
        //}


        public List<int> gridprof(ref List<string> matriculas, ref string mnsj)
        {
          
            List<int> ids = new List<int>();
            string query = "select IdProfesor,Matricula from Profesor";
            SqlConnection cnt2 = null;
            SqlDataReader dr1 = null;
            cnt2 = capa1.AbrirConexion();
            if (cnt2 != null)
            {
                dr1 = capa1.ConsultaDataReader(ref cnt2, query, ref mnsj);
                if (dr1 != null)
                {
                    while (dr1.Read())
                    {
                        ids.Add((int)dr1[0]);
                        matriculas.Add((string)dr1[1]);
                    }
                }
                cnt2.Close();
                cnt2.Dispose();
            }
            return ids;
        }


        public System.Data.DataTable ConsultarHorariosProfDia(int id, string dia, ref string ms)
        {
           
            SqlConnection cnt3 = null;
            System.Data.DataSet Caja = null;
            System.Data.DataTable Salida = null;
            cnt3 = capa1.AbrirConexion();
            if (cnt3 != null)
            {
                Caja = capa1.ConsultaDataSet(cnt3, "ConsultaHorarioProfDia " + id + ",'" + dia + "'", ref ms);
                if (Caja != null)
                {
                    Salida = Caja.Tables[0];
                }
            }
            return Salida;
        }

        public DataSet DTConsultarHorario(SqlConnection carretera, int selecc, ref string mensj)
        {
            DevuelveCuatrimestres(carretera);
            int losCuatris = idforeign[selecc];
            return msql.ConsultaDataSet(carretera, @"select distinct concat(cuatri.Periodo,' ',cuatri.Año)as Cuatrimestre, grup.Grado, grup.Grupo,grup.Turno,grup.Especialidad,labo_e.Aula,labo_e.Edificio, diaSem.Dia,
mate.Asignatura, concat(profe.Nombre_P,' ',profe.Apellido_P,' ',profe.Apellido_M) as Docente, concat(horas.Hora_Entrada,' a ',horas.Hora_Salida) as Horario
from AsignaHorario asig
JOIN Grupo grup ON grup.IdGrupo = asig.IdGrupo
JOIN cuatrimestre cuatri ON cuatri.IdCuatrimestre = grup.IdCuatrimestre
JOIN Laboratorios_Edificios labo_e ON labo_e.IdLaboratorio = asig.IdLaboratorio
JOIN Dias diaSem ON diaSem.IdDia = asig.IdDia
JOIN Materias mate ON mate.IdMateria = asig.IdMateria
JOIN Profesor profe ON profe.IdProfesor = asig.IdProfesor
JOIN Horario horas ON horas.IdHorario = asig.IdHorario where cuatri.IdCuatrimestre = " + losCuatris, ref mensj);
        }

        public DataSet DTConsultarAlumnos(SqlConnection carretera, int selecc, ref string mensj)
        {
            DevuelveAlumnos(carretera);
            int losAlumnos = alumnoss[selecc];
            return msql.ConsultaDataSet(carretera, @"select distinct CONCAT(solici.NombreA,' ',solici.apellidoPA,' ',solici.apellidoMA) as Alumno,grup.Turno,solici.MatriculaA as Matricula,
CONCAT(grup.Grado,' ',grup.Grupo,', ',grup.Turno,', ',grup.Especialidad) as Grupo, diaSem.Dia, CONCAT(solici.aula,' del ',solici.edifi) as Laboratorio,
solici.he as Hora_entrada, solici.hs as Hora_salida
from SolicitarAulaLaboratorio solici
JOIN Grupo grup ON grup.IdGrupo = solici.IdGrupo
join Dias diaSem on diaSem.IdDia = solici.IdDia
where solici.idalumno =" + losAlumnos, ref mensj);
        }
    }
}