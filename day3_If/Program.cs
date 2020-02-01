using System;

namespace day3_If
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cilveks ievada tris skaitlus- int
            //Jaizvada lielakais
            Console.WriteLine("Ievadiet skaitli!");
            String skaitlaIevade = Console.ReadLine();
            int skaitlis1 = Convert.ToInt32(skaitlaIevade);

            Console.WriteLine("Ievadiet skaitli!");
            skaitlaIevade = Console.ReadLine();
            int skaitlis2 = Convert.ToInt32(skaitlaIevade);

            Console.WriteLine("Ievadiet skaitli!");
            skaitlaIevade = Console.ReadLine();
            int skaitlis3 = Convert.ToInt32(skaitlaIevade);


            //1. variants
            int biggest = 0;
            if (skaitlis1 > skaitlis2)
            {
                biggest = skaitlis1;
            }
            else
            {
                biggest = skaitlis2;
            }

            if (biggest < skaitlis3)
            {
                biggest = skaitlis3;
            }
    

            Console.WriteLine("Rezultats ir " + biggest);

            //2
 
             if (skaitlis1 >= skaitlis2 && skaitlis1 >= skaitlis3)
             {
                Console.WriteLine("Lielakais ir " + skaitlis1);
             }
             else if (skaitlis2 >= skaitlis1 && skaitlis2 >= skaitlis3)
             {
                Console.WriteLine("Lielakais ir " + skaitlis2);
             }
             else if(skaitlis3 >= skaitlis1 && skaitlis3 >= skaitlis1)
             {
                Console.WriteLine("Lielakais ir " + skaitlis3);
             }
            
       

        }

        static void piemersZarosanas()
        {
            int a = 5;
            int b = 6;

            // &&
            //jaizpildas abiem
            if (a >= 5 && b == 6)
            {

            }

            // ||
            //jaizpildas vienam
            if (a > 5 || b == 6)
            {

            }


            int skaitlis = 5;
            //#
            //##
            //###
            //>5, <5, ==5

            if (skaitlis > 5)
            {
                Console.WriteLine("#");
            }
            else if (skaitlis < 5)
            {
                Console.WriteLine("##");
            }
            else
            {
                Console.WriteLine("###");
            }

        }

        static void uzd1()
        {
            //Kalkulators
            //cilveks ievada divus skaitlus
            Console.WriteLine("Ievadiet skaitli!");
            String skaitlaIevade = Console.ReadLine();
            Double skaitlis1 = Convert.ToDouble(skaitlaIevade);
            //Cilveks ievada ko grib darit //+, -, *, /


            Console.WriteLine("Ievadiet skaitli!");
            skaitlaIevade = Console.ReadLine();
            Double skaitlis2 = Convert.ToDouble(skaitlaIevade);

            Console.WriteLine("Ievadiet darbibu: +,-,*,/");
            String darbiba = Console.ReadLine();
            //uz ekrana izvada rezultutu
            //ja cilveks ka darbibu ievada jebko citu, nevis matematiskas, tad kludas pazinojums

            if (darbiba == "+")
            {
                Console.WriteLine("Rezultats ir " + (skaitlis1 + skaitlis2));
            }
            else if (darbiba == "-")
            {
                Console.WriteLine("Rezultats ir " + (skaitlis1 - skaitlis2));
            }
            else if (darbiba == "*")
            {
                Console.WriteLine("Rezultats ir " + (skaitlis1 * skaitlis2));
            }
            else if (darbiba == "/")
            {
                Console.WriteLine("Rezultats ir " + (skaitlis1 / skaitlis2));
            }
            else
            {
                Console.WriteLine("Kluda! Bija jaievada +, -, * vai /");
            }

            //Convert.ToDouble()
        }
    }
}
