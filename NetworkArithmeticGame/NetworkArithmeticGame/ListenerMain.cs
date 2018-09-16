////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	ListenerMain.cs
//
// summary:	Implements the listener main class
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
 * Purpose: Class for ListenerMain
 * Version Control: 1.0
 * Date: 17/09/2018
*/

namespace StudentForm
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A listener main. </summary>
    ///
    /// <remarks>   Brayden, 15/09/2018. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    class ListenerMain
    {
        /// <summary>   The socket main. </summary>
        Socket socketMain;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets a value indicating whether the listening main. </summary>
        ///
        /// <value> True if listening main, false if not. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool ListeningMain
        {
            get;
            private set;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the port main. </summary>
        ///
        /// <value> The port main. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public int PortMain
        {
            get;
            private set;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="port"> The port. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public ListenerMain(int port)
        {
            PortMain = port;
            socketMain = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Starts this object. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Start()
        {
            if (ListeningMain)
                return;

            socketMain.Bind(new IPEndPoint(0, PortMain));
            socketMain.Listen(0);

            socketMain.BeginAccept(callback, null);
            ListeningMain = true;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Stops this object. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Stop()
        {
            if (!ListeningMain)
                return;

            socketMain.Close();
            socketMain.Dispose();
            socketMain = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            socketMain.BeginAccept(callback, null);
            ListeningMain = true;
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
                Socket socketMain = this.socketMain.EndAccept(arr);

                if (SocketAccepted != null)
                {
                    SocketAccepted(socketMain);
                }
                this.socketMain.BeginAccept(callback, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Socket accept handler main. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="f">    A Socket to process. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public delegate void SocketAcceptHandlerMain(Socket f);
        /// <summary>   Event queue for all listeners interested in SocketAccepted events. </summary>
        public event SocketAcceptHandlerMain SocketAccepted;
    }
}
