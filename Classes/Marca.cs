using System.Collections.Generic;
using System;
namespace gerenciamentoProdutos.Classes
{
    public class Marca
    {
        private int codigoMarca;
        private string nomeMarca;
        private DateTime dataMarca = DateTime.Now;

        List<Marca> marcas = new List<Marca>();

        public string CadastrarMarca(Marca marca){
            marcas.Add(marca);
            Console.WriteLine("Insira o código da marca");
            this.codigoMarca = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o nome da marca");
            this.nomeMarca = Console.ReadLine();
            return "Marca cadastrada";
        }

        public void ListarMarcas(){
            foreach(Marca marca in marcas){
                Console.WriteLine(marca);
            }
        }

        public string DeletarMarcas(){
            Console.WriteLine("Qual item você quer remover? (De preferência um número existente)");
            foreach(Marca marca in marcas){
                int i = 0;
                Console.WriteLine($@"{i}- {marca}");
                i++;
            }
            marcas.RemoveAt(int.Parse(Console.ReadLine()));
            return "Marca deletada com sucesso";
        }

    }
}