using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    // 16 - Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva.
    // Crie, a seguir, um vetor para cada uma das operações:
    // •	A união de X com Y
    // •	A diferença entre X e Y
    // •	A interseção entre X e Y
    // Escreva o vetor resultado de cada uma das operações.

    internal class Q16
    {
        public static void exec()
        {
            int[] x = new int[5];
            int[] y = new int[5];

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º valor de X: ");
                x[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < y.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º valor de Y: ");
                y[i] = int.Parse(Console.ReadLine());
            }

            int[] uniao = new int[x.Length + y.Length];
            int auxUniao = 0;

            // UNIÃO
            for (int i = 0; i < x.Length; i++)
            {
                uniao[i] = x[i];
                auxUniao++;
            }

            for (int i = 0; i < y.Length; i++)
            {
                uniao[auxUniao] = y[i];
                auxUniao++;
            }
            Console.WriteLine("\nUnião: [{0}]", string.Join(", ", uniao));

            // DIFERENÇA
            int auxDiferenca = 0;

            for (int i = 0; i < x.Length; i++)
            {
                bool encontrado = false;

                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        encontrado = true;
                        break;
                    }
                }
                if (!encontrado) auxDiferenca++;
            }

            int[] diferenca = new int[auxDiferenca];
            int cont = 0;

            for (int i = 0; i < x.Length; i++)
            {
                bool encontrado = false;

                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    diferenca[cont] = x[i];
                    cont++;
                }
            }

            Console.WriteLine("\nDiferença: [{0}]", string.Join(", ", diferenca));

            // INTESERCÇÃO
            int auxIntersecao = 0;

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        auxIntersecao++;
                        break;
                    }
                }
            }

            int[] intersecao = new int[auxIntersecao];
            cont = 0;

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        intersecao[cont] = x[i];
                        cont++;
                        break;
                    }
                }
            }
            Console.WriteLine("\nInterseção: [{0}]", string.Join(", ", intersecao));
        }
    }
}
