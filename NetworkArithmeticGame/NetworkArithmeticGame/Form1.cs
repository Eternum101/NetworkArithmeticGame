////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Form1.cs
//
// summary:	Implements the form 1 class
////////////////////////////////////////////////////////////////////////////////////////////////////

using NetworkArithmeticGame.Nodes;
using StudentForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Brayden Cantrill 210160216 or 454657305
 * Purpose: Functionality for Displaying the Main Application
 * Version Control: 1.0
 * Date: 17/09/2018
*/

namespace NetworkArithmeticGame
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A form 1. </summary>
    ///
    /// <remarks>   Brayden, 15/09/2018. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public partial class Form1 : Form
    {
        /// <summary>   The node properties. </summary>
        List<NodeProperties> nodeProperties = new List<NodeProperties>();
        /// <summary>   The values. </summary>
        NodeProperties2 values; 
        /// <summary>   List of nodes. </summary>
        NodeList nodeList = new NodeList();
        /// <summary>   The binary tree. </summary>
        BinaryTree binaryTree = new BinaryTree();

        /// <summary>   The socket. </summary>
        Socket socket;
        /// <summary>   The listener. </summary>
        ListenerMain listener;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets the answer. </summary>
        ///
        /// <value> The answer. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        double firstNumber, secondNumber, answer;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Form1()
        {
            InitializeComponent();
            listener = new ListenerMain(9);
            listener.SocketAccepted += new ListenerMain.SocketAcceptHandlerMain(listener_SocketAccepted);
            Load += new EventHandler(Form1_Load);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        /// <summary>   The mouse y coordinate. </summary>
        int mouseX = 0, mouseY = 0;
        /// <summary>   True to mouse down. </summary>
        bool mouseDown;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by Form1 for load events. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Delay(7000).ContinueWith(t => connect());
            listener.Start();
            btnSend.Enabled = false;
            btnSend.Text = "Please Wait...";
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Connects this object. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void connect()
        {
            socket.Connect("127.0.0.1", 8);
            btnSend.Enabled = true;
            btnSend.Text = "Send"; 
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Listener socket accepted. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="f">    A Socket to process. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        void listener_SocketAccepted(System.Net.Sockets.Socket f)
        {
            ClientMain client = new ClientMain(f);
            client.Received += new ClientMain.ClientReceivedHandlerMain(client_ReceivedMain);
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
        /// <param name="senderMain">   The sender main. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Client_Disconnected(ClientMain senderMain)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Client received main. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="senderMain">   The sender main. </param>
        /// <param name="dataMain">     The data main. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        void client_ReceivedMain(ClientMain senderMain, byte[] dataMain)
        {
            Invoke((MethodInvoker)delegate
            {
                if (txtAnswer.Text == Encoding.Default.GetString(dataMain))
                {
                    MessageBox.Show("Answer Is Correct!", "Correct!");
                    btnSend.Enabled = true;
                }
                else if (txtAnswer.Text != Encoding.Default.GetString(dataMain))
                {
                    int num;
                    bool answer = int.TryParse(txtAnswer.Text, out num);
                    nodeList.AddNode(new Node(num));
                    LinkList();
                    MessageBox.Show("Incorrect Answer!", "Incorrect!");
                }
            });
                values = new NodeProperties2(Convert.ToInt32(txtFirstNumber.Text), Convert.ToInt32(txtSecondNumber.Text), comboBoxOperator.Text, Convert.ToInt32(txtAnswer.Text));
                BinaryTree();
                btnSend.Enabled = true;
                txtFirstNumber.Text = "";
                comboBoxOperator.Text = "";
                txtSecondNumber.Text = "";
                txtAnswer.Text = "";
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Links the list. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void LinkList()
        {
            string value = txtFirstNumber.Text + comboBoxOperator.Text + txtSecondNumber.Text + "=";
            StringBuilder sb = new StringBuilder();
            if (lstLinkedList.Text == "")
            {
                sb.Append("HEAD <-> ");
                sb.Append(value + nodeList.getCurrentNode().tostring());
            }
            else
            {
                sb.Append(lstLinkedList.Text);
                sb.Append(" <-> ");
                sb.Append(value + nodeList.getCurrentNode().tostring());
            }
            lstLinkedList.Text = sb.ToString();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by btnSend for click events. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] message = new byte[1500];
                message = enc.GetBytes(txtFirstNumber.Text + " " + comboBoxOperator.Text + " " + txtSecondNumber.Text + " " + "=");
                // Get the string from the textbox and convert it to raw bytes
                socket.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataGridViewArrays(txtFirstNumber.Text, comboBoxOperator.Text, txtSecondNumber.Text, txtAnswer.Text);

            if (txtFirstNumber.Text == "" || comboBoxOperator.Text == "" || txtSecondNumber.Text == "" || txtAnswer.Text == "")
            {
                MessageBox.Show("Please Input Values to Send!", "Input!");
            }
            else
            {
                btnSend.Enabled = false;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by txtSecondNumber for text changed events. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void txtSecondNumber_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxOperator.Text == "+")
            {
                if (txtSecondNumber.Text != "")
                {
                    firstNumber = Convert.ToDouble(txtFirstNumber.Text);
                    secondNumber = Convert.ToDouble(txtSecondNumber.Text);
                    answer = firstNumber + secondNumber;
                    txtAnswer.Text = answer.ToString();
                }
                else
                {

                }
            }
            else if (comboBoxOperator.Text == "-")
            {
                if (txtSecondNumber.Text != "")
                {
                    firstNumber = Convert.ToDouble(txtFirstNumber.Text);
                    secondNumber = Convert.ToDouble(txtSecondNumber.Text);
                    answer = firstNumber - secondNumber;
                    txtAnswer.Text = answer.ToString();
                }
                else
                {

                }
            }
            else if (comboBoxOperator.Text == "x")
            {
                if (txtSecondNumber.Text != "")
                {
                    firstNumber = Convert.ToDouble(txtFirstNumber.Text);
                    secondNumber = Convert.ToDouble(txtSecondNumber.Text);
                    answer = firstNumber * secondNumber;
                    txtAnswer.Text = answer.ToString();
                }
                else
                {

                }
            }
            else if (comboBoxOperator.Text == "/")
            {
                if (txtSecondNumber.Text != "")
                {
                    firstNumber = Convert.ToDouble(txtFirstNumber.Text);
                    secondNumber = Convert.ToDouble(txtSecondNumber.Text);
                    answer = firstNumber / secondNumber;
                    txtAnswer.Text = answer.ToString();
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Data grid view arrays. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="firstName">    The person's first name. </param>
        /// <param name="Operator">     The operator. </param>
        /// <param name="secondNumber"> The second number. </param>
        /// <param name="answer">       The answer. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DataGridViewArrays(string firstName, string Operator, string secondNumber, string answer)
        {
            dgdArrayQuestions.ColumnCount = 4;
            dgdArrayQuestions.Columns[0].Name = "First Number";
            dgdArrayQuestions.Columns[1].Name = "Operator";
            dgdArrayQuestions.Columns[2].Name = "Second Number";
            dgdArrayQuestions.Columns[3].Name = "Answer";
            dgdArrayQuestions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            String[] row = { firstName, Operator, secondNumber, answer };

            dgdArrayQuestions.Rows.Add(row);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Binary tree. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void BinaryTree()
        {
            // Indicates if the tree is null
            if (binaryTree.top == null)
            {
                // Creates a new node value at the top of the tree
                binaryTree.top = new BinaryTreeNode(values);
            }
            else
            {
                // Else adds another value to the tree
                binaryTree.Add(values);
            }
            lstBinaryTree.Clear();
            lstBinaryTree.Text = "IN-ORDER: ";
            lstBinaryTree.Text += binaryTree.printInOrder(binaryTree);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Hash table. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void HashTable()
        {
            Hashtable Save = new Hashtable();

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by btnExit for click events. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by btnMinimize for click events. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by btnPreSave for click events. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnPreSave_Click(object sender, EventArgs e)
        {
            string PreOrder = "PreOrder.txt";

            using (StreamWriter sw = File.AppendText(PreOrder))
            {
                sw.WriteLine("PRE-ORDER: " + binaryTree.printPreOrder(binaryTree));
                sw.Close();
            }
            MessageBox.Show("Successfully Saved!", "Success!"); 
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by btnSort1 for click events. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnSort1_Click(object sender, EventArgs e)
        {
            this.dgdArrayQuestions.Sort(this.dgdArrayQuestions.Columns[0], ListSortDirection.Ascending); 
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by btnSort2 for click events. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnSort2_Click(object sender, EventArgs e)
        {
            this.dgdArrayQuestions.Sort(this.dgdArrayQuestions.Columns[0], ListSortDirection.Descending);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by btnSort3 for click events. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnSort3_Click(object sender, EventArgs e)
        {
            this.dgdArrayQuestions.Sort(this.dgdArrayQuestions.Columns[1], ListSortDirection.Ascending);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by btnPreDisplay for click events. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnPreDisplay_Click(object sender, EventArgs e)
        {
            lstBinaryTree.Clear();
            lstBinaryTree.Text = "PRE-ORDER: ";
            lstBinaryTree.Text += binaryTree.printPreOrder(tree: binaryTree);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by btnInDisplay for click events. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnInDisplay_Click(object sender, EventArgs e)
        {
            lstBinaryTree.Clear();
            lstBinaryTree.Text = "IN-ORDER: ";
            lstBinaryTree.Text += binaryTree.printInOrder(tree: binaryTree);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by btnPostDisplay for click events. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnPostDisplay_Click(object sender, EventArgs e)
        {
            lstBinaryTree.Clear();
            lstBinaryTree.Text = "POST-ORDER: ";
            lstBinaryTree.Text += binaryTree.printPostOrder(tree: binaryTree);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by btnInSave for click events. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnInSave_Click(object sender, EventArgs e)
        {
            string InOrder = "InOrder.txt";

            using (StreamWriter sw = File.AppendText(InOrder))
            {
                sw.WriteLine("IN-ORDER: " + binaryTree.printInOrder(binaryTree));
                sw.Close();
            }
            MessageBox.Show("Successfully Saved!", "Success!");
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by btnPostSave for click events. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnPostSave_Click(object sender, EventArgs e)
        {
            string PostOrder = "PostOrder.txt";

            using (StreamWriter sw = File.AppendText(PostOrder))
            {
                sw.WriteLine("POST-ORDER: " + binaryTree.printPostOrder(binaryTree));
                sw.Close();
            }
            MessageBox.Show("Successfully Saved!", "Success!");
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by pnlHeader for mouse up events. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Mouse event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; 
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by pnlHeader for mouse move events. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Mouse event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by pnlHeader for mouse down events. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Mouse event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
