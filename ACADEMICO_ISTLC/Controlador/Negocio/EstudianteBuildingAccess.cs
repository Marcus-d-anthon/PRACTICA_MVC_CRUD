 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACADEMICO_ISTLC.Controlador.Datos;
using ACADEMICO_ISTLC.Modelo;

namespace ACADEMICO_ISTLC.Controlador.Negocio
{
    public class EstudianteBuildingAccess
    {
        /* El controlador se compone de la capa de negocios y la capa de datos
         * La capa de negocios se comunica primero con la pantall
         * La capa de datos, se refiere a la Base de Datos
         */
        public List<Estudiante> GetEstudiantesBL()
        {
            EstudianteDataAccess objEstudianteDataAccess = new EstudianteDataAccess();
            return objEstudianteDataAccess.GetEstudianteDA();
        }
    }
}
