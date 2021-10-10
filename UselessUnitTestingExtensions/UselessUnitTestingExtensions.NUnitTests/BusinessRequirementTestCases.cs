using NUnit.Framework;

namespace UselessUnitTestingExtensions.NUnitTests
{
    public class BusinessRequirementTestCases
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [BusinessRequirement]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        [BusinessRequirement("JIRA-011")]
        public void Test2()
        {
            Assert.Pass();
        }
    }
}