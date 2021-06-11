using System;

namespace gerenciamentoProdutos.Classes
{
    public class Login
    {

        public bool Logado = false;
        Usuario u = new Usuario();

        Marca m = new Marca();
        Produto p = new Produto();
        public Login()
        {

            Usuario usuarioDados = new Usuario();
            Console.WriteLine("Digite seu código");
            usuarioDados.cod = Console.ReadLine();
            Console.WriteLine("Digite seu nome");
            usuarioDados.nome = Console.ReadLine();
            Console.WriteLine("Digite seu email");
            usuarioDados.email = Console.ReadLine();
            Console.WriteLine("Digite sua senha");
            usuarioDados.senha = Console.ReadLine();
            usuarioDados.dataUsuario = DateTime.Now;
            u.Cadastrar(usuarioDados);

            Console.WriteLine("Fazendo login");
            Console.WriteLine("Confirme seu email");
            usuarioDados.email = Console.ReadLine();
            Console.WriteLine("Confirme sua senha");
            usuarioDados.senha = Console.ReadLine();

            Logar(usuarioDados);


            do
            {
                Console.WriteLine($@"-------------------------
| Qual opção você quer? |
| 1- Marca              |
| 2- Produto            |
| 3- Deslogar           |
-------------------------");

                switch (Console.ReadLine())
                {
                    case "1":
                        string resposta;
                        do
                        {
                            Console.WriteLine($@"-------------------------
                | Qual opção você quer? |
                | 1- Cadastrar marca    |
                | 2- Deletar marca      |
                | 3- Ver marcas         |
                | 4- Voltar             |
                -------------------------");
                            resposta = Console.ReadLine();
                            switch (resposta)
                            {

                                case "1":
                                    Marca marcaDados = new Marca();
                                    Console.WriteLine("Insira o código da marca");
                                    m.codigoMarca = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Insira o nome da marca");
                                    m.nomeMarca = Console.ReadLine();
                                    m.dataMarca = DateTime.Now;
                                    m.CadastrarMarca(m);
                                    break;
                                case "2":
                                    m.DeletarMarcas();
                                    break;
                                case "3":
                                    // m.ListarMarcas();
                                    int i = 1;
                                    foreach (Marca marca in m.ListarMarcas())
                                    {
                                        Console.WriteLine($@"{i}- {marca.nomeMarca}");
                                        i++;
                                    }
                                    break;
                                case "4":
                                    Console.WriteLine("Voltando");
                                    break;

                                default:
                                    Console.WriteLine("Resposta inválida");
                                    break;
                            }
                        } while (resposta != "4");
                        break;

                    case "2":
                        Console.WriteLine($@"
                        -------------------------
| Qual opção você quer? |
| 1- Cadastrar produto  |
| 2- Deletar produto    |
| 3- Ver produtos       |
| 4- Voltar             |
-------------------------");
                        resposta = Console.ReadLine();
                        do
                        {
                            switch (resposta)
                            {
                                case "1":
                                    Produto produtoDados = new Produto();
                                    p.Cadastrar(produtoDados);
                                    Console.WriteLine(produtoDados.Cadastrar(produtoDados));
                                    break;

                                case "2":
                                    p.DeletarProduto();
                                    Console.WriteLine(p.DeletarProduto());
                                    break;

                                case "3":
                                    int i = 0;
                                    foreach (Produto produto in p.ListaProdutos())
                                    {
                                        Console.WriteLine($@"{i}- {produto.nomeProduto}");
                                        i++;
                                    }
                                    break;

                                case "4":
                                    Console.WriteLine("Voltando");
                                    break;

                                default:
                                Console.WriteLine("Opção inválida");
                                break;
                            }
                        } while (resposta != "4");
                        break;

                    case "3":
                        Console.WriteLine($@"Deslogando...");
                        Console.WriteLine(Deslogar());
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (Logado == true);


        }

        public Usuario Logar(Usuario usuario)
        {
            Usuario usuarioEncontrado = null;

            if (u.listaUsuario.Find(x => x.email == usuario.email).senha == usuario.senha)
            {
                usuarioEncontrado = u.listaUsuario.Find(x => x.email == usuario.email);
                Logado = true;
                // CRIAR MENU AQUI!!!!
            }
            else
            {
                Console.WriteLine("usuario ou senha incorreto");
            }
            return usuarioEncontrado;

        }

        public string Deslogar()
        {
            Logado = false;
            return "Deslogado!";
        }
    }
}