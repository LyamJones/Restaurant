using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Mcdonalds
    {
        private string naam;
        private List<Mens> bestellingen;
        public Mcdonalds()
        {
            this.naam = "Mcdonalds";
        }
        public void McdriveBestellen(Mens mens)
        {
            bestellingen.Add(mens);
        }


    }
}
