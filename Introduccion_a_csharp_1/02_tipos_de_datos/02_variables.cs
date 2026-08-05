using System;

namespace Variables
{
    public class Var
    {
        public static void Main(string[] args)
        {

        /*
        
        ·  Los nombres de variable pueden contener caracteres alfanuméricos y el carácter de subrayado. No se permiten caracteres especiales, 
           como el símbolo # (también conocido como símbolo de almohadilla) o el símbolo del dólar $.
          
        ·  Los nombres de variable deben comenzar con una letra alfabética o un carácter de subrayado, no un número.
          
        ·  Los nombres de variables distinguen mayúsculas de minúsculas, lo que significa que string Value; y string value; son dos variables diferentes.
          
        ·  Los nombres de variable no deben ser una palabra clave de C#. Por ejemplo, no puede usar las siguientes declaraciones de variable: decimal decimal; o string string;.
        
        */

        string primerNombre;
        /*
        
        · Los nombres de variable no deben incluir el tipo de datos de la variable. 
          Es posible que vea algunos consejos para usar un estilo como string strValue;. Ese consejo ya no es actual.

        */

        char opcionUsuario;
        int marcadorJuego;
        decimal particulasPorMillon;
        bool clienteAtendido;

        var message = "Hello world!";


        primerNombre = "Gael";

        Console.WriteLine(primerNombre);


        }
    }
}