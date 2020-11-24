using System.Collections.Generic;
using Domen;
using SistemskeOperacije;

namespace Kontroler
{
    public class VratiSveKnjigeSO : OpstaSO
    {
        public List<Knjiga> KnjigeList { get; internal set; }

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