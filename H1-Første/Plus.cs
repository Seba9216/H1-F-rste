using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace H1_Første
{
    public class Plus{
        // ligger 2 tal sammen
        public static void Plus1(double x, double y)
        {
            double result = x + y;
            Console.WriteLine(result);
           
        }
        // ganger 2 tal 
        public static void Gange(double x, double y)
        {
            double result = x * y;
            Console.WriteLine(result);

        }


        //sætter et tal i anden 
        public static void Ianden(double y, double x)
        {
            double res = y; 

            for (int i  =1; i < x; i++)
            {
                res = res * y; 
            }
            Console.WriteLine($"Du har opløftet {y} {x} antal gange og har fået {res}");
        }
    }
}
