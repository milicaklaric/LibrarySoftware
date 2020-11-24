using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Diagnostics;

namespace Forme
{
    public class Komunikacija
    {
        
        private Socket klijentskiSocket;
        private NetworkStream stream;
        private BinaryFormatter formatter = new BinaryFormatter();

        //singleton
        private static Komunikacija instance;
        private Komunikacija()
        {
            
        }
        public static Komunikacija Instance
        {
            get
            {
                if (instance == null) instance = new Komunikacija();
                return instance;
            }
        }

        public bool PoveziSe()
        {
            try
            {
                if (klijentskiSocket == null || !klijentskiSocket.Connected)
                {
                    klijentskiSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    klijentskiSocket.Connect("localhost", 9090);
                    stream = new NetworkStream(klijentskiSocket);
                }
                return true;
            }
            catch (SocketException)
            {
                return false;
            }
        }

        internal void PosaljiZahtev(Zahtev z)
        {
            formatter.Serialize(stream, z);
        }

        internal Odgovor ProcitajOdgovor()
        {
            try
            {
                return (Odgovor)formatter.Deserialize(stream);
            }
            catch (Exception e)
            {
                Debug.WriteLine(">>>" + e.Message);
                return null;
            }
        }
        
    }
}
