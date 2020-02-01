using System;

namespace day3_If
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;

            // &&
            //jaizpildas abiem
            if(a >= 5 && b == 6)
            {

            }

            // ||
            //jaizpildas vienam
            if(a > 5 || b == 6)
            {

            }

            int skaitlis = 5;
            //#
            //##
            //###
            //>5, <5, ==5

            if(skaitlis > 5)
            {
                Console.WriteLine("#");
            }
            else if(skaitlis < 5)
            {
                Console.WriteLine("##");
            }
            else
            {
                Console.WriteLine("###");
            }



            //Gadijums ar vairakiem
            //and ir viens nosacijums, or nakamais
            //izpildas vai nu visi and vai viens or
            int c = 7;

            if((a>5 && b<7 && c==7) || a < 9)
            {
                
            }
        }
    }
}
