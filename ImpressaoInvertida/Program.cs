using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpressaoInvertida
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Crie um algoritmo que cadastre cinco números
             * em um vetor e após o cadastro imprima esses 
             * números nas seguintes ordens: do primeiro ao
             * último e do último ao primeiro.
            */

            int[] numeros = new int[5];

            //cadastro dos números
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Informe um número..: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            // impressão do primeiro ao último
            Console.WriteLine("IMPRESSÃO 1o. AO ÚLTIMO");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("IMPRESSÃO DO ÚLTIMO AO 1o.");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.ReadKey();
        }
    }
}
