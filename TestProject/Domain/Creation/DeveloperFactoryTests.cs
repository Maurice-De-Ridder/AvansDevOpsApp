using AvansDevOpsApp.Domain.Creation;
using AvansDevOpsApp.Domain.Person;
using System;
using Xunit;

namespace TestProject.Domain.Creation
{
    public class DeveloperFactoryTests
    {
        [Fact]
        public void CreatePerson_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var factory = new DeveloperFactory();
            var testValue = "Developer 1";
            // Act
            AbstractPerson developer = factory.CreatePerson();
            developer.Name = testValue;
            // Assert
            Assert.Equal(developer.Name, testValue);
        }
    }
}
