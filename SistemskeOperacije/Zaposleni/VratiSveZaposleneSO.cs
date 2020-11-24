using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije.ZaposleniSO
{
    public class VratiSveZaposleneSO : OpstaSO
    {
        public List<Zaposleni> ZaposleniList { get; set; }

        protected override void IzvrsiKonkretnuOperaciju(IDomenskiObjekat odo)
        {
            Zaposleni o = (Zaposleni)odo;
            ZaposleniList = broker.VratiSve(o).OfType<Zaposleni>().ToList();
        }

        protected override void Validacija(IDomenskiObjekat odo)
        {
            if (!(odo is Zaposleni))
            {
                throw new ArgumentException("Prosleđeni objekat nije tipa zaposleni!");
            }
        }
    }
}
