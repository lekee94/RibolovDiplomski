using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using Biblioteka;
using System.Threading;

namespace Server
{
    public class Server
    {
        public static readonly List<Delegat> listaUlogovanihDelegata = new List<Delegat>();
        Socket soket;

        public bool PokreniServer() 
        {
            try
            {
                soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                EndPoint ep = new IPEndPoint(IPAddress.Any, 20000);
                soket.Bind(ep);

                ThreadStart ts = Osluskuj;
                var nit = new Thread(ts);
                nit.Start();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void Osluskuj() 
        {
            try
            {
                soket.Listen(6);
                while (true) 
                {
                    var klijent = soket.Accept();
                    var tok = new NetworkStream(klijent);
                    new Obrada(tok);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        internal bool ZaustaviServer()
        {
            try
            {
                soket.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
