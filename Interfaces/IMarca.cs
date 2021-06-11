using System.Collections.Generic;
using gerenciamentoProdutos.Classes;
namespace ProjetoProdutos.Classes
{
    public interface IMarca
    {
         string DeletarMarcas();
         List<Marca> ListaMarcas();
         string CadastrarMarca(Marca marca);
    }
}