namespace ListaAtividade8
{
    internal class Program
    {
        static void Q01()
        {
            Console.Write("Escolha o tipo de instanciação(1 - nome e idade; 2 - idade): ");
            int op = int.Parse(Console.ReadLine());

            if (op == 1) 
            {
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o idade: ");
                int idade = int.Parse(Console.ReadLine());

                Pessoa p1 = new Pessoa(nome, idade);
                p1.exibirDados();

            }
            else if (op == 2)
            {
                Console.Write("Digite o idade: ");
                int idade = int.Parse(Console.ReadLine());

                Pessoa p1 = new Pessoa(idade);
                p1.exibirDados();
            }
            else
            {
                Console.WriteLine("Opção inválida!!");
            }
        }

        static void Q02()
        {
            Aluno a1 = new Aluno("Mateus", "12345");
            Aluno a2 = new Aluno("01/01/1999");
            Aluno a3 = new Aluno("Mateus", "01/01/1999", "05/09/2015");

            a1.exibirDados();
            a2.exibirDados();
            a3.exibirDados();
        }

        static void Q03()
        {
            ContaCorrente cc = new ContaCorrente();
            cc.definirSaldoInicial(1000);
       
            if (cc.sacar(500)) Console.WriteLine("Sacou!");
            else Console.WriteLine("Não possivel sacar!");

            Console.WriteLine($"Saldo atual: R${cc.saldoAtual():N2}");
        }

        static void Main(string[] args)
        {
            //Q01();
            //Q02();
            //Q03();
        }
    }
}