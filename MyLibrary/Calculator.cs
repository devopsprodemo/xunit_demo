using System;

namespace MyLibrary
{
    /// <summary>
    /// Provides basic arithmetic operations.
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// Adds two integers.
        /// </summary>
        public static int Add(int a, int b) => a + b;

        /// <summary>
        /// Subtracts the second integer from the first.
        /// </summary>
        public static int Subtract(int a, int b) => a - b;

        /// <summary>
        /// Multiplies two integers.
        /// </summary>
        public static int Multiply(int a, int b) => a * b;

        /// <summary>
        /// Divides the first integer by the second.
        /// Throws DivideByZeroException if b is zero.
        /// </summary>
        public static int Divide(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a / b;
        }
    }
} 