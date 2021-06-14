using System.Collections.Generic;
using System;

namespace gerenciamentoProdutos.Classes
{
    public class Login
    {

        public bool Logado = false;
        int contador = 0;
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

            do
            {
            Usuario usuarioLogin = new Usuario();
            Console.WriteLine("Fazendo login");
            Console.WriteLine("Confirme seu email");
            usuarioLogin.email = Console.ReadLine();
            Console.WriteLine("Confirme sua senha");
            usuarioLogin.senha = Console.ReadLine();

            Usuario UsuarioLogado = Logar(usuarioLogin);          
            } while (Logado == false);

            if (Logado == true)
            {
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
                                        // Console.WriteLine("Insira o código da marca");
                                        // marcaDados.codigoMarca = int.Parse(Console.ReadLine());
                                        contador++;
                                        marcaDados.codigoMarca = contador;
                                        Console.WriteLine("Insira o nome da marca");
                                        marcaDados.nomeMarca = Console.ReadLine();
                                        marcaDados.dataMarca = DateTime.Now;
                                        m.CadastrarMarca(marcaDados);
                                        break;

                                    case "2":
                                        m.DeletarMarcas();
                                        break;
                                    case "3":
                                        // m.ListarMarcas();
                                        int i = 1;
                                        foreach (Marca marca in m.ListaMarcas())
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
                            bool sair = false;
                            
                            switch (resposta)
                            {
                                case "1":
                                    Marca marca = new Marca();
                                    Produto produtoDados = new Produto();
                                    Console.WriteLine("Insira o nome do produto");
                                    produtoDados.nomeProduto = Console.ReadLine();

                                    Console.WriteLine("Insira o preço do produto");
                                    produtoDados.preco = float.Parse(Console.ReadLine());

                                    Console.WriteLine("Qual marca deseja escolher?");
                                    foreach (Marca m in m.ListaMarcas())
                                    {
                                        Console.WriteLine($@"{m.codigoMarca}- {m.nomeMarca}");
                                    }
                                    int marcaProduto = int.Parse(Console.ReadLine());
                                    List<Marca> _marcas = m.ListaMarcas();
                                    produtoDados.marca = _marcas.Find(item => item.codigoMarca == marcaProduto);

                                    p.Cadastrar(produtoDados);
                                    Console.WriteLine("Produto cadastrado com sucesso");
                                    sair = true;
                                    break;

                                case "2":
                                    Console.WriteLine("Qual produto deseja deletar?");
                                    int j = 0;
                                    foreach (Produto produto in p.ListaProdutos())
                                    {
                                        Console.WriteLine($@"{j}- {produto}");
                                        j++;
                                    }
                                    p.ListaProdutos().RemoveAt(int.Parse(Console.ReadLine()));
                                    p.DeletarProduto();
                                    Console.WriteLine(p.DeletarProduto());
                                    sair = true;
                                    break;

                                case "3":
                                    int k = 1;
                                    foreach (Produto produto in p.ListaProdutos())
                                    {
                                        Console.WriteLine($@"{k}- {produto.nomeProduto}");
                                        Console.WriteLine($@"{produto.marca.nomeMarca}");
                                        Console.WriteLine($@"Cadastrado em: {produto.dataProduto}");
                                        Console.WriteLine($@"Preço: {produto.preco:C2}");
                                        Console.WriteLine($@"Cadastrado por: {produto.CadastradoPor.nome}\n");
                                        k++;
                                    }
                                    break;

                                case "4":
                                    Console.WriteLine("Voltando");
                                    sair = false;
                                    break;

                                default:
                                    Console.WriteLine("Opção inválida");
                                    break;
                            }
                            
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
            else
            {
                Console.WriteLine("Senha ou email inválida!");
            }


        }

        public Usuario Logar(Usuario usuario)
        {
            Usuario usuarioEncontrado = u.listaUsuario.Find(x => x.email == usuario.email);

            if (usuarioEncontrado != null)
            {
                if(usuarioEncontrado.senha == usuario.senha){
                usuarioEncontrado = u.listaUsuario.Find(x => x.email == usuario.email);
                Logado = true;
                }else{
                    Console.WriteLine("Senha incorreta");
                }
            }
            else
            {
                Console.WriteLine("Email incorreto");
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