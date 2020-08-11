using System;
using System.Collections.Generic;
using System.Text;

namespace Comando2
{
    class ComandoPrenderAlarma : Icomando
    {
        Automovil auto;
        public ComandoPrenderAlarma (Automovil pAuto)
        {
            auto = pAuto;
        }
        public void ejecutar()
        {
            //invocamos la acción correspondiente en el auto
            auto.ColocarAlarma();
        }
    }
}
