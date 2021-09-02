using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Github.Actions.Secrets.Tests
{
    [TestClass]
    public class UnitTest1
    {

        public TestContext TestContext { get; set; }

        private static TestContext _testContext;

        [ClassInitialize]
        public static void SetupTests(TestContext testContext)
        {
            _testContext = testContext;
        }

        [TestMethod]
        public void TestMethod1()
        {
            var data = Environment.GetEnvironmentVariable("ENVHELLOWORLD");
            throw new Exception("HelloWorld = [" + data + "]");
        }
    }
}
