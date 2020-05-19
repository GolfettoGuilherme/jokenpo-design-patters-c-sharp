using System;
using System.Collections.Generic;

namespace JogoJoquenPo.Models
{
    public class Lagarto : Escolha
    {
        private static Lagarto Instancia = null;

        public Lagarto()
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
            this.Ganha.Add(Spock.BuscarInstancia());
        }

        public static Lagarto BuscarInstancia()
        {
            if (Instancia == null)
                Instancia = new Lagarto();

            return Instancia;
        }
    }
}
