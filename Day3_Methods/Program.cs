using System;

namespace Day3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*bool a = true;
            a = false;
            a = !a;
            Console.WriteLine(a);*/
            //Cilveks ievada skaitli
            //Uztaisam metodi kas atgriez (return) vai skaitlis ir pozitivs vai negativs
            int skaitlis = skaitlaIevade();
            
            Console.WriteLine(pozNeg(skaitlis));


        }

        static bool pozNeg(int sk)
        {
            if(sk > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void refactorTask()
        {
            //Cilveks ievada tris skaitlus- int
            //Jaizvada lielakais


            int skaitlis1 = skaitlaIevade();
            int skaitlis2 = skaitlaIevade();
            int skaitlis3 = skaitlaIevade();

            //1. variants
            int biggest = biggestNumber(skaitlis1, skaitlis2);
            biggest = biggestNumber(biggest, skaitlis3);
            Console.WriteLine("Rezultats ir " + biggest);
        }

        static int biggestNumber(int a, int b)
        { 
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static int skaitlaIevade()
        {
            Console.WriteLine("Ievadiet skaitli!");
            String skaitlaIevade = Console.ReadLine();
            int skaitlis = Convert.ToInt32(skaitlaIevade);
            return skaitlis;
        }

        static int saisinataSkaitlaIevade()
        {
            Console.WriteLine("Ievadiet skaitli!");
            return Convert.ToInt32(Console.ReadLine());
        }


        static void tasks1To3()
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
