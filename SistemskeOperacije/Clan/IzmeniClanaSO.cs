using Domen;
using SistemskeOperacije;
using System;

namespace Kontroler
{
    public class IzmeniClanaSO : OpstaSO
    {
        public bool Uspesno { get; internal set; }

        protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat odo)
        {
            Clan o = (Clan)odo;
            Uspesno = broker.Izmeni(o);
        }

        protected override void Validacija(IDomenskiObjekat odo)
        {
            if (!(odo is Clan))
            {
                throw new ArgumentException("Prosleđeni objekat nije tipa knjiga!");
            }
        }
    }
}