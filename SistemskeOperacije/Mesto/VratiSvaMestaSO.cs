using System;
using System.Collections.Generic;
using System.Linq;
using Domen;
using SistemskeOperacije;

namespace Kontroler
{
    public class VratiSvaMestaSO : OpstaSO
    {
        public List<Mesto> MestaList { get; set; }

        protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat odo)
        {
            Mesto o = (Mesto)odo;
            MestaList = broker.VratiSve(o).OfType<Mesto>().ToList();
        }

        protected override void Validacija(IDomenskiObjekat odo)
        {
            if (!(odo is Mesto))
            {
                throw new ArgumentException("Prosleđeni objekat nije tipa mesto!");
            }
        }
    }
}