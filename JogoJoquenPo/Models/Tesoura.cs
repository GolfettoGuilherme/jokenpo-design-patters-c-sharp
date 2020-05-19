using System;
using System.Collections.Generic;

namespace JogoJoquenPo.Models
{
    public class Tesoura : Escolha
    {
        private static Tesoura Instancia = null;

        public Tesoura()
        {
            if (!FoiConfigurada)
            {
                FoiConfigurada = true;
                Iniciar();
            }
            
        }

        public override void Iniciar()
        {
            this.Ganha.Add(Papel.BuscarInstancia());
            this.Ganha.Add(Lagarto.BuscarInstancia());
        }

        public static Escolha BuscarInstancia()
        {
            if (Instancia == null)
                Instancia = new Tesoura();

            return Instancia;
        }


    }
}
