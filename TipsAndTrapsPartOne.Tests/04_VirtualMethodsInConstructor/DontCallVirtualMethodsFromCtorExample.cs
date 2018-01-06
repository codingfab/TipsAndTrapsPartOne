using Microsoft.VisualStudio.TestTools.UnitTesting;
using TipsAndTrapsPartOne._04_VirtualMethodsInConstructor;

namespace TipsAndTrapsPartOne.Tests._04_VirtualMethodsInConstructor
{
    [TestClass]
    public class DontCallVirtualMethodsFromCtorExample
    {
        [TestMethod]
        public void UsingBaseClass()
        {
            new BaseClass();
        }

        [TestMethod]
        public void UsingDerivedClass()
        {
            new DerivedClass();
        }

    }
}