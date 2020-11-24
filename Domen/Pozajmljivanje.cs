using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Pozajmljivanje : IDomenskiObjekat
    {
        Clan clan;
        Knjiga knjiga;
        Primerak primerak;
        DateTime datumPozajmljivanja;
        DateTime rokVracanja;
        Zaposleni zaposleni;
        readonly string format = "yyyy-MM-dd HH:mm:ss";

        public Clan Clan { get => clan; set => clan = value; }
        public Knjiga Knjiga { get => knjiga; set => knjiga = value; }
        public Primerak Primerak { get => primerak; set => primerak = value; }
        public DateTime DatumPozajmljivanja { get => datumPozajmljivanja; set => datumPozajmljivanja = value; }
        public DateTime RokVracanja { get => rokVracanja; set => rokVracanja = value; }
       public Zaposleni Zaposleni { get => zaposleni; set => zaposleni = value; }

        [Browsable(false)]
        public string Tabela => "Pozajmljivanje";
        [Browsable(false)]
        public string Join => "JOIN Knjiga ON (Pozajmljivanje.ISBN = Knjiga.ISBN) JOIN Primerak ON (Pozajmljivanje.PrimerakID = Primerak.PrimerakID) JOIN Zaposleni ON (Pozajmljivanje.Zaposleni = Zaposleni.ZaposleniID)";
        [Browsable(false)]
        public string Where => $"BrClanskeKarte = {Clan.BrClanskeKarte} AND ISBN = {Knjiga.Isbn} AND PrimerakID = {Primerak.PrimerakID}";
        [Browsable(false)]
        public string Update => "";
        [Browsable(false)]
        public string Insert => $"({Clan.BrClanskeKarte}, {Knjiga.Isbn}, {Primerak.PrimerakID}, '{DatumPozajmljivanja.ToString(format)}', '{RokVracanja.ToString(format)}', {Zaposleni.ZaposleniID})";

        public override bool Equals(object obj)
        {
            Pozajmljivanje p = (Pozajmljivanje)obj;
            if (p.Clan.BrClanskeKarte == this.Clan.BrClanskeKarte && p.primerak.Isbn == this.primerak.Isbn && p.primerak.PrimerakID == this.primerak.PrimerakID)
                return true;

            return false;
        }

       
        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            BindingList<Pozajmljivanje> poz = new BindingList<Pozajmljivanje>();

            while (reader.Read())
            {
                Pozajmljivanje p = new Pozajmljivanje();
                p.Clan = new Clan()
                {
                    BrClanskeKarte = reader.GetInt32(0)
                };
                p.Knjiga = new Knjiga()
                {
                    Isbn = reader.GetInt64(1),
                    Naziv = reader.GetString(8)
                };
                p.Primerak = new Primerak
                {
                    Isbn = p.Knjiga.Isbn,
                    PrimerakID = reader.GetInt32(2),
                    Dostupan = reader.GetBoolean(16)
                };
                p.Zaposleni = new Zaposleni
                {
                    Ime = reader.GetString(18),
                    Prezime = reader.GetString(19)
                };
                p.DatumPozajmljivanja = reader.GetDateTime(3);
                p.RokVracanja = reader.GetDateTime(4);
                poz.Add(p);
            }

            return poz.ToList<IDomenskiObjekat>();
        }

        public void TesktKomande( SqlCommand command)
        {
            command.CommandText = $"insert into {Tabela} values {Insert}";
        }
    }
}
