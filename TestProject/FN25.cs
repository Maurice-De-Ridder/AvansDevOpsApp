using AvansDevOpsApp.Domain.Notifier;
using AvansDevOpsApp.Domain.Person;
using AvansDevOpsApp.Domain.Project.Sprint;

namespace TestProject
{
    public class FN25
    {
        [Fact]
        public void Test1()
        {
            INotification notificationTest = new EmailNotification();

            string toTest = notificationTest.Message("SprintEen is cancelled");

            ProductOwner productOwner = new ProductOwner("Luuk",new EmailNotification());

            Sprint sprintEen = new Sprint("SprintEen",new NotificationPublisher());

            sprintEen.Subscribe(productOwner);

            sprintEen.ChangeStateCancelled();


            Assert.Equal(toTest, productOwner.Inbox[0]);

        }
    }
}