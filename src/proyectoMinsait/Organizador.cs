using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoMinsait
{
    internal class Organizador
    {
        private string nombre;
        private string correo;
        private List<Evento> eventosCreados;

        public Organizador(string nom, string correo)
        {
            nombre = nom;
            this.correo = correo;
            eventosCreados = new List<Evento>();
        }


        public void CrearEvento(string n, string f, string ubi, string cat, bool esonline)
        {
            Evento e = new Evento(n, f, ubi,cat, esonline);
            eventosCreados.Add(e);
            Console.WriteLine($"Evento con nombre {e.Nombre} creado para el dia {e.FechaEvento.ToString()}");
        }

        //este metodo solo permite que aquel organizador que creó el evento
        //sea el único que lo pueda borrar (por razones de seguridad)
        public void EliminarEvento(int idEvento)
        {
            //uso esta estructura ya que es útil para localizar objetos coincidentes.
            Evento eventoEncontrado = null;
            foreach (Evento e in eventosCreados)
            {
                if (e.ID == idEvento)
                {
                    eventoEncontrado = e;
                    break;
                }
            }

            if (eventoEncontrado != null)
            {
                //borro el evento de la lista de eventos del organizador
                eventosCreados.Remove(eventoEncontrado);
                Console.WriteLine($"Evento {eventoEncontrado.Nombre} eliminado correctamente.");
                //borro el evento de la lista de Eventos en la clase Eventos.
                Eventos.ListaEventos.Remove(eventoEncontrado);
            } else
            {
                Console.WriteLine("No existe ningún evento asociado al ID proporcionado");
            }
        }
    }
}
