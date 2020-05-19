using System;
namespace JogoJoquenPo.Models
{
    public class Jogador
    {
        public Jogador(Escolha escolha)
        {
            Escolha = escolha;
        }

        public Escolha Escolha { get; set; }
    }
}
