using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionConsola.Clases
{
    public class claseDePrueba
    {
        private int id;
        private string nombreDePrueba;
        private int numeroRandom;

        public claseDePrueba(int id, string nombreDePrueba, int numeroRandom)
        {
            this.Id = id;
            this.NombreDePrueba = nombreDePrueba;
            this.NumeroRandom = numeroRandom;
        }

        public int Id { get => id; set => id = value; }
        public string NombreDePrueba { get => nombreDePrueba; set => nombreDePrueba = value; }
        public int NumeroRandom { get => numeroRandom; set => numeroRandom = value; }
    }
}
