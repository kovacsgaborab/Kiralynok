using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
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
        public void FajlbaIr(StreamWriter fajl)
        {
            //fajl.WriteLine("Ez egy szöveg.");
            for (int i = 0; i < 8; i++)
            {
                string sor = "";
                for (int j = 0; j < 8; j++)
                {
                    sor += T[i, j];
                }
                fajl.WriteLine(sor);
            }
        }
        public void Megjelenit()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("{0} ",T[i, j]);
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

            /*int i = 0;

            while (i < 8 && T[i, oszlop] != 'K')
            {
                i++;
            }
            if (i<8)
            {
                return false;
            }
            else
            {
                return true;
            }*/

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

            /*int i = 0;

            while (i < 8 && T[sor, i] != 'K')
            {
                i++;
            }
            if (i<8)
            {
                return false;
            }
            else
            {
                return true;
            }*/

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

            //Console.Write("Melyik oszlop? ");        //ÜresSor, ÜresOszlop
            //int a = int.Parse(Console.ReadLine());
            //if (t.UresOszlop(a) == true)
            //{
            //    Console.WriteLine("Az oszlop üres");
            //}
            //else
            //{
            //    Console.WriteLine("Az oszlop nem üres");
            //}
            //Console.Write("Melyik sor? ");
            //int b = int.Parse(Console.ReadLine());
            //if (t.UresSor(b) == true)
            //{
            //    Console.WriteLine("A sor üres");
            //}
            //else
            //{
            //    Console.WriteLine("A sor nem üres");
            //}

            Console.Write("8. feladat: Üres sorok és oszlopok száma: ");

            int uressor = 0;
            int uresoszlop = 0;

            for (int i = 0; i < 8; i++)
            {
                if (t.UresSor(i)==true)
                {
                    uressor++;
                }
                else if (t.UresOszlop(i)==true)
                {
                    uresoszlop++;
                }
            }
            Console.Write("{0}, {1}", uressor, uresoszlop);





            Tabla[] tablak = new Tabla[64]; //9. feladat            

            StreamWriter ki = new StreamWriter("adatok.txt");

            for (int i = 0; i < 64; i++)
            {
                tablak[i] = new Tabla('*');
            }

            for (int i = 0; i < 64; i++)
            {
                tablak[i].Elhelyez(i + 1);
                tablak[i].FajlbaIr(ki);
                ki.WriteLine();
            }

            ki.Close();



            Console.ReadKey();
        }

        
    }
}
