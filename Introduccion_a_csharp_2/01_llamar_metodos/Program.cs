using System;

namespace ProyectoPrueba
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine();
            Random dado = new(); // Nueva sintaxis para crear una instancia u objeto sin redundancia de tipo explícito.
        //  Random dado = new Random(); La sintaxis anterior es redundante.
            int roll = dado.Next(1, 7); // Genera un número aleatorio entre 1 y 6 y se guarda en la variable roll.
            Console.WriteLine(roll);
            Console.WriteLine(dado.Next(1, 7)); 
        //  No se guarda el valor resultante en una vairable y se imprime directamente en consola.

        //  Genera un numero aleatorio en general
            int roll1 = dado.Next();

        //  Genera un numero aleatorio entre 0 y 100.
            int roll2 = dado.Next(101);

        //  Genera un numero aleatorio entre 50 y 100.
            int roll3 = dado.Next(50, 101);

            Console.WriteLine($"Primer roll {roll1}");
            Console.WriteLine($"Segundo roll {roll2}");
            Console.WriteLine($"Tercer roll {roll3}");

        /*-----------------------------------------------------------------------------*/
        
        //  Uso de la clase Math para obtener el mayor valor entre dos numeros.
            int primerValor, segundoValor, mayorValor;

            primerValor = 500;
            segundoValor = 600;
        
        //  Math.Max es un metodo estatico, por lo que se usa directamente con su clase y no se instancia o se le crea un objeto.
            mayorValor = Math.Max(primerValor, segundoValor); 

            Console.WriteLine(mayorValor);
            Console.WriteLine();
        }   
    }
}


/*

System es la puerta de entrada a la clase Random.
Despues, instanciamos o creamos un objeto de la clase Random llamado dado.
Luego creamos la variable roll, se asigna el valor dado con el metodo Next.
Se le asigna un estado al metodo Next "(1, 7)" y queda inicializado.
Al final, la variable roll ya asignada con un valor, imprime en consola un numero aleatorio entre 1 y 6.

Observaciónes:
Las clases estaticas no se pueden instanciar o crearle un objeto. 
se usa directamente la clase y su metodo por ejemplo: "Math.Max"

Las clases normales como "Random" se tienen que instanciar o crearles un objeto para poder
usar sus metodos.

Hay clases que no son estaticas y se pueden usar sin instanciarlas o crearlas, como la clase Console.

*/