using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace H1_Første
{
    public class Plus{

        public Plus(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(x + y == result);
           
        }
    }
}
