using Domen;
using SistemskeOperacije;
using System;

namespace Kontroler
{
    public class SacuvajKnjiguSO : OpstaSO
    {
        public Knjiga Sacuvana { get; internal set; }

        protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat odo)
        {
            Knjiga o = (Knjiga)odo;
            bool uspesno = broker.Sacuvaj(o);

            if (uspesno)
                Sacuvana = o;
            else
                Sacuvana = null;
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