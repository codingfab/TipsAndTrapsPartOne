using Microsoft.VisualStudio.TestTools.UnitTesting;
using TipsAndTrapsPartOne._02_DebuggerBrowsableAttribute;

namespace TipsAndTrapsPartOne.Tests
{
    [TestClass]
    public class DebuggerBrowsableAttributeExample
    {
        [TestMethod]
        public void Without()
        {
            var p = new PersonWithoutDebuggerBrowsable()
            {
                AgeInYears = 50,
                Name = "Sarah",
                FaveColors = {"Red", "Green", "Blue"}
            };
        }

        [TestMethod]
        public void With()
        {
            var p = new PersonWithDebuggerBrowsable()
            {
                AgeInYears = 50,
                Name = "Sarah",
                FaveColors = { "Red", "Green", "Blue" }
            };
        }
    }
}