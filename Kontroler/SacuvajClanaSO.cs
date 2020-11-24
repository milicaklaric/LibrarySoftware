using Domen;
using SistemskeOperacije;

namespace Kontroler
{
    public class SacuvajClanaSO : OpstaSO
    {
        public Clan Sacuvani { get; internal set; }

        protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat odo)
        {
            throw new System.NotImplementedException();
        }

        protected override void Validacija(IDomenskiObjekat odo)
        {
            throw new System.NotImplementedException();
        }
    }
}