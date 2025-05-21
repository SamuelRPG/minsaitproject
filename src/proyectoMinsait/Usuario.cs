using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace proyectoMinsait
{
    internal class Usuario
    {
        private string nombre;
        private string correo;
        private List<Inscripcion> inscripciones;

        public Usuario(string n, string correo)
        {
            this.nombre = n;
            this.correo = correo;
            inscripciones = new List<Inscripcion>();
        }
    }
}
