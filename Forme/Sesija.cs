using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forme
{
    public class Sesija
    {
        private static Sesija instance;

        public static Sesija Instance
        {
            get
            {
                if (instance == null) instance = new Sesija();
                return instance;
            }
        }

        private Sesija()
        {

        }

        public Zaposleni Zaposleni { get; set; }
    }
}
