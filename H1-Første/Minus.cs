using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Første
{
    public class Minus
    {
        public static int minus(int i, int j)
        {
            Console.WriteLine($" {i} - {j} giver {i - j}"); 
            return i - j;
        }
        public static int divi(int i, int j)
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
