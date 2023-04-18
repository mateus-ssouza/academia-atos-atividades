using System;
using System.Drawing;

namespace ListaAtividade3
{
    internal class Program
    {
        static void Questao1()
        {
            // Escreva um algoritmo para ler um número n, 
            // e em seguida ler pelo teclado calcular a média de idade de n pessoas.

            int n, idade, somaIdades = 0;
            double media;

            Console.Write("Digite um número: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite a idade da {i+1}º pessoa: ");
                idade = int.Parse(Console.ReadLine());

                somaIdades += idade;
            }

            media = somaIdades / n;
            Console.WriteLine($"A média das idades é: {media:N2}");
        }

        static void Questao2()
        {
            // Faça um algoritmo que leia 10 números pelo teclado,
            // e que no final mostre o maior deles. Não usar vetor.
            int num, maior;

            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            maior = num;

            for (int i = 0; i < 9; i++)
            {
                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());

                if (num > maior) maior = num;
            }

            Console.WriteLine("O maior número digitado foi: " + maior);
        }

        static void Questao3()
        {
            // Escreva um algoritmo que leia pelo teclado um valor e então calcule
            // a tabuada de 1 a 10 de um número x lido utilizando laços de repetição,
            // e mostre na tela..

            int valor;

            Console.Write("Digite um valor: ");
            valor = int.Parse(Console.ReadLine());

            Console.WriteLine("TABUADA DE " + valor);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{valor} X {i} = {valor * i}");
            } 
        }

        static void Questao4()
        {
            // Escreva um algoritmo que leia dois valores pelo teclado, x e y,
            // e em seguida calcule a potência de x elevado na y sem utilizar a função pow.
            int x, y, resultado = 1;

            Console.Write("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de Y: ");
            y = int.Parse(Console.ReadLine());

            for (int i = 0; i < y; i++)
            {
                resultado *= x;
            }
            Console.WriteLine($"\n{x}^{y} = {resultado}");
        }

        static void Questao5()
        {
            // Escreva um algoritmo para calcular o fatorial de um número.
            int num, fat = 1;

            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                fat *= i;
            }
            
            Console.WriteLine($"\nFatorial de {num} = {fat}");
        }

        static void Questao6()
        {
            // Escreva um algoritmo que leia o número de alunos de uma turma
            // e em seguida leia a quantidade de avaliações aplicadas para aquela
            // turma. Por fim, leia as notas das avaliações de cada aluno e mostre
            // sua nota final (média das notas das avaliações).

            int numAlunos, numNotas;
            double nota, somaNota = 0, media;

            Console.Write("Digite o número de alunos: ");
            numAlunos = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de notas: ");
            numNotas = int.Parse(Console.ReadLine());

            for(int i = 0; i < numAlunos; i++)
            {
                Console.WriteLine($"Aluno {i+1}");
                for(int j = 0; j < numNotas; j++)
                {
                    Console.Write($"Digite a {j+1}º nota: ");
                    nota = double.Parse(Console.ReadLine());

                    somaNota += nota;
                }
                
                media = somaNota / numNotas;
                Console.WriteLine($"Média: {media:N2}");
                Console.WriteLine("******************************\n");
                media = 0;
                somaNota = 0;
            }
        }

        static void Questao7()
        {
            // Escreva um programa em C# leia 20 números e que conte a quantidade
            // de números pares e ímpares digitados por um usuário. Apresente o resultado.

            int num, quantPares = 0, quantImpares = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    quantPares++;
                }
                else
                {
                    quantImpares++;
                }
            }

            Console.WriteLine("Total números pares: " + quantPares);
            Console.WriteLine("Total números ímpares: " + quantImpares);
        }

            static void Main(string[] args)
        {
            //Questao1();
            //Questao2();
            //Questao3();
            //Questao4();
            //Questao5();
            //Questao6();
            //Questao7();
        }
    }
}