using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TipsAndTrapsPartOne.Tests
{
    [TestClass]
    public class NullCoalescingOperatorExample
    {
        [TestMethod]
        public void ReferenceTypes()
        {
            // Without the null-coalescing operator

            // if(name == null)
            // {
            //      result = "no name provided";
            // }
            // else
            // {
            //      result = name;
            // }

            var name = "Sarah";

            var result = name ?? "no name provided";

            name = null;

            result = name ?? "no name provided";
        }
        
    }
}