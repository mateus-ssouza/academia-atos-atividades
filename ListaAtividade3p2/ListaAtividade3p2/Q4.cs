using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    internal class Q4
    {
        public static void exec()
        {
            /* Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
             * Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
             * Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
             * Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
             * escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
             * de votos em branco. */

            int votosJoao = 0, votosZeca = 0, votosBranco = 0;
            string voto;

            for (; ;)
            {
                Console.Write("Digite o seu voto (JOAO, ZECA, BRANCO ou FIM): ");
                voto = Console.ReadLine().ToUpper();

                if (voto == "FIM")
                {
                    break;
                }
                else if (voto == "JOAO")
                {
                    votosJoao++;
                }
                else if (voto == "ZECA")
                {
                    votosZeca++;
                }
                else if (voto == "BRANCO")
                {
                    votosBranco++;
                }
                else
                {
                    Console.WriteLine("Voto inválido!");
                }
            }

            Console.WriteLine("Resultado da eleição:");
            Console.WriteLine($"Joao: {votosJoao} votos");
            Console.WriteLine($"Zeca: {votosZeca} votos");
            Console.WriteLine($"Branco: {votosBranco} votos");
        }

        public static void exec2()
        {

            int votosJoao = 0, votosZeca = 0, votosBranco = 0;
            string voto;

            while(true)
            {
                Console.Write("Digite o seu voto (JOAO, ZECA, BRANCO ou FIM): ");
                voto = Console.ReadLine().ToUpper();

                if (voto == "FIM") break;
                else if (voto == "JOAO") votosJoao++;
                else if (voto == "ZECA") votosZeca++;
                else if (voto == "BRANCO") votosBranco++;
                else Console.WriteLine("Voto inválido!");
            }

            Console.WriteLine("Resultado da eleição:");
            Console.WriteLine($"Joao: {votosJoao} votos");
            Console.WriteLine($"Zeca: {votosZeca} votos");
            Console.WriteLine($"Branco: {votosBranco} votos");
        }
    }
}

