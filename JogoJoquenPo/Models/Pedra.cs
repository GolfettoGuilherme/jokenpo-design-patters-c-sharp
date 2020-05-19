using System;
using System.Collections.Generic;

namespace JogoJoquenPo.Models
{
    public class Pedra : Escolha
    {
        private static Pedra Instancia = null;

        public Pedra()
        {
            if (!FoiConfigurada)
            {
                FoiConfigurada = true;
                Iniciar();
            }
            
        }

        public static Escolha BuscarInstancia()
        {
            if (Instancia == null)
                Instancia = new Pedra();

            return Instancia;
        }

        public override void Iniciar()
        {
            this.Ganha.Add(Lagarto.BuscarInstancia());
            this.Ganha.Add(Tesoura.BuscarInstancia());
        }
    }
}
