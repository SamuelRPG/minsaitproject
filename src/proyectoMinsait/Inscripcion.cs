using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoMinsait
{
    internal class Inscripcion
    {
        private Evento eventoInscrito;
        private Usuario usuarioInscrito;

        public Inscripcion(Evento e, Usuario u)
        {
            this.eventoInscrito = e;
            this.usuarioInscrito = u;
        }

        public Evento Evento { get { return eventoInscrito; } }
        public Usuario UsuarioInscrito { get { return usuarioInscrito; } }
    }
}
