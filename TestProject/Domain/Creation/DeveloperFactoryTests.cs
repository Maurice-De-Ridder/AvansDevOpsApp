using AvansDevOpsApp.Domain.Creation;
using AvansDevOpsApp.Domain.Creation.Interfaces;
using AvansDevOpsApp.Domain.Person;
using Moq;
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
            IPersonFactory factory = new DeveloperFactory();

            var testValue = "Developer 1";
            // Act
            AbstractPerson sut = factory.CreatePerson();
            sut.Name = testValue;
            // Assert
            Assert.Equal(sut.Name, testValue);
        }
    }
}
