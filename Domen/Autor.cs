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
    public class Autor : IDomenskiObjekat
    {
        int autorID;
        string ime;
        string prezime;

        public int AutorID { get => autorID; set => autorID = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }

        [Browsable(false)]
        public string Tabela => "Autor";
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
            List<Autor> autori = new List<Autor>();

            while (reader.Read())
            {
                Autor a = new Autor();
                a.AutorID = reader.GetInt32(0);
                a.Ime = reader.GetString(1);
                a.Prezime = reader.GetString(2);

                autori.Add(a);
            }

            return autori.ToList<IDomenskiObjekat>();

        }
    }
}
