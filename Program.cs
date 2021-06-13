using System;

namespace TideUpPhotografies
{
    class Program
    {
        static void Main(string[] args)
        {   //Marco de bienvenida
            Console.WriteLine("<-------------------------------------->");
            Console.WriteLine("<------Bienvenido a Photo Tide Up------>");
            Console.WriteLine("Sigue las instrucciones para ordenar tus fotos");
            //Inputs de usuario para filas y columnas
            Console.WriteLine("Indica la cantídad de filas");
            var rows = Console.ReadLine();
            var rowsParced = int.Parse(rows);
            Console.WriteLine("Inserta el numero de columnas");
            var columns = Console.ReadLine();
            var columnsParced = int.Parse(columns);

        }
    }
}
