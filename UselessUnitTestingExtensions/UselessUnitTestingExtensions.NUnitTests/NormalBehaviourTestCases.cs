using NUnit.Framework;

namespace UselessUnitTestingExtensions.NUnitTests
{
    public class NormalBehaviourTestCases
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [NormalBehaviour]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        [NormalBehaviour("JIRA-011")]
        public void Test2()
        {
            Assert.Pass();
        }
    }
}