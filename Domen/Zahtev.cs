using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Zahtev
    { 
        public Operacija Operacija { get; set; }
        public object Objekat { get; set; }
        public string Kriterijum { get; set; }

        public BindingList<Pozajmljivanje> lista;
    }

    public enum Operacija
    {
        Login,
        VratiSveZaposlene,
        VratiSveIzdavace,
        VratiSveAutore,
        VratiSvaMesta,
        VratiSvePrimerke,
        VratiSveKnjige,
        VratiClanove,
        VratiPozajmljivanja,
        PretraziClanove,
        PretraziKnjige,
        IzmeniClana,
        SacuvajClana,
        ObrisiClana,
        VratioSveKnjige,
        SacuvajKnjigu,
        ObrisiKnjigu,
        SacuvajPozajmljivanja,
        VracanjeKnjige
    }
}
