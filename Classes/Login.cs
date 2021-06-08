using System;

namespace gerenciamentoProdutos.Classes
{
    public class Login
    {

        public bool Logado = false;

        public Login()
        {
        }

        public string Logar()
        {
            Usuario u = new Usuario();
            u.Cadastrar(u);
            Console.WriteLine("fazendo login");
            Console.WriteLine("confirme seu email");
            string confirmarEmail = Console.ReadLine();
            Console.WriteLine("confirme sua senha");
            string confirmarSenha = Console.ReadLine();

            if (confirmarEmail == u.email || confirmarSenha == u.senha)
            {
                Logado = true;
                // CRIAR MENU AQUI!!!!
            }
            else
            {
                Console.WriteLine("usuario ou senha incorreto");
            }
            return "";
        }

        public string Deslogar()
        {
            return "";

        }
    }
}