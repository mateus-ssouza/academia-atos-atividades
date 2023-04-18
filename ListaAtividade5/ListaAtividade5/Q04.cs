using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade5
{
    // 4) Popule uma matriz 5x5 e informe:
    // -Quantos números são pares
    // -Quantos números são impares
    // -Quantos números são positivos
    // -Quantos números são negativos
    // -Quantos zeros existem!

    internal class Q04
    {
        public static void exec()
        {
            int[,] matriz = new int[5, 5];
            int contPares = 0;
            int contImpares = 0;
            int contPositivos = 0;
            int contNegativos = 0;
            int contZeros = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Digite o valor [{i}][{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    if (matriz[i,j] % 2 == 0) contPares++;
                    else contImpares++;

                    if (matriz[i,j] < 0) contNegativos++;
                    else if (matriz[i,j] > 0) contPositivos++;
                    else contZeros++;
                }
            }

            Console.WriteLine($"Total pares: {contPares}");
            Console.WriteLine($"Total ímpares: {contImpares}");
            Console.WriteLine($"Total positivos: {contPositivos}");
            Console.WriteLine($"Total negativos: {contNegativos}");
            Console.WriteLine($"Total zeros: {contZeros}");
        }
    }
}
