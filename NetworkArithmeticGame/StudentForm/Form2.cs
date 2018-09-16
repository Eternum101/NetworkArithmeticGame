////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Form2.cs
//
// summary:	Implements the form 2 class
////////////////////////////////////////////////////////////////////////////////////////////////////

using NetworkArithmeticGame;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Brayden Cantrill 210160216 or 454657305
 * Purpose: Functionality for Displaying the Student Form
 * Version Control: 1.0
 * Date: 17/09/2018
*/

namespace StudentForm
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A form 2. </summary>
    ///
    /// <remarks>   Brayden, 15/09/2018. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public partial class Form2 : Form
    {
        /// <summary>   The listener. </summary>
        Listener listener;
        /// <summary>   The socket main. </summary>
        Socket socketMain;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Form2()
        {
            InitializeComponent();
            listener = new Listener(8);
            listener.SocketAccepted += new Listener.SocketAcceptHandler(listener_SocketAccepted);
            Load += new EventHandler(Form2_Load);
            socketMain = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        /// <summary>   The mouse y coordinate. </summary>
        int mouseX = 0, mouseY = 0;
        /// <summary>   True to mouse down. </summary>
        bool mouseDown;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by Form2 for load events. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Form2_Load(object sender, EventArgs e)
        {
            Task.Delay(7000).ContinueWith(t => connect());
            listener.Start();
            btnSubmit.Enabled = false;
            btnSubmit.Text = "Please Wait...";
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Connects this object. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void connect()
        {
            socketMain.Connect("127.0.0.1", 9);
            btnSubmit.Enabled = true;
            btnSubmit.Text = "Submit"; 
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Listener socket accepted. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="e">    A Socket to process. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void listener_SocketAccepted(System.Net.Sockets.Socket e)
        {
            Client client = new Client(e);
            client.Received += new Client.ClientReceivedHandler(client_Received);
            client.Disconnected += Client_Disconnected; 

            Invoke((MethodInvoker)delegate
            {
                ListViewItem i = new ListViewItem();
                i.Text = client.EndPoint.ToString();
                i.Tag = client;
            });
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Client disconnected. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Client_Disconnected(Client sender)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Client received. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="data">     The data. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void client_Received(Client sender, byte[] data /* IAsyncResult aResult*/)
        {
            Invoke((MethodInvoker)delegate
            {
                ListViewItem i = new ListViewItem();
                i.Text = Encoding.Default.GetString(data);
                lstQuestion.Items.Add(i);
            });
        }

            ////////////////////////////////////////////////////////////////////////////////////////////////////
            /// <summary>   Event handler. Called by btnExitStudent for click events. </summary>
            ///
            /// <remarks>   Brayden, 15/09/2018. </remarks>
            ///
            /// <param name="sender">   Source of the event. </param>
            /// <param name="e">        Event information. </param>
            ////////////////////////////////////////////////////////////////////////////////////////////////////

            private void btnExitStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by panel6 for mouse down events. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Mouse event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by panel6 for mouse move events. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Mouse event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by panel6 for mouse up events. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Mouse event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void panel6_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; 
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by btnSubmit for click events. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] messageTwo = new byte[2000];
                messageTwo = enc.GetBytes(txtStudentAnswer.Text);// Get the string from the textbox and convert it to raw bytes
                socketMain.Send(messageTwo);

                txtStudentAnswer.Text = "";

                Invoke((MethodInvoker)delegate
                {
                    for (int i = 0; i < lstQuestion.Items.Count; i++)
                    {
                        Client client = lstQuestion.Items[i].Tag as Client;

                        lstQuestion.Items.RemoveAt(i);
                        break;
                    }
                });
            }
            catch (Exception)
            {

                throw;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by btnMinimizeStudent for click events. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnMinimizeStudent_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
