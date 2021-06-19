using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Recuperatorio_Ingreso_Quark.Modelos
{
    class Socio
    {
        private string apellido;
        private int id;
        private List<Ejemplar> ejemplares_retirados;
        private int cantidad_max_ejemplares;

        #region Encapsulamientos
        public string Nombre { get ; set ; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Id { get => id; set => id = value; }
        internal List<Ejemplar> Ejemplares_retirados { get => ejemplares_retirados; set => ejemplares_retirados = value; }
        public int Cantidad_max_ejemplares { get => cantidad_max_ejemplares; }
        #endregion

        public Socio(int cantidad = 1)
        {
            this.cantidad_max_ejemplares = cantidad;
            Ejemplares_retirados = new List<Ejemplar>();
        }

        public bool TieneCupoEjemplares() {
            if (Cantidad_max_ejemplares > Ejemplares_retirados.Count)
                return true;
            return false;
        }

        public void PedirPrestadoEjemplar(Ejemplar ejemplar) {
            Ejemplares_retirados.Add(ejemplar);
        }

        public void DevolverEjemplar(Ejemplar ejemplar) {
            Ejemplares_retirados.Remove(ejemplar);
        }
    }
}
