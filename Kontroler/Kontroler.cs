using BrokerBP;
using Domen;
using SistemskeOperacije;
using SistemskeOperacije.ZaposleniSO;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Kontroler
{
    public class Kontroler
    {
        //singleton
        private Broker broker = new Broker();
        private static Kontroler _instance;
        public static Kontroler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Kontroler();
                }
                return _instance;
            }
        }

        private Kontroler()
        {
        }
        
        //Vrati metode - punjenje cmb
        public List<Zaposleni> VratiSveZaposlene()
        {
            OpstaSO so = new VratiSveZaposleneSO();
            Zaposleni o = new Zaposleni();
            so.IzvrsiSO(o);

            return ((VratiSveZaposleneSO)so).ZaposleniList;
        }

        public List<Izdavac> VratiSveIzdavace()
        {
            OpstaSO so = new VratiSveIzdavaceSO();
            Izdavac o = new Izdavac();
            so.IzvrsiSO(o);

            return ((VratiSveIzdavaceSO)so).IzdavaciList;
        }

        public List<Autor> VratiSveAutore()
        {
            OpstaSO so = new VratiSveAutoreSO();
            Autor o = new Autor();
            so.IzvrsiSO(o);

            return ((VratiSveAutoreSO)so).AutoriList;
        }

        public List<Mesto> VratiSvaMesta()
        {
            OpstaSO so = new VratiSvaMestaSO();
            Mesto o = new Mesto();
            so.IzvrsiSO(o);

            return ((VratiSvaMestaSO)so).MestaList;
        }

        public BindingList<Primerak> VratiPrimerke(Knjiga k)
        {
            OpstaSO so = new VratiSvePrimerkeSO();
            Primerak o = new Primerak();
            o.Isbn = k.Isbn;
            so.IzvrsiSO(o);

            return ((VratiSvePrimerkeSO)so).PrimerciList;
        }

        public List<Knjiga> VratiSveKnjige()
        {
            OpstaSO so = new VratiSveKnjigeSO();
            Knjiga o = new Knjiga();
            so.IzvrsiSO(o);

            return ((VratiSveKnjigeSO)so).KnjigeList;
        }

        public BindingList<Clan> VratiClanove()
        {
            OpstaSO so = new VratiSveClanoveSO();
            Clan o = new Clan();
            so.IzvrsiSO(o);

            return ((VratiSveClanoveSO)so).ClanoviList;
        }

        public BindingList<Pozajmljivanje> VratiPozajmljivanja(Clan c)
        {
            OpstaSO so = new VratiSvaPozajmljivanjaSO();
            Pozajmljivanje o = new Pozajmljivanje();
            o.Clan = c;
            so.IzvrsiSO(o);

            return ((VratiSvaPozajmljivanjaSO)so).PozajmljivanjaList;

        }
        
        //Pretrage za clana sve odjednom
        public BindingList<Clan> PretraziClanove(Clan c, string kriterijum)
        {
            OpstaSO so = new VratiSveClanoveSO();
            so.IzvrsiSO(c);

            BindingList<Clan> svi = ((VratiSveClanoveSO)so).ClanoviList;
            BindingList<Clan> trazeni = new BindingList<Clan>();

            foreach (Clan clan in svi)
            {
                switch (kriterijum)
                {
                    case "brClKarte": if (clan.BrClanskeKarte == c.BrClanskeKarte) trazeni.Add(clan);
                        break;
                    case "ime": if (clan.Ime.Contains(c.Ime.ToLower()) || clan.Ime.Contains(c.Ime.ToUpper())) trazeni.Add(clan);
                        break;
                    case "prezime": if (clan.Prezime.Contains(c.Prezime.ToLower()) || clan.Prezime.Contains(c.Prezime.ToUpper())) trazeni.Add(clan);
                        break;
                    default:
                        break;
                }
            }

            return trazeni;

        }

        //Pretrage za knjige sve odjednom
        public BindingList<Knjiga> PretraziKnjige(Knjiga k, string kriterijum)
        {
            OpstaSO so = new VratiSveKnjigeSO();
            so.IzvrsiSO(k);

            BindingList<Knjiga> svi = new BindingList<Knjiga>(((VratiSveKnjigeSO)so).KnjigeList);
            BindingList<Knjiga> trazene = new BindingList<Knjiga>();

            foreach (Knjiga knjiga in svi)
            {
                switch (kriterijum)
                {
                    case "isbn":
                        if (knjiga.Isbn == k.Isbn) trazene.Add(knjiga);
                        break;
                    case "autor":
                        if (knjiga.Autor.Ime.Contains(k.Autor.Ime.ToLower()) || knjiga.Autor.Prezime.Contains(k.Autor.Ime.ToLower()) ||
                            knjiga.Autor.Ime.Contains(k.Autor.Ime.ToUpper()) || knjiga.Autor.Prezime.Contains(k.Autor.Ime.ToUpper())) trazene.Add(knjiga);
                        break;
                    case "naziv":
                        if (knjiga.Naziv.Contains(k.Naziv.ToUpper()) || knjiga.Naziv.Contains(k.Naziv.ToLower())) trazene.Add(knjiga);
                        break;
                    default:
                        break;
                }
            }

            return trazene;

        }

        //Rad sa clanovima biblioteke
        public bool IzmeniClana(Clan clan)
        {
            OpstaSO so = new IzmeniClanaSO();
            so.IzvrsiSO(clan);

            return ((IzmeniClanaSO)so).Uspesno;
        }

        public Clan SacuvajClana(Clan clan)
        {
            OpstaSO so = new SacuvajClanaSO();
            so.IzvrsiSO(clan);

            return ((SacuvajClanaSO)so).Sacuvani;            
        }

        public bool ObrisiClana(Clan c)
        {
            OpstaSO so = new ObrisiClanaSO();
            so.IzvrsiSO(c);

            return ((ObrisiClanaSO)so).Uspesno;
        }

        public BindingList<Knjiga> VratioSveKnjige(Clan c)
        {
            BindingList<Knjiga> knjige = new BindingList<Knjiga>();
            
            try
            {

                BindingList<Pozajmljivanje> pozajmljivanja = VratiPozajmljivanja(c);
                foreach (Pozajmljivanje p in pozajmljivanja)
                {
                    if (p.Clan.BrClanskeKarte == c.BrClanskeKarte && !knjige.Contains(p.Knjiga))
                        knjige.Add(p.Knjiga);
                }

                

                return knjige;
            }
            catch (Exception e)
            {
                throw new Exception("Nije moguce vratiti sve knjige!" + e.Message + "\n");
            }
            
        }
          
        //Rad sa knjigama
        public Knjiga SacuvajKnjigu(Knjiga knjiga)
        {
            OpstaSO so = new SacuvajKnjiguSO();
            so.IzvrsiSO(knjiga);

            return ((SacuvajKnjiguSO)so).Sacuvana;
        }

        public bool ObrisiKnjigu(Knjiga k)
        {
            OpstaSO so = new ObrisiKnjiguSO();
            so.IzvrsiSO(k);

            return ((ObrisiKnjiguSO)so).Uspesno;
        }
        
        //Rad sa pozajmljivanjem knjiga
        public BindingList<Pozajmljivanje> SacuvajPozajmljivanja(BindingList<Pozajmljivanje> pozajmljivanja)
        {
            OpstaSO so = new SacuvajPozajmljivanjeSO();
            bool uspesno = true;

            foreach (Pozajmljivanje p in pozajmljivanja)
            {
                so.IzvrsiSO(p);
                if (!((SacuvajPozajmljivanjeSO)so).Uspesno)
                    uspesno = false;
            }

            if (uspesno)
                return pozajmljivanja;
            else
                return null;
        }

        public bool VracanjeKnjige(Pozajmljivanje p)
        {
            OpstaSO so = new ObrisiPozajmljivanjeSO();
            so.IzvrsiSO(p);

            return ((ObrisiPozajmljivanjeSO)so).Uspesno;
        }
    }
}
