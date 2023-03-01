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
        /// <summary>
        /// står for at kalde de respektive metoder i de forskelige klasser ud fra input
        /// </summary>
        /// <param name="tal1"></param>
        /// <param name="tal2"></param>
       public static void Valg(double tal1 , double tal2)
       {
         string choice = Console.ReadLine(); 
            if(choice == "+")
            {
                Plus.Plus1(tal1,tal2);
            }
            if(choice == "-")
            {
                Minus.minus(tal1,tal2);
            }
            if(choice == "*") 
            { 
                Plus.Gange(tal1,tal2);
            }
            if (choice == "/")
            {
                Minus.divi(tal1, tal2); 
            }

            if(choice == "?")
            {
                Plus.Ianden(tal1,tal2);
            }

            else
            {
                Console.WriteLine("Vælg en regnemetode"); 
            }
       }
   }
}
