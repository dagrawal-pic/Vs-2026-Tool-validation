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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vs_2026_Tool_validation
{
    /// <summary>
    /// Create and run test method using MSTest
    /// </summary>
    [TestClass]
    public class CreateAndRunTestMethods
    {
        /// <summary>
        /// method to test Add method in Program class - postive scenerio
        /// </summary>
        [TestMethod]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            int result = Program.Add(5, 3);
            Assert.AreEqual(8, result);
        }

        /// <summary>
        /// method to test Add method in Program class - negative scenerio
        /// </summary>
        [TestMethod]
        public void Add_NegativeAndPositiveNumber_ReturnsCorrectSum()
        {
            int result = Program.Add(-2, 7);
            Assert.AreEqual(5, result);
        }
    }
}
