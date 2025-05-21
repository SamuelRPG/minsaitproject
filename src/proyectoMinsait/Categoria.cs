using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoMinsait
{
    internal class Categoria
    {
        private string nomCategoria;

        public Categoria(string cat)
        {
            nomCategoria = cat.ToUpper();
        }

        public string NomCategoria {  get { return nomCategoria; } }
    }
}
