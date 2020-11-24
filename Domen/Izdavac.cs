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
    public class Izdavac : IDomenskiObjekat
    {
        int izdavacID;
        string nazivIzdavaca;

        public int IzdavacID { get => izdavacID; set => izdavacID = value; }
        public string NazivIzdavaca { get => nazivIzdavaca; set => nazivIzdavaca = value; }

        [Browsable(false)]
        public string Tabela => "Izdavac";
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
            return nazivIzdavaca;
        }

        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<Izdavac> izdavaci = new List<Izdavac>();

            while (reader.Read())
            {
                Izdavac i = new Izdavac();
                i.IzdavacID = reader.GetInt32(0);
                i.NazivIzdavaca = reader.GetString(1);

                izdavaci.Add(i);
            }

            return izdavaci.ToList<IDomenskiObjekat>();
        }
    }
}
