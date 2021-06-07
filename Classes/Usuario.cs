using System;

namespace gerenciamentoProdutos.Classes
{
    public class Usuario
    {
        string cod;
        string nome;
        string email;
        string senha;
        public DateTime dataUsuario = DateTime.Now;

        public Usuario(){
            Console.WriteLine("Digite seu código");
            cod = Console.ReadLine();
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu email");
            email = Console.ReadLine();
            Console.WriteLine("Digite sua senha");
            senha = Console.ReadLine();
            Console.WriteLine(dataUsuario);
            
        }

        public void Deletar(){
            cod =  null;
            nome = null;
            email = null;
            senha = null;
        }

    }
}