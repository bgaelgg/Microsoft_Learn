using System;

namespace escapeDeCaracteres
{
    public class Escapes
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("¡Hola \nMundo!"); // La secuencia \n agrega una nueva linea.
            Console.WriteLine("¡Hola \tMundo!"); // La secuencia \t agrega una tabulación.
            Console.WriteLine("¡Hola \'Mundo\'!"); // La secuencia \' \'  agrega comillas simples.
            Console.WriteLine("¡Hola \"Mundo\"!"); // La secuencia \" \"  agrega comillas dobles.
            Console.WriteLine("C:\\source\\repos"); // La secuencia \\ indica una barra invertida \.
            

            Console.WriteLine("Generación de facturas para el cliente \"Contoso Corp\" ... \n");
            Console.WriteLine("Factura: 1021\t\t¡Completado!");
            Console.WriteLine("Factura: 1022\t\t¡Completado!");
            Console.Write("\nDirectorio de salida:\t");
            Console.WriteLine(@"C:\facturas"); // Con @ elimiamos las secuencias de barra invertida \

            // Kon'nichiwa Mundo
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F Mundo!"); // La secuencia \u para usar caracteres UNICODE (UTF-16)
            
            // Para generar facturas en japones:
            // Nihon no seikyū-sho o seisei suru ni wa:
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            
            // Usa el comando para iniciar la aplicación
            Console.WriteLine(@"c:\invoices\app.exe -j");


        }
    }
}