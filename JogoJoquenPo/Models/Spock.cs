using System;
using System.Collections.Generic;

namespace JogoJoquenPo.Models
{
    public class Spock : Escolha
    {
        private static Spock Instancia = null;

        public Spock()
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
            this.Ganha.Add(Tesoura.BuscarInstancia());
        }

        public static Spock BuscarInstancia()
        {
            if (Instancia == null)
                Instancia = new Spock();

            return Instancia;
        }

    }
}
