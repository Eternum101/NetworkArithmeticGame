////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Nodes\BinaryTreeNode.cs
//
// summary:	Implements the binary tree node class
////////////////////////////////////////////////////////////////////////////////////////////////////

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

namespace NetworkArithmeticGame.Nodes
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A binary tree node. </summary>
    ///
    /// <remarks>   Brayden, 15/09/2018. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    class BinaryTreeNode
    {
        /// <summary>   The value. </summary>
        public NodeProperties2 value;
        /// <summary>   The left. </summary>
        public BinaryTreeNode left;
        /// <summary>   The right. </summary>
        public BinaryTreeNode right;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="val">  The value. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public BinaryTreeNode(NodeProperties2 val)
        {
            value = val;
            left = null;
            right = null;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Node to string. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <returns>   A string. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string NodeToString()
        {
            return value.Answer.ToString() + "(" + value.FirstNumber.ToString() + value.Operator + value.SecondNumber.ToString() + "), ";
        }
    }
}
