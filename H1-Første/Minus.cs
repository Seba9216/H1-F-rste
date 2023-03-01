using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Første
{
    public class Minus
    {
        // trækker 2 tal fra hinanden
        public static double minus(double i, double j)
        {
            Console.WriteLine($" {i} - {j} giver {i - j}"); 
            return i - j;
        }

        //dividere 2 tal
        public static double divi(double i, double j)
        {
            if(i == 0 && j == 0)
            {
                Console.WriteLine("Du må ikke dividere med 0 din SO"); 
                return 0; 
            }
            Console.WriteLine($"din divison stykker giver {i / j}"); 
            return i / j;
        }
    }
}
