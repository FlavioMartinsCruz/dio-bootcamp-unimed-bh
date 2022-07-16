using System;
namespace CatalogoUnimedBH
{
    class Program
    {
        static StreamRepositorio repositorio = new StreamRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarStream(); break;
                    case "2":
                        InserirStream(); break;
                    case "3":
                        AtualizarStream(); break;
                    case "4":
                        ExcluirStream(); break;
                    case "5":
                        VisualizarStream(); break;
                    case "C":
                        Console.Clear(); break;
                    default:
                        throw new ArgumentOutOfRangeException("Entrada inválida! É necessário escolher uma das opções disponíveis");
                        
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }

            Cabecalho();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Acesse mais vídeos/podcasts da Unimed-BH em https://www.youtube.com/user/unimedbh/playlists");
            Console.ResetColor();
            Console.WriteLine();
            System.Threading.Thread.Sleep(4000);
        }

        private static void ExcluirStream()
        {
            Cabecalho();
            var lista = repositorio.Lista();
            if (lista.Count == 0)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nenhum cadastro encontrado para excluir!");
                    Console.ResetColor();
                    System.Threading.Thread.Sleep(2000);
                    return;
                }

            foreach (var streamExcluir in lista)
                {
                    var excluido = streamExcluir.retornaExcluido();
                    
                    Console.WriteLine($"Id {streamExcluir.retornaId()}: {streamExcluir.retornaTitulo()} {(excluido ? "(Excluído)" : "")}");
                }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Digite um dos Id apresentados acima: ");
            Console.ResetColor(); 
            int indiceStream = int.Parse(Console.ReadLine()!);
            repositorio.Exclui(indiceStream);

            Console.Clear();
            Cabecalho();
            Console.WriteLine();            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Vídeo/podcast excluído com sucesso!");
            Console.ResetColor();
            System.Threading.Thread.Sleep(2000);            
        }

        private static void VisualizarStream()
        {
            Cabecalho();
            var lista = repositorio.Lista();
            if (lista.Count == 0)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nenhum cadastro encontrado para visualizar!");
                    Console.ResetColor();
                    System.Threading.Thread.Sleep(2000);
                    return;
                }
            
            foreach (var streamVisualizar in lista)
                {
                    var excluido = streamVisualizar.retornaExcluido();
                    
                    Console.WriteLine($"Id {streamVisualizar.retornaId()}: {streamVisualizar.retornaTitulo()} {(excluido ? "(Excluído)" : "")}");
                }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Digite um dos Id apresentados acima: ");
            Console.ResetColor(); 
            int indiceStream = int.Parse(Console.ReadLine()!);
            var stream = repositorio.RetornaPorId(indiceStream);
            Console.WriteLine(stream);
            System.Threading.Thread.Sleep(4000);
        }

        private static void AtualizarStream()
        {
            Cabecalho();
            var lista = repositorio.Lista();
            if (lista.Count == 0)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nenhum cadastro encontrado para atualizar!");
                    Console.ResetColor();
                    System.Threading.Thread.Sleep(2000);
                    return;
                }

            foreach (var streamExcluir in lista)
                {
                    var excluido = streamExcluir.retornaExcluido();
                    
                    Console.WriteLine($"Id {streamExcluir.retornaId()}: {streamExcluir.retornaTitulo()} {(excluido ? "(Excluído)" : "")}");
                }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Digite o Id do vídeo/podcast: ");
            Console.ResetColor(); 
            Console.WriteLine();

            int indiceStream = int.Parse(Console.ReadLine()!);
            Console.WriteLine();
            foreach (int i in Enum.GetValues(typeof(Playlist)))
                {
                    Console.WriteLine($"({i}) {Enum.GetName(typeof(Playlist), i)}");
                }
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Selecione alguma playlist dentre as opções acima: ");
            Console.ResetColor(); 
            int entradaPlaylist = int.Parse(Console.ReadLine()!);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Digite o título do vídeo/podcast: ");
            Console.ResetColor(); 
            string? entradaTitulo = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Qual a duração do vídeo/podcast (em minutos)? ");
            Console.ResetColor(); 
            float duracao = float.Parse(Console.ReadLine()!);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Insira o link do vídeo/podcast: ");
            Console.ResetColor(); 
            string entradaLink = Console.ReadLine()!;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Digite a descrição do vídeo/podcast: ");
            Console.ResetColor(); 
            string entradaDescricao = Console.ReadLine()!;

            Stream atualizaStream = new Stream(id: indiceStream,
                                        playlist: (Playlist)entradaPlaylist,
                                        titulo: entradaTitulo!,
                                        duracao: duracao,
                                        descricao: entradaDescricao,
                                        link: entradaLink);

            repositorio.Atualiza(indiceStream, atualizaStream);

            Console.Clear();
            Cabecalho();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Vídeo/podcast atualizado com sucesso!");
            Console.ResetColor();
            System.Threading.Thread.Sleep(2000);

        }
        private static void ListarStream()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Cabecalho();

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nenhum cadastro encontrado!");
                Console.ResetColor();
                System.Threading.Thread.Sleep(2000);
                return;
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;;
            Console.WriteLine("Vídeos/podcasts cadastrados:");
            Console.ResetColor();
            Console.WriteLine();

            foreach (var stream in lista)
            {
                var excluido = stream.retornaExcluido();
                
                Console.WriteLine($"Id {stream.retornaId()}: {stream.retornaTitulo()} {(excluido ? "(Excluído)" : "")}");
            }
            System.Threading.Thread.Sleep(3000);
        }

        private static void InserirStream()
        {
            Cabecalho();
            Console.WriteLine();

            foreach (int i in Enum.GetValues(typeof(Playlist)))
            {
                Console.WriteLine($"({i}) {Enum.GetName(typeof(Playlist), i)}");
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Para inserir um novo vídeo/podcast, selecione uma das playlists acima: ");
            Console.ResetColor();
            int entradaPlaylist = int.Parse(Console.ReadLine()!);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Digite o título do vídeo/podcast: ");
            Console.ResetColor();
            Console.WriteLine();
            string? entradaTitulo = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Qual a duração do vídeo/podcast (em minutos)?");
            Console.ResetColor();
            Console.WriteLine();
            float Duracao = float.Parse(Console.ReadLine()!);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Digite a descrição do vídeo/podcast: ");
            Console.ResetColor();
            Console.WriteLine();
            string? entradaDescricao = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Insira o link do vídeo/podcast: ");
            Console.ResetColor();
            Console.WriteLine();
            string entradaLink = Console.ReadLine()!;

            Stream novaStream = new Stream(id: repositorio.ProximoId(),
                                        playlist: (Playlist)entradaPlaylist,
                                        duracao: Duracao,
                                        titulo: entradaTitulo!,
                                        descricao: entradaDescricao!,
                                        link: entradaLink);

            repositorio.Insere(novaStream);
            
            Console.Clear();
            Cabecalho();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Vídeo/podcast inserido com sucesso!");
            Console.ResetColor();
            System.Threading.Thread.Sleep(2000);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.Clear();
            Cabecalho();
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Informe a opção desejada:");
            Console.ResetColor(); 
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            Console.WriteLine("(1) Listar vídeos/podcasts");
            Console.WriteLine("(2) Inserir novo vídeo/podcast");
            Console.WriteLine("(3) Atualizar vídeo/podcast");
            Console.WriteLine("(4) Excluir vídeo/podcast");
            Console.WriteLine("(5) Visualizar vídeo/podcast");
            Console.WriteLine("(c) Limpar tela");
            Console.WriteLine("(x) Sair");
            Console.WriteLine("-------------------------------");

            string opcaoUsuario = Console.ReadLine()!.ToUpper();
            Console.WriteLine();
            Console.Clear();
            return opcaoUsuario;
        }
        private static void Cabecalho(){
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n _    _           _                          _            ____    _    _ \n| |  | |         (_)                        | |          |  _ \\  | |  | |\n| |  | |  _ __    _   _ __ ___     ___    __| |  ______  | |_) | | |__| |\n| |  | | | '_ \\  | | | '_ ` _ \\   / _ \\  / _` | |______| |  _ <  |  __  |\n| |__| | | | | | | | | | | | | | |  __/ | (_| |          | |_) | | |  | |\n \\____/  |_| |_| |_| |_| |_| |_|  \\___|  \\__,_|          |____/  |_|  |_|\n\n");
        Console.ResetColor();
        }
    }
}
