using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;

namespace IpScanner
{
    internal class PortClass
    {
        public int PotNum { get; set; }

    }
    internal class PortScanner
    {

        private string host;
        private List<int> portList;
        public int tcpTimeout;
        public List<PortClass> port1 = new List<PortClass>();


        private class isTcpPortOpen
        {
            public TcpClient MainClient { get; set; }
            public bool tcpOpen { get; set; }
        }


        public PortScanner(string host, List<int> ports, int timeout)
        {
            this.host = host;
            portList = ports;
            tcpTimeout = timeout;

        }
        public void RunScanTcp()
        {

            foreach (var port in portList)
            {
                //Thread.Sleep(1);
                try
                {

                    Connect(host, port, tcpTimeout);
                    port1.Add(new PortClass { PotNum = port });

                }
                catch
                {
                    continue;
                }

            }

        }
        //method for returning tcp client connected or not connected
        public TcpClient Connect(string hostName, int port, int timeout)
        {
            var newClient = new TcpClient();

            var state = new isTcpPortOpen
            {
                MainClient = newClient,
                tcpOpen = true
            };

            IAsyncResult ar = newClient.BeginConnect(hostName, port, AsyncCallback, state);
            state.tcpOpen = ar.AsyncWaitHandle.WaitOne(timeout, false);
            if (state.tcpOpen == false || newClient.Connected == false)
            {
                throw new Exception();

            }
            return newClient;
        }

        void AsyncCallback(IAsyncResult asyncResult)
        {
            var state = (isTcpPortOpen)asyncResult.AsyncState;
            TcpClient client = state.MainClient;

            try
            {
                client.EndConnect(asyncResult);
            }
            catch
            {
                return;
            }

            if (client.Connected && state.tcpOpen)
            {
                return;
            }

            client.Close();
        }


    }

}