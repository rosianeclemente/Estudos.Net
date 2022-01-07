using System;

namespace estudos1
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
           string opcaoUsuario = ObterOpcaoUsuario();
           while(opcaoUsuario.ToUpper() != "X")
           {
               switch(opcaoUsuario)
               {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
               }
               opcaoUsuario = ObterOpcaoUsuario();
           }
           Console.WriteLine("Obrigado por utilizar nossos serviços.");
           Console.ReadLine();
        }
        private static void ListarSeries()
        {
            Console.WriteLine("Listar serie");
            var lista = repositorio.Listar();

            if(lista.Count == 0){
                Console.WriteLine("Nenhuma serie cadastrada.");
                return;

            }
            foreach(var serie in lista)
            {
                Console.WriteLine("#ID {0}: {1}", serie.retornoId(), serie.retornaTitulo());
            }
        }
        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova serie");
            foreach(int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine("{0}.{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o genero entre as opções acima: ");
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Series a seu dispor!!");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Listar series");
            Console.WriteLine("2- Inserir nova serie");
            Console.WriteLine("3- Excluir serie");
            Console.WriteLine("4- Visualizar serie");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }    
        }
}
