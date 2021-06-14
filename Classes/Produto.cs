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
        public Marca marca;
        public Usuario CadastradoPor;
        List<Produto> produtos = new List<Produto>();

        public string Cadastrar(Produto produto)
        {
            Marca m = new Marca();
            // this.codigoProduto = int.Parse(Console.ReadLine());

            
            produtos.Add(produto);
            return "Produto cadastrado com sucesso";
        }

        public List<Produto> ListaProdutos()
        {
            return produtos;
        }
        public string DeletarProduto()
        {
            
            return "Produto removido";
        }
    }
}