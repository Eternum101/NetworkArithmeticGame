////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	ClientMain.cs
//
// summary:	Implements the client main class
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
 * Purpose: Class for ClientMain
 * Version Control: 1.0
 * Date: 17/09/2018
*/

namespace StudentForm
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A client main. </summary>
    ///
    /// <remarks>   Brayden, 15/09/2018. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    class ClientMain
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

        /// <summary>   The socket main. </summary>
        Socket socketMain;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="accepted"> The accepted. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public ClientMain(Socket accepted)
        {
            socketMain = accepted;
            ID = Guid.NewGuid().ToString();
            EndPoint = (IPEndPoint)socketMain.RemoteEndPoint;
            socketMain.BeginReceive(new byte[] { 0 }, 0, 0, 0, callback, null);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Async callback, called on completion of callback. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="arr">  The result of the asynchronous operation. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        void callback(IAsyncResult arr)
        {
            try
            {
                socketMain.EndReceive(arr);

                byte[] buf = new byte[8192];

                int rec = socketMain.Receive(buf, buf.Length, 0);

                if (rec < buf.Length)
                {
                    Array.Resize<byte>(ref buf, rec);

                }
                if (Received != null)
                {
                    Received(this, buf);
                }
                socketMain.BeginReceive(new byte[] { 0 }, 0, 0, 0, callback, null);
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
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Close()
        {
            socketMain.Close();
            socketMain.Dispose();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Client received handler main. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="senderMain">   The sender main. </param>
        /// <param name="dataMain">     The data main. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public delegate void ClientReceivedHandlerMain(ClientMain senderMain, byte[] dataMain);

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Client disconnect handler main. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="senderMain">   The sender main. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public delegate void ClientDisconnectHandlerMain(ClientMain senderMain);

        /// <summary>   Event queue for all listeners interested in Received events. </summary>
        public event ClientReceivedHandlerMain Received;
        /// <summary>   Event queue for all listeners interested in Disconnected events. </summary>
        public event ClientDisconnectHandlerMain Disconnected;
    }
}
