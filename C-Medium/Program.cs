using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium
{
    class Program
    {
        static void Main(string[] args)
        {
            var stars = 0;
            for (var i = 0; i < 50; i++)
            {
                Console.Write("*");
                stars++;
                if (stars % 10 == 0)
                {
                    Console.Write("\n");
                }

            }

        }
    }
}

