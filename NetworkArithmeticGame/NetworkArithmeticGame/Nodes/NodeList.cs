////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Nodes\NodeList.cs
//
// summary:	Implements the node list class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Brayden Cantrill 210160216 or 454657305
 * Purpose: Creation of Nodes & Functionality for the Doubly Linked List in the Application
 * Version Control: 1.0
 * Date: 17/09/2018
*/

namespace NetworkArithmeticGame
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   List of nodes. </summary>
    ///
    /// <remarks>   Brayden, 16/09/2018. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    class NodeList
    {


        /// <summary>   The tail node. </summary>
        public Node CurrentNode = null, HeadNode = null, TailNode = null;



        /// <summary>   Number of. </summary>
        static int count = 0;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Brayden, 16/09/2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public NodeList() { }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Brayden, 16/09/2018. </remarks>
        ///
        /// <param name="node"> The node. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public NodeList(Node node)
        {
            HeadNode = node;
            CurrentNode = node;
            TailNode = node;
            count++;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets current node. </summary>
        ///
        /// <remarks>   Brayden, 16/09/2018. </remarks>
        ///
        /// <returns>   The current node. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Node getCurrentNode() { return CurrentNode; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets head node. </summary>
        ///
        /// <remarks>   Brayden, 16/09/2018. </remarks>
        ///
        /// <returns>   The head node. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Node getHeadNode() { return HeadNode; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets tail node. </summary>
        ///
        /// <remarks>   Brayden, 16/09/2018. </remarks>
        ///
        /// <returns>   The tail node. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Node getTailNode() { return TailNode; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Sets current node. </summary>
        ///
        /// <remarks>   Brayden, 16/09/2018. </remarks>
        ///
        /// <param name="node"> The node. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void setCurrentNode(Node node) { CurrentNode = node; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Sets head node. </summary>
        ///
        /// <remarks>   Brayden, 16/09/2018. </remarks>
        ///
        /// <param name="node"> The node. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void setHeadNode(Node node) { HeadNode = node; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Sets tail node. </summary>
        ///
        /// <remarks>   Brayden, 16/09/2018. </remarks>
        ///
        /// <param name="node"> The node. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void setTailNode(Node node) { TailNode = node; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Adds a node. </summary>
        ///
        /// <remarks>   Brayden, 16/09/2018. </remarks>
        ///
        /// <param name="node"> The node. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void AddNode(Node node)
        {
            if ((HeadNode == null) && (CurrentNode == null) && (TailNode == null))
            {
                // this firstNode in the list
                HeadNode = node;
                CurrentNode = node;
                TailNode = node;
                count++;
            }
            else
            {
                CurrentNode = node;
                HeadNode.setPrevious(node);
                CurrentNode.setNext(HeadNode);
                setHeadNode(CurrentNode);
                count++;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Sort list. </summary>
        ///
        /// <remarks>   Brayden, 16/09/2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void SortList()
        {
            Node current = HeadNode;
            for (Node i = current; i.getNext() != null; i = i.getNext())
            {
                for (Node j = i.getNext(); j != null; j = j.getNext())
                {
                    if (i.getValue() > j.getValue())
                    {
                        int Temp = j.getValue();
                        j.setMyValue(i.getValue());
                        i.setMyValue(Temp);
                    }
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Binary search. </summary>
        ///
        /// <remarks>   Brayden, 16/09/2018. </remarks>
        ///
        /// <param name="searchValue">  The search value. </param>
        ///
        /// <returns>   An int. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public int binarySearch(int searchValue)
        {
            this.SortList();
            Node current = HeadNode;
            ArrayList myTempList = new ArrayList();
            for (Node i = current; i != null; i = i.getNext())
            {
                myTempList.Add(i.getValue());
            }
            return myTempList.BinarySearch(searchValue);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Links a list table. </summary>
        ///
        /// <remarks>   Brayden, 16/09/2018. </remarks>
        ///
        /// <param name="node"> The node. </param>
        ///
        /// <returns>   A Hashtable. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Hashtable LinkListTable(NodeList node)
        {
            Hashtable LinkListTable = new Hashtable();
            int counter = 1;

            for (Node i = node.HeadNode; i.getNext() != null; i = i.getNext())
            {
                LinkListTable.Add(count.ToString(), i);
                counter++;
            }
            return LinkListTable;
        }
    }
}
