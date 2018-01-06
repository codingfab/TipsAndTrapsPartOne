using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using TipsAndTrapsPartOne._05_CallerInfoAttributes;

namespace TipsAndTrapsPartOne.Tests._05_CallerInfoAttributes
{
    [TestClass]
    public class CallerInfoAttributesExample
    {
        [TestMethod]
        public void ExampleFooMethod()
        {
            var c = new CallerInfoAttributeDemo();

            Debug.WriteLine(c.WhoCalledMe());
            Debug.WriteLine(c.WhatFileCalledMe());
            Debug.WriteLine(c.WhatLineCalledMe());
        }
    }
}