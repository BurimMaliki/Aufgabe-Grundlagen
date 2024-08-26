using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github
{
    internal class MyMath { }
    namespace Github
    {
        
        public static int Calc_ggt(int a, int b) {
            int z = 0;
            while (b != 0)
            {
                z = a % b;
                a = b;
                b = z;
            }
            return a;
        }

        public static int Calc_kgv(int a, int b)
        {
            return (a*b)
        }
        class Program
        {
            public static void Main(string[] args)
            {
                int val = 10;
                IncrementValue(val);
                Console.WriteLine(val);
            }

            public static void IncrementValue(int value)
            {
                value = value + 1;
            }
        }
     
    }
}
