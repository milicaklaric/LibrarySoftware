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
    public class Clan : IDomenskiObjekat
    {
        int brClanskeKarte;
        string ime;
        string prezime;
        Mesto mesto;
        string brTelefona;
        Kategorija kategorija;
        DateTime vaziDo;
        readonly string format = "yyyy-MM-dd HH:mm:ss";

        public int BrClanskeKarte { get => brClanskeKarte; set => brClanskeKarte = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public Mesto Mesto { get => mesto; set => mesto = value; }
        public string BrTelefona { get => brTelefona; set => brTelefona = value; }
        public Kategorija Kategorija { get => kategorija; set => kategorija = value; }
        public DateTime VaziDo { get => vaziDo; set => vaziDo = value; }
        

        [Browsable(false)]
        public string Tabela => "Clan";
        [Browsable(false)]
        public string Join => "JOIN Mesto on (Clan.Mesto = Mesto.MestoID)";
        [Browsable(false)]
        public string Where => $"BrClanskeKarte = {BrClanskeKarte}";
        [Browsable(false)]
        public string Update => $"VaziDo = '{vaziDo.ToString(format)}'";
        [Browsable(false)]
        public string Insert => $"({BrClanskeKarte}, '{Ime}', '{Prezime}', {Mesto.MestoID}, '{brTelefona}', {(int)Kategorija}, '{VaziDo.ToString(format)}')";

        public override string ToString()
        {
            return ime + " " + prezime;
        }

        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            BindingList<Clan> clanovi = new BindingList<Clan>();

            while (reader.Read())
            {
                Clan c = new Clan();
                c.BrClanskeKarte = reader.GetInt32(0);
                c.Ime = reader.GetString(1);
                c.Prezime = reader.GetString(2);

                c.Mesto = new Mesto()
                {
                    MestoID = reader.GetInt32(3),
                    Naziv = reader.GetString(8),
                    Opstina = reader.GetString(9)
                };

                c.BrTelefona = reader.GetString(4);
                c.Kategorija = (Kategorija)reader.GetInt32(5);
                c.VaziDo = reader.GetDateTime(6);

                clanovi.Add(c);
            }
            return clanovi.ToList<IDomenskiObjekat>();
        }

        public void TesktKomande( SqlCommand command)
        {
            command.CommandText = $"insert into Clan values (@BrClKarte, @Ime, @Prezime, @Mesto, @BrTel, @Kategorija, @VaziDo)";
            command.Parameters.AddWithValue("@BrClKarte", BrClanskeKarte);
            command.Parameters.AddWithValue("@Ime", Ime);
            command.Parameters.AddWithValue("@Prezime", Prezime);
            command.Parameters.AddWithValue("@Mesto", Mesto.MestoID);
            command.Parameters.AddWithValue("@BrTel", BrTelefona);
            command.Parameters.AddWithValue("@Kategorija", (int)Kategorija);
            command.Parameters.AddWithValue("@VaziDo", VaziDo);
        }
    }

    public enum Kategorija
    {
        Dete,
        Student,
        Zaposlen,
        Penzioner
    }
    
    
}
