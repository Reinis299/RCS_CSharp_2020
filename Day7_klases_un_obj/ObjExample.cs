using System;
namespace Day7_klases_un_obj
{
    public class ObjExample
    {
        private int a = 0;
        private int b = 0;

        public ObjExample()
        {
        }

        public void setA(int par1)
        {
            a = par1;
        }

        public int getA()
        {
            return a;
        }

        public void setB(int par1)
        {
            b = par1;
        }

        public int getB()
        {
            return b;
        }

        public void print()
        {
            Console.WriteLine("a = " + a + "b = " + b);
        }
    }
}
