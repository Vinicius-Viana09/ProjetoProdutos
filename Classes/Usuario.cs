using System;

namespace gerenciamentoProdutos.Classes
{
    public class Usuario
    {
        int cod;
        public string nome;
        string email;
        string senha;

        public Usuario(){
            Console.WriteLine("Digite seu código");
            cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu email");
            email = Console.ReadLine();
            Console.WriteLine("Digite sua senha");
            senha = Console.ReadLine();
            Console.WriteLine(DateTime.Now);
        }

        public void Deletar(){
            // cod = null;
        }
    }
}