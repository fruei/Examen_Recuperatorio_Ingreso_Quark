using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Recuperatorio_Ingreso_Quark.Modelos
{
    class SocioVIP : Socio
    {
        private int cuota_mensual;

        #region Encapsulamientos
        public int Cuota_mensual { get => cuota_mensual; set => cuota_mensual = value; }
        #endregion

        public SocioVIP(int cantidad = 3): base(cantidad){ }
    }
}
