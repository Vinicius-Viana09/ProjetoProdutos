using System;

namespace gerenciamentoProdutos.Classes
{
    public class Marca
    {
        public string Codigo;
        public string Nome;
        public DateTime dataMarca = DateTime.Now;

        public string CadastrarMarca(string codigo, string Nome){
            this.Codigo = codigo;
            this.Nome = Nome;
        }
    }
}