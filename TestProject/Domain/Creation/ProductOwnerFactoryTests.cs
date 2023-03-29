using AvansDevOpsApp.Domain.Creation;
using AvansDevOpsApp.Domain.Creation.Interfaces;
using AvansDevOpsApp.Domain.Person;
using System;
using Xunit;

namespace TestProject.Domain.Creation
{
    public class ProductOwnerFactoryTests
    {
        [Fact]
        public void CreatePerson_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            IPersonFactory factory = new ProductOwnerFactory();
            var testValue = "Product Owner 1";
            // Act
            AbstractPerson sut = factory.CreatePerson();
            sut.Name = testValue;
            // Assert
            Assert.Equal(sut.Name, testValue);
        }
    }
}
