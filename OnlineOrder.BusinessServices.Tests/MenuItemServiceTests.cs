using Moq;
using NUnit.Framework;
using OrderServiceRepository.Interface;

namespace OnlineOrder.BusinessServices.Tests
{
    public class MenuItemServiceTests
    {
        [Test]
        public void GetAllMenuItems_P()
        {
            //Arrange

            var service = new MenuItems();

            //Act
            var result = service.GetMenuItems();

            //Asserts
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual("Cheese Pizza", result[0].Name);

        }
    }
}
