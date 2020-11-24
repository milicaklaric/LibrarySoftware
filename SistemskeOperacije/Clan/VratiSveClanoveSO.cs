using System;
using System.ComponentModel;
using System.Linq;
using Domen;
using SistemskeOperacije;

namespace Kontroler
{
    public class VratiSveClanoveSO : OpstaSO
    {
        public BindingList<Clan> ClanoviList { get; internal set; }

        protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat odo)
        {
            Clan o = (Clan)odo;
            ClanoviList = new BindingList<Clan>(broker.VratiSve(o).OfType<Clan>().ToList());
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