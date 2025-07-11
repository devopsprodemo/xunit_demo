using System;

namespace MyLibrary
{
    /// <summary>
    /// Provides basic arithmetic operations.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Adds two integers.
        /// </summary>
        public int Add(int a, int b) => a + b;

        /// <summary>
        /// Subtracts the second integer from the first.
        /// </summary>
        public int Subtract(int a, int b) => a - b;

        /// <summary>
        /// Multiplies two integers.
        /// </summary>
        public int Multiply(int a, int b) => a * b;

        /// <summary>
        /// Divides the first integer by the second.
        /// Throws DivideByZeroException if b is zero.
        /// </summary>
        public int Divide(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a / b;
        }
    }
} 