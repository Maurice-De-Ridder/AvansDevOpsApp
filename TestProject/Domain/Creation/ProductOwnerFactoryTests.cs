using AvansDevOpsApp.Domain.Creation;
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
            var factory = new ProductOwnerFactory();

            // Act
            var result = factory.CreatePerson();

            // Assert
            Assert.True(false);
        }
    }
}
