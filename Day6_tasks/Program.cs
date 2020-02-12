using System;

namespace Day6_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            task5();
        }

        static void task1()
        {
            int biggest = Int32.MinValue; 
            for(int i = 0; i<6; i++)
            {
                int currentNumber = skaitlaIevade("skaitli"); //1. variants
               /* if (i == 0)
                {
                    biggest = currentNumber; //2. variants
                }*/
                if (currentNumber > biggest)
                {
                    biggest = currentNumber;
                }
            }

            Console.WriteLine(biggest);

        }

        static void task2()
        {
            Console.WriteLine("ievadiet gradus pec farenheita");
            String input = Console.ReadLine();
            double gradiF = Convert.ToDouble(input);

            double gradiC = (gradiF - 32) * 5 / 9;
            Console.WriteLine("pec celsija " + gradiC);
        }

        static void task3()
        {
            int w = skaitlaIevade("platumu");
            int h = skaitlaIevade("augstumu");

            for(int i = 0; i<h; i++)
            {

                for(int j = 0; j<w; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }

        static void task4()
        {
            String input = "";
            do
            {
                Console.WriteLine("Ievadiet frazi");
                input = Console.ReadLine();
            } while (input.Contains("zirgs") || input.Contains("suns")); //contains nav case sensitve
        }

        static void task5()
        {
            Console.WriteLine("Ievadiet minamo vardu!");
            String minamais = Console.ReadLine();

            Console.Clear();

            for(int i = 5; i > 0; i--)
            {
                Console.WriteLine("Ievadiet vardu, vel palikusi " + i + " meginajumi");
                Console.WriteLine("Varda garums ir " + minamais.Length);

                String ievade = Console.ReadLine();
                if(ievade == minamais)
                {
                    Console.WriteLine("Uzvar otrais speletajs");
                    break;
                }
                if(ievade!=minamais && i == 1)
                {
                    Console.WriteLine("Uzvar pirmais speletajs");
                }
            }
        }

        static void task6()
        {
            Console.WriteLine("Ievadiet savu vardu!");
            String vards = Console.ReadLine();

            Console.WriteLine("Sveiks, " + vards);
        }

        static int skaitlaIevade(String vertiba)
        {
            Console.WriteLine("Ievadiet " + vertiba);
            String skaitlaIevade = Console.ReadLine();
            int skaitlis = Convert.ToInt32(skaitlaIevade);
            return skaitlis;
        }
    }
}
