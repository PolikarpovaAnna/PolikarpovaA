using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job1
{
    internal class Discr
    {
        private class Discr1
        {
            public double h, h1, h2;
            public static double EnterData()
            {
                double ddata;
                while (!Double.TryParse(Console.ReadLine(), out ddata))
                {
                    Console.Write("Enter data\n");
                }
                return ddata;
            }
            private double claDiscriminant()
            {
                return Math.Pow(h1, 2) - 4 * h * h2;
            }
            public void claRoots()
            {
                double D = claDiscriminant();
                if (D < 0)
                {
                    Console.Write("roots do not exist ( real numbers)");
                    return;
                }
                if (D == 0)
                {
                    Console.Write("Answer is {0}", -h1 / 2 * h);
                    return;
                }
                if (D > 0)
                {
                    Console.Write("Answer is {0} and {1}", (-h1 + Math.Sqrt(D)) / 2 * h, (-h1 - Math.Sqrt(D)) / 2 * h);
                }
            }
        }
        public static void Main(string[] args)
        {
            Discr1 mDiscr1 = new Discr1();
            mDiscr1.h = Discr1.EnterData();
            mDiscr1.h1 = Discr1.EnterData();
            mDiscr1.h2 = Discr1.EnterData();
            mDiscr1.claRoots();
        }
    }
}



