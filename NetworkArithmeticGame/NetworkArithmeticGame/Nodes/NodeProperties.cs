////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Nodes\NodeProperties.cs
//
// summary:	Implements the node properties class
////////////////////////////////////////////////////////////////////////////////////////////////////

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Brayden Cantrill 210160216 or 454657305
 * Purpose: Class for NodeProperties
 * Version Control: 1.0
 * Date: 17/09/2018
*/

namespace NetworkArithmeticGame
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A node properties. </summary>
    ///
    /// <remarks>   Brayden, 15/09/2018. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    class NodeProperties
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the first number. </summary>
        ///
        /// <value> The first number. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        [JsonProperty("first_number")]
        public ushort FirstNumber { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the second number. </summary>
        ///
        /// <value> The second number. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        [JsonProperty("second_number")]
        public ushort SecondNumber { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the operator. </summary>
        ///
        /// <value> The operator. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        [JsonProperty("operator")]
        public string Operator { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the answer. </summary>
        ///
        /// <value> The answer. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        [JsonProperty("answer")]
        public ushort Answer { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets a value indicating whether this object is correct. </summary>
        ///
        /// <value> True if this object is correct, false if not. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        [JsonProperty("is_correct")]
        public bool IsCorrect { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public NodeProperties() { }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="firstNumber">  The first number. </param>
        /// <param name="secondNumber"> The second number. </param>
        /// <param name="operator">     The operator. </param>
        /// <param name="answer">       The answer. </param>
        /// <param name="isCorrect">    True if is correct, false if not. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public NodeProperties(ushort firstNumber, ushort secondNumber, string @operator, ushort answer, bool isCorrect)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            Operator = @operator;
            Answer = answer;
            IsCorrect = isCorrect;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <param name="data"> The data. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public NodeProperties(byte[] data)
        {
            FirstNumber = BitConverter.ToUInt16(data, 0);
            SecondNumber = BitConverter.ToUInt16(data, 1);
            Answer = BitConverter.ToUInt16(data, 2);
            int operatorLength = BitConverter.ToInt32(data, 3);
            Operator = Encoding.ASCII.GetString(data, 4, operatorLength);
            IsCorrect = BitConverter.ToBoolean(data, 5);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Converts this object to a byte array. </summary>
        ///
        /// <remarks>   Brayden, 15/09/2018. </remarks>
        ///
        /// <returns>   This object as a byte[]. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public byte[] ToByteArray()
        {
            List<byte> byteList = new List<byte>();
            byteList.AddRange(BitConverter.GetBytes(FirstNumber));
            byteList.AddRange(BitConverter.GetBytes(SecondNumber));
            byteList.AddRange(BitConverter.GetBytes(Answer));
            byteList.AddRange(BitConverter.GetBytes(Operator.Length));
            byteList.AddRange(BitConverter.GetBytes(IsCorrect));
            return byteList.ToArray();
        }
    }
}
