using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeticao
{
    internal class Exemplo03
    {
        static void Main(string[] args)
        {

            int i = 100;

            Console.WriteLine("Números de 100 a 1");

            while (i > 0)
            {
                Console.WriteLine(i);
                i--;
            }

            Console.WriteLine("Fim do programa...");
            Console.ReadKey();
        }
        }
}
