using System;
using System.Collections.Generic;
using Domen;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.ComponentModel;

namespace Server
{
    class Server
    {
        private Socket osluskujuciSoket;
        bool kraj;

        public List<Zaposleni> Prijavljeni { get; internal set; } = new List<Zaposleni>();

        public event PrijavljenNovEventHandler PrijavljenNov;

        public delegate void PrijavljenNovEventHandler();
        
        private BindingList<Obrada> PovezaniKlijenti = new BindingList<Obrada>();

        public bool PokreniServer()
        {
            try
            {
                osluskujuciSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ep = new IPEndPoint(IPAddress.Any, 9090);
                osluskujuciSoket.Bind(ep);

                osluskujuciSoket.Listen(5);
                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Osluskuj()
        {
            kraj = false;
            while (!kraj)
            {
                try
                {
                    Socket klijentskiSoket = osluskujuciSoket.Accept();
                    Obrada klijent = new Obrada(klijentskiSoket, this);
                    PovezaniKlijenti.Add(klijent);
                    Thread nitKlijenta = new Thread(klijent.ObradaZahteva);
                    nitKlijenta.Start();
                }
                catch (Exception)
                {
                    
                }
            }
        }

        internal void OnPrijavljen()
        {
            PrijavljenNov?.Invoke();
        }

        public bool ZaustaviServer()
        {
            try
            {
                kraj = true;
                osluskujuciSoket?.Close();
                foreach (Obrada klijentObrada in PovezaniKlijenti)
                {
                    klijentObrada.klijentskiSoket.Shutdown(SocketShutdown.Both);
                    klijentObrada.klijentskiSoket.Close();
                }
                Prijavljeni = new List<Zaposleni>();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        
    }
}
