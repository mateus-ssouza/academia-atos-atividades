using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    internal class Q6
    {
        public static void exec()
        {
            /*  6. Faça um programa em VS que solicite ao o usuário que 
             *  informe a idade e valide a entrada de dados, ou seja, 
             *  repita a leitura até que ela esteja correta (maior do que zero). 
             *  Ao final, mostre a idade digitada.
             */

            int idade;

            for (; ;)
            {
                Console.Write("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

                if (idade <= 0)
                {
                    Console.WriteLine("Idade inválida!!");
                    continue;
                }
                else
                {
                    Console.WriteLine("Idade registrada: " + idade);
                    break;
                }
            }
        }

        public static void exec2()
        {

            int idade;

           while(true)
            {
                Console.Write("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

                if (idade <= 0)
                {
                    Console.WriteLine("Idade inválida!!");
                    continue;
                }
                else
                {
                    Console.WriteLine("Idade registrada: " + idade);
                    break;
                }
            }
        }
    }
}
