using System;
using JogoJoquenPo.Core;
using JogoJoquenPo.Models;

namespace JogoJoquenPo
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador(new Pedra());


            Jogador j2 = new Jogador(new Pedra());


            var processador = new Processador();

            Console.WriteLine(processador.Jogar(j1, j2));
            Console.ReadKey();
        }
    }
}
