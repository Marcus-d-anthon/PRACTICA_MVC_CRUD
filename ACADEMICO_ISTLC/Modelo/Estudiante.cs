using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMICO_ISTLC.Modelo
{
    public class Estudiante
    {
        string cedula;
        string nombres;
        string apellidos;
        string direccion;
        DateTime fecha_nacimiento;
        string contrasena;

        public Estudiante(string cedula, string nombres, string apellidos, string direccion, DateTime fecha_nacimiento, string contrasena)
        {
            this.Cedula = cedula;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Direccion = direccion;
            this.Fecha_nacimiento = fecha_nacimiento;
            this.Contrasena = contrasena;
        }

        //Encapsulacion: se usa para temas de seguridad
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
    }
}
