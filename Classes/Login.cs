using System;

namespace gerenciamentoProdutos.Classes
{
    public class Login
    {

        public bool Logado = false;
        Usuario u = new Usuario();

        Marca m = new Marca();

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

            Console.WriteLine("fazendo login");
            Console.WriteLine("confirme seu email");
            usuarioDados.email = Console.ReadLine();
            Console.WriteLine("confirme sua senha");
            usuarioDados.senha = Console.ReadLine();

            Logar(usuarioDados);


            Console.WriteLine($@"Qual opção você quer?
            1- Marca
            2- Produto
            3- Deslogar");

            switch (Console.ReadLine())
            {
                case "1":
                string resposta;
                do
                {
                    Console.WriteLine($@"Qual opção você quer?
            1- Cadastrar marca
            2- Deletar marca
            3- Ver marcas
            4- Sair");
            resposta = Console.ReadLine();
                    switch (resposta)
                    {
                        
                        case "1":
                        Marca marcaDados = new Marca();
                            Console.WriteLine("Insira o código da marca");
                            marcaDados.codigoMarca = int.Parse(Console.ReadLine());
                            Console.WriteLine("Insira o nome da marca");
                            marcaDados.nomeMarca = Console.ReadLine();
                            marcaDados.dataMarca = DateTime.Now;
                            m.CadastrarMarca(marcaDados);
                            break;
                        case "2":
                        m.DeletarMarcas();
                            break;
                        case "3":
                        m.ListarMarcas();
                            int i = 1;
                        foreach(Marca marca in m.ListarMarcas()){
                            Console.WriteLine($@"{i}- {marca.nomeMarca}");
                            i++;
                        }
                            break;
                            case "4":
                            break;

                            default:
                            Console.WriteLine("Resposta inválida");
                            break;
                    }                    
                } while (resposta != "4");
                    break;

                case "2":
                    Console.WriteLine($@"Qual opção você quer?
            1- Cadastrar produto
            2- Deletar produto
            3- Ver produtos
            4- Sair");
                    break;

                case "3":
                    break;

                default:
                    break;
            }


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
            return "";

        }
    }
}