using System;
namespace Day7_klases_un_obj
{
    public class Trijsturis
    {
        private static int mala1 = 0;
        private static int mala2 = 0;
        private static int mala3 = 0;

        public static void setMala1(int par1)
        {
            mala1 = par1;
        }

        public static int getMala1()
        {
            return mala1;
        }

        public static void setMala2(int par1)
        {
            mala2 = par1;
        }

        public static int getMala2()
        {
            return mala2;
        }

        public static void setMala3(int par1)
        {
            mala3 = par1;
        }

        public static int getMala3()
        {
            return mala3;
        }

        public static int perimetrs()
        {
            int p = 0;

            if(mala1 > 0 && mala2 > 0 && mala3 > 0)
            {
                p = mala1 + mala2 + mala3;
            }

            return p;
        }

        public static String perimetrs2()
        {
            int p = 0;

            if (mala1 > 0 && mala2 > 0 && mala3 > 0)
            {
                p = mala1 + mala2 + mala3;
                return p.ToString();
            }

            return "Kluda!";
        }


    }
}
