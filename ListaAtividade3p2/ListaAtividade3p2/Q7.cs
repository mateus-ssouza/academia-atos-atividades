using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    internal class Q7
    {
        public static void exec()
        {
            /* 7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
             * A cada solicitação, teste se o usuário informou um valor válido. 
             * Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
             * informe que ele está incorreto e saia do programa em VS. 
             * Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
             * informe que está errada e saia. Se estiver correta, solicite o salário. 
             * Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
             * Se estiver correto, mostre todos os valores lidos.
             */

            string nome;
            int idade;
            double salario;
            bool loop = false;

            // Solicita o nome e testa se a entrada é válida
            do
            {
                Console.Write("Digite o nome: ");
                nome = Console.ReadLine();

                for (int i = 0; i < nome.Length; i++)
                {
                    if (char.IsDigit(nome[i]) || string.IsNullOrEmpty(nome))
                    {
                        loop = true;
                        Console.WriteLine("Nome inválido. Digite novamente.");
                        break;
                    }
                    loop = false;
                }

            } while (loop);

            // Solicita a idade e testa se a entrada é válida
            do
            {
                Console.Write("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());

                if (idade <= 0) Console.WriteLine("Idade inválida. Digite novamente.");

            } while (idade <= 0);

            // Solicita o salário e testa se a entrada é válida
            do
            {
                Console.Write("Digite o salário: ");
                salario = double.Parse(Console.ReadLine());

                if (salario <= 0) Console.WriteLine("Salário inválido. Digite novamente.");

            } while (salario <= 0);

            // Exibe os valores lidos
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Salário: R${salario:F2}");
        }
    }
}
