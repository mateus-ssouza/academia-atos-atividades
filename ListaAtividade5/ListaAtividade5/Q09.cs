using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade5
{
    // 9) Leia uma matriz 3x3. Em seguida, solicite um número qualquer ao
    // usuário e pesquise na matriz se o número existe.
    // Caso, seja verdade imprima a mensagem:  “O número
    // existe no vetor” , caso contrário “Número inexistente”.

    internal class Q09
    {
        public static void exec()
        {
            int[,] matriz = new int[3, 3];
            int linha = matriz.GetLength(0);
            int coluna = matriz.GetLength(1);

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write($"Digite o valor [{i}][{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("\nDigite um número para ser pesquisado: ");
            int x = int.Parse(Console.ReadLine());
            bool temNumero = false;

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    if (matriz[i, j] ==  x)
                    {
                        temNumero = true;
                        break;
                    }
                }
            }

            if (temNumero) Console.WriteLine("O número existe no vetor");
            else Console.WriteLine("Número inexistente");
        }
    }
}
