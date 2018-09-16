////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Nodes\NodeProperties2.cs
//
// summary:	Implements the node properties 2 class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Brayden Cantrill 210160216 or 454657305
 * Purpose: Class for NodeProperties2
 * Version Control: 1.0
 * Date: 17/09/2018
*/

namespace NetworkArithmeticGame.Nodes
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A node properties 2. </summary>
    ///
    /// <remarks>   Brayden, 15/09/2018. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    class NodeProperties2
    {
        /// <summary>   The first number. </summary>
        public int FirstNumber;
        /// <summary>   The operator. </summary>
        public string Operator;
        /// <summary>   The second number. </summary>
        public int SecondNumber;
        /// <summary>   The answer. </summary>
        public int Answer;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="firstNumber">  The first number. </param>
        /// <param name="secondNumber"> The second number. </param>
        /// <param name="operation">    The operation. </param>
        /// <param name="answer">       The answer. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public NodeProperties2(int firstNumber, int secondNumber, string operation, int answer)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            Operator = operation;
            Answer = answer;
        }
    }
}
