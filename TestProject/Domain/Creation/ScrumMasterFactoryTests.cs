using AvansDevOpsApp.Domain.Creation;
using System;
using Xunit;

namespace TestProject.Domain.Creation
{
    public class ScrumMasterFactoryTests
    {
        [Fact]
        public void CreatePerson_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var factory = new ScrumMasterFactory();

            // Act
            var result = factory.CreatePerson();

            // Assert
            Assert.True(false);
        }
    }
}
