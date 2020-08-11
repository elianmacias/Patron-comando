using System;
using System.Collections.Generic;
using System.Text;

namespace Comando2
{
    class ComandoApagarAlarma : Icomando
    {
        Automovil auto;
        public ComandoApagarAlarma (Automovil pAuto)
        {
            auto = pAuto;
        }
        public void ejecutar()
        {
            //invocamos la acción correspondiente en el auto
            auto.QuitarAlarma();
        }
    }
}
