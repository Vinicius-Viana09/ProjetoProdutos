using System;
using gerenciamentoProdutos.Classes;

namespace gerenciamentoProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario u = new Usuario();
            Console.WriteLine($@"========================
|  O que deseja fazer? |
|----------------------|            
| 1 - cadastrar        |
| 2 - remover cadastro |
========================");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    u.Cadastrar(u);
                    u.Listar();
                    break;

                case "2":
                    u.Remover(u);
                    Console.WriteLine("Você removeu um usuário");
                    break;

                default:
                    break;
            }


            // Produto p = new Produto();

            // Console.WriteLine(p.dataProduto);
        }
    }
}
