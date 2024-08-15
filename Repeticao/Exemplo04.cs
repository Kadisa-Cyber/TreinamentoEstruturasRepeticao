using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeticao
{
    internal class Exemplo04
    {
        static void Main(string[] args)
        {

            int gap, i = 1;

            Console.WriteLine("Digite o fim do intervalo");
            gap = int.Parse(Console.ReadLine());

            if (gap > 0)
            {

                Console.WriteLine($"Os números de 1 à {gap} são:");

                while (i <= gap)
                {
                    Console.WriteLine(i);
                    i++;
                }

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Não foi possível fazer essa operação, na próxima digite um número positivo.");
                Console.ReadKey();  
            }
        }
    }
}
