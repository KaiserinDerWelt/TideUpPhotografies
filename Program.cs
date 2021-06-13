using System;

namespace TideUpPhotografies
{
    class Program
    {
        static void Main(string[] args)
        {
            //Marco de bienvenida
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
            //Creacion de la matriz y su asignacion

            try {
                string[,] bidimensionalArray; //Array de los input
                bidimensionalArray = new string[rowsParced, columnsParced];
                //Instanciacion de la clase 

                COLORaSIGNATION stored = new COLORaSIGNATION(rowsParced, columnsParced);
                stored.storePhoto(); //Comienza el loopeo para lectura de filas
                for(int filas=0; filas<bidimensionalArray.GetLength(0);filas++)
                {
                    //Lectura de columnas por loopeo
                    for(int columnas = 0; columnas<bidimensionalArray.GetLength(1); columnas ++)
                        {
                        var chares = "CMYWGB";
                        var stringChares = new char[1];
                        var random = new Random(); //Metodo invocable random
                        for (int i = 0; i < stringChares.Length; i++)
                        {
                            stringChares[i] = chares[random.Next(chares.Length)];
                        }
                        var throwString = new String(stringChares);
                        bidimensionalArray[filas, columnas] = throwString;
                    }
                }
                // Selecciona componente de la matriz 
                Console.WriteLine("Indica el numero de fotografia a evaluar");
                var photoSelection = Console.ReadLine();
                int photoSelectionParced = int.Parse(photoSelection);

                //Analisis de colores
                var colorValues = "";
                //Loop para colores
                for ( int col =0; col<bidimensionalArray.GetLength(0); col ++)
                {
                    Console.Write(bidimensionalArray[photoSelectionParced, col]);
                    colorValues = colorValues + bidimensionalArray[photoSelectionParced, col];
                    
                }
                //Evaluador de color
                if (!colorValues.Contains("C") && !colorValues.Contains("M") && !colorValues.Contains("Y"))
                {
                    Console.WriteLine(" Blanco y Negro");
                }
                else if (colorValues.Contains("C")  || !colorValues.Contains("M") || !colorValues.Contains("Y"))
                {
                    Console.WriteLine("\nColor:"  + colorValues);
                }
            }
            catch (IndexOutOfRangeException)//Excepcion para index  mayor al indicado
            {
                System.Console.WriteLine("Algo anda mal");
            }
        }
    }
}
