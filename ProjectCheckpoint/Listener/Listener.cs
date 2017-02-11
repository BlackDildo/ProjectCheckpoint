using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectCheckpoint.Listener
{
    public class TcpListener
    {        
        public static TcpListener Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        private static readonly Lazy<TcpListener> lazy = new Lazy<TcpListener>(() => new TcpListener());
        
        private System.Net.Sockets.TcpListener tcpListener;
        private byte[] dataArray;
        private Task task;
        private bool isListen = false;

        private TcpListener()
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            tcpListener = new System.Net.Sockets.TcpListener(ip, 48654);
        }

        public void Listen()
        {
            task = new Task(InternalListen);
            task.Start();
        }

        private void InternalListen()
        {
            try
            {
                if (isListen)
                    return;

                tcpListener.Start();
                isListen = true;

                while (true)
                {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();
                    NetworkStream stream = tcpClient.GetStream();
                    stream.Read(dataArray, 0, (int)stream.Length);
                    tcpClient.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                StopListen();
            }
        }

        private void StopListen()
        {
            if (tcpListener != null)
                tcpListener.Stop();

            isListen = false;           
        }
    }
}
