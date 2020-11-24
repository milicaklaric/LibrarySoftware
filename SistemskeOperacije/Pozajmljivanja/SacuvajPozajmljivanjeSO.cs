using System;
using System.ComponentModel;
using Domen;
using SistemskeOperacije;

namespace Kontroler
{
    public class SacuvajPozajmljivanjeSO : OpstaSO
    {
        public bool Uspesno { get; internal set; }

        protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat odo)
        {
            Pozajmljivanje o = (Pozajmljivanje)odo;
            Uspesno = broker.Sacuvaj(o);

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