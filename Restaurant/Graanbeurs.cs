using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Graanbeurs : Restaurant
    {
        public Graanbeurs()
        {
            this.naam = "Graanbeurs";
        }
        public override bool IsVol()
        {
            if (this.klanten.Count >= 60)
            {
                return true;

            }

            else return false;

        }

    }
}
