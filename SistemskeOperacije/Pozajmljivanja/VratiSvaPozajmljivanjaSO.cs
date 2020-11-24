using System;
using System.ComponentModel;
using System.Linq;
using Domen;
using SistemskeOperacije;

namespace Kontroler
{
    public class VratiSvaPozajmljivanjaSO : OpstaSO
    {
        public BindingList<Pozajmljivanje> PozajmljivanjaList { get; internal set; }

        protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat odo)
        {
            Pozajmljivanje o = (Pozajmljivanje)odo;
            BindingList<Pozajmljivanje> sva = new BindingList<Pozajmljivanje>(broker.VratiSve(o).OfType<Pozajmljivanje>().ToList());
            PozajmljivanjaList = new BindingList<Pozajmljivanje>();

            foreach (Pozajmljivanje pozajmljivanje in sva)
            {
                if (pozajmljivanje.Clan.BrClanskeKarte == o.Clan.BrClanskeKarte && !PozajmljivanjaList.Contains(pozajmljivanje))
                {
                    PozajmljivanjaList.Add(pozajmljivanje);
                }
            }
        }

        protected override void Validacija(IDomenskiObjekat odo)
        {
            if (!(odo is Pozajmljivanje))
            {
                throw new ArgumentException("Prosleđeni objekat nije tipa pozajmljivanje!");
            }
        }
    }
}