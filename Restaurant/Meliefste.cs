using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Meliefste : Restaurant, IKanAfhalen
    {
        public Meliefste()
        {
            this.naam = "Meliefste";
        }
        public override bool IsVol()
        {
            if (this.klanten.Count >= 80)
            {
                return true;

            }

            else return false;
        }

        public void Afhalen(Mens mens)
        {
            this.klanten.Add(mens);
        }

    }
}
