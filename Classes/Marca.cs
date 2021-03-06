using System.Collections.Generic;
using System;
namespace gerenciamentoProdutos.Classes
{
    public class Marca
    {
        public int codigoMarca;
        public string nomeMarca;
        public DateTime dataMarca;

        List<Marca> marcas = new List<Marca>();

        public string CadastrarMarca(Marca marca)
        {
            marcas.Add(marca);
            return "Marca cadastrada";
        }

        public List<Marca> ListaMarcas()
        {
            return marcas;
        }

        public string DeletarMarcas()
        {
            Console.WriteLine("Qual item você quer remover? (De preferência um número existente)");
            int i = 0;
            foreach(Marca marca in marcas){
                Console.WriteLine($@"{i}- {nomeMarca}");
                i++;
            }
            marcas.RemoveAt((int.Parse(Console.ReadLine()))-1);
            return "Marca deletada com sucesso";
        }

    }
}