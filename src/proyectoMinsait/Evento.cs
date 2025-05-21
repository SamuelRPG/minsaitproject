using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoMinsait
{
    internal class Evento
    {
        private static int contadorID = 100;
        private int id;
        private string nombre;
        private DateTime fechaEvento;
        private Ubicacion ubicacion;
        private Categoria categoria;
        List<Inscripcion> inscripcionesEvento;

        public Evento(string n, string f, string ubi, string cat, bool esonline)
        {
            this.id = contadorID;
            contadorID++;
            this.nombre = n;
            if (!DateTime.TryParse(f, out fechaEvento))
            {
                // Si falla, puedes lanzar una excepción o asignar una fecha por defecto
                //throw new ArgumentException("Fecha inválida. Debe tener un formato correcto.");
                fechaEvento = DateTime.Now;
            }
            this.ubicacion = new Ubicacion(ubi, esonline); // Suponemos que Ubicacion es otra clase
            this.categoria = new Categoria (cat);
            inscripcionesEvento = new List<Inscripcion> ();

            //añado todo el objeto ya instanciado a la lista de eventos
            //IMPORTANTE --> hacer este proceso al final del constructor,
            //sino, a nivel lógico, estaríamos equivocandonos.
            Eventos.ListaEventos.Add(this);
        }

        public int ID { get { return id; } }
        public string Nombre { get { return nombre; } }
        public DateTime FechaEvento { get { return fechaEvento; } }
        public Ubicacion Ubicacion { get { return ubicacion; } }
        public Categoria Categoria { get { return categoria; } }
        public List<Inscripcion> ListaInscripciones { get { return inscripcionesEvento; } }
    }
}
