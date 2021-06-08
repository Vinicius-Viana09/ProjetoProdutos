using System;
using System.Collections.Generic;

namespace gerenciamentoProdutos.Classes
{
    public class Usuario
    {
        public string cod;
        public string nome;
        public string email;
        public string senha;
        public DateTime dataUsuario = DateTime.Now;

        public List<Usuario> listaUsuario = new List<Usuario>();

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
        
        public string Cadastrar(Usuario u){
            listaUsuario.Add(u);
            return "";
        }

        public string Remover(Usuario u){
            listaUsuario.Remove(u);
            return "";
        }

        public void Listar(){
            foreach (var item in listaUsuario)
            {
                Console.WriteLine($" {item.cod} {item.nome} {item.email} {item.senha} {item.dataUsuario}");
            }
        }


    }
}