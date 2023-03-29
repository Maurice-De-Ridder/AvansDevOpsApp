using AvansDevOpsApp.Domain.Person;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            Developer dev = new Developer();

            dev.Name = "test";

            Assert.Equal("test", dev.Name);

        }
    }
}