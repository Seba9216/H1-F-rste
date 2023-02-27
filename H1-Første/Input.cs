using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Første
{
    public class Input
    {
        public static double input()
        {
            string Input = Console.ReadLine();
           return isValid(Input);
            
        }

        public static double isValid(string res)
        {
            if (res == null)
            {
                Console.WriteLine("Skriv et tal din nar"); 
                return 0;
            }

            try 
            { 
              double res1 =  Convert.ToDouble(res);
                return res1; 
            }
            
            catch(Exception e)
            { Console.WriteLine("Du skal vælge et tal og ikke alt mulig andet skidt"); return 0;  }

           
        }

    }
}
