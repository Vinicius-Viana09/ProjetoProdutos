using System.Collections.Generic;
using System;
namespace gerenciamentoProdutos.Classes
{
    public class Produto
    {
        public int codigoProduto;
        public string nomeProduto;
        private float preco;
        private DateTime dataProduto = DateTime.Now;
        private Marca marca;
        private Usuario CadastradoPor = null;
        List<Produto> produtos = new List<Produto>();

        public string Cadastrar(Produto produto)
        {
            Marca m = new Marca();
            this.codigoProduto = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o nome do produto");
            this.nomeProduto = Console.ReadLine();

            Console.WriteLine("Insira o preço do produto");
            this.preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual marca deseja escolher?");
            List<Marca> _marcas = m.ListarMarcas();
            foreach (Marca marca in _marcas)
            {
                int i = 0;
                Console.WriteLine($@"{i}- {marca}");
                i++;
            }
            int marcaProduto = int.Parse(Console.ReadLine());
            marca = _marcas.Find(item => item.codigoMarca == marcaProduto);
            return "Produto cadastrado com sucesso";
        }

        public List<Produto> ListaProdutos()
        {
            return produtos;
        }
        public string DeletarProduto()
        {
            Console.WriteLine("Qual produto deseja deletar?");
            int j = 0;
            foreach (Produto produto in produtos)
            {
                Console.WriteLine($@"{j}- {produto}");
                j++;
            }
            produtos.RemoveAt(int.Parse(Console.ReadLine()));
            return "Produto removido";
        }
    }
}