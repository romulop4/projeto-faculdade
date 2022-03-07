using System;

namespace DataStructuresCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var gerenciadorFilaAtendimento = new GerenciadorFilaAtendimento();

            gerenciadorFilaAtendimento.GerarSenha();
            gerenciadorFilaAtendimento.GerarSenha();
            gerenciadorFilaAtendimento.GerarSenha();

            gerenciadorFilaAtendimento.MostrarFila();

            gerenciadorFilaAtendimento.ChamarProximo();
            gerenciadorFilaAtendimento.ChamarProximo();

            gerenciadorFilaAtendimento.MostrarFila();

            gerenciadorFilaAtendimento.GerarSenha();

            gerenciadorFilaAtendimento.ChamarProximo();

            gerenciadorFilaAtendimento.MostrarFila();

            Console.ReadLine();
        }
    }
}