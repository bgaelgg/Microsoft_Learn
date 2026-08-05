using System;

namespace Suma
{
    public class Add
    {
        public static void Main(string[] args)
        {
            int primerNumero, segundoNumero;

            primerNumero = 12;
            segundoNumero = 7;
            Console.WriteLine(primerNumero + segundoNumero); // Suma de toda la vida


            /*
            En C#, el lenguaje tiene especificado en su gramática que el operador + está sobrecargado para la clase string. 
            La regla oficial de C# dice:
            
            "Si al menos uno de los operandos en una operación + es de tipo string, el compilador convierte el operador 
            en una llamada interna a string.Concat(), invocando automáticamente el método .ToString() en cualquier objeto 
            que no sea texto."
            
            Ejemplo:
            Console.WriteLine(nombre + " duplicó " + valorDuplicado + 4 + " stacks de diamante.");
            */
            
            string nombre = "Duplicio";
            int valorDuplicado = 7;
            Console.WriteLine($@"{nombre} duplicó {valorDuplicado} stacks de diamante."); // Suma de caracteres con variales int guardadas.
            // El numero pierde su valor matematico de forma temporal para concatenarlo con las cadena de caracteres.
            Console.WriteLine(nombre + " duplicó " + (valorDuplicado + 4) + " stacks de diamante.");
            Console.WriteLine($@"{nombre} duplicó {(valorDuplicado + 57)} stacks de netherita");
            /*
            Por orden de operaciones, se resuelve primero los parentecis internos y luego los externos
            En este caso, los parentesis internos hacen una suma de dos valores numericos.
            Después se resuelve lo de afuera, y el numero 11 que es el resultado de la suma, 
            pierde su valor matematico y se vuelve un string de forma temporal para sumarse 
            al resto de la cadena de caracteres.
            */


        }
    }
}