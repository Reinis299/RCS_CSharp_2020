using System;

namespace Day4_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            loopExtra();
        }

        static void loopExtraExtra()
        {
            //*
            //**
            //***
            //****


            //*
            //**
            //***
            //****
            //***
            //**
            //*
        }

        static void loopExtra()
        {
            //cilveks ievada bazi(skaitli, ko kapinat)
            //ievada pakapi
            //izvadam rezultatu
            //*izmantojam veselus skaitlus
            //for ciklu
            Console.WriteLine("Ievadiet skaitli");
            String input = Console.ReadLine();
            int baze = Convert.ToInt32(input);

            Console.WriteLine("Ievadiet skaitli");
            input = Console.ReadLine();
            int pakape = Convert.ToInt32(input);

            int rezultats = 1;
            for(int i = 0; i < pakape; i++)
            {
                rezultats = rezultats * baze;
            }

            Console.WriteLine(rezultats);
        }
        static void forLoopTask2()
        {
            //Cilveks ievada 5 skaitlus
            //Izvadam skaitlu summu
            int sum = 0;

            for(int i = 0; i<5; i++)
            {
                Console.WriteLine("Ievadiet skaitli");
                String input = Console.ReadLine();
                sum = sum + Convert.ToInt32(input);
            }

            Console.WriteLine(sum);
        }

        static void forLoopTask1()
        {
            //ar for cikla palidzibu sasummet skaitlus no 1 lidz 10
            //izvadit summu
            int sum = 0;

            for(int i = 1; i<=10; i++)
            {
                sum = sum + i;
                //sum+=i;

            }

            Console.WriteLine("Summa ir " + sum);
        }

        static void forLoopExample()
        {
            int b = 0;
            for(int i = 1; i<101; i++)
            {
                b = i;
                Console.WriteLine(i);
            }
            Console.WriteLine(b);

            for(int i = 0; i<6; i++) //i++ -> i=i+1
            {
                //Console.WriteLine("ievadiet frazi");
                //String fraze = Console.ReadLine();
                //Console.WriteLine("Cikla pielietojums -> " + i);
            }
        }

        static void whileUnDoWhile()
        {
            int a = 0;

            while (a < 10)
            {
                Console.WriteLine("Cikla pielietojums -> " + a);
                a++;
            }
            a = 0;

            //Do..while ieiet cikla vismaz vienu reizi (ja a >= 10 )
            do
            {
                Console.WriteLine("Cikla pielietojums -> " + a);
                a++;
            } while (a < 10);
        }
    }
}
