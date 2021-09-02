using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Github.Actions.Secrets.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var data = Environment.GetEnvironmentVariable("EnvHelloWorld");
            throw new Exception("HelloWorld = [" + data + "]");
        }
    }
}
