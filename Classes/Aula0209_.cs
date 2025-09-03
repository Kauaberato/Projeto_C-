using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Pessoa
    {
        public string Nome;
        public string CPF;
        public string Endereco;
        public string Idade;
        public string Estadocivil;
        public string email;

        public void Cadastrar()
        {
            Console.WriteLine("Óla, vamos começar o seu cadastro");
            Console.WriteLine("Informe seu nome, por gentileza");
            Nome = Console.ReadLine();
            Console.WriteLine("Informe seu CPF");
            CPF = Console.ReadLine();
            Console.WriteLine("Agora informe seu Endereço");
            Endereco = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            Idade = Console.ReadLine();
            Console.WriteLine("Por fim digite seu email para contato");
            email = Console.ReadLine();



        }


    }
}
