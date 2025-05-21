using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoMinsait
{
    internal static class Eventos
    {
       private static List<Evento> listaEventos = new List<Evento>();

        public static void ListarEventos()
        {
            foreach (Evento e in listaEventos)
            {
                Console.WriteLine($"ID del evento: {e.ID}");
                Console.WriteLine($"Nombre del evento: {e.Nombre}");
                Console.WriteLine($"Fecha del evento: {e.FechaEvento.ToString()}");
                Console.WriteLine($"Ubicación del evento: {e.Ubicacion.Direccion}");
                if (e.Ubicacion.Esonline) Console.WriteLine($"Modalidad del evento: Online");
                else Console.WriteLine($"Modalidad del evento: Presencial");
                Console.WriteLine($"Categoria del evento: {e.Categoria.NomCategoria}");
            }
        }

        public static List<Evento> ListaEventos {  get { return listaEventos; } }
    }
}
