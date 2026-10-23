using System;

class Program
{
    static void Main()
    {
        int opcao = 0;

        while (opcao != 5)
        {
            Console.Clear();

            Console.WriteLine("=== MENU ===");
            Console.WriteLine("1. Cadastrar Usuário");
            Console.WriteLine("2. Cadastrar Livro");
            Console.WriteLine("3. Realizar Empréstimo");
            Console.WriteLine("4. Devolver Livro");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");

            try
            {
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("=== CADASTRO DE USUÁRIO ===");

                        Console.Write("Digite o nome do usuário: ");
                        string nome = Console.ReadLine()!;

                        Console.Write("Digite a idade: ");
                        int idade = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nUsuário cadastrado com sucesso!");
                        Console.WriteLine($"Nome: {nome}");
                        Console.WriteLine($"Idade: {idade}");
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("=== CADASTRO DE LIVRO ===");

                        Console.Write("Digite o nome do livro: ");
                        string titulo = Console.ReadLine()!;

                        Console.Write("Digite o autor: ");
                        string autor = Console.ReadLine()!;

                        Console.WriteLine("\nLivro cadastrado com sucesso!");
                        Console.WriteLine($"Título: {titulo}");
                        Console.WriteLine($"Autor: {autor}");
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("=== REALIZAR EMPRÉSTIMO ===");

                        Console.Write("Digite o nome do usuário: ");
                        string usuarioEmprestimo = Console.ReadLine()!;

                        Console.Write("Digite o nome do livro: ");
                        string livroEmprestimo = Console.ReadLine()!;

                        Console.WriteLine("\nEmpréstimo realizado com sucesso!");
                        Console.WriteLine($"Usuário: {usuarioEmprestimo}");
                        Console.WriteLine($"Livro: {livroEmprestimo}");
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("=== DEVOLVER LIVRO ===");

                        Console.Write("Digite o nome do livro: ");
                        string livroDevolvido = Console.ReadLine()!;

                        Console.WriteLine(
                            $"\nLivro '{livroDevolvido}' devolvido com sucesso!"
                        );
                        break;

                    case 5:
                        Console.WriteLine("\nSaindo do sistema...");
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida!");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(
                    "\nOpção inválida. Digite apenas números."
                );
            }

            if (opcao != 5)
            {
                Console.WriteLine("\nPressione ENTER para voltar ao menu...");
                Console.ReadLine();
            }
        }
    }
}