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

        public string Nombre { get { return nombre; } }
        public string Correo { get { return correo; } }

        public void InscribirseEnEvento(int idEvento)
        {
            foreach (Evento e in Eventos.ListaEventos)
            {
                if (e.ID == idEvento)
                {
                    //si el id coincide con el ID de algún evento, paso al constructor
                    // la ifnroamcion del evento de ListaEventos y también paso this, 
                    //que contiene la información del usuario que ejecute este método.
                    Inscripcion nuevaIns = new Inscripcion(e, this);

                    //Agrego la inscripción a la lista de inscripciones del evento.
                    e.AgregarInscripcion(nuevaIns);
                    //Agrego la inscripcion a la lista de inscripciones del usuario.
                    this.inscripciones.Add(nuevaIns);

                    Console.WriteLine($"Usuario {this.Nombre} inscrito con éxito al evento {e.Nombre}");
                    return; 
                }
            }
            Console.WriteLine("Evento no encontrado");
        }

        public void CancelarInscripcion(int idEvento)
        {
            Inscripcion inscripcionEncontrada = null;
            foreach (Inscripcion i in inscripciones)
            {
                if (i.Evento.ID == idEvento)
                {
                    inscripcionEncontrada = i;
                    break;
                }
            }

            if (inscripcionEncontrada != null)
            {
                //borro la inscripcion de la lista de inscripciones del usuario
                inscripciones.Remove(inscripcionEncontrada);
                Console.WriteLine($"Inscripcion al evento {inscripcionEncontrada.Evento.Nombre} cancelada a nombre de {inscripcionEncontrada.UsuarioInscrito.Nombre}");
                //borro la inscripcion de la lista de inscripciones del evento.
                inscripcionEncontrada.Evento.EliminarInscripcion(inscripcionEncontrada);
                
            }
        }

        public void MostrarInscripciones()
        {
            foreach (Inscripcion i in inscripciones)
            {
                Console.WriteLine($"ID del evento{i.Evento.ID}");
                Console.WriteLine($"Nombre del evento{i.Evento.Nombre}");
                Console.WriteLine($"Fecha del evento{i.Evento.FechaEvento}");
                Console.WriteLine($"Dirección del evento{i.Evento.Ubicacion.Direccion}");
                if (i.Evento.Ubicacion.Esonline == true) Console.WriteLine($"Evento online");
                else Console.WriteLine($"Evento presencial");
            }
        }
    }
}
