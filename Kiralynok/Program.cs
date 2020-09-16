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

        public void Elhelyez()
        {
            

        }
        public void FajlbaIr()
        {
            
        }
        public void Megjelenit()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(T[i, j]);
                }
                Console.WriteLine();
            }
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
        public int UresOszlop()
        {
            return 0;
        }
        public int UresSor()
        {
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Királynők feladat");

            Tabla t = new Tabla('#');

            Console.WriteLine("Üres Ttábla");
            t.Megjelenit();

            Console.ReadKey();
        }

        
    }
}
