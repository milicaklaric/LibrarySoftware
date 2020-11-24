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
    public class Knjiga : IDomenskiObjekat
    {
        long isbn;
        int godinaIzdanja;
        string naziv;
        Zanr zanr;
        int brStrana;
        string povez;
        Izdavac izdavac;
        Autor autor;
        BindingList<Primerak> primerci = new BindingList<Primerak>();

        public long Isbn { get => isbn; set => isbn = value; }
        public int GodinaIzdanja { get => godinaIzdanja; set => godinaIzdanja = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public Zanr Zanr { get => zanr; set => zanr = value; }
        public int BrStrana { get => brStrana; set => brStrana = value; }
        public string Povez { get => povez; set => povez = value; }
        public Izdavac Izdavac { get => izdavac; set => izdavac = value; }
        public BindingList<Primerak> Primerci { get => primerci; set => primerci = value; }
        public Autor Autor { get => autor; set => autor = value; }

        [Browsable(false)]
        public string Tabela => "Knjiga";
        [Browsable(false)]
        public string Join => "JOIN Autor on (Knjiga.Autor = Autor.AutorID) JOIN Izdavac on (Knjiga.Izdavac = Izdavac.IzdavacID)";
        [Browsable(false)]
        public string Where => $"ISBN = {Isbn}";
        [Browsable(false)]
        public string Update => "";
        [Browsable(false)]
        public string Insert => $"({Isbn}, {GodinaIzdanja}, '{Naziv}', {(int)Zanr}, {BrStrana}, '{Povez}', {Izdavac.IzdavacID}, {Autor.AutorID})";

        public void TesktKomande( SqlCommand command)
        {
            command.CommandText = "Insert into Knjiga values (@isbn, @godinaIzdanja, @naziv, @zanr, @brStrana, @povez, @izdavac, @autor)";
            command.Parameters.AddWithValue("@isbn", Isbn);
            command.Parameters.AddWithValue("@godinaIzdanja", GodinaIzdanja);
            command.Parameters.AddWithValue("@naziv", Naziv);
            command.Parameters.AddWithValue("@zanr", (int)Zanr);
            command.Parameters.AddWithValue("@brStrana", BrStrana);
            command.Parameters.AddWithValue("@povez", Povez);
            command.Parameters.AddWithValue("@izdavac", Izdavac.IzdavacID);
            command.Parameters.AddWithValue("@autor", Autor.AutorID);
        }

        public override string ToString()
        {
            return naziv;
        }

        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<Knjiga> knjige = new List<Knjiga>();

            while (reader.Read())
            {
                Knjiga k = new Knjiga();
                k.Isbn = reader.GetInt64(0);
                k.GodinaIzdanja = reader.GetInt32(1);
                k.Naziv = reader.GetString(2);
                k.Zanr = (Zanr)reader.GetInt32(3);
                k.BrStrana = reader.GetInt32(4);
                k.Povez = reader.GetString(5);

                k.Izdavac = new Izdavac();
                k.Izdavac.IzdavacID = reader.GetInt32(6);
                k.Izdavac.NazivIzdavaca = reader.GetString(12);

                k.Autor = new Autor()
                {
                    AutorID = reader.GetInt32(8),
                    Ime = reader.GetString(9),
                    Prezime = reader.GetString(10)
                };

                knjige.Add(k);
            }

            return knjige.ToList<IDomenskiObjekat>();
        }
    }

    public enum Zanr
    {
        Drama,
        Triler,
        Klasika,
        Istorijski,
        Horor,
        Romansa, 
        Naučna_fantastika,
        Fantazija
    }
}
