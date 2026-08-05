using System;

namespace Primitivos
{
    public class Prim
    {
        public static void Main(string[] args)
        {
            
            /*
            Estos son los tipos de datos primitivos. Estos datos son la base de todo programa
            que se pueda construir. Estos son representados de la siguiente manera:
            */
            
            Console.WriteLine('x'); // Imprimir caracteres es con comilla simple ''
           
           // Console.Write('xd'); // Aqui va a mandar error el compilador CS1012 porque son 2 caracteres

           Console.WriteLine(123); // Imprime directamente los numeros en este caso enteros o <int>

           /*
           Cantidad de digitos por  cada tipo de dato numerico
        
          Float Type    Precision
        ----------------------------
        float         ~6-9 digits
        double        ~15-17 digits
        decimal        28-29 digits   
          
           */

           Console.WriteLine(0.25F); // Sufijo 'F' para indicar que es float <float>

           Console.WriteLine(2.625); // Para double no hay sufijo porque el compilador lo aplica por defecto <double>

           Console.WriteLine(12.39816m); // Sufijo 'm' para indicar que es un numero decimal <decimal>

           Console.WriteLine(true);  // Este tipo de dato es verdadero <true> booleano
           Console.WriteLine(false); // Este tipo de dato es falso <false> booleano


           Console.WriteLine("123");
           // Esta es una cadena de caracteres <str> porque esta dentro de las comillas dobles, por lo que los numeros no tienen valor matematico

           Console.WriteLine("true");
           Console.WriteLine("false");
           // Lo mismo pasa con los valores booleanos, mientras esten dentro de las comillas dobles son tratados como <str> y no como booleano


        }
    }
}