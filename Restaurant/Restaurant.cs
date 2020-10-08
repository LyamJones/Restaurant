using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public abstract class Restaurant
    {
        protected List<Mens> klanten = new List<Mens>();
        protected string naam;
        public void Reserveren(Mens mens)
        {
           if(!IsVol()) this.klanten.Add(mens);
        }
               
        

        public void ZitAanTafel(Mens mens)
        {
            this.klanten.Add(mens);           
        }

        public abstract bool IsVol();
                
        public List<Mens> GetKlanten()
        {
            return this.klanten;
        }

        public bool KanReserveringAnnuleren(Mens mens)
        {
            foreach (Mens klant in klanten)
            {
                if (klant == mens)
                {
                    return true;
                }
            }

            if (mens.GetIsManager())
            {
                return true;
            }

            return false;
        }

        public void ReserveringAnnuleren(Mens mens)
        {
            if (KanReserveringAnnuleren(mens))
            {
                this.klanten.Remove(mens);
            }
        }

        public void ReserveringAnnuleren(Mens mens, Mens manager)
        {
            if (KanReserveringAnnuleren(manager))
            {
                this.klanten.Remove(mens);
            }
        }

        public bool HeeftTafelNummer(Mens mens)
        {
            foreach (Mens klant in klanten)
            {
                if (klant == mens)
                {
                    return true;
                }
            }

            if (mens.GetIsManager())
            {
                return true;
            }

            return false;
        }
    }


}

