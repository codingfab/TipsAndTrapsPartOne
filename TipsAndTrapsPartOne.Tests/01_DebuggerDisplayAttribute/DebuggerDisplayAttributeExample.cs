using Microsoft.VisualStudio.TestTools.UnitTesting;
using TipsAndTrapsPartOne._01_DebuggerDIsplayAttribute;

namespace TipsAndTrapsPartOne.Tests
{
    [TestClass]
    public class DebuggerDisplayAttributeExample
    {
        [TestMethod]
        public void Wihtout()
        {
            var p = new PersonWithoutDebuggerDisplay()
            {
                AgeInYears = 50,
                Name="Sarah"
            };
        }

        [TestMethod]
        public void With()
        {
            var p = new PersonWithDebuggerDisplay()
            {
                AgeInYears = 50,
                Name = "Sarah"
            };
        }

        // DebuggerDisplayAttribute can be applied to:
        // Classes
        // Delegates
        // Structs
        // Enums
        // Fields
        // Properties
        // Assemblies
    }
}
