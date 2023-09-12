
using Estante;
using Livros;
using System;
class program
{
    public static void Menu()
    {
        Console.WriteLine("Gerenciador de Livros");
        Console.WriteLine("Selecione uma das opções abaixo:");
        Console.WriteLine("1 - Pesquisar livros");
        Console.WriteLine("2 - Adicionar novo livro");
        Console.WriteLine("3 - Sair");
    }

    public static void Main()
    {
        try
        {
            CadastroLivroEmMemoria cadastroLivros = new CadastroLivroEmMemoria();
            String opcao = "";
            
            while (true)
            {
                Menu();
                opcao = Console.ReadLine();
                if(opcao == "1")
                {
                    Console.WriteLine("Digite o nome, ou parte do nome, do livro que deseja encontrar:");
                    String termoBuscado = Console.ReadLine();

                    Console.WriteLine("Selecione uma das opções abaixo para visualizar os dados de um dos livros encontrados:");                    
                    IEnumerable<Livro> resultadoBusca = cadastroLivros.BuscaLivro(termoBuscado);
                    int numeroPesquisa = 0;
                    foreach(Livro l in resultadoBusca)
                    {
                        numeroPesquisa++;
                        Console.WriteLine($"{numeroPesquisa} - {l.Nome}");
                    }

                    int numeroEscolhido = Convert.ToInt32(Console.ReadLine());
                    Livro livroSelecionado = resultadoBusca.ElementAt(numeroEscolhido-1);
                    Console.WriteLine($"O nome do livro é: {livroSelecionado.Nome}.");
                    Console.WriteLine($"O livro tem {livroSelecionado.NumeroPaginas} páginas.");
                    if(livroSelecionado.EhNovo == true)
                    {
                        Console.WriteLine($"O livro é novo.");
                    }
                    else
                    {
                        Console.WriteLine($"O livro é usado.");
                    }
                    Console.WriteLine($"A data da publicação é: {livroSelecionado.DataPublicacao}");
                    Console.WriteLine($"O preço do livro é: {livroSelecionado.Preco}");
                    Console.WriteLine($"Tem {Livro.CalcularIdadeLivro(livroSelecionado.DataPublicacao)} anos da publicação deste livro.");

                }
                if (opcao == "2")
                {
                    Console.WriteLine("Digite o nome do Livro:");
                    String nome = Console.ReadLine();
                    Console.WriteLine("Digite o número de páginas");
                    int numeroPaginas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite N para livro novo e U para usado");
                    string ehNovo = Console.ReadLine();
                    Console.WriteLine("Digite a data da publicação no formato dd/MM/yyyy");
                    DateTime dataPublicacao = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor do livro");
                    double preco = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Os dados abaixo estão corretos?");
                    Console.WriteLine(nome);
                    Console.WriteLine(numeroPaginas);
                    Console.WriteLine(ehNovo); 
                    Console.WriteLine(dataPublicacao); 
                    Console.WriteLine(preco);

                    Console.WriteLine("1 - Sim");
                    Console.WriteLine("2 - Não");
                    if (Console.ReadLine() == "1")
                    {
                        Livro livro = new Livro(nome, numeroPaginas, ehNovo, dataPublicacao, preco);
                        cadastroLivros.AdicionarLivro(livro);
                        Console.WriteLine("Dados adicionados com sucesso!");
                    }                    
                }
                if (opcao == "3")
                {                    
                    Console.WriteLine("Até mais!");
                    break;
                }
            }
            
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        

    }
}
