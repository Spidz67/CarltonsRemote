using System;
using NUnit.Framework;
using Problems;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Program p = new Program();
            string myResult = p.Prefix("hello");
            Assert.AreEqual("5,1:hello",myResult);
        }

               [Test]
        public void Test2()
        {
            Program p = new Program();
            string myResult = p.Prefix("");
            Assert.AreEqual("0,0:",myResult);
        }

               [Test]
        public void Test3()
        {
            Program p = new Program();
            string myResult = p.Prefix(("what   ... did you say??"));
            Assert.AreEqual("24,5:what   ... did you say??",myResult);
        }
    }
}