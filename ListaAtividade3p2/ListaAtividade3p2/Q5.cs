using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    internal class Q5
    {

        public static void exec()
        {
            /* 5. Modifique o programa em VS anterior para aceitar votos nulos 
             * (qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
             * Ao final, informe o nome do candidato vencedor, o número de votos nulos 
             * e o número de pessoas que votaram.
             */

            int votosJoao = 0, votosZeca = 0, votosBranco = 0, votosNulos = 0, totalVotos = 0;

            for (; ;)
            {
                Console.Write("Digite o nome do candidato (JOAO, ZECA, BRANCO) ou FIM para encerrar: ");
                string nome = Console.ReadLine().ToUpper();

                if (nome == "FIM") break;
                else if (nome == "JOAO") votosJoao++;
                else if (nome == "ZECA") votosZeca++;
                else if (nome == "BRANCO") votosBranco++;
                else votosNulos++;
                totalVotos++;
            }

            if (votosJoao > votosZeca) Console.WriteLine("João é o candidato vencedor!");
            else if (votosZeca > votosJoao) Console.WriteLine("Zeca é o candidato vencedor!");
            else Console.WriteLine("Houve um empate entre João e Zeca!");

            Console.WriteLine($"Total de votos: {totalVotos}");
            Console.WriteLine($"Votos nulos: {votosNulos}");
        }

        public static void exec2()
        {
            int votosJoao = 0, votosZeca = 0, votosBranco = 0, votosNulos = 0, totalVotos = 0;

            while(true)
            {
                Console.Write("Digite o nome do candidato (JOAO, ZECA, BRANCO) ou FIM para encerrar: ");
                string nome = Console.ReadLine().ToUpper();

                if (nome == "FIM") break;
                else if (nome == "JOAO") votosJoao++;
                else if (nome == "ZECA") votosZeca++;
                else if (nome == "BRANCO") votosBranco++;
                else votosNulos++;
                totalVotos++;
            }

            if (votosJoao > votosZeca) Console.WriteLine("João é o candidato vencedor!");
            else if (votosZeca > votosJoao) Console.WriteLine("Zeca é o candidato vencedor!");
            else Console.WriteLine("Houve um empate entre João e Zeca!");

            Console.WriteLine($"Total de votos: {totalVotos}");
            Console.WriteLine($"Votos nulos: {votosNulos}");
        }
    }
}
