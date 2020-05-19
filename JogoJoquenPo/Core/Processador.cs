using System;
using JogoJoquenPo.Models;

namespace JogoJoquenPo.Core
{
    public class Processador
    {
        public Processador()
        {
        }

        public String Jogar(Jogador jogador1, Jogador jogador2)
        {

            if (jogador1.Escolha.GetType() == jogador2.Escolha.GetType())
            {
                return "Empate";
            }


            if (jogador1.Escolha.Ganha.Contains(jogador2.Escolha))
            {
                return "Jogador 1 Ganhou";
            }

            return "Jogador 2 Ganhou";

        }
    }
}
