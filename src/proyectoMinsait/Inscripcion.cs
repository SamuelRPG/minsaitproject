using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoMinsait
{
    internal class Inscripcion
    {
        private Evento evento;
        private Usuario usuarioInscrito;

        public Inscripcion(Evento e, Usuario u)
        {
            this.evento = e;
            this.usuarioInscrito = u;
        }
    }
}
