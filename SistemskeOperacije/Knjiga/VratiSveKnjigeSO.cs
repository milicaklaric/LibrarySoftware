using System;
using System.Collections.Generic;
using System.Linq;
using Domen;
using SistemskeOperacije;

namespace Kontroler
{
    public class VratiSveKnjigeSO : OpstaSO
    {
        public List<Knjiga> KnjigeList { get; internal set; }

        protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat odo)
        {
            Knjiga o = (Knjiga)odo;
            KnjigeList = broker.VratiSve(o).OfType<Knjiga>().ToList();
        }

        protected override void Validacija(IDomenskiObjekat odo)
        {
            if (!(odo is Knjiga))
            {
                throw new ArgumentException("Prosleđeni objekat nije tipa knjiga!");
            }
        }
    }
}