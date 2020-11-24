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
    public class Mesto : IDomenskiObjekat
    {
        int mestoID;
        string naziv;
        string opstina;

        public int MestoID { get => mestoID; set => mestoID = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Opstina { get => opstina; set => opstina = value; }

        [Browsable(false)]
        public string Tabela => "Mesto";
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
            return naziv;

        }

        public List<IDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<Mesto> mesta = new List<Mesto>();

            while (reader.Read())
            {
                Mesto m = new Mesto();
                m.MestoID = reader.GetInt32(0);
                m.Naziv = reader.GetString(1);
                m.Opstina = reader.GetString(2);

                mesta.Add(m);
            }

            return mesta.ToList<IDomenskiObjekat>();
        }
    }
}
