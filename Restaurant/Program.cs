using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Mcdonalds MAC = new Mcdonalds();
            IKanAfhalen mcDonalds = new McdonaldsAdapter(MAC);
            IKanAfhalen meliefste = new Meliefste();
            Restaurant graanbeurs = new Graanbeurs();
            Mens mens = new Mens();

            mcDonalds.Afhalen(mens);
            //graanbeurs.Afhalen(mens);

        }
        void KanGebeldWorden(IKanAfhalen restaurant)
        {

        }
    }
}
