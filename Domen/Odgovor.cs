using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Odgovor
    {
        public Signal Signal { get; set; } = Signal.Ok;
        public string Poruka { get; set; }
        public object Objekat { get; set; }
    }

    public enum Signal
    {
        Ok,
        Error
    }
}
