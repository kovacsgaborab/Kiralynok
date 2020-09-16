using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiralynok
{

    class Tabla
    {
        private char[,] T; //csak a konstruktorban definiáljuk, a feladat alapján

        private char UresCella;
        private int UresOszlopokSzama;
        private int UresSorokSzama;

        private static void Elhelyez()
        {
            

        }
        private static void FajlbaIr()
        {
            
        }
        private static void Megjelenit()
        {

        }
        public Tabla(char ch)
        {
            T = new char[8, 8];
            UresCella = ch;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    T[i, j] = UresCella;
                }
            }
        }
        private int UresOszlop()
        {
            return 0;
        }
        private int UresSor()
        {
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            Console.ReadKey();
        }

        
    }
}
