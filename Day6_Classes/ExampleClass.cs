using System;

namespace Day6_Classes
{
    public class ExampleClass 
    {
        //public - varam pieklut no arpasaules
        //private - izmantojam tikai klases ieksiene
        public static int a = 5;
        private static int b = 8;

        public static void test()
        {
            Console.WriteLine("Hello from the otter side");
            privateTest();
        }

        private static void privateTest()
        {
            Console.WriteLine("Incognito");
            Console.WriteLine(b);
        }
    }
}
