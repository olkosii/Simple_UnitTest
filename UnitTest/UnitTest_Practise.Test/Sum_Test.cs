using NUnit.Framework;
using System;

namespace UnitTest_Practise.Test
{
    [TestFixture]
    public class Sum_Test
    {
        [Test]
        public void Test()
        {
            int result = Sum.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }
        
    }
}
