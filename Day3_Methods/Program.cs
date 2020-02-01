using System;

namespace Day3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = piemers5();
            Console.WriteLine(a);
            /*piemers1();
            piemers2();
            piemers3(3,7);
            int c = piemers4();*/


            //1. Saskaitisana-
            //ievads main metode, padodam skaitlus uz musu izveidoto metodi ka parametrus
            //izvade notiek tur
            Console.WriteLine("Ievadiet skaitli");
            String ievade = Console.ReadLine();
            int sk1 = Convert.ToInt32(ievade);

            Console.WriteLine("Ievadiet skaitli");
            ievade = Console.ReadLine();
            int sk2 = Convert.ToInt32(ievade);

            uzd1(sk1, sk2);

            //2. Ievade notiek musu izveidota metode
            //rezultatu atgreizam ar return un izvadam main

            Console.WriteLine("Rezultats ir " + uzd2());

            //3. Apvienojam 1 un 2.
            // Musu izveidotaja metode notiek tikai darbiba
            // visa ievade/izvade notiek main (gan parametri, gan return)

            //Ievadi atstasu no 1. uzd

            Console.WriteLine("Rezultats ir " + uzd3(sk1, sk2));
        }

        static void uzd1(int a, int b)
        {
            Console.WriteLine("rezultats ir " + (a + b));
        }

        static int uzd2()
        {
            Console.WriteLine("Ievadiet skaitli");
            String ievade = Console.ReadLine();
            int sk1 = Convert.ToInt32(ievade);

            Console.WriteLine("Ievadiet skaitli");
            ievade = Console.ReadLine();
            int sk2 = Convert.ToInt32(ievade);

            return sk1 + sk2;
        }

        static int uzd3(int a, int b)
        {
            return a + b;
        }

        static void piemers1()
        {
            Console.WriteLine("Parasta void metode");
            piemers2();
        }

        static void piemers2()
        {
            //metodes obligati ir jaizsauc no main vai no citas metodes
            Console.WriteLine("Velviena void metode");
        }

        static void piemers3(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static int piemers4()
        {
            int sk1 = 5;
            int sk2 = 6;

            return sk1 + sk2;
        }

        static String piemers5()
        {
            Console.WriteLine("ievadiet kaut ko");
            String ievads = Console.ReadLine();

            return ievads;
        }


    }
}
