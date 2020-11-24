using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Diagnostics;
using Kontroler;
using System.ComponentModel;

namespace Server
{
    class Obrada
    {
        public Socket klijentskiSoket { get; } 
        private readonly Server s;
        private NetworkStream stream;
        private BinaryFormatter formatter = new BinaryFormatter();

        public Obrada(Socket klijentskiSoket, Server server)
        {
            this.klijentskiSoket = klijentskiSoket;
            this.s = server;
            stream = new NetworkStream(klijentskiSoket);
        }

        public void ObradaZahteva()
        {
            bool kraj = false;
            while (!kraj)
            {
                try
                {
                    Zahtev zahtev = (Zahtev)formatter.Deserialize(stream);
                    Odgovor o = IzvrsiZahtev(zahtev);
                    formatter.Serialize(stream, o);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($">>> {ex.Message}");
                    kraj = true;
                }
            }

        }

        public Odgovor IzvrsiZahtev(Zahtev zahtev)
        {
            Odgovor odgovor = new Odgovor();
            try
            {
                switch (zahtev.Operacija)
                {
                    case Operacija.Login:
                        Zaposleni k = (Zaposleni)zahtev.Objekat;
                        odgovor.Poruka = "Uspešno prijavljivanje!";
                        odgovor.Objekat = k;
                        s.Prijavljeni.Add(k);
                        s.OnPrijavljen();
                        break;
                    case Operacija.VratiSveZaposlene:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.VratiSveZaposlene();
                        odgovor.Poruka = "Sistem je uspešno pronašao zaposlene!";
                        break;
                    case Operacija.VratiSveIzdavace:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.VratiSveIzdavace();
                        odgovor.Poruka = "Sistem je uspešno pronašao izdavače!";
                        break;
                    case Operacija.VratiSveAutore:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.VratiSveAutore();
                        odgovor.Poruka = "Sistem je uspešno pronašao autore!";
                        break;
                    case Operacija.VratiSvaMesta:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.VratiSvaMesta();
                        odgovor.Poruka = "Sistem je uspešno pronašao mesta!";
                        break;
                    case Operacija.VratiSvePrimerke:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.VratiPrimerke((Knjiga)zahtev.Objekat);
                        odgovor.Poruka = "Sistem je uspešno pronašao primerke!";
                        break;
                    case Operacija.VratiSveKnjige:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.VratiSveKnjige();
                        odgovor.Poruka = "Sistem je uspešno pronašao knjige!";
                        break;
                    case Operacija.VratiClanove:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.VratiClanove();
                        odgovor.Poruka = "Sistem je uspešno pronašao članove!";
                        break;
                    case Operacija.VratiPozajmljivanja:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.VratiPozajmljivanja((Clan)zahtev.Objekat);
                        odgovor.Poruka = "Sistem je uspešno pronašao pozajmljivanja!";
                        break;
                    case Operacija.PretraziClanove:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.PretraziClanove((Clan)zahtev.Objekat, zahtev.Kriterijum);
                        odgovor.Poruka = "Sistem je uspešno pronašao članove!";
                        break;
                    case Operacija.PretraziKnjige:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.PretraziKnjige((Knjiga)zahtev.Objekat, zahtev.Kriterijum);
                        odgovor.Poruka = "Sistem je uspešno pronašao knjige!";
                        break;
                    case Operacija.IzmeniClana:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.IzmeniClana((Clan)zahtev.Objekat);
                        odgovor.Poruka = "Sistem je uspešno izmenio člana!";
                        break;
                    case Operacija.SacuvajClana:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.SacuvajClana((Clan)zahtev.Objekat);
                        odgovor.Poruka = "Sistem je uspešno sačuvao člana!";
                        break;
                    case Operacija.ObrisiClana:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.ObrisiClana((Clan)zahtev.Objekat);
                        odgovor.Poruka = "Sistem je uspešno obrisao člana!";
                        break;
                    case Operacija.VratioSveKnjige:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.VratioSveKnjige((Clan)zahtev.Objekat);
                        odgovor.Poruka = "Član je vratio sve pozajmljene knjige!";
                        break;
                    case Operacija.SacuvajKnjigu:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.SacuvajKnjigu((Knjiga)zahtev.Objekat);
                        odgovor.Poruka = "Sistem je uspešno sačuvao knjigu!";
                        break;
                    case Operacija.ObrisiKnjigu:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.ObrisiKnjigu((Knjiga)zahtev.Objekat);
                        odgovor.Poruka = "Sistem je uspešno obrisao knjigu!";
                        break;
                    case Operacija.SacuvajPozajmljivanja:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.SacuvajPozajmljivanja(zahtev.lista);
                        odgovor.Poruka = "Sistem je uspešno sačuvao pozajmljivanje knjige!";
                        break;
                    case Operacija.VracanjeKnjige:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.VracanjeKnjige((Pozajmljivanje)zahtev.Objekat);
                        odgovor.Poruka = "Sistem je uspešno obrisao pozajmljivanje knjige!";
                        break;


                }
            }
            catch (Exception e)
            {
                odgovor.Signal = Signal.Error;
                odgovor.Poruka = e.Message;
            }
            return odgovor;
        }

        /*Zatvaranje soketa
        internal void Zaustavi()
        {
            klijentskiSoket.Close();
        }*/
    }
}
