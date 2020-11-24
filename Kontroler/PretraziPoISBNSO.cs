using System.ComponentModel;
using Domen;
using SistemskeOperacije;

namespace Kontroler
{
    public class PretraziPoISBNSO : OpstaSO
    {
        public BindingList<Knjiga> KnjigeList { get; internal set; }

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