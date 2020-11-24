using System;
using System.ComponentModel;
using System.Linq;
using Domen;
using SistemskeOperacije;

namespace Kontroler
{
    public class VratiSvePrimerkeSO : OpstaSO
    {
        public BindingList<Primerak> PrimerciList { get; internal set; }

        protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat odo)
        {
            Primerak o = (Primerak)odo;
            BindingList<Primerak> svi = new BindingList<Primerak>(broker.VratiSve(o).OfType<Primerak>().ToList());
            PrimerciList = new BindingList<Primerak>();

            foreach(Primerak p in svi)
            {
                if (p.Isbn == o.Isbn && p.Dostupan) PrimerciList.Add(p);
            }
        }

        protected override void Validacija(IDomenskiObjekat odo)
        {
            if (!(odo is Primerak))
            {
                throw new ArgumentException("Prosleđeni objekat nije tipa primerak!");
            }
        }
    }
}