using System;
using System.Collections.Generic;
using System.Linq;
using Domen;
using SistemskeOperacije;

namespace Kontroler
{
    public class VratiSveAutoreSO : OpstaSO
    {
        public List<Autor> AutoriList { get; set; }

        protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat odo)
        {
            Autor o = (Autor)odo;
            AutoriList = broker.VratiSve(o).OfType<Autor>().ToList();
        }

        protected override void Validacija(IDomenskiObjekat odo)
        {
            if (!(odo is Autor))
            {
                throw new ArgumentException("Prosleđeni objekat nije tipa autor!");
            }
        }
    }
}