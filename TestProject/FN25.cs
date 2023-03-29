using AvansDevOpsApp.Domain.Notifier;
using AvansDevOpsApp.Domain.Person;
using AvansDevOpsApp.Domain.Project.Sprint;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            INotification notificationTest = new EmailNotification();

            string toTest = notificationTest.message("SprintEen is cancelled");
            ProductOwner productOwner = new ProductOwner("Luuk",new EmailNotification());

            Sprint sprintEen = new Sprint("SprintEen");

            sprintEen.Subscribe("Cancelled", productOwner);

            sprintEen.ChangeStateCancelled();


            Assert.Equal(toTest, productOwner.latestMessage);

        }
    }
}