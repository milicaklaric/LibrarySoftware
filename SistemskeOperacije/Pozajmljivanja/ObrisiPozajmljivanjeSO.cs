using Domen;
using SistemskeOperacije;
using System;

namespace Kontroler
{
    public class ObrisiPozajmljivanjeSO : OpstaSO
    {
        public bool Uspesno { get; internal set; }

        protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat odo)
        {
            Pozajmljivanje o = (Pozajmljivanje)odo;
            Uspesno = broker.Obrisi(o);
        }

        protected override void Validacija(IDomenskiObjekat odo)
        {
            if (!(odo is Pozajmljivanje))
            {
                throw new ArgumentException("Prosleđeni objekat nije tipa pozajmljivanje!");
            }
        }
    }
}