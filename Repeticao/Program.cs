using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 0;

            Console.WriteLine("Números de 1 a 100");

            while (i <= 100)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("Fim do programa...");
            Console.ReadKey();

        }
    }
}
