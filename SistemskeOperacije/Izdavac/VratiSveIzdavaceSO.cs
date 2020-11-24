using System;
using System.Collections.Generic;
using System.Linq;
using Domen;
using SistemskeOperacije;

namespace Kontroler
{
    public class VratiSveIzdavaceSO : OpstaSO
    {
        public List<Izdavac> IzdavaciList { get; set; }

        protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat odo)
        {
            Izdavac o = (Izdavac)odo;
            IzdavaciList = broker.VratiSve(o).OfType<Izdavac>().ToList();
        }

        protected override void Validacija(IDomenskiObjekat odo)
        {
            if (!(odo is Izdavac))
            {
                throw new ArgumentException("Prosleđeni objekat nije tipa izdavac!");
            }
        }
    }
}