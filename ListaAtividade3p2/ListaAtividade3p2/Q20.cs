using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    internal class Q20
    {
        public static void exec()
        {
            /* 20. Foi realizada uma pesquisa de algumas características 
             * físicas da população de uma certa região, a qual coletou 
             * os seguintes dados referentes a cada habitante para serem analisados:
             * 
             * - sexo (masculino e feminino)
             * - cor dos olhos (azuis, verdes ou castanhos)
             * - cor dos cabelos ( louros, castanhos, pretos)
             * - idade 
             * 
             * Faça um algoritmo que determine e escreva: 
             * 
             * - a maior idade dos habitantes
             * - a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
             * e que tenham olhos verdes e cabelos louros.
             * O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.
             */

            int maiorIdade = 0;
            int qtdMulheres = 0;

            while (true)
            {
                Console.Write("Informe a idade (ou -1 para encerrar): ");
                int idade = int.Parse(Console.ReadLine());

                if (idade == -1) break;

                Console.Write("Informe o sexo (M/F): ");
                char sexo = char.Parse(Console.ReadLine());

                Console.Write("Informe a cor dos olhos (A - Azul, V - Verde, C - Castanho): ");
                char corOlhos = char.Parse(Console.ReadLine());

                Console.Write("Informe a cor dos cabelos (L - Louro, C - Castanho, P - Preto): ");
                char corCabelos = char.Parse(Console.ReadLine());

                if (idade > maiorIdade) maiorIdade = idade;

                if ((sexo == 'F') && (idade >= 18) && (idade <= 35) && (corOlhos == 'V') && (corCabelos == 'L')) qtdMulheres++;
            }

            Console.WriteLine("Maior idade: " + maiorIdade);
            Console.WriteLine("Quantidade de mulheres com olhos verdes, cabelos louros e idade entre 18 e 35 anos: " + qtdMulheres);
        }
    }
}
