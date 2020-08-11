using System;
using System.Collections.Generic;
using System.Text;

namespace Comando2
{
    class ComandoEncender :   Icomando
    {
        Automovil auto;
        public ComandoEncender(Automovil pAuto)
        {
            auto = pAuto;
        }
        public void ejecutar()
        {
            //invocamos la acción correspondiente en el auto
            auto.Encender();
        }
    }
}
