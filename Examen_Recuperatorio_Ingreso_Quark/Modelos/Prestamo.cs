using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Recuperatorio_Ingreso_Quark.Modelos
{
    class Prestamo
    {
        private Ejemplar ejemplar;
        private Socio socio;
        private DateTime fecha_prestamo;

        #region Encapsulamientos
        internal Ejemplar Ejemplar { get => ejemplar; }
        internal Socio Socio { get => socio; }
        public DateTime Fecha_prestamo { get => fecha_prestamo; set => fecha_prestamo = value; }
        #endregion

        public Prestamo(Socio _socio, Ejemplar _ejemplar)
        {
            this.socio = _socio;
            this.ejemplar = _ejemplar;
            this.fecha_prestamo = DateTime.UtcNow;
        }
    }
}
