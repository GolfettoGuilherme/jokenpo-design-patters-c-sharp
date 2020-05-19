using System;
using System.Collections.Generic;

namespace JogoJoquenPo.Models
{
    public abstract class Escolha
    {
        public List<Escolha> Ganha = new List<Escolha>();
        protected static bool FoiConfigurada = false;

        public abstract void Iniciar();

        public override bool Equals(object obj)
        {
            if(this.GetType() == obj.GetType())
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Ganha);
        }
    }
}
