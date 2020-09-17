using System;
using System.Collections.Generic;
using System.Configuration;
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

        static Random vel = new Random();

        public void Elhelyez(int N)
        {
            //1. Véletlen helyiérték létrehozása
            //      - Random osztály értékkészlet [0-7]
            //      - Véletlen sor és oszlop kell
            //      - Elhelyezzük a K-t
            //              HA!!! üres --> nincs benne "#"


            for (int i = 0; i < N; i++)
            {
                int sor = vel.Next(0, 8);
                int oszlop = vel.Next(0, 8);
                while (T[sor, oszlop] == 'K')
                {
                    sor = vel.Next(0, 8);
                    oszlop = vel.Next(0, 8);

                }
                T[sor, oszlop] = 'K';
            }

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
        public bool UresOszlop(int oszlop)
        {
            //int a = 0;
            bool vank = true;

            for (int i = 0; i < 8; i++)
            {
                if (T[i, oszlop] == 'K')
                {
                    vank = false;
                    break;
                }
            }
            //while (T[a, oszlop] != 'K')
            //{
            //    if (T[a, oszlop] == 'K')
            //    {
            //        vank = false;
            //    }
            //    a++;
            //}

            return vank;
        }
        public bool UresSor(int sor)
        {
            bool vank = true;

            for (int i = 0; i < 8; i++)
            {
                if (T[sor, i] == 'K')
                {
                    vank = false;
                    break;
                }
            }

            return vank;
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
            t.Elhelyez(8);

            Console.WriteLine();
            t.Megjelenit();

            Console.Write("Melyik oszlop?");
            int a = int.Parse(Console.ReadLine());
            if (t.UresOszlop(a)==true)
            {
                Console.WriteLine("Az oszlop üres");
            }
            else
            {
                Console.WriteLine("Az oszlop nem üres");
            }
            Console.Write("Melyik sor?");
            int b = int.Parse(Console.ReadLine());
            if (t.UresSor(b)==true)
            {
                Console.WriteLine("A sor üres");
            }
            else
            {
                Console.WriteLine("A sor nem üres");
            }

            Console.ReadKey();
        }

        
    }
}
