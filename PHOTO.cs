using System;
using System.Collections.Generic;
using System.Text;

namespace TideUpPhotografies
{
    abstract class PHOTO
    {
        //Datos miembro protected

        protected int row;
        protected int column;

        //Asignacion de variables en metodo de dos parametros
        public PHOTO (int rows, int columns)
        {
            row = rows;
            column = columns;
        }

        //Show input data
        public void ShowMatrixInputs()
        {
            if(row>0 && column > 0)
            {
                Console.WriteLine("Ingresaste datos correctos, tu solicitud sera procedada.");
            }
            else
            {
                Console.WriteLine("Los datos ingresados son invalidos, inicia de nuevo.");
            }
        }

        //Metodo abstracto para guardar fotos
        public abstract int storePhoto();

        //Interface para datos de una fila
        public int rowData
        {
            get
            {
                return row;
            }
            set
            {
                row = value;
            }
        }


        //Interface para datos de una columna

        public int columnData
        {
            get
            {
                return column;
            }
            set
            {
                column = value;
            }
        }


        //Finalizer

        ~PHOTO() {
            row = 0;
            column = 0;
        }
           
        
    }
}
