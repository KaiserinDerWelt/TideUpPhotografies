using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TideUpPhotografies
{
    class COLORaSIGNATION:PHOTO
    {
     public COLORaSIGNATION(int row, int column):base(row, column)
        {
        }
        public override int storePhoto()
        {
            //Bloque de atrapado de excepcion IONot Implemented
            try
            {
                ShowMatrixInputs();
            }
            catch(IOException ioe)
            {
                throw new NotImplementedException();
                Console.WriteLine(ioe);
            }

            return base.column;
        }
    }
}
