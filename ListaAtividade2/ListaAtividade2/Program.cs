using System.Net;
using System.Reflection.Emit;

namespace ListaAtividade2
{
    internal class Program
    {
        static void Questao04()
        {
            /* 4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores 
             * e o valor por hora recebido por cada um deles. 
             * Mostrar na tela qual dos professores tem o maior salário total.
             */

            int p1HoraAula, p2HoraAula;
            double valorHora, salP1, salP2;

            Console.WriteLine("Digite a hora/aula do professor 1: ");
            p1HoraAula = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a hora/aula do professor 2: ");
            p2HoraAula = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor hora: ");
            valorHora = double.Parse(Console.ReadLine());

            salP1 = p1HoraAula * valorHora;
            salP2 = p2HoraAula * valorHora;

            if (salP1 > salP2)
            {
                Console.WriteLine("O professor 1 tem o maior salário");
            }
            else if (salP1 < salP2)
            {
                Console.WriteLine("O professor 2 tem o maior salário");
            }
            else
            {
                Console.WriteLine("O professores tem os mesmos salário");
            }
        }

        static void Questao05()
        {
            /* 5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
             * se a média das duas notas for maior ou igual a 7, 0. Caso a média seja inferior a 7,0, 
             * o programa deve ler a nota do exame e calcular a média final, é a média entre a nota do exame e 
             * a média das 2 notas. Se esta média final for maior ou igual a 5,0, o programa deve 
             * escrever “Aprovado”, caso contrário deve escrever “Reprovado”.*/

            double nota1, nota2, media;

            Console.WriteLine("Digite a nota 1: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 2: ");
            nota2 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            if (media >= 7.0)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                double notaExame, mediaFinal;

                Console.WriteLine("Digite a nota do exame: ");
                notaExame = double.Parse(Console.ReadLine());

                mediaFinal = (notaExame + media) / 2;

                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine("Aprovado");
                }
                else
                {
                    Console.WriteLine("Reprovado");
                }
            }
        }

        static void Questao06()
        {
            /* 6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
             * O programa deve calcular o Indice de Massa Corpórea(IMC), exibi-lo ao usuário e informar sua situação conforme a tabela.
             * O cálculo do imc = peso / (altura * altura)
             * 
             *                  IMC
             *          menor que 18                    ->  baixo peso
             *          maior que 18 e menor que 25     ->  peso normal
             *          maior que 25 e menor que 30     ->  sobrepeso
             *          maior que 30 e menor que 35     ->  obesidade
             *          maior que 35                    ->  obesidade grau sério
             */

            string nome;
            double altura, peso, imc;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            nome = nome.ToUpper();

            Console.WriteLine("Digite sua altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine("\nO IMC de " + nome);

            if (imc <= 18)
            {
                Console.WriteLine("baixo peso");
            }
            else if (imc > 18 && imc <= 25)
            {
                Console.WriteLine("peso normal");
            }
            else if (imc > 25 && imc <= 30)
            {
                Console.WriteLine("sobrepeso");
            }
            else if (imc > 30 && imc <= 35)
            {
                Console.WriteLine("obesidade");
            }
            else 
            {
                Console.WriteLine("obesidade grau sério");
            }
        }

        static void Questao07() 
        {
            /* 7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
            O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por
            exemplo, A palavra encontra-se na frase ou A palavra não se encontra na frase.*/

            Console.WriteLine("Digite uma frase:");
            string frase = Console.ReadLine();

            Console.WriteLine("Digite uma palavra para buscar:");
            string palavra = Console.ReadLine();

            if (frase.Contains(palavra))
            {
                Console.WriteLine("A palavra " + palavra + " encontra-se na frase.");
            }
            else
            {
                Console.WriteLine("A palavra " + palavra + " não se encontra na frase.");
            }
        }

        static void Questao08()
        {
            /* 8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
             * Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
             * Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
             * E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
             * total de vendas. */

            int codigo;
            string nome;
            double salarioBase, totalVendas, salarioFinal;
            
            Console.Write("Digite o código do funcionário: ");
            codigo = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o nome do funcionário: ");
            nome = Console.ReadLine();
            
            Console.Write("Digite o salário base do funcionário: ");
            salarioBase = double.Parse(Console.ReadLine());
            
            Console.Write("Digite o total de vendas do funcionário: ");
            totalVendas = double.Parse(Console.ReadLine());

            if (totalVendas > 500 && totalVendas <= 1000)
            {
                salarioFinal = salarioBase + (totalVendas * 0.05);
            }
            else if (totalVendas > 1000 && totalVendas <= 5000)
            {
                salarioFinal = salarioBase + (totalVendas * 0.07);
            }
            else if (totalVendas > 5000)
            {
                salarioFinal = salarioBase + (totalVendas * 0.10);
            }
            else
            {
                salarioFinal = salarioBase;
            }

            Console.WriteLine("Funcionário: " + nome);
            Console.WriteLine("Salário base: " + salarioBase.ToString("F2"));
            Console.WriteLine("Total de vendas: " + totalVendas.ToString("F2"));
            Console.WriteLine("Salário final: " + salarioFinal.ToString("F2"));
        }

        static void Questao09()
        {
            /*9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
             * diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
             * Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
             * Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.
             * 
             * Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
             * menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
             * 150, avisá-lo que será necessário adicionar 2 unidades de insulina.
             */

            double glicemia1, glicemia2, glicemia3;
            
            Console.WriteLine("Digite a primeira medição de glicemia:");
            glicemia1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda medição de glicemia:");
            glicemia2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira medição de glicemia:");
            glicemia3 = double.Parse(Console.ReadLine());

            // Verificando se há risco de hipoglicemia
            if (glicemia1 < 65 || glicemia2 < 65 || glicemia3 < 65)
            {
                Console.WriteLine("Atenção! Existe risco de hipoglicemia.");
            }

            // Verificando se há risco de hiperglicemia
            if (glicemia1 > 250 || glicemia2 > 250 || glicemia3 > 250)
            {
                Console.WriteLine("Atenção! Existe risco de hiperglicemia.");
            }
            
            double media = (glicemia1 + glicemia2 + glicemia3) / 3;
        
            if (media < 80)
            {
                Console.WriteLine("É preciso diminuir 2 unidades de insulina.");
            }

            if (media > 150)
            {
                Console.WriteLine("É necessário adicionar 2 unidades de insulina.");
            }
        }

        static void Questao10()
        {
            /* 10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
             * O programa deve mostrar os dados do atleta mais novo e mais alto.
             */

            string nomeAtleta1, nomeAtleta2, maisNovoNome, maisAltoNome;
            int idadeAtleta1, idadeAtleta2, maisNovoIdade, maisAltoIdade;
            double alturaAtleta1, alturaAtleta2, maisNovoAltura, maisAltoAltura;

            // Recebendo os dados do primeiro atleta
            Console.WriteLine("Digite os dados do primeiro atleta:");
            
            Console.Write("Nome: ");
            nomeAtleta1 = Console.ReadLine();
            
            Console.Write("Idade: ");
            idadeAtleta1 = int.Parse(Console.ReadLine());
            
            Console.Write("Altura (em metros): ");
            alturaAtleta1 = double.Parse(Console.ReadLine());

            // Recebendo os dados do segundo atleta
            Console.WriteLine("Digite os dados do segundo atleta:");
            
            Console.Write("Nome: ");
            nomeAtleta2 = Console.ReadLine();
            
            Console.Write("Idade: ");
            idadeAtleta2 = int.Parse(Console.ReadLine());
            
            Console.Write("Altura (em metros): ");
            alturaAtleta2 = double.Parse(Console.ReadLine());

            
            if (idadeAtleta1 < idadeAtleta2)
            {
                maisNovoNome = nomeAtleta1;
                maisNovoIdade = idadeAtleta1;
                maisNovoAltura = alturaAtleta1;
            }
            else
            {
                maisNovoNome = nomeAtleta2;
                maisNovoIdade = idadeAtleta2;
                maisNovoAltura = alturaAtleta2;
            }

            if (alturaAtleta1 > alturaAtleta2)
            {
                maisAltoNome = nomeAtleta1;
                maisAltoIdade = idadeAtleta1;
                maisAltoAltura = alturaAtleta1;
            }
            else
            {
                maisAltoNome = nomeAtleta2;
                maisAltoIdade = idadeAtleta2;
                maisAltoAltura = alturaAtleta2;
            }

            // Mostrando os dados do atleta mais novo e mais alto
            Console.WriteLine("O atleta mais novo é " + maisNovoNome + ", com " + maisNovoIdade + " anos e " + maisNovoAltura + " de altura");
            Console.WriteLine("O atleta mais alto é " + maisAltoNome + ", com " + maisAltoIdade + " anos e " + maisAltoAltura + " de altura");
        }

        static void Questao11()
        {
            /* 11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
             * O programa deve exibir se a hora digitada está ou não válida. 
             * Lembre que usaremos o padrão de hora com 24h, de 0 a 23.
             */

            string horaEntrada;
            int hora, minutos;

            Console.Write("Digite a hora: ");
            horaEntrada = Console.ReadLine();

            hora = int.Parse(horaEntrada.Split(":")[0]);
            minutos = int.Parse(horaEntrada.Split(":")[0]);

            if ((hora < 0) || (hora > 23) || (minutos < 0) || (minutos > 59))
            {
                Console.WriteLine("Hora digitada inválida!");
            }
            else
            {
                Console.WriteLine("Hora digitada válida!");
            }
        }

        static void Questao12()
        {
            /* 12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
             * número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
             * R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento 
             * armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
             * No final do processamento, exibir o salário total e o salário excedente do operário.
             */

            int codigo, numeroHoras;
            double salarioTotal, salarioExcendente;

            Console.Write("Digite o código do operário: ");
            codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite as horas trabalhadas: ");
            numeroHoras = int.Parse(Console.ReadLine());

            if (numeroHoras > 50)
            {
                int extra = numeroHoras - 50;
                salarioExcendente = 20.0 * extra;
                salarioTotal = numeroHoras * 10.0;
            }
            else
            {
                salarioExcendente = 0;
                salarioTotal = numeroHoras * 10.0;
            }

            Console.WriteLine("\n*** OPERÁRIO ***");
            Console.WriteLine("Código do operário: " + codigo);
            Console.WriteLine("Salário total: R$" + salarioTotal);
            Console.WriteLine("Salário excedente: R$" + salarioExcendente);
        }

        static void Questao13()
        {
            /* 13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
             * seu peso ideal, utilizando as seguintes fórmulas:
             * Para homens: (72.7 * h) - 58
             * Para mulheres: (62.1 * h) - 44.7
             */

            double h, pesoIdeal;
            char sexo;

            Console.Write("Digite seu sexo (M ou F): ");
            sexo = char.Parse(Console.ReadLine());

            switch (sexo)
            {
                case 'M':
                    Console.Write("Digite sua altura: ");
                    h = float.Parse(Console.ReadLine());

                    pesoIdeal = (double)(72.7 * h) - 58;
                    Console.WriteLine($"Seu peso ideal é de : {pesoIdeal:F2} KG");
                    break;
                case 'F':
                    Console.Write("Digite sua altura: ");
                    h = float.Parse(Console.ReadLine());

                    pesoIdeal = (double)(62.1 * h) - 44.7;
                    Console.WriteLine($"Seu peso ideal é de : {pesoIdeal:F2} KG");
                    break;
                default:
                    Console.WriteLine("Sexo inválido!");
                    break;
            }
        }

        static void Questao14()
        {
            /* 14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
             * link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
             * do arquivo usando este link (em minutos).
             */

            Console.Write("Informe o tamanho do arquivo em MB: ");
            double ArquivoMB = double.Parse(Console.ReadLine());

            Console.Write("Informe a velocidade do link em Mbps: ");
            double vel = double.Parse(Console.ReadLine());

            double velMB = vel * 0.125;

            double DownloadSegundos = ArquivoMB / velMB;
            double DownloadMinutos = DownloadSegundos / 60;

            Console.WriteLine($"O tempo aproximado de download é de {DownloadMinutos:F2} minutos.");
        }

        static void Questao15()
        {
            /* 15 - Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
             * da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados 
             * e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
             * Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.
             */

            double tamMetros, quantLitros, quantLatas;
            double total;

            Console.Write("Digite a quantidade em metros para ser pintada: ");
            tamMetros = double.Parse(Console.ReadLine());

            quantLitros = tamMetros / 3;
            quantLatas = quantLitros / 18;
            quantLatas = Math.Ceiling(quantLatas); // Função para arrendondar pra cima.
            total = quantLatas * 80.0;

            Console.WriteLine($"Será necessário comprar {quantLatas} latas, custando R${total:F2}");
        }

        static void Questao16()
        {
            /* 16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. 
             * Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
             * na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. 
             * Caso contrário, mostre uma mensagem indicando que os dois times irão se
             * enfrentar novamente em um novo jogo.
             * 
             * ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
             * ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
             * plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.
             */

            // Ler o placar do jogo da primeira fase da copa do Brasil
            Console.Write("Digite o placar do jogo (time1xtime2): ");
            string placar = Console.ReadLine();

            int placarTimeCasa = int.Parse(placar.Split("x")[0]);
            int placarTimeFora = int.Parse(placar.Split("x")[1]);

            
            if (placarTimeFora - placarTimeCasa > 1)
            {
                Console.WriteLine("O time de fora já se classificou");
            }
            else if (placarTimeCasa - placarTimeFora > 1)
            {
                Console.WriteLine("O time de casa já se classificou");
            }
            else
            {
                Console.WriteLine("Os dois times se enfrentarão em um novo jogo");

                Console.Write("Digite o placar do segundo jogo (time1xtime2): ");
                placar = Console.ReadLine();

                placarTimeCasa += int.Parse(placar.Split("x")[0]);
                placarTimeFora += int.Parse(placar.Split("x")[1]);

                if (placarTimeFora > placarTimeCasa)
                {
                    Console.WriteLine("O time de fora passou de fase.");
                }
                else if (placarTimeCasa > placarTimeFora)
                {
                    Console.WriteLine("O time da casa passou de fase.");
                }
                else
                {
                    Console.WriteLine("Houve um empate!");
                }
            }
        }

        static void Questao17()
        {
            /*17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), 
             * e então diga se esses lados podem ou não formar um triangulo. Para que os lados
             * formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros 
             * dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos
             * os lados iguais), isoceles (somente 2 lados são iguais) ou escaleno (os 3 lados são diferentes).
             */

            Console.Write("Digite o lado A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite o lado B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Digite o lado C: ");
            double c = double.Parse(Console.ReadLine());

            if ((a < b + c) && ( b < a + c) && (c < a + b))
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Triângulo equilátero");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Triângulo isósceles");
                }
                else
                {
                    Console.WriteLine("Triângulo escaleno");
                }
            }
            else
            {
                Console.WriteLine("Não é possível formar um triângulo");
            }
        }

        static void Questao18()
        {
            // 18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.

            Console.Write("Digite o 1º número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2º número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 3º número: ");
            int num3 = int.Parse(Console.ReadLine());

            int maior = num1;

            if (num2 > maior) maior = num2;

            if (num3 > maior) maior = num3;

            Console.WriteLine($"O maior valor é {maior}");
        }

        static void Questao19()
        {
            // 19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.

            Console.Write("Digite o 1º número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2º número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 3º número: ");
            int num3 = int.Parse(Console.ReadLine());

            int maior, medio, menor;

            if (num1 >= num2 && num1 >= num3)
            {
                maior = num1;
                if (num2 >= num3)
                {
                    medio = num2;
                    menor = num3;
                }
                else
                {
                    medio = num3;
                    menor = num2;
                }
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                maior = num2;
                if (num1 >= num3)
                {
                    medio = num1;
                    menor = num3;
                }
                else
                {
                    medio = num3;
                    menor = num1;
                }
            }
            else
            {
                maior = num3;
                if (num1 >= num2)
                {
                    medio = num1;
                    menor = num2;
                }
                else
                {
                    medio = num2;
                    menor = num1;
                }
            }

            Console.WriteLine($"Os valores em ordem decrescente: {maior}, {medio}, {menor}");
        }

        static void Questao20()
        {
            /* 20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. 
             * O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
             * plus: você pode gerar o número de forma randomica (função random c#).
             */

            Random random = new Random();
            int numeroSecreto = random.Next(1, 10);

            Console.WriteLine("*** JOGO DO NÚMERO SECRETO ***");
            Console.WriteLine("Você tem 3 chances para adivinhar o número secreto, que está entre 1 e 10.\n");

            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Tentativa {i}: digite um número: ");
                int palpite = int.Parse(Console.ReadLine());

                if (palpite == numeroSecreto)
                {
                    Console.WriteLine("Parabéns, você acertou o número secreto!");
                    return; // encerra o programa
                }
                else if (palpite < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é maior.");
                }
                else
                {
                    Console.WriteLine("O número secreto é menor.");
                }
            }

            Console.WriteLine($"Você perdeu. O número secreto era {numeroSecreto}.");
        }

        static void Questao21()
        {
            /* 21 - Crie um programa que permita que o usuário selecione uma unidade de 
             * medida de entrada (metros, centímetros, polegadas ou pés) e uma unidade de 
             * medida de saída usando um menu com o comando switch case. O programa deve,
             * em seguida, pedir ao usuário um valor de entrada e converter esse 
             * valor para a unidade de saída selecionada.
             */

            Console.WriteLine("Selecione a unidade de medida de entrada:");
            Console.WriteLine("1 - Metros");
            Console.WriteLine("2 - Centímetros");
            Console.WriteLine("3 - Polegadas");
            Console.WriteLine("4 - Pés");

            int unidadeEntrada = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSelecione a unidade de medida de saída:");
            Console.WriteLine("1 - Metros");
            Console.WriteLine("2 - Centímetros");
            Console.WriteLine("3 - Polegadas");
            Console.WriteLine("4 - Pés");

            int unidadeSaida = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de entrada:");

            double valorEntrada = double.Parse(Console.ReadLine());

            double valorSaida = 0;

            switch (unidadeEntrada)
            {
                case 1:
                   switch (unidadeSaida)
                    {
                        case 1:
                            valorSaida = valorEntrada;
                            break;
                        case 2:
                            valorSaida = valorEntrada * 100;
                            break;
                        case 3:
                            valorSaida = valorEntrada * 39.37;
                            break;
                        case 4:
                            valorSaida = valorEntrada * 3.281;
                            break;
                        default:
                            Console.WriteLine("Unidade de medida de saída inválida.");
                            break;
                    } 
                    
                    break;

                case 2:
                    switch (unidadeSaida)
                    {
                        case 1:
                            valorSaida = valorEntrada / 100;
                            break;
                        case 2:
                            valorSaida = valorEntrada;
                            break;
                        case 3:
                            valorSaida = valorEntrada / 2.54;
                            break;
                        case 4:
                            valorSaida = valorEntrada / 30.48;
                            break;
                        default:
                            Console.WriteLine("Unidade de medida de saída inválida.");
                            break;
                    }
                    break;

                case 3:
                    switch (unidadeSaida)
                    {
                        case 1:
                            valorSaida = valorEntrada / 39.37;
                            break;
                        case 2:
                            valorSaida = valorEntrada * 2.54;
                            break;
                        case 3:
                            valorSaida = valorEntrada;
                            break;
                        case 4:
                            valorSaida = valorEntrada / 12;
                            break;
                        default:
                            Console.WriteLine("Unidade de medida de saída inválida.");
                            break;
                    }  
                    break;

                case 4:
                    switch (unidadeSaida)
                    {
                        case 1:
                            valorSaida = valorEntrada / 3.281;
                            break;
                        case 2:
                            valorSaida = valorEntrada * 30.48;
                            break;
                        case 3:
                            valorSaida = valorEntrada * 12;
                            break;
                        case 4:
                            valorSaida = valorEntrada;
                            break;
                        default:
                            Console.WriteLine("Unidade de medida de saída inválida.");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Unidade de medida de entrada inválida.");
                    break;
            }

            Console.WriteLine($"Valor de saída: {valorSaida:F2}");
        }

        static void Main(string[] args)
        {
            //Questao04();
            //Questao05();
            //Questao06();
            //Questao07();
            //Questao08();
            //Questao09();
            //Questao10();
            //Questao11();
            //Questao12();
            //Questao13();
            //Questao14();
            //Questao15();
            //Questao16();
            //Questao17();
            //Questao18();
            //Questao19();
            //Questao20();
            //Questao21();
        }
    }
}