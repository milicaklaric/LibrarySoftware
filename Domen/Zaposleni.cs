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


    public class Zaposleni : IDomenskiObjekat
    {
        int zaposleniID;
        string ime;
        string prezime;
        string korisnickoIme;
        string sifra;
        
        public int ZaposleniID { get => zaposleniID; set => zaposleniID = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Sifra { get => sifra; set => sifra = value; }

        [Browsable(false)]
        public string Tabela => "Zaposleni";
        [Browsable(false)]
        public string Join => "";
        [Browsable(false)]
        public string Where => "";
        [Browsable(false)]
        public string Update => "";
        [Browsable(false)]
        public string Insert => "";

        public void TesktKomande( SqlCommand command)
        {
            
        }

        public override string ToString()
        {
            return ime + " " + prezime;
        }

        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<Zaposleni> zaposleni = new List<Zaposleni>();

            while (reader.Read())
            {
                Zaposleni z = new Zaposleni();
                z.ZaposleniID = reader.GetInt32(0);
                z.Ime = reader.GetString(1);
                z.Prezime = reader.GetString(2);
                z.KorisnickoIme = reader.GetString(3);
                z.Sifra = reader.GetString(4);

                zaposleni.Add(z);
            }

            return zaposleni.ToList<IDomenskiObjekat>();
        }
    }
}
