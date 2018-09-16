////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Nodes\BinaryTree.cs
//
// summary:	Implements the binary tree class
////////////////////////////////////////////////////////////////////////////////////////////////////

using NetworkArithmeticGame.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Brayden Cantrill 210160216 or 454657305
 * Purpose: Functionality for the Binary Tree in the Application
 * Version Control: 1.0
 * Date: 17/09/2018
*/

namespace NetworkArithmeticGame
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A binary tree. </summary>
    ///
    /// <remarks>   Brayden, 15/09/2018. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    class BinaryTree
    {
        /// <summary>   The top. </summary>
        public BinaryTreeNode top;
        /// <summary>   The print string. </summary>
        private static string printString;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="answerValue">  The answer value to add. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public BinaryTree(NodeProperties2 answerValue)
        {
            top = new BinaryTreeNode(answerValue);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public BinaryTree()
        {
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Adds answerValue. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="answerValue">  The answer value to add. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Add(NodeProperties2 answerValue)
        {
            if (top == null)
            {
                // Indicates the tree is empty
                top = new Nodes.BinaryTreeNode(answerValue);
                return;
            }
            BinaryTreeNode currentNode = top;
            bool insert = false;

            do
            {
                // If the inserted value is less than the current value
                if (answerValue.Answer < currentNode.value.Answer)
                {
                    // Insert left
                    if (currentNode.left == null)
                    {
                        // End node
                        currentNode.left = new BinaryTreeNode(answerValue);
                        insert = true;
                    }
                    else
                    {
                        // Move left
                        currentNode = currentNode.left;
                    }

                    // If the inserted value is greater than or equal to current
                    if (answerValue.Answer >= currentNode.value.Answer)
                    {
                        // Insert right
                        if (currentNode.right == null)
                        {
                            // End node
                            currentNode.right = new Nodes.BinaryTreeNode(answerValue);
                            insert = true;
                        }
                        else
                        {
                            // Move right
                            currentNode = currentNode.right;
                        }
                    }
                    else
                    {

                    }
                }
            } while (!insert);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Print tree. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="root"> The root. </param>
        ///
        /// <returns>   A string. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static string PrintTree(BinaryTreeNode root)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(root.value.Answer.ToString());
            sb.Append("(");
            sb.Append(root.value.FirstNumber.ToString());
            sb.Append(root.value.Operator.ToString());
            sb.Append(root.value.SecondNumber.ToString());
            sb.Append(")");
            return sb.ToString();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Print pre order. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="tree"> The tree. </param>
        ///
        /// <returns>   A string. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string printPreOrder(BinaryTree tree)
        {
            printString = "";
            PreOrder(tree.top);
            return printString; 
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Pre order. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="Root"> The root. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void PreOrder(BinaryTreeNode Root)
        {
            if(Root == null)
            {
                return;
            }
            else
            {
                printString += Root.NodeToString();
                PreOrder(Root.left);
                PreOrder(Root.right); 
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Print in order. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="tree"> The tree. </param>
        ///
        /// <returns>   A string. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string printInOrder(BinaryTree tree)
        {
            printString = "";
            InOrder(tree.top);
            return printString;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   In order. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="Root"> The root. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void InOrder(BinaryTreeNode Root)
        {
            if (Root == null)
            {
                return;
            }
            else
            {
                InOrder(Root.left);
                if (!printString.Contains(Root.NodeToString()))
                {
                    printString += Root.NodeToString();
                }
                InOrder(Root.right);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Print post order. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="tree"> The tree. </param>
        ///
        /// <returns>   A string. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string printPostOrder(BinaryTree tree)
        {
            printString = "";
            PostOrder(tree.top);
            return printString;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Posts an order. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="Root"> The root. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void PostOrder(BinaryTreeNode Root)
        {
            if (Root == null)
            {
                return;
            }
            PreOrder(Root.left);
            PreOrder(Root.right);
            printString += Root.NodeToString();
        }
    }
}
