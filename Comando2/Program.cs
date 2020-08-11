using System;

namespace Comando2
{
    class Automovil
    {
        public void Encender()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Se han encendido el auto");
        }
        public void Apagar()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Se han apagado el auto");
        }
        public void ColocarAlarma()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Alarma encendida");
        }
        public void QuitarAlarma()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Alarma apagada");
        }
    }
}
