using System;

namespace Day2_dataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
 
            //cilveks ievada skaitli
            //parbaudam vai ir lielaks par pieci
            //ja ir ##
            //ja nav #

            //Majas- sameklet ka parbaudit divus nosacijumus
            //un parbaudit vai cilveks ievada pareiza garuma String
            //un vai sis String ir vienads ar "aaaaaaaaaa"

        }

        static void piemers()
        {
            int a = 5;
            int b = 7;

            int c = a + b;

            Console.WriteLine("Ievadiet skaitli!");
            String ievade = Console.ReadLine();

            int parkonvertetsNr = Convert.ToInt32(ievade);
            c = parkonvertetsNr - a;

            Console.WriteLine("Skaitlis ir "+ c);

            String virkne1 = "vertiba ";
            String virkne2 = "ir ";

            String virkne3 = virkne1 + virkne2;
            Console.WriteLine(virkne3);
        }

        static void piemers2()
        {
            int a = 5;
            int b = 6;

            if (a > 5)
            {
                Console.WriteLine("ir");
            }
            else
            {
                Console.WriteLine("nav");
            }

            // > lielaks/mazaks
            // < 
            // <=
            // >=
            // == ( = ir pieskirt, == salidzinat)
            // != nav vienads

            String piem = "aaa";

            if (piem == "aaa") //var salidzinat ari string- ir vienads vai nav
            {

            }

            //int c = piem.Length; sadi varam dabut Stringa garumu
        }

        static void uzdevums1()
        {
            //Lietotajam paprasam kurs gads ir
            Console.WriteLine("Kurs gads ir sobrid?");
            //lietotajs ievada
            String ievade = Console.ReadLine();
            int pasreizejais = Convert.ToInt32(ievade);
            //Lietotajam paprasat kura gads vins ir dzimis
            Console.WriteLine("Kura gada esat dzimis?");

            //lietotajs ievada
            ievade = Console.ReadLine();
            int dzimsanas = Convert.ToInt32(ievade);
            //Atnemtas skaitlus lai izvaditu starpibu
            int rezultats = pasreizejais - dzimsanas;
            //Izvadam Vecums ir xx
            Console.WriteLine("Jusu vecums ir " + rezultats);
        }
    }
}
