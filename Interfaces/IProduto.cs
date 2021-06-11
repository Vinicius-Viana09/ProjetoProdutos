using System.Collections.Generic;
using gerenciamentoProdutos.Classes;

namespace ProjetoProdutos.Interfaces
{
    public interface IProduto
    {
         string Cadastrar(Produto produto);
         List<Produto> ListaProdutos();
         string DeletarProduto();
    }
}