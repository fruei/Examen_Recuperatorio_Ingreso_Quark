using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Recuperatorio_Ingreso_Quark.Modelos
{
    class Libro
    {
        private string nombre;
        private int codigo_ISBN;
        private string autor;
        private Queue<Ejemplar> ejemplares_disponibles;

        #region Encapsulamientos
        public string Nombre { get => nombre; set => nombre = value; }
        public int Codigo_ISBN { get => codigo_ISBN; set => codigo_ISBN = value; }
        public string Autor { get => autor; set => autor = value; }
        internal Queue<Ejemplar> Ejemplares_disponibles { get => ejemplares_disponibles; set => ejemplares_disponibles = value; }
        #endregion

        public Libro()
        {
            Ejemplares_disponibles = new Queue<Ejemplar>();
        }

        public void AgregarNuevoEjemplar(Ejemplar ejemplar) {
            Ejemplares_disponibles.Enqueue(ejemplar);
        }

        public bool DisponibleEjemplar()
        {
            return ejemplares_disponibles.Count > 0 ? true : false ;
        }


        public Ejemplar PrestarEjemplar() {
            return Ejemplares_disponibles.Dequeue();
        }

        public void RegistrarReingresoEjemplar(Ejemplar ejemplar) {
            AgregarNuevoEjemplar(ejemplar);
        }
    }    
}
