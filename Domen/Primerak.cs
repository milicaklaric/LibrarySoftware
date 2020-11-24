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
    public class Primerak : IDomenskiObjekat
    {

        long isbn;
        int primerakID;
        bool dostupan = true;

        public int PrimerakID { get => primerakID; set => primerakID = value; }
        public bool Dostupan { get => dostupan; set => dostupan = value; }
        public long Isbn { get => isbn; set => isbn = value; }

        [Browsable(false)]
        public string Tabela => "Primerak";
        [Browsable(false)]
        public string Join => "";
        [Browsable(false)]
        public string Where => "";
        [Browsable(false)]
        public string Update => "";
        [Browsable(false)]
        public string Insert => "(" + Isbn + ", " + PrimerakID + ", '" + Dostupan + "')";

        public void TesktKomande( SqlCommand command)
        {
            command.CommandText = $"insert into {Tabela} values {Insert}";
        }

        public override string ToString()
        {
            return "Primerak: " + primerakID;
        }

        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            BindingList<Primerak> primerci = new BindingList<Primerak>();

            while (reader.Read())
            {
                Primerak p = new Primerak();
                p.Isbn = reader.GetInt64(0);
                p.PrimerakID = reader.GetInt32(1);
                p.Dostupan = reader.GetBoolean(2);

                if (p.Dostupan)
                    primerci.Add(p);
            }

            return primerci.ToList<IDomenskiObjekat>();
        }
    }
}
