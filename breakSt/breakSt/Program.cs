using System;

namespace breakSt
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine("Ievadiet y vai n");
                String input = Console.ReadLine();
                
                input = input.ToUpper(); //ToUpper, ToLower
                if(input == "Y")
                {
                    break; //lai partrauktu darbibu ciklam
                }
                else
                {
                    Console.WriteLine(i);
                }
            }


            while (true)
            {
                Console.WriteLine("aa");
                String input = Console.ReadLine();

                input = input.ToUpper(); //ToUpper, ToLower
                if (input == "Y")
                {
                    break; //lai partrauktu darbibu ciklam
                }

            }
        }
    }
}
