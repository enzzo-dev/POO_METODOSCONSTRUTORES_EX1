using System;
using POO_METODOSCONSTRUTORES_EX1.classes;

namespace POO_METODOSCONSTRUTORES_EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            Pessoa pessoa = new Pessoa(nome,sobrenome);

            Console.WriteLine($"Bem vindo, {pessoa.Nome} {pessoa.SobreNome}");
        }
    }
}
