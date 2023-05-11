namespace ListaAtividade8p3
{
    internal class Program
    {
        static void Q11()
        {
            Aluno a1 = new Aluno("Ana");
            a1.Nota1 = 8.5;
            a1.Nota2 = 9.0;
            a1.Nota3 = 9.5;

            Aluno a2 = new Aluno("José");
            a2.Nota1 = 5.5;
            a2.Nota2 = 6.0;
            a2.Nota3 = 4.5;

            Console.WriteLine("Alunos");
            Console.WriteLine("Nome: " + a1.Nome);
            Console.WriteLine($"Média: {a1.Media():N2}");
            Console.WriteLine("Situação: " + (a1.Situacao() ? "Aprovado!": "Reprovado!"));

            Console.WriteLine("Nome: " + a2.Nome);
            Console.WriteLine($"Média: {a2.Media():N2}");
            Console.WriteLine("Situação: " + (a2.Situacao() ? "Aprovado!" : "Reprovado!"));
        }

        static void Q12() 
        {
            Carro c = new Carro("Toyota", "1980");

            Console.WriteLine(c);
            c.Frear();
            Console.WriteLine("\n" + c);
            c.Acelerar();
            Console.WriteLine("\n" + c);
            c.Acelerar();
            Console.WriteLine("\n" + c);
            c.Frear();
            Console.WriteLine("\n" + c);

        }

        static void Q13() 
        {
            Autor a = new Autor("Mateus");
            Livro l = new Livro("Céu azul", a);

            l.info();
        }
        
        static void Q14() 
        {
            Agenda a = new Agenda();

            a.armazenaPessoa("Mateus", 19, 1.75F);
            a.armazenaPessoa("Bea", 39, 1.55F);
            a.armazenaPessoa("José", 61, 1.95F);
            Console.WriteLine("************************************");
            a.imprimeAgenda();
            Console.WriteLine("************************************");
            a.removePessoa("José");
            Console.WriteLine("************************************");
            a.imprimeAgenda();
            Console.WriteLine("************************************");
            bool busca = a.buscaPessoa("Mateus") != null;
            Pessoa p = a.buscaPessoa("Mateus");

            Console.WriteLine(busca ? p: "Pessoa não encontrada!");
        }

        static void Main(string[] args)
        {
            //Q11();
            //Q12();
            //Q13();
            //Q14();
        }
    }
}