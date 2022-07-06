using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 0; i < 100; i++)

            {

                if (i % 2 == 0)
                {
                    Console.WriteLine("Numero par: " + i);
                }
            }
        }
    }
}
