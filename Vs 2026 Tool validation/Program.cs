#region File Header
// # ==============================================================================
// #
// #  © 2025 Koninklijke Philips N.V.
// #
// #  All rights are reserved.  Reproduction in whole or in part is prohibited
// #  without the prior written consent of the copyright holder.
// #
// # ==============================================================================
#endregion

using System;
using System.Collections.Generic;

namespace Vs_2026_Tool_validation
{
    /// <summary>
    /// Main program class to validate tool installation in VS 2026
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if(n == 1)
            {
                Console.WriteLine("1");
            }
            else if (n == 2)
            {
                Console.WriteLine("2");
            }
            else if (n == 3)
            {
                Console.WriteLine("3");
            }
            else
            {
                Console.WriteLine($"{n}");
            }
        }

        /// <summary>
        /// method to add two number and return the sum used for unit test secenrios
        /// </summary>
        /// <param name="a">a</param>
        /// <param name="b">b</param>
        /// <returns>sum</returns>
        public static int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// method to multiply two number and return the sum used for unit test secenrios
        /// </summary>
        /// <param name="a">a</param>
        /// <param name="b">b</param>
        /// <returns>sum</returns>
        public static int Multiply(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// method to divide number and return the sum used for unit test secenrios
        /// </summary>
        /// <param name="a">a</param>
        /// <param name="b">b</param>
        /// <returns>sum</returns>
        public static int Divide(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// method to subtract two number and return the sum used for unit test secenrios
        /// </summary>
        /// <param name="a">a</param>
        /// <param name="b">b</param>
        /// <returns>sum</returns>
        public static int Subtract(int a, int b)
        {
            return a + b;
        }


        // Unused method for static code analysis
        private static void badmethod()
        {
            int unused = 10;
            return;
        }
    }
}