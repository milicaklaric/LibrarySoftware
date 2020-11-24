using System.ComponentModel;
using Domen;
using SistemskeOperacije;

namespace Kontroler
{
    public class VratiSvePrimerkeSO : OpstaSO
    {
        public BindingList<Primerak> PrimerciList { get; internal set; }

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