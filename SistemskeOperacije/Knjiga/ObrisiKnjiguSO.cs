using Domen;
using SistemskeOperacije;
using System;

namespace Kontroler
{
    public class ObrisiKnjiguSO : OpstaSO
    {
        public bool Uspesno { get; internal set; }

        protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat odo)
        {
            Knjiga o = (Knjiga)odo;
            Uspesno = broker.Obrisi(o);
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