﻿using System.ComponentModel;
using Domen;
using SistemskeOperacije;

namespace Kontroler
{
    public class PretraziPoBrClKarteSO : OpstaSO
    {
        public BindingList<Clan> ClanoviList { get; internal set; }

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