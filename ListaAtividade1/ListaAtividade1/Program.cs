namespace ListaAtividade1
{
    internal class Program
    {
        static void Questao1()
        {
            Console.WriteLine("Q1 - Média aritmética entre dois números quaisquer");

            double num1;
            double num2;
            double media;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            media = (num1 + num2) / 2;

            Console.WriteLine("Média: " + media);
        }

        static void Questao2()
        {
            Console.WriteLine("Q2 - Média aritmética entre quatro números quaisquer");

            double num1, num2, num3, num4, media;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            num3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quarto número: ");
            num4 = double.Parse(Console.ReadLine());

            media = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("Média: " + media);
        }

        static void Questao3()
        {
            Console.WriteLine("Q3 - Trocar entre si os valores de duas variáveis A e B");

            int a, b, aux;

            a = 10;
            b = 20;

            Console.WriteLine("A variavel A possui valor: " + a);
            Console.WriteLine("A variavel B possui valor: " + b);

            Console.WriteLine("Realizando a troca de valores");
            aux = a;
            a = b;
            b = aux;

            Console.WriteLine("A variavel A possui valor: " + a);
            Console.WriteLine("A variavel B possui valor: " + b);
        }

        static void Questao4()
        {
            Console.WriteLine("Q4 - Receba a data na forma DDMMAAAA e imprima na forma AAAAMMDD.");
            string dia, mes, ano;

            Console.WriteLine("Digite o dia: ");
            dia = Console.ReadLine();

            Console.WriteLine("Digite o mes: ");
            mes = Console.ReadLine();

            Console.WriteLine("Digite o ano: ");
            ano = Console.ReadLine();

            Console.WriteLine("DATA: " +  ano + "/" + mes + "/" + dia);
        }

        static void Questao5()
        {
            Console.WriteLine("Q5 - Calcular o consumo médio de um automóvel (medido em Km/l)");

            double litros, km, consumo;

            Console.WriteLine("Digite a distância em km: ");
            km = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a distância em km: ");
            litros = double.Parse(Console.ReadLine());

            consumo = km / litros;
            Console.WriteLine("Consumo do automóvel: " + consumo);
        }

        static void Questao6()
        {
            string codigoA, codigoB;
            int quantidadeA, quantidadeB;
            double valorUnitarioA, valorUnitarioB, ipi;

            Console.WriteLine("Q6 - Leia os dados para o parafuso A e para o parafuso B, isto é, o código, " +
                "a quantidade de peças e o valor unitário de cada parafuso e a porcentagem de IPI (única) a ser acrescentada");

            Console.WriteLine("Informe os dados para o parafuso A:");
            Console.Write("Código: ");
            codigoA = Console.ReadLine();
            
            Console.Write("Quantidade: ");
            quantidadeA = int.Parse(Console.ReadLine());
            
            Console.Write("Valor unitário: ");
            valorUnitarioA = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme os dados para o parafuso B:");
            Console.Write("Código: ");
            codigoB = Console.ReadLine();
            
            Console.Write("Quantidade: ");
            quantidadeB = int.Parse(Console.ReadLine());
            
            Console.Write("Valor unitário: ");
            valorUnitarioB = double.Parse(Console.ReadLine());

            Console.Write("\nPorcentagem de IPI a ser acrescentada: ");
            ipi = double.Parse(Console.ReadLine());

            Console.WriteLine("Parafuso A: COD: " + codigoA + " Valor: " + valorUnitarioA + " Quantidade: " + quantidadeA);
            Console.WriteLine("Parafuso B: COD: " + codigoB + " Valor: " + valorUnitarioB + " Quantidade: " + quantidadeB);
            Console.WriteLine("IPI: " + ipi);
        }

        static void Questao7()
        {
            /*
             * Q7 - leia o número de um vendedor, o seu salário fixo, 
             * o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
             * Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.
             */

            int numVendedor, totalVendas;
            double salarioFixo, percentualVendas, salarioTotal;

            Console.WriteLine("Número do vendedor: ");
            numVendedor = int.Parse(Console.ReadLine());

            Console.WriteLine("Total vendas: ");
            totalVendas = int.Parse(Console.ReadLine());

            Console.WriteLine("Salário fixo: ");
            salarioFixo = double.Parse(Console.ReadLine());

            Console.WriteLine("Salário percentual vendas: ");
            percentualVendas = double.Parse(Console.ReadLine());


            salarioTotal = salarioFixo + (totalVendas * percentualVendas);

            Console.WriteLine("Número vendedor: " + numVendedor + " Sálario total: " + salarioTotal);
        }

        static void Questao8()
        {
            /*
             * Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
             * A fórmula da conversão é F=(9*C+160)/5
             */
            float celsius, fahrenheit;

            Console.WriteLine("Digite a temperatura Celsius: ");
            celsius = float.Parse(Console.ReadLine());

            fahrenheit = (9 * celsius + 160) / 5;

            Console.WriteLine(celsius + "Cº = " + fahrenheit + "ºF");

        }
        static void Questao9()
        {
            /* Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
             * do que ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis. 
             * Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00; 
             * se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
             * Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
             * da entrada e das duas prestações, de acordo com as regras acima. 
             * Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
             * conseqüente pagamento dos boletos das duas prestações.*/

            double valorMecadoria, entrada, pres1, pres2, aux;

            Console.WriteLine("Valor da mercadoria: ");
            valorMecadoria = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor da entrada: ");
            entrada = double.Parse(Console.ReadLine());

            aux = valorMecadoria - entrada;

            pres1 = aux / 2;
            pres2 = pres1;

            Console.WriteLine("Valor mercadoria: R$" + valorMecadoria);
            Console.WriteLine("Entrada: R$" + valorMecadoria);
            Console.WriteLine("1º Prestação: R$" + pres1);
            Console.WriteLine("2º Prestação: R$" + pres2);
        }

        static void Questao10()
        {
            /*
             Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
             para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
            realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
            notas de menor valor fossem distribuídas em número mínimo possível. 
            Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
            uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
            Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
            de acordo com o critério da “distribuição ótima”.*/

            int valorPedido, auxValor, notas50, notas20, notas10, notas5, notas1;

            Console.Write("Informe o valor da quantia solicitada: R$ ");
            valorPedido = int.Parse(Console.ReadLine());

            auxValor = valorPedido;
            notas50 = auxValor / 50;
            auxValor %= 50;
            notas20 = auxValor / 20;
            auxValor %= 20;
            notas10 = auxValor / 10;
            auxValor %= 10;
            notas5 = auxValor / 5;
            auxValor %= 5;
            notas1 = auxValor;

            Console.WriteLine("\nDistribuição das notas para R$" + valorPedido);
            Console.WriteLine(notas50 + " nota(s) de R$ 50,00");
            Console.WriteLine(notas20 + " nota(s) de R$ 20,00");
            Console.WriteLine(notas10 + " nota(s) de R$ 10,00");
            Console.WriteLine(notas5 + " nota(s) de R$ 5,00");
            Console.WriteLine(notas1 + " nota(s) de R$ 1,00");
        }

        static void Questao11()
        {
            /* Escreva um algoritmo para ler o número de eleitores de um município, 
             * o número de votos brancos, nulos e válidos. 
             * Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.
            */ 

            int numEleitores, votosBrancos, votosNulos, votosValidos;
            double percBrancos, percNulos, percValidos;

            Console.Write("Digite o número totais de eleitores: ");
            numEleitores = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de votos brancos: ");
            votosBrancos = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de votos nulos: ");
            votosNulos = int.Parse(Console.ReadLine());

            votosValidos = numEleitores - votosBrancos - votosNulos;

            percBrancos = (double)votosBrancos / numEleitores * 100;
            percNulos = (double)votosNulos / numEleitores * 100;
            percValidos = (double)votosValidos / numEleitores * 100;

            Console.WriteLine("\nPercentuais de votos em relação ao total de eleitores (" + numEleitores +")");
            Console.WriteLine("Votos brancos: " + percBrancos + "%");
            Console.WriteLine("Votos nulos: " + percNulos + "%");
            Console.WriteLine("Votos válidos: " + percValidos + "%");
        }

        static void Questao12()
        {
            /*Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, 
             * escreva um algoritmo para ler a marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia,
             * o número de litros de combustível gasto e o valor total (R$) recebido dos passageiros. Calcule e escreva a média do consumo 
             * em Km/l e o lucro líquido do dia.
             * 
             * Fórmulas: Total quilometragem =  marcação odômetro final do dia - marcação odômetro inicio do dia 
             * Média do consumo = Total quilometragem/ quantidade de combustível gasto
             * Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)
             */

            double marcIniDia, marcFinDia, nLitros, totalRecebido, totalKm, mediaConsumo, lucroLiquido;

            Console.Write("Informe a marcação no início do dia: ");
            marcIniDia = double.Parse(Console.ReadLine());

            Console.Write("Informe a marcaçãono final do dia: ");
            marcFinDia = double.Parse(Console.ReadLine());

            Console.Write("Informe o número de litros de combustível gasto: ");
            nLitros = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor total recebido dos passageiros: ");
            totalRecebido = double.Parse(Console.ReadLine());

            totalKm = marcFinDia - marcIniDia;
            mediaConsumo = totalKm / nLitros;
            lucroLiquido = totalRecebido - (nLitros * 6.90);

            Console.WriteLine("\nTotal de quilômetros percorridos: " + totalKm + " km");
            Console.WriteLine("Média de consumo: " + mediaConsumo + " km/l");
            Console.WriteLine("Lucro líquido do dia: R$ " + lucroLiquido);
        }

        static void Questao13()
        {
            /*
             * Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. 
             * Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% 
             * sobre o preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que 
             * leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número 
             * de bicicletas vendidas pelo vendedor, calcule e mostre: o salário do empregado
             */

            double salarioMinimo, precoCusto, comissao, salarioEmpregado;
            int numBicicletas;

            Console.WriteLine("Digite o valor do salário mínimo: ");
            salarioMinimo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço de custo de cada bicicleta: ");
            precoCusto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de bicicletas vendidas pelo vendedor: ");
            numBicicletas = int.Parse(Console.ReadLine());

            comissao = precoCusto * 0.15 * numBicicletas;

            salarioEmpregado = (salarioMinimo * 2) + comissao;

            Console.WriteLine("O salário do empregado é: " + salarioEmpregado);
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
            //Questao8();
            //Questao9();
            //Questao10();
            //Questao11();
            //Questao12();
            //Questao13();
        }
    }
}