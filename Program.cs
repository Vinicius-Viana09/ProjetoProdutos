using System;
using gerenciamentoProdutos.Classes;

namespace gerenciamentoProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario u = new Usuario();
            Produto p = new Produto();

            Console.WriteLine(p.dataProduto);
        }
    }
}
