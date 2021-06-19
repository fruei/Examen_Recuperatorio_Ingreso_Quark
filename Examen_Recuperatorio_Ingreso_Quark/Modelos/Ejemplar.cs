using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Recuperatorio_Ingreso_Quark.Modelos
{
    class Ejemplar
    {
        private Libro libro;
        private int edicion_numero;
        private string ubicacion;

        #region Encapsulamientos
        public int Edicion_numero { get => edicion_numero; set => edicion_numero = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        internal Libro Libro { get => libro; set => libro = value; }
        #endregion
    }
}
