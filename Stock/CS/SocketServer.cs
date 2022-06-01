using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Stock.CS
{
    public class SocketServer
    {
        Socket SListen; // for listening
        Socket SClient; // which SListen accepted client
        string SEndPoint; // record each client ip n port
        public void SConnect()
        {
            IPEndPoint ipE = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8485); // build ip
            SListen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);  //  set the type of socket
            SListen.Bind(ipE); // tangle with ip
            SListen.Listen(4); //   start to wait for client
            SAccept(SListen);
        }
        public void SAccept(Socket socket)
        {
            SListen.BeginAccept(SResult =>
            {
                SClient = socket.EndAccept(SResult);
                SEndPoint = SClient.RemoteEndPoint.ToString(); // get client ip
                //comboBox1.Items.Add(SEndPoint); //  add ip to comboBox
                //dic.Add(SEndPoint, SClient);
                SSend(SClient, string.Format("Welcome {0}", SEndPoint));
                SReceive(SClient);
                SAccept(socket); // add another client
            }, null
            );
        }
        public void SSend(Socket socket, string message)
        {
            if (socket == null || message == string.Empty)
            {
                return;
            }
            byte[] data = Encoding.UTF8.GetBytes(message);
            try
            {
                socket.BeginSend(data, 0, data.Length, SocketFlags.None, Result =>
                {
                    int length = socket.EndSend(Result);
                }, null);
            }
            catch (Exception)
            {
                string deleteClient = socket.RemoteEndPoint.ToString();
                //dic.Remove(deleteClient);
                //comboBox1.Items.Remove(deleteClient);
            }
        }

        public void SReceive(Socket socket)
        {
            byte[] data = new byte[1024];
            try
            {
                socket.BeginReceive(data, 0, data.Length, SocketFlags.None, Result =>
                {
                    try
                    {
                        SetText(Encoding.UTF8.GetString(data));
                        int length = socket.EndReceive(Result);
                    }
                    catch (Exception)
                    {
                        SReceive(socket);
                    }
                    SReceive(socket);
                }, null);
            }
            catch (Exception)
            {
            }
        }

        public void SetText(string str)
        {
            Console.WriteLine(str);
        }
    }
}
