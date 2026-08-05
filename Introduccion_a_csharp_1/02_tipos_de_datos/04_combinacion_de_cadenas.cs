using System;

namespace Combinacion
{
    public class Concatenacion
    {
        public static void Main(string[] args)
        {
            string primerNombre, mensaje, saludo;

            primerNombre = "Gael";
            saludo = "Hola";
            mensaje = "¡" + saludo + " " + primerNombre + "!";
            Console.WriteLine(mensaje);
            Console.WriteLine("¡" + saludo + " " + primerNombre + "!");
        }
    }
}