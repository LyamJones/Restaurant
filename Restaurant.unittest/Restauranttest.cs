using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Restaurant.unittest
{
    [TestClass]
    public class Restauranttest
    {
        Mens mens;

        [TestInitialize]
        public void Setup()
        {
            mens = new Mens();
        }
        

        [TestMethod]
        public void KanReserveringAnnuleren_IsManager_ReturnsTrue()
        {
            //Mens mens = new Mens();
            Mens manager = new Mens();
            Restaurant graanbeurs = new Graanbeurs();

            manager.SetIsManager(true);
            graanbeurs.Reserveren(mens);
            var result = graanbeurs.KanReserveringAnnuleren(manager);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void KanReserveringAnnuleren_IsKlant_ReturnsTrue()
        {
            //Mens mens = new Mens();
            Restaurant graanbeurs = new Graanbeurs();

            graanbeurs.Reserveren(mens);

            var result = graanbeurs.KanReserveringAnnuleren(mens);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void KanReserveringAnnuleren_IsRandom_ReturnsFalse()
        {
            //Mens mens = new Mens();
            Mens random = new Mens();
            Restaurant graanbeurs = new Graanbeurs();

            graanbeurs.Reserveren(mens);

            var result = graanbeurs.KanReserveringAnnuleren(random);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void HeeftTafelNummer_IsKlant_ReturnsTrue()
        {
            //Mens mens = new Mens();
            Restaurant meliefste = new Meliefste();

            meliefste.ZitAanTafel(mens);

            var result = meliefste.HeeftTafelNummer(mens);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HeeftTafelNummer_IsRandom_ReturnsFalse()
        {
            //Mens mens = new Mens();
            Mens random = new Mens();
            Restaurant meliefste = new Meliefste();

            var result = meliefste.HeeftTafelNummer(random);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Reserveren_IsVol_ReturnsFalse()
        {
            Restaurant Meliefste = new Meliefste();
            //Mens mens = new Mens();

            var result = false;

            for (int i = 0; i < 80; i++)
            {
                Mens random = new Mens();
                Meliefste.Reserveren(random);
            }

            Meliefste.Reserveren(mens);

            foreach (Mens klant in Meliefste.GetKlanten())
            {
                if (klant == mens)
                {
                    result = true;
                }
            }

            Assert.IsFalse(result);
        }

    }
}
