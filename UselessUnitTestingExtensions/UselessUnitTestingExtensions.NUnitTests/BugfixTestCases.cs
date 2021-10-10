using NUnit.Framework;

namespace UselessUnitTestingExtensions.NUnitTests
{
    public class BugfixTestCases
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Bugfix]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        [Bugfix("JIRA-011")]
        public void Test2()
        {
            Assert.Pass();
        }


    }
}