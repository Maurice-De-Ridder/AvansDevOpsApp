using AvansDevOpsApp.Domain.Creation;
using AvansDevOpsApp.Domain.Person;
using System;
using Xunit;

namespace TestProject.Domain.Creation
{
    public class TesterFactoryTests
    {
        [Fact]
        public void CreatePerson_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var factory = new TesterFactory();
            var testValue = "Tester 1";
            // Act
            AbstractPerson tester = factory.CreatePerson();
            tester.Name = testValue;
            // Assert
            Assert.Equal(tester.Name, testValue);
        }
    }
}
