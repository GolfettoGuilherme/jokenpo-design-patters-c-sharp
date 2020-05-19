using System;
using System.Collections.Generic;

namespace JogoJoquenPo.Models
{
    public class Papel : Escolha
    {

        private static Papel Instancia = null;

        public Papel()
        {
            if (!FoiConfigurada)
            {
                FoiConfigurada = true;
                Iniciar();
            }
        }

        public override void Iniciar()
        {
            this.Ganha.Add(Pedra.BuscarInstancia());
            this.Ganha.Add(Spock.BuscarInstancia());
        }

        public static Papel BuscarInstancia()
        {
            if (Instancia == null)
                Instancia = new Papel();

            return Instancia;
        }
    }
}
