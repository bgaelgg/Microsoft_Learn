using System;

namespace Convertidor
{
    public class Conversor
    {
        public static void Main(string[] args)
        {
            int fahrenheit;
            fahrenheit = 94;
            fahrenheit -= 32;
            decimal valor = 5/9m;
            /*-------------------------------------------------------------------------------------------*/
            double valorDos = 5.0/9.0; // Forma correta de dividir decimales.
            double valorTres = 5/9; 
            // En esta operación, aunque este marcado como coma flotante "double" los operandos son enteros. 
            // Por lo tanto la operación va a dar como resultado 0 porque los enteros se truncan) 
            /*-------------------------------------------------------------------------------------------*/

            Console.WriteLine("La temperatura es: " + (fahrenheit * valor));

            int result = 3 + 1 * 5 / 2; // Xdxdxddd

            Console.WriteLine(result);
            Console.WriteLine(5 / 10); // Aunque sea double, si no es 5.0/10.0 el resultado sera siempre 0
        }
    }
}
