using System;

namespace _02_logica_if_else_elseif
{
    public class LanzarDados
    {
        public static void Main(string[] args)
        {
            int roll1, roll2,roll3, total;

            Console.WriteLine();

            Random dado = new();
            roll1 = dado.Next(1, 7);
            roll2 = dado.Next(1, 7);
            roll3 = dado.Next(1, 7);

            total = roll1 + roll2 + roll3;
            
            Console.WriteLine($"Tiradas: {roll1}, {roll2}, {roll3}");

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
        //  Sentencia OR que indica que si una de las condiciones es verdadera, se ejecuta el bloque de codigo.
            {
                if ((roll1 == roll2) && (roll2 == roll3))
            //  Sentencia AND que indica que si ambas condiciones son verdaderas, se ejecuta el bloque de codigo.
                {
                    Console.WriteLine("¡Sacaste un triple! Obtienes +6 puntos");
                    total += 6;
                }

                else
                {
                Console.WriteLine("¡Sacaste pares! Obtienes +2 puntos");
                total += 2;                    
                }
            }

            if (total >= 16)
            {
                Console.WriteLine("¡Ganaste un auto nuevo!");
            }

            else if (total >= 10)
            {
                Console.WriteLine("¡Ganaste un laptop nuevo!");
            }

            else if (total == 7)
            {
                Console.WriteLine("¡Ganaste un viaje para dos!");
            }

            else
            {
                Console.WriteLine("¡Ganaste un gatito!");
            }

            Console.WriteLine();
        }
    }
}

/*

Este codigo representa la parte de usar solamente la expreción "if" para evaluar los resultados de los dados.

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
        //  Sentencia OR que indica que si una de las condiciones es verdadera, se ejecuta el bloque de codigo.
            {
                Console.WriteLine("¡Sacaste pares! Obtienes +2 puntos");
                total += 2;
            }

            if ((roll1 == roll2) && (roll2 == roll3))
        //  Sentencia AND que indica que si ambas condiciones son verdaderas, se ejecuta el bloque de codigo.
            {
                Console.WriteLine("¡Sacaste un triple! Obtienes +6 puntos");
                total += 6;
            }

            if (total >= 15)  
            {
                Console.WriteLine($"Conseguiste {total}. Ganaste");
            }

            if (total < 15)
            {
                Console.WriteLine($"Conseguiste {total}. Perdiste");
            }

            Console.WriteLine();

*/