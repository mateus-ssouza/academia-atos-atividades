namespace ListaAtividade8p2
{
    internal class Program
    {
        static void Q04()
        {
            Pessoa p = new Pessoa();
            Console.WriteLine("Nome: " + p.Nome);
            Console.WriteLine("Idade: " + p.Idade);

            Console.WriteLine("\nNovos dados: ");
            p.Nome = "Ana";
            p.Idade = 10;

            Console.WriteLine("Nome: " + p.Nome);
            Console.WriteLine("Idade: " + p.Idade);
        }

        static void Q05()
        {
            Conta c = new Conta(10);

            Console.WriteLine("Número: " + c.Numero);
            Console.WriteLine("Saldo: " + c.Saldo);
            Console.WriteLine("Limite: " + c.Limite);

            Console.WriteLine("\nNovos dados: ");
            c.Saldo = 500;
            c.Limite = 1500;

            Console.WriteLine("Número: " + c.Numero);
            Console.WriteLine("Saldo: " + c.Saldo);
            Console.WriteLine("Limite: " + c.Limite);
        }

        static void Q06()
        {
            Fabricante f = new Fabricante("Fab1", "End1", "Rio de Janeiro");
            Produto p = new Produto("Lápis", 2.35);

            p.Fabricante = f;

            Console.WriteLine("Nome do produto: " + p.Nome);
            Console.WriteLine("Preço do produto: " + p.Preco);
            Console.WriteLine("Fabricante do produto: " + p.Fabricante.Nome);
            Console.WriteLine("Endereço do fabricante: " + p.Fabricante.Endereco);
            Console.WriteLine("Cidade do fabricante: " + p.Fabricante.Cidade);
        }

        static void Q07()
        {
            Autor a = new Autor("Mateus");
            Livro l = new Livro("Novo título", a);

            Console.WriteLine("Livro titulo: " + l.Titulo);
            Console.WriteLine("Livro Autor: " + l.Autor.Nome);
        }

        static void Q08()
        {
            Aluno a = new("Mateus", 1234);

            Console.WriteLine("Nome: " + a.Nome);
            Console.WriteLine("Matricula: " + a.Matricula);
        }

        static void Q09()
        {
            Console.Write("Digite o nome do titular: ");
            string t = Console.ReadLine();

            Console.Write("Digite o número da conta: ");
            string n = Console.ReadLine();

            Console.Write("Digite o saldo: ");
            double s = double.Parse(Console.ReadLine());

            Console.Write("Digite o limite: ");
            double l = double.Parse(Console.ReadLine());


            ContaBancaria cb = new ContaBancaria(n, t, s, l);

            while (true)
            {
                Console.WriteLine("*** Conta Bancária ***");
                Console.WriteLine("1 - Depositar\n2 - Sacar\n3 - Visualizar info.\n0 - Sair");
                int op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Console.Clear();
                    Console.Write("Digite o valor do deposito: ");
                    double d = double.Parse(Console.ReadLine());
                    bool statusOperacao = cb.Depositar(d);
                    Console.WriteLine(statusOperacao ? "Valor depositado!" : "Deposito indisponivel!");
                    Console.ReadLine();
                }
                if (op == 2)
                {
                    Console.Clear();
                    Console.Write("Digite o valor do saque: ");
                    double sq = double.Parse(Console.ReadLine());
                    bool statusOperacao = cb.Sacar(sq);
                    Console.WriteLine(statusOperacao ? "Valor sacado!" : "Saque indisponivel!");
                    Console.ReadLine();
                }    
                if (op == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Número da conta: " + cb.NumeroConta);
                    Console.WriteLine("Nome titular: " + cb.Titular);
                    Console.WriteLine("Saldo: " + cb.Saldo);
                    Console.WriteLine("Limite: " + cb.Limite);
                    Console.ReadLine();
                }
                if (op == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Programa finalizado!");
                    break;
                }
                Console.Clear();
            }
        }

        static void Q10()
        {
            Animal a = new Animal("Rex", "Cão", 4);
            a.EmitirSom();
        }

        static void Main(string[] args)
        {
            //Q04();
            //Q05();
            //Q06();
            //Q07();
            //Q08();
            //Q09();
            //Q10();
        }
    } 
}
