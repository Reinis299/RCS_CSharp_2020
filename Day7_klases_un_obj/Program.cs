using System;

namespace Day7_klases_un_obj
{
    class Program
    {
        static void Main(string[] args)
        {

            task1();


            //Klases nosaukums ir trijsturis
            //Cilveks ievada 3 malu vertibas - mainigie jaunaja klase
            //Metodi, kas izvada perimetru mala + mala + mala
            //visa ievade un izvade notiek no main- WriteLine un ReadLine
            //ja kada mala ir 0, par to ir japazino
        }

        static void task1()
        {
            //uztaisat jaunu klasi ar nosaukumu SkaitluSumma
            //Cilveks ievada 2 int tipa skaitlus no main
            //uztaisat, get,set, un lai butu publiska metode, kas izvada
            //abu skaitlu summu
            //abiem skaitliem ir jabut pieejamiem visa SkaitluSumma klasē
            //bet no Program.cs klases tikai ar get un set.
            int sk1 = skaitlaIevade();
            int sk2 = skaitlaIevade();

            SkaitluSumma.setA(sk1);
            SkaitluSumma.setB(sk2);

            SkaitluSumma.Summa();

        }

        static int skaitlaIevade()
        {
            Console.WriteLine("Ievadiet skaitli!");
            String skaitlaIevade = Console.ReadLine();
            int skaitlis = Convert.ToInt32(skaitlaIevade);
            return skaitlis;
        }
    }
}
