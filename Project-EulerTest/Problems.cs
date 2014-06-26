using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Problems;

namespace Project_EulerTest
{
    [TestClass]
    public class Problems
    {
        [TestMethod]
        public void Problem1()
        {
            var solution = new Problem1().Solve();
            Assert.AreEqual("The sum of all multiples of 3 or 5 below 1000 is 233168", solution);
        }

        [TestMethod]
        public void Problem2()
        {
            var solution = new Problem2().Solve();
            Assert.AreEqual("The sum of the even-valued terms in the Fibonacci sequence below 4000000 is 4613732",
                solution);
        }
    }
}