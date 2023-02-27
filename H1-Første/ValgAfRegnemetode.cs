using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Første
{
     public class ValgAfRegnemetode
    {
       public static void Valg(double tal1 , double tal2)
        {
         string   choice = Console.ReadLine(); 
            if(choice == "+")
            {

            }
            if(choice == "-")
            {
                Minus.minus(tal1,tal2);
            }
            if(choice == "*") 
            { 
            
            }
            if (choice == "/")
            {
                Minus.divi(tal1, tal2); 
            }
            else
            {
                Console.WriteLine("Vælg en regnemetode"); 
            }


        }

    }
}
