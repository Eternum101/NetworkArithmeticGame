////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Client.cs
//
// summary:	Implements the client class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Brayden Cantrill 210160216 or 454657305
 * Purpose: Class for Client
 * Version Control: 1.0
 * Date: 17/09/2018
*/

namespace StudentForm
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A client. </summary>
    ///
    /// <remarks>   Brayden, 16/09/2018. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    class Client
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the identifier. </summary>
        ///
        /// <value> The identifier. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string ID
        {
            get;
            private set;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the end point. </summary>
        ///
        /// <value> The end point. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public IPEndPoint EndPoint
        {
            get;
            private set;
        }

        /// <summary>   The socket. </summary>
        Socket socket;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Brayden, 16/09/2018. </remarks>
        ///
        /// <param name="accepted"> The accepted. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Client(Socket accepted)
        {
            socket = accepted;
            ID = Guid.NewGuid().ToString();
            EndPoint = (IPEndPoint)socket.RemoteEndPoint;
            socket.BeginReceive(new byte[] { 0 }, 0, 0, 0, callback, null);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Async callback, called on completion of callback. </summary>
        ///
        /// <remarks>   Brayden, 16/09/2018. </remarks>
        ///
        /// <param name="ar">   The result of the asynchronous operation. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        void callback(IAsyncResult ar)
        {
            try
            {
                socket.EndReceive(ar);

                byte[] buf = new byte[8192];

                int rec = socket.Receive(buf, buf.Length, 0);

                if (rec < buf.Length)
                {
                    Array.Resize<byte>(ref buf, rec);

                }
                if (Received != null)
                {
                    Received(this, buf);
                }
                socket.BeginReceive(new byte[] { 0 }, 0, 0, 0, callback, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Close();

                if (Disconnected != null)
                {
                    Disconnected(this);
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Closes this object. </summary>
        ///
        /// <remarks>   Brayden, 16/09/2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Close()
        {
            socket.Close();
            socket.Dispose();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Handler, called when the client received. </summary>
        ///
        /// <remarks>   Brayden, 16/09/2018. </remarks>
        ///
        /// <param name="sender">   The sender. </param>
        /// <param name="data">     The data. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public delegate void ClientReceivedHandler(Client sender, byte[] data);

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Handler, called when the client disconnect. </summary>
        ///
        /// <remarks>   Brayden, 16/09/2018. </remarks>
        ///
        /// <param name="sender">   The sender. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public delegate void ClientDisconnectHandler(Client sender);

        /// <summary>   Event queue for all listeners interested in Received events. </summary>
        public event ClientReceivedHandler Received;
        /// <summary>   Event queue for all listeners interested in Disconnected events. </summary>
        public event ClientDisconnectHandler Disconnected;
    }
}
