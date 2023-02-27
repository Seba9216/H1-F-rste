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
        public static string input()
        {
            string Input = Console.ReadLine();
            return Input;
        }

        public static bool isValid(string res)
        {
            if (res == null)
            {
                Console.WriteLine("Skriv et tal din nar"); 
                return false;
            }

            try 
            { 
                Convert.ToInt64(res); 
                return true;
            }
            
            catch(Exception e)
            { Console.WriteLine("Du skal vælge et tal og ikke alt mulig andet skidt"); return false;   }
        }

    }
}
