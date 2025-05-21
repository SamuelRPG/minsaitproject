using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoMinsait
{
    internal class Ubicacion
    {
        private string direccion;
        private bool esonline;

        public Ubicacion (string direccion, bool esonline)
        {
            this.direccion = direccion;
            this.esonline = esonline;
        }

        public string Direccion { get { return direccion; } }
        public bool Esonline { get { return esonline; } }
    }
}
