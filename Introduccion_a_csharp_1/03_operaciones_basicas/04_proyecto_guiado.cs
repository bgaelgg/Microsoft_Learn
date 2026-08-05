/* 

Datos de calificación
Sophia: 93, 87, 98, 95, 100

Nicolas: 80, 83, 82, 88, 85

Zahirah:   84, 96, 73, 85, 79

Jeong:  90, 92, 98, 100, 97

Rangos
97 - 100    A+
93 - 96     A
90 - 92     A-
87 - 89     B+
83 - 86     B

Resultao en consola
Student     Grade
Sophia      94.6  A
Nicolas     83.6  B
Zahirah     83.4  B
Jeong       95.4  A

*/

using System;

namespace ProyectoGuiado
{
    public class Proyecto
    {
        public static void Main(string[] args)
        {
            // initialize variables - graded assignments 
            int asignaturasActuales = 5;

            int shinra1 = 93;
            int shinra2 = 87;
            int shinra3 = 98;
            int shinra4 = 95;
            int shinra5 = 100;
            int shinraTotal = shinra1 + shinra2 + shinra3 + shinra4 + shinra5;
            decimal shinraPuntos = (decimal) shinraTotal / asignaturasActuales; // Se utiliza el (decimal) porque no son valores matematicos (numericos). Son variables.

            int ezio1 = 80;
            int ezio2 = 83;
            int ezio3 = 82;
            int ezio4 = 88;
            int ezio5 = 85;
            int ezioTotal = ezio1 + ezio2 + ezio3 + ezio4 + ezio5;
            decimal ezioPuntos = (decimal) ezioTotal / asignaturasActuales;

            int dionisio1 = 84;
            int dionisio2 = 96;
            int dionisio3 = 73;
            int dionisio4 = 85;
            int dionisio5 = 79;
            int dionisioTotal = dionisio1 + dionisio2 + dionisio3 + dionisio4 + dionisio5;
            decimal dionisioPuntos = (decimal) dionisioTotal / asignaturasActuales;

            int ann1 = 90;
            int ann2 = 92;
            int ann3 = 98;
            int ann4 = 100;
            int ann5 = 97;
            int annTotal = ann1 + ann2 + ann3 + ann4 + ann5;
            decimal annPuntos = (decimal) annTotal / asignaturasActuales;

            Console.WriteLine("Estudihambre\tGrado\n");
            Console.WriteLine("Shinra:\t\t" + shinraPuntos + "\tA");
            Console.WriteLine("Ezio:\t\t" + ezioPuntos + "\tB");
            Console.WriteLine("Jotisio:\t" + dionisioPuntos + "\tB");
            Console.WriteLine("Ann:\t\t" + annPuntos + "\tA");
        }
    }
}