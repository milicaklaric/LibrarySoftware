using Domen;
using SistemskeOperacije;
using System;

namespace Kontroler
{
    public class SacuvajClanaSO : OpstaSO
    {
        public Clan Sacuvani { get; internal set; }

        protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat odo)
        {
            Clan o = (Clan)odo;
            o.BrClanskeKarte = broker.VratiBrClanskeKarte();
            bool uspesno = broker.Sacuvaj(o);

            if (uspesno)
                Sacuvani = o;
            else
                Sacuvani = null;
        }

        protected override void Validacija(IDomenskiObjekat odo)
        {
            if (!(odo is Clan))
            {
                throw new ArgumentException("Prosleđeni objekat nije tipa clan!");
            }
        }
    }
}