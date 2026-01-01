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

using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Vs_2026_Tool_validation
{
    /// <summary>
    /// Create and run test method using NUnit
    /// </summary>
    public class CreateAndRunTestMethodUsingNUnit
    {
        /// <summary>
        /// method to test Add method in Program class - postive scenerio
        /// </summary>
        [Test]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            int result = Program.Add(5, 3);
            ClassicAssert.AreEqual(8, result);
        }

        /// <summary>
        /// method to test Add method in Program class - negative scenerio
        /// </summary>
        [Test]
        public void Add_NegativeAndPositiveNumber_ReturnsCorrectSum()
        {
            int result = Program.Add(-2, 7);
            ClassicAssert.AreEqual(5, result);
        }
    }
}
