using System;
using System.Collections.Generic;
using System.Text;

namespace Comando2
{
    class ComandoApagar : Icomando
    {
        Automovil auto;
        public ComandoApagar(Automovil pAuto)
        {
            auto = pAuto;
        }
        public void ejecutar()
        {
            //invocamos la acción correspondiente en el auto
            auto.Apagar();
        }
    }
}
