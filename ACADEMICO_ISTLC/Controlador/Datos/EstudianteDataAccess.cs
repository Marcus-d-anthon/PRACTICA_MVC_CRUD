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
        public List<Estudiante> getEstudiante()
        {
            List<Estudiante> respuesta = new List<Estudiante>();
            SqlCommand comando = new SqlCommand(); //Ejecuta comandos dentro de la Base de Datos
            comando.Connection = BaseDatos.GetConnection();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_CONS_ESTUDIANTES"; //En la lista tipo 'Estudiante', almacenará todos los datos de la tabla
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataSet data = new DataSet();
            adaptador.Fill(data);
            respuesta = fillEstudiantes(data.Tables[0]);
            return respuesta;
        }

        private List<Estudiante> fillEstudiantes(DataTable dataTable)
        {
            throw new NotImplementedException();
        }
    }
}
