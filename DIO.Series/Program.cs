using System;


namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() ! = "X")

            {
                switch (opcaoUsuario)
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

                        throw new ArgumentOutRangeExcepetion();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
                Console.WriteLine("Obrigada por utilizar nossos serviços");
                Console.ReadLine();

        }


        public static void ListarSeries()
        {
            Console.WriteLine("Listar séries");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadstrada.");
                return;
            }

            foreach (var serie in lista)

            {
                var excluido = serie.retornaExcluido();

            
                Console.WriteLine("#ID {0}: - {1} {2}" , serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluido*" : ""));
            }
        }

         public static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("ID {0}: - {1}", Enum.GetName(typeof(Genero),1));
            }

            Console.WriteLine("Digite o Genêro entre as opções acima:");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Titulo entre as opções acima:");
            int entradaTitulo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Ano entre as opções acima:");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição entre as opções acima:");
            int entradaDescricao= int.Parse(Console.ReadLine());

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        Titulo: entradaTitulo,
                                        Ano: entradaAno,
                                        Descrição: entradaDescricao);
            repositorio.Insere(novaSerie);

        }

        private static void AtualizarSerie()
        {
            Console.WriteLine("Digite o id da série:");
            int indiceSerie = int.Parse(Console.ReadLine());


             foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("ID {0}: - {1}", Enum.GetName(typeof(Genero),1));
            }

            Console.WriteLine("Digite o Genêro entre as opções acima:");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Titulo entre as opções acima:");
            int entradaTitulo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Ano entre as opções acima:");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição entre as opções acima:");
            int entradaDescricao= int.Parse(Console.ReadLine());

              Serie novaSerie = new Serie(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        Titulo: entradaTitulo,
                                        Ano: entradaAno,
                                        Descrição: entradaDescricao);
            repositorio.Insere(novaSerie);

        }

        private static void ExcluirSerie()
        {
            Console.WriteLine("Digite o id da série que deseja excluir:");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);

            repositorio.Exclui(serie);
        }

        private static void VisualizarSerie()
        {
            Console.WriteLine("Digite o id da série que deseja visuzaliar:");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);

            repositorio.Exclui(serie);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();            
            Console.WriteLine("Seja bem vindo ao DIO Séries!");            
            Console.WriteLine("Informe a opção desejada para continuar:");

            
            Console.WriteLine("1- Listar séries");            
            Console.WriteLine("2- Inserier nova séries");            
            Console.WriteLine("3- Atualizar série");            
            Console.WriteLine("4- Excluir série");            
            Console.WriteLine("5- Visualizar série");            
            Console.WriteLine("C - Limpar Tela");            
            Console.WriteLine("X - Sair");            
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }
        
           
    }
}
