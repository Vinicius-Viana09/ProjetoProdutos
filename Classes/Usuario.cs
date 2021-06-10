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
        public DateTime dataUsuario;

        public List<Usuario> listaUsuario = new List<Usuario>();

        public Usuario(){
            
            
        }
        
        public string Cadastrar(Usuario u){
            listaUsuario.Add(u);
            return "Usuário cadastrado";
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