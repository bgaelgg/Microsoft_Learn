using System;

namespace Interpolacion
{
    public class Inter
    {
        public static void Main(string[] args)
        {
            string primerNombre, mensaje, saludo;

            primerNombre = "Gael";
            saludo = "Hola";
            mensaje = "¡" + saludo + " " + primerNombre + "!";
            Console.WriteLine(mensaje);
            Console.WriteLine("¡" + saludo + " " + primerNombre + "!");


            string  primerNombre1, mensaje1, saludo1, otroMensaje;

            primerNombre1 = "Gael";
            saludo1 = "Hola";
            mensaje1 = $"¡{saludo1} {primerNombre1}!";
            otroMensaje = $"¡Hola {primerNombre1}";
            Console.WriteLine(mensaje1);
            Console.WriteLine("¡" + saludo1 + " " + primerNombre1 + "!");
            Console.WriteLine(otroMensaje);

            string nuevoMensaje, textoActualizado;
            int version;

            version = 11;
            textoActualizando = "Actualizando Windows";
            nuevoMensaje = $"{textoActualizando} {version}";
            Console.WriteLine(nuevoMensaje);
            Console.WriteLine($"{textoActualizando} {version}");

            string nombreDelProyecto;

            nombreDelProyecto = "Mi-Primer-Proyecto";
            Console.WriteLine($@"C:\Output\{nombreDelProyecto}\Data");
        }
    }
}