using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public interface IDomenskiObjekat
    {
        [Browsable(false)]
        string Tabela { get; }
        [Browsable(false)]
        string Join { get; }
        [Browsable(false)]
        string Where { get; }
        [Browsable(false)]
        string Update { get; }
        [Browsable(false)]
        string Insert { get; }
       
        List<IDomenskiObjekat> VratiListu(SqlDataReader reader);
        void TesktKomande( SqlCommand command);
        

    }
}
