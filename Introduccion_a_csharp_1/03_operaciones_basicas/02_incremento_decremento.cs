using System;

namespace IncrementoDecremento
{
    public class AsignacionCompuesta
    {
        public static void Main(string[] args)
        {
            int valor, valorDos;
            valor = 1;

            valor = valor + 1; // Suma a la variable valor 1
            Console.WriteLine("Primer incremento: " + valor);

            valor += 1; // Suma a la variable valor 1
            Console.WriteLine("Segundo incremento: " + valor);

            valor ++; // Suma a la variable valor 1
            Console.WriteLine("Tercer incremento: " + valor);

            valor = valor - 1; // Resta a la variable valor 1
            Console.WriteLine("Primer decremento: " + valor);

            valor -= 1; // Resta a la variable valor 1
            Console.WriteLine("Segundo decremento: " + valor);

            valor --; // Resta a la variable valor 1
            Console.WriteLine("Tercer decremento: " + valor);

            valorDos = 1;
            valorDos ++;
            Console.WriteLine("Primero: " + valorDos);
            Console.WriteLine($"Segundo: {valorDos++}");
            // Aqui no sale 3, porque primero imprime la variable "valorDos", y luego suma de ++. 
            // porque el ++ esta despues de la variable "valorDos"
            Console.WriteLine("Tercero: " + valorDos);
            Console.WriteLine("Cuarto: " + (++valorDos));
            // Aqui imprime el 4, porque primero hace la suma de la variable "valorDos". 
            // Luego muestra en consola el valor de la variable "valorDos"

        }
    }
}