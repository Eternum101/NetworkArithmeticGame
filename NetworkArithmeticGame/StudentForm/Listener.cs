////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Listener.cs
//
// summary:	Implements the listener class
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
 * Purpose: Class for Listener
 * Version Control: 1.0
 * Date: 17/09/2018
*/

namespace StudentForm
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A listener. </summary>
    ///
    /// <remarks>   Brayden, 16/09/2018. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    class Listener
    {
        /// <summary>   The socket. </summary>
        Socket socket;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets a value indicating whether the listening. </summary>
        ///
        /// <value> True if listening, false if not. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool Listening
        {
            get;
            private set;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the port. </summary>
        ///
        /// <value> The port. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public int Port
        {
            get;
            private set;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Brayden, 16/09/2018. </remarks>
        ///
        /// <param name="port"> The port. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Listener(int port)
        {
            Port = port;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Starts this object. </summary>
        ///
        /// <remarks>   Brayden, 16/09/2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Start()
        {
            if (Listening)
                return;

            socket.Bind(new IPEndPoint(0, Port));
            socket.Listen(0);

            socket.BeginAccept(callback, null);
            Listening = true;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Stops this object. </summary>
        ///
        /// <remarks>   Brayden, 16/09/2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Stop()
        {
            if (!Listening)
                return;

            socket.Close();
            socket.Dispose();
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            socket.BeginAccept(callback, null);
            Listening = true;
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
                Socket socket = this.socket.EndAccept(ar);

                if (SocketAccepted != null)
                {
                    SocketAccepted(socket);
                }
                this.socket.BeginAccept(callback, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Handler, called when the socket accept. </summary>
        ///
        /// <remarks>   Brayden, 16/09/2018. </remarks>
        ///
        /// <param name="e">    A Socket to process. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public delegate void SocketAcceptHandler(Socket e);
        /// <summary>   Event queue for all listeners interested in SocketAccepted events. </summary>
        public event SocketAcceptHandler SocketAccepted;
    }
}
