/*

Student: Sophia Johnson

Course          Grade   Credit Hours	
English 101         4       3
Algebra 101         3       3
Biology 101         3       4
Computer Science I  3       4
Psychology 101      4       3

Final GPA:          3.35

*/

using System;

namespace ProyectoGuiado
{
    public class Proyecto
    {
        public static void Main(string[] args)
        {
            string nombreEstudiante = "Sophia Johnson";
            string nombreCurso1 = "Inglés 101";
            string nombreCurso2 = "Algebra 101";
            string nombreCurso3 = "Biología 101";
            string nombreCurso4 = "Ciencias de Computo I";
            string nombreCurso5 = "Psicología 101";

            int cursoCredito1 = 3;
            int cursoCredito2 = 3;
            int cursoCredito3 = 4;
            int cursoCredito4 = 4;
            int cursoCredito5 = 3;

            int gradoA = 4;
            int gradoB = 3;

            int cursoGrado1 = gradoA;
            int cursoGrado2 = gradoB;
            int cursoGrado3 = gradoB;
            int cursoGrado4 = gradoB;
            int cursoGrado5 = gradoA;

            int totalCreditosHoras = 0; // La variable esta asignada, por lo que en tiempo de compilación esta variable esta activa.
            totalCreditosHoras += cursoCredito1; // Como la variable ya esta asignada, el operador += suma la variable cursoCreditox a la variable totalCreditosHoras
            totalCreditosHoras += cursoCredito2; // Estas asignaciones se hacen de izquierda a derecha. Por eso, va variable totalCreditosHoras
            totalCreditosHoras += cursoCredito3; // termina con el valor de 17. Que es la suma de todos los datos de todas las variables cursoCredito.
            totalCreditosHoras += cursoCredito4;
            totalCreditosHoras += cursoCredito5;
            //Console.WriteLine(totalCreditosHoras); // Total 17

            int totalGradoPuntos = 0; // La variable esta asignada, por lo que en tiempo de compilación esta variable esta activa.
            totalGradoPuntos += cursoCredito1 * cursoGrado1;
            totalGradoPuntos += cursoCredito2 * cursoGrado2;
            totalGradoPuntos += cursoCredito3 * cursoGrado3; // Aqui pasa algo similar a lo de arriba. La diferencia es que hace la multiplicación de las 
            totalGradoPuntos += cursoCredito4 * cursoGrado4; // variables cursoCredito * cursoGrado y el resultado lo suma a la variable totalGradoPuntos.
            totalGradoPuntos += cursoCredito5 * cursoGrado5;
            //Console.WriteLine(totalGradoPuntos); // Total 57

            decimal puntoGradosPromedio = (decimal) totalGradoPuntos / totalCreditosHoras;

            int digitoSinRedondeo = (int) puntoGradosPromedio;
            int primerDigito = (int) (puntoGradosPromedio * 10) % 10;
            int segundoDigito = (int) (puntoGradosPromedio * 100) % 10;
            // Console.WriteLine($"Final de PGP: {puntoGradosPromedio:F2}");
            // Con {valor:F2} se formatea el valor a solo dos decimales sin necesidad de hacer operaciónes.

            Console.WriteLine($"Estudihambre: {nombreEstudiante}\n");
            Console.WriteLine("Curso\t\t\tGrado\tCredito Horas");
            Console.WriteLine($"{nombreCurso1}\t\t{cursoGrado1}\t\t{cursoCredito1}");
            Console.WriteLine($"{nombreCurso2}\t\t{cursoGrado2}\t\t{cursoCredito2}");
            Console.WriteLine($"{nombreCurso3}\t\t{cursoGrado3}\t\t{cursoCredito3}");
            Console.WriteLine($"{nombreCurso4}\t{cursoGrado4}\t\t{cursoCredito4}");
            Console.WriteLine($"{nombreCurso5}\t\t{cursoGrado5}\t\t{cursoCredito5}");
            Console.WriteLine($"Final de PGP:\t\t{digitoSinRedondeo}.{primerDigito}{segundoDigito}");

        }
    }
}