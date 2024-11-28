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
        public List<Estudiante> getEstudiante() //Funcion
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
