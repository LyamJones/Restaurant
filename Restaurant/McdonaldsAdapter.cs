using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class McdonaldsAdapter : IKanAfhalen
    {
        private Mcdonalds mcdonalds;
        public McdonaldsAdapter(Mcdonalds mcdonalds)
        {
            this.mcdonalds = mcdonalds;
        }

        public void Afhalen(Mens mens)
        {
            this.mcdonalds.McdriveBestellen(mens);
        }
    }
}
