using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACADEMICO_ISTLC.Modelo;

namespace ACADEMICO_ISTLC.Controlador.Datos
{
    public class EstudianteDataAccess
    {
        public List<Estudiante> GetEstudianteDA() //Funcion
        {
            List<Estudiante> respuesta = new List<Estudiante>();

            SqlCommand comando = new SqlCommand(); //Ejecuta comandos dentro de la Base de Datos
            comando.Connection = BaseDatos.GetConnection(); //1) la conexion
            comando.CommandType = System.Data.CommandType.StoredProcedure; //2) tipo de comando que se va a ingresar
            comando.CommandText = "SP_CONS_ESTUDIANTES"; //3) nombre del stored procedure
            
            SqlDataAdapter adaptador = new SqlDataAdapter(comando); //Extrae datos de la Base de Datos
            DataSet data = new DataSet(); //Se transforma a un data set
            adaptador.Fill(data);

            respuesta = fillEstudiantes(data.Tables[0]);
            return respuesta;
        }

        public void addEstudiante(Estudiante objestudiante)
        {
            SqlCommand comando = new SqlCommand(); //Ejecuta comandos dentro de la Base de Datos
            comando.Connection = BaseDatos.GetConnection(); //1) la conexion
            comando.CommandType = System.Data.CommandType.StoredProcedure; //2) tipo de comando que se va a ingresar
            comando.CommandText = "SP_CONS_ESTUDIANTES"; //3) nombre del stored procedure

            SqlParameter parametro1 = new SqlParameter("CEDULA", objestudiante.Cedula);
            comando.Parameters.Add(parametro1);
            SqlParameter parametro2 = new SqlParameter("NOMBRES", objestudiante.Nombres);
            comando.Parameters.Add(parametro2);
            SqlParameter parametro3 = new SqlParameter("APELLIDOS", objestudiante.Apellidos);
            comando.Parameters.Add(parametro3);
            SqlParameter parametro4 = new SqlParameter("DIRECCION", objestudiante.Direccion);
            comando.Parameters.Add(parametro4);
            SqlParameter parametro5 = new SqlParameter("FECHA_NACIMIENTO", objestudiante.Fecha_nacimiento);
            comando.Parameters.Add(parametro5);
            SqlParameter parametro6 = new SqlParameter("CONTRASENA", objestudiante.Contrasena);
            comando.Parameters.Add(parametro6);
            comando.ExecuteNonQuery();  
        }

        private List<Estudiante> fillEstudiantes(DataTable datos) //Los datos ingresados en la Base de Datos estan ingresados en "datos"
        {
            List<Estudiante> respuesta = new List<Estudiante> ();
            for(int i = 0; i < datos.Rows.Count; i++)
            {
                Estudiante objEstudiante = new Estudiante
                    (datos.Rows[i]["CEDULA"].ToString(),
                    datos.Rows[i]["NOMBRES"].ToString(),
                    datos.Rows[i]["APELLIDOS"].ToString(),
                    datos.Rows[i]["DIRECCION"].ToString(),
                    Convert.ToDateTime(datos.Rows[i]["FECHA_NACIMIENTO"]), // DateTime.Parse(datos.Rows[i]["FECHA_NACIMIENTO"].ToString())
                    datos.Rows[i]["CONTRASENA"].ToString()
                    );

                respuesta.Add(objEstudiante);
            }

            return respuesta;
        }
    }
}
