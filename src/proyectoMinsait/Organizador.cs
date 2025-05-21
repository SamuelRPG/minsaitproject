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

        private void CrearEvento(string n, string f, string ubi, string cat, bool esonline)
        {
            Evento e = new Evento(n, f, ubi,cat, esonline);
            eventosCreados.Add(e);
        }
    }
}
