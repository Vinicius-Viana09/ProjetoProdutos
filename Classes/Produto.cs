using System.Collections.Generic;
using System;
namespace gerenciamentoProdutos.Classes
{
    public class Produto
    {
        public int codigoProduto;
        public string nomeProduto;
        public float preco;
        public DateTime dataProduto = DateTime.Now;
        private Marca marca;
        public Usuario CadastradoPor;
        List<Produto> produtos = new List<Produto>();

        public string Cadastrar(Produto produto)
        {
            Marca m = new Marca();
            // this.codigoProduto = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o nome do produto");
            this.nomeProduto = Console.ReadLine();

            Console.WriteLine("Insira o preço do produto");
            this.preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual marca deseja escolher?");
<<<<<<< HEAD
            List<Marca> _marcas = marca.ListaMarcas();
            int i = 1;
            foreach (Marca marca in m.ListaMarcas())
=======
            List<Marca> _marcas = m.ListarMarcas();
            foreach (Marca marca in _marcas)
>>>>>>> 21befb6b8095ba50e3c7ca310cbd1ea1d1aa2c60
            {
                Console.WriteLine($@"{i}- {marca.nomeMarca}");
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