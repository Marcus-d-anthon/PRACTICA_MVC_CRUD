using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMICO_ISTLC.Controlador.Datos
{
    //Clase tipo estatica: Es una clase que no se tiene que instanciar
    public static class BaseDatos
    {
        private static string cadenaConexionSa = "Persist Security Info=False;User ID=sa;Password=E46dbg;Initial Catalog=ACADEMICO_ISTLC;Server=CompuOriginal\\SQLEXPRESS";

        public static SqlConnection conexion;

        public static SqlConnection GetConnection()
        {
            conexion = new SqlConnection(cadenaConexionSa); 
            conexion.Open();
            return conexion;
        }
    }
}
